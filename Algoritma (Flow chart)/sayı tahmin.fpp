16       	 <--SHAPES
19       	 <--LINES
id1
2       	 <--TYPE
335       	 <--LEFT
62       	 <--TOP
70       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
START



id2
2       	 <--TYPE
597       	 <--LEFT
557       	 <--TOP
70       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
STOP



id3
91       	 <--TYPE
234       	 <--LEFT
198       	 <--TOP
276       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
INPUT
1 ile 100 arasýnda sayi gir
x

id4
92       	 <--TYPE
315       	 <--LEFT
277       	 <--TOP
112       	 <--WIDTH
50       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
IF_LESS
x
70

id5
91       	 <--TYPE
539       	 <--LEFT
282       	 <--TOP
228       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
OUTPUT
daha büyük deger giriniz


id6
0       	 <--TYPE
336       	 <--LEFT
151       	 <--TOP
70       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
DEFINITION
x
70

id7
92       	 <--TYPE
311       	 <--LEFT
445       	 <--TOP
112       	 <--WIDTH
50       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
IF_EQUAL
x
70

id8
92       	 <--TYPE
313       	 <--LEFT
355       	 <--TOP
112       	 <--WIDTH
50       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
IF_GREATER
x
70

id9
91       	 <--TYPE
536       	 <--LEFT
362       	 <--TOP
228       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
OUTPUT
daha küçük deger giriniz


id10
91       	 <--TYPE
581       	 <--LEFT
447       	 <--TOP
100       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
OUTPUT
buldunuz


id11
0       	 <--TYPE
325       	 <--LEFT
106       	 <--TOP
92       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
DEFINITION
hak
5

id12
0       	 <--TYPE
853       	 <--LEFT
367       	 <--TOP
124       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
SUBTRACT
hak
1
hak
id13
92       	 <--TYPE
859       	 <--LEFT
192       	 <--TOP
112       	 <--WIDTH
50       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
IF_GREATER
hak
0

id14
3       	 <--TYPE
1149       	 <--LEFT
213       	 <--TOP
10       	 <--WIDTH
10       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
INTERSECTION



id16
91       	 <--TYPE
1065       	 <--LEFT
551       	 <--TOP
180       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
OUTPUT
hakkiniz bitmistir


id17
91       	 <--TYPE
817       	 <--LEFT
265       	 <--TOP
196       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
OUTPUT
kalan hakkiniz
hak

  
---- LINES ---- from,to ----
id6,id3
reserved 1

id3,id4
reserved 1

id4,id5
reserved 1
EVET
id4,id8
reserved 1
HAYIR
id8,id9
reserved 1
EVET
id8,id7
reserved 1
HAYIR
id7,id10
reserved 1
EVET
id7,id2
reserved 1
HAYIR
id1,id11
reserved 1

id11,id6
reserved 1

id13,id3
reserved 1
EVET
id13,id14
reserved 1
HAYIR
id17,id13
reserved 1

id14,id16
reserved 1

id16,id2
reserved 1

id10,id2
reserved 1

id9,id12
reserved 1

id5,id12
reserved 1

id12,id17
reserved 1

