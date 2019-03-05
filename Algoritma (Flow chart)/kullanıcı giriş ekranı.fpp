14       	 <--SHAPES
15       	 <--LINES
id1
2       	 <--TYPE
609       	 <--LEFT
13       	 <--TOP
70       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
START



id2
0       	 <--TYPE
588       	 <--LEFT
54       	 <--TOP
108       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
DEFINITION
user
ayan

id3
0       	 <--TYPE
589       	 <--LEFT
96       	 <--TOP
100       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
DEFINITION
pass
123

id7
2       	 <--TYPE
945       	 <--LEFT
568       	 <--TOP
70       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
STOP



id4
91       	 <--TYPE
538       	 <--LEFT
231       	 <--TOP
188       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
INPUT
kullanici adi
kadi

id5
91       	 <--TYPE
532       	 <--LEFT
310       	 <--TOP
132       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
INPUT
sifre
sifre

id6
91       	 <--TYPE
522       	 <--LEFT
135       	 <--TOP
212       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
OUTPUT
kullanici giris ekrani


id8
91       	 <--TYPE
479       	 <--LEFT
183       	 <--TOP
276       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
OUTPUT
lütfen kullanici adini giriniz


id9
0       	 <--TYPE
805       	 <--LEFT
129       	 <--TOP
268       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
COMP
user
kadi
sonuc
id10
92       	 <--TYPE
879       	 <--LEFT
199       	 <--TOP
112       	 <--WIDTH
50       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
IF_EQUAL
sonuc
0

id11
91       	 <--TYPE
680       	 <--LEFT
404       	 <--TOP
148       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
OUTPUT
giris basarili


id12
91       	 <--TYPE
1059       	 <--LEFT
296       	 <--TOP
164       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
OUTPUT
kullanici hatali


id13
92       	 <--TYPE
784       	 <--LEFT
302       	 <--TOP
136       	 <--WIDTH
50       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
IF_EQUAL
pass
sifre

id14
91       	 <--TYPE
947       	 <--LEFT
368       	 <--TOP
132       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
OUTPUT
sifre hatali


  
---- LINES ---- from,to ----
id1,id2
reserved 1

id2,id3
reserved 1

id10,id12
reserved 1
HAYIR
id3,id6
reserved 1

id6,id8
reserved 1

id8,id4
reserved 1

id4,id5
reserved 1

id9,id10
reserved 1

id13,id14
reserved 1
HAYIR
id14,id7
reserved 1

id12,id7
reserved 1

id5,id9
reserved 1

id10,id13
reserved 1
EVET
id13,id11
reserved 1
EVET
id11,id7
reserved 1

