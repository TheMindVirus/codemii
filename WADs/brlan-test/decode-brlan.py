# Benzin Project 2009 (ported in 2021)

import sys, struct, re
from ethyl import *

if len(sys.argv) != 2:
    print('Usage: python parse-brlan.py something.brlan')
    sys.exit(1)

f = open(sys.argv[1], 'rb')
rlan = f.read()
f.close()

print(rlan[0:4])
assert(rlan[0:4] in ( b'RLAN', b'RLTP', b'RLMC', b'RLVC', b'RLPA', b'RLTS', b'RLVI'))
assert(rlan[4:8] == b'\xfe\xff\x00\x08')
offs, nel = struct.unpack('>hh', rlan[0xc:0x10])
ch = iff_to_chunks(rlan[offs:])

assert(len(ch) == nel)

# Holy indirection
# rlan
#   pai1
#       timg
#       anim
#           anim body
#               aent
#                   aent body
#

for typ, chunk in ch:
    assert(typ == b'pai1')
    framesize, flags, _, num_timgs, num_anims, anim_offset = struct.unpack('>hbbhhI', chunk[:0xc])
    print('Framesize: %d\nFlags:     %x' % (framesize, flags))
    for n in range(num_timgs):
       pos = 0x10 + 4*n
       offs = struct.unpack('>I', chunk[pos:pos+4])
       print('timg: %s' % nullterm(chunk[pos - 8:]))
    for n in range(num_anims):
       pos = anim_offset - 8 + 4*n
       offs = struct.unpack('>I', chunk[pos:pos+4])[0] - 8
       
       name = chunk[offs:offs + 0x14].rstrip(b'\0')
       
       aunk, aoffs = struct.unpack('>II', chunk[offs + 0x14:offs + 0x1c])
       print(name, hex(aoffs))
       aoffs += offs
       atyp = chunk[aoffs:aoffs+4]
       #print(hex(aoffs), hex(offs), name)
       
       num_aents = ord(str(chunk[aoffs + 4]))
       print(atyp, name, hex(aunk))
       
       for m in range(num_aents):
            boffs = aoffs + 8 + 4*m
            if len(chunk[boffs:boffs + 4]) <= 0:
                continue
            coffs, = struct.unpack('>I', chunk[boffs:boffs + 4])
            coffs += aoffs
            if atyp in ('RLMC', 'RLVC', 'RLPA', 'RLTP', 'RLIM', 'RLTS'): # doesn't cover RLVI
                byte0, byte1, byte2, byte3, num_cookies, pad, cookies_offs = struct.unpack('>BBBBHHI', chunk[coffs:coffs+0xc])
                #print('cookies_offs: %x' % cookies_offs)
                print(hex(byte0), hex(byte1), hex(byte2), hex(byte3), num_cookies)
                for o in range(num_cookies):
                    cookie_offs = coffs + cookies_offs + 0xc*o
                    coords = struct.unpack('>fff', chunk[cookie_offs:cookie_offs + 0xc])
                    print('   ', coords)
            print('   ', '---')
            
       #print(repr(name))
       #unk, anim_header_len = struct.unpack('>II', chunk[offs + 20:offs + 28])
       #atyp = chunk[offs + 28:offs + 32]