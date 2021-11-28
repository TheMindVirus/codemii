# Benzin Project 2009 (ported in 2021)

import sys, struct, re, random
from ethyl import *

if len(sys.argv) != 3:
    print('Usage: python write-brlyt.py input.rlyt.py output.brlyt')
    print('(for example, see test.rlyt.py)')
    sys.exit(1)


f = open(sys.argv[1], 'r')
chunks = eval(f.read())
f.close()

def flatten(chunks):
    a = []
    for c in chunks:
        if type(c) == list:
            a += flatten(c)
        else:
            a.append(c)
    return a
chunks = flatten(chunks)



rlyt = b'RLYT\xfe\xff\x00\x08\x00\x00\x00\x00' # size later
rlyt += struct.pack('>hh', 0x10, len(chunks))

materials = None

for c in chunks:
    #if isinstance(c, basestring):
    if type(c) in (str, ):
        typ = c
        chunk = ''
    else:
        typ, vars = c
        if typ == 'lyt1':
            chunk = unparse_data(vars, 'lytheader')
        elif typ == 'grp1':
            vars['numsubs'] = len(vars['subs'])
            chunk = unparse_data(vars, 'group')
            for sub in vars['subs']:
                chunk += unnullterm(sub, 16)
        elif typ in ('txl1', 'fnl1',):
            things = {'txl1': 'textures', 'fnl1': 'files'}[typ]
            ls = vars[things]
            chunk = struct.pack('>hh', len(ls), 0)
            strings = ''
            offss = []
            for thing in ls:
                name = thing['name'] + '\x00'
                offss.append(len(strings))
                strings += name
            for n, thing in enumerate(ls):
                chunk += struct.pack('>II', offss[n] + 8 * len(ls), thing['unk'])
            chunk += strings.encode()
            if typ == 'txl1':
                textures = ls
            else:
                filenames = ls
        elif typ == 'mat1':
            materials = []
            mchunks = []
            for mat in vars['materials']:
                flags = mat['flags'] if ('flags' in mat.keys()) else 0
                
                for a in mat['texref']:
                    a['tex_offs'] = [i for i in range(len(textures)) if textures[i]['name'] == a['tex']][0]

                c1, flags = put_array(mat['texref'], flags, 28, 31, 4, 'texref')
                c1 = c1.encode() if type(c1) in (str, ) else c1
                c2, flags = put_array(mat['ua2'], flags, 24, 27, 0x14, 'ua2')
                c2 = c2.encode() if type(c2) in (str, ) else c2
                c3, flags = put_array(mat['ua3'], flags, 20, 23, 4, '4b')
                c3 = c3.encode() if type(c3) in (str, ) else c3
                c4, flags = put_opt(mat['ua4'], flags, 6, 4, '4b')
                c4 = c4.encode() if type(c4) in (str, ) else c4
                c5, flags = put_opt(mat['ua5'], flags, 4, 4, '4b')
                c5 = c5.encode() if type(c5) in (str, ) else c5
                c6, flags = put_opt(mat['ua6'], flags, 19, 4, '4b')
                c6 = c6.encode() if type(c6) in (str, ) else c6
                c7, flags = put_array(mat['ua7'], flags, 17, 18, 0x14, 'ua7')
                c7 = c7.encode() if type(c7) in (str, ) else c7
                c8, flags = put_array(mat['ua8'], flags, 14, 16, 4, '4b')
                c8 = c8.encode() if type(c8) in (str, ) else c8
                c9, flags = put_array(mat['ua9'], flags, 9, 13, 0x10, '10b')
                c9 = c9.encode() if type(c9) in (str, ) else c9
                ca, flags = put_opt(mat['uaa'], flags, 8, 4, '4b')
                ca = ca.encode() if type(ca) in (str, ) else ca
                cb, flags = put_opt(mat['uab'], flags, 7, 4, '4b')
                cb = cb.encode() if type(cb) in (str, ) else cb
                
                mat['flags'] = flags
                mchunk = unparse_data(mat, 'material')
                assert(len(mchunk) == 0x40)
                
                mchunk += c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + ca + cb
                
                mchunks.append(mchunk)
                materials.append(mat['name'])
            chunk = struct.pack('>hh', len(mchunks), 0)
            zchunk = b''
            for a in mchunks:
                chunk += struct.pack('>I', 0xc + 4*len(mchunks) + len(zchunk))
                zchunk += a
            chunk += zchunk
            
        elif typ in ('pic1', 'pan1', 'bnd1', 'wnd1', 'txt1'):  
            chunk = unparse_data(vars, 'pane')
            if typ == 'txt1':
                vars['~text.name_offs'] = 0x74
                vars['~text.mat_off'] = materials.index(vars['~text.material'])
                blob = untv(unicode(vars['~text.text']).encode('utf_16_be'))
                vars['~text.len1'] = vars['~text.len2'] = len(blob)
                chunk += unparse_data(vars, 'text', prefix='~text')
                chunk += blob
            elif typ == 'pic1':
                vars['~pic.mat_off'] = materials.index(vars['~pic.material'])
                vars['~pic.num_texcoords'] = len(vars['~pic.texcoords'])
                chunk += unparse_data(vars, 'pic', prefix='~pic')
                for tc in vars['~pic.texcoords']:
                    chunk += struct.pack('>ffffffff', *tc)
            elif typ != 'pan1':
                failz
        else:
            raise Exception('Unhandled type %s' % typ)
    while len(chunk) % 4 != 0:
        chunk += b'\0'
    chunk = chunk.encode() if type(chunk) in (str, ) else chunk
    rlyt += typ.encode() + struct.pack('>I', len(chunk) + 8) + chunk


rlyt = rlyt[:8] + struct.pack('>I', len(rlyt)) + rlyt[0xc:]


g = open(sys.argv[2], 'wb')
g.write(rlyt)
g.close()