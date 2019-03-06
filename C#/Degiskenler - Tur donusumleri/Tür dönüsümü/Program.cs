using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_12_20_Tür_dönüsümü
{
    class Program
    {
        static void Main(string[] args)
        {

            //bilincsiz dönüsümler

            //hatasız ornekler:

            //char c = 'S';
            //int x = c;
            //Console.WriteLine(x);

            //short s = -458;
            //long l = s;
            //Console.WriteLine(l);

            //float f = 4.458697156f;
            //double d = f;
            //Console.WriteLine(d);

            //int i = 1264;
            //float f1 = i;
            //Console.WriteLine(f1);

            //hatalı ornekler:

            //double d1 = 1524.759661144d;
            //long l1 = d1;
            //Console.WriteLine(d1);


            //ushort a = 5;
            //char c = x;



            //--------------------------------------------------------------


            //bilincli dönüsümler
            // yapılan işlemlerden bir tanesi: Explicit Cast Operator () casting 

            //decimal sayi = 12;
            //int sayi2 = (int)sayi;




            //NOT==== kendinden kücük bir tipe bilicli sekilde asagıdaki gibi dönüstürürsünüz fakat byte 8 bit oldugundan 8 bite kadar olan degeri alır ve o degeri yazar.    ornegin s=32767 fakat b=255 alır. b=s oldugu halde eksik veri verir.


            //short s = short.MaxValue;
            //Console.WriteLine(s);


            //byte b = (byte)s;
            //Console.WriteLine(b);
            //Console.WriteLine(s);

            //---------------------------------------------------------------------

            //int i = 256;
            //byte b;
            //checked
            //{
            //    b = (byte)i;

            //}

            //Console.WriteLine(b);


            // checked komutunu float,double,decimal dönüsümlerinde uyarı vermez.

            //decimal d = 1254.45698521478566456m;
            //float f;
            //checked
            //{
            //    f = (float)d;

            //}

            //Console.WriteLine(f);


            //--------------------------------------------------------------------------


            //convert Tür Dönüsümü ::::::::::::::::


            //int _int = 34;
            //long _long = Convert.ToInt64(_int);
            //Console.WriteLine(_long);


            //int _int = int.MaxValue;
            //long _long = Convert.ToInt64(_int);
            //Console.WriteLine(_long);


            //long _long2 = int.MaxValue;
            //int _int2 = Convert.ToInt32(_long2);
            //Console.WriteLine("long => int:{0}", _long);


            //bool _is = true;
            //string metin;
            //metin = Convert.ToString(_is);
            //Console.WriteLine("boll => string:{0}", metin);

            // decimal hiç bir türe dönüsemedigi için hata verir.
            //decimal _decimal = 12.6m;
            //float _float = Convert.ToSingle(decimal);


            //--------------------------

            // Ekrana yazdırma:

            // cıkan ekrana yazı yazmanı ister enter tusuna basana kadar yazabilirsin. 

            //string metin = Console.ReadLine();
            //Console.WriteLine("Girdiginiz Deger:{0}", metin);

            //-------------------------------


            //Console.WriteLine("Lütfen iki sayi giriniz...");

            //string sayi1 = Console.ReadLine();
            //string sayi2 = Console.ReadLine();

            ////birinci sayıyı string'den int'e cevirir..

            //int _intsayi1 = Convert.ToInt32(sayi1);

            ////ikinci sayiyi string'den int'e cevirir..

            //int _intsayi2 = Convert.ToInt32(sayi2);
            //Console.WriteLine("{0}+{1}={2}", _intsayi1, _intsayi2, _intsayi1 + _intsayi2);


            //-----------------------------------------------------------------------------------



            //double veya float'dan int'e tür dönüsümü ::::::::::::::::::::::

            //conver ile dönüsüm

            //double _double = 3.12;
            //int _int = Convert.ToInt32(_double);
            //Console.WriteLine("{0} sayisi conver ile int'e cevrildi=>{1}", _double, _int);


            //double _double1 = 3.50;
            //int _int1 = Convert.ToInt32(_double1);
            //Console.WriteLine("{0} sayisi conver ile int'e cevrildi=>{1}", _double1, _int1);


            //double _double2 = 3.53;
            //int _int2 = Convert.ToInt32(_double2);
            //Console.WriteLine("{0} sayisi conver ile int'e cevrildi=>{1}", _double2, _int2);


            ////cast ile dönüsüm convert farkı görmek:

            //double _double3 = 3.12;
            //int _int3= (int) _double3;
            //Console.WriteLine("{0} sayisi cast ile int'e cevrildi=>{1}", _double3, _int3);

            //double _double4 = 3.50;
            //int _int4 = (int)_double4;
            //Console.WriteLine("{0} sayisi cast ile int'e cevrildi=>{1}", _double4, _int4);

            //double _double5 = 3.53;
            //int _int5 = (int)_double5;
            //Console.WriteLine("{0} sayisi cast ile int'e cevrildi=>{1}", _double5, _int5);


            //-------------------------------------------------------------------------------


            //ornek 1 ------------------------------------------------------------------------------------


            //Console.WriteLine("1.kisi_isim:");
            //string kisi_1isim = Console.ReadLine();
            //Console.WriteLine("1.kisi_yasi:");
            //string kisi_1yas = Console.ReadLine();
            //int _intkisi_1yas = Convert.ToInt32(kisi_1yas);

            //Console.WriteLine("2.kisi_isim:");
            //string kisi_2isim = Console.ReadLine();
            //Console.WriteLine("2.kisi_yasi:");
            //string kisi_2yas = Console.ReadLine();
            //int _intkisi_2yas = Convert.ToInt32(kisi_2yas);


            //Console.WriteLine("3.kisi_isim:");
            //string kisi_3isim = Console.ReadLine();
            //Console.WriteLine("3.kisi_yasi:");
            //string kisi_3yas = Console.ReadLine();
            //int _intkisi_3yas = Convert.ToInt32(kisi_3yas);


            //Console.WriteLine("4.kisi_isim:");
            //string kisi_4isim = Console.ReadLine();
            //Console.WriteLine("4.kisi_yasi:");
            //string kisi_4yas = Console.ReadLine();
            //int _intkisi_4yas = Convert.ToInt32(kisi_4yas);


            //Console.WriteLine("5.kisi_isim:");
            //string kisi_5isim = Console.ReadLine();
            //Console.WriteLine("5.kisi_yasi:");
            //string kisi_5yas = Console.ReadLine();
            //int _intkisi_5yas = Convert.ToInt32(kisi_5yas);

            //int toplamyas = _intkisi_1yas + _intkisi_2yas + _intkisi_3yas + _intkisi_4yas + _intkisi_5yas;

            //double _double = Convert.ToDouble(toplamyas);

            //double ortyas = (_double/5);


            //Console.WriteLine("yasların Toplamı={0}+{1}+{2}+{3}+{4}={5}", _intkisi_1yas, _intkisi_2yas, _intkisi_3yas, _intkisi_4yas, _intkisi_5yas,toplamyas);

            //Console.WriteLine("yasların Ortalaması=({0}+{1}+{2}+{3}+{4})/5={5}", _intkisi_1yas, _intkisi_2yas, _intkisi_3yas, _intkisi_4yas, _intkisi_5yas, ortyas);



            //*****************

            //Console.Write("adın:");Console.Read();

            //********************



            //Parse ile Tür dönüsümü *****string degerlerei dönüstürür.--------------------------------------------

            //string deger1 = "12";
            //Console.WriteLine(int.Parse(deger1));




            //ornek: iki sayı isteyip toplama islemi


            //Console.Write("1.sayiyi giriniz:");
            //string sayi1 = Console.ReadLine();
            //double i1= double.Parse(sayi1);

            //Console.Write("2.sayiyi giriniz:");
            //string sayi2 = Console.ReadLine();
            //double i2 = double.Parse(sayi2);

            //double toplam = i1 + i2;

            //double ort = (toplam/2);

            //Console.WriteLine("toplam sayi:{0}",toplam);
            //Console.WriteLine("ortalama sayi:{0}", ort);



            //-------------------------------------------------------------------------------------------------



            ////Object tür dönüsümleri-------------------

            ////as referan tiplerde calısır.

            //object o = "elif";
            //object o2 = long.MaxValue;
            //object o3 = double.MaxValue;

            //string s = o as string;


            ////************************
            ////hatalıkot
            //int a = 23;
            //long l = a as long;
            ////düzeltmek içinde ? yapabiliriz(null olarak ata demek)
            //long? l = a as long?;
            ////******************************


            ////*********************************
            ////hata verecektir.cünkü obje ve int i yanyana yazmaz.
            //object a = '5';
            //int b = 4;
            //Console.WriteLine(a + b);
            ////**********************************



            ////**********************************
            ////kodu yazarken hata vermez fakat calıstırırken hata alırsın.
            //object a = "5";
            //int b = (int)a;
            //Console.WriteLine(b);

            ////Hatayı düzeltme:
            //object a = "5";
            //string s = a as string;
            //int i = int.Parse(s);
            //Console.WriteLine(i);


            ////************************************

            ////Burda ozüne döndügünden calışır.
            //object a = 'k';
            //char b = (char)a;
            //Console.WriteLine(b);

            ////buradaki as referans tiplerde kullanıldıgından char da calışmaz.
            //object a = 'k';
            //char b = a as char;
            //Console.WriteLine(b);

            ////hata düzeltme:
            //object a = 'k';
            //char? b = a as char?;
            //Console.WriteLine(b);

            ////*****************************************



            ////String Türüyle İlgili Dönüsümler:  x.ToString() ****sadece stringe dönüstürür.

            ////1-
            //string b = 3.ToString();
            //Console.WriteLine(b);

            ////2-
            //string c=12.7f.ToString();
            //Console.WriteLine(c);



            ////3- Burada string olarak yanyana yazar fakat int degeri ve char olarak tanımladıgın k nın taban sayısı olan 107 yi int olarak alır toplar deri kalanı yanyana yazar.ekran görüntüsüde "112deneme12.5" yazar.

            //int a = 5;
            //char m = 'k';
            //string r = "deneme";
            //float f = 12.5f;
            //string b = a + m + r + f;
            //Console.WriteLine(b);

            //yukarıdaki ornegin sadece intlerden olusursa ne olur?-------------------------------------

            //hatalı olacaktır.
            //int a = 5;
            //int b = 7;
            //int c = 3;
            //string = a + b + c;
            //Console.WriteLine(a + b + c);

            ////hatayı düzeltmek icin 1.yol:

            //int a = 5;
            //int b = 7;
            //int c = 3;
            //string e = "";
            //string d = a + b + c + e;

            //Console.WriteLine(d);


            ////hatayı düzeltmek icin 2.yol:

            //int a = 5;
            //int b = 7;
            //int c = 3;
            //string e = (a + b + c).ToString();

            //Console.WriteLine(e);







        }
    }
}
