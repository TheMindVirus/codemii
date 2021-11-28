@echo on
python decode-brlan.py icon.brlan
python decode-brlan.py banner.brlan
python decode-brlyt.py banner.brlyt
python encode-brlan.py input-brlan.py test.brlan
python encode-brlyt.py input-brlyt.py test.brlyt
python decode-brlan.py test.brlan
python decode-brlyt.py test.brlyt
pause