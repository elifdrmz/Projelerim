using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_12_20_
{
    class Program
    {
        static void Main(string[] args)
        {
            // null :atadıgın veri icerisinde hic bir veri olmadıgını göster

            // string den sonra ? koymamıza gerek yoktur.

            //  string name = null; ir.
            //  Console.WriteLine(name ?? "(no name)");
            //------------------------------------------

            // int den sonra ? olmazsa hata verir.

            //int? a = 5;
            //Console.WriteLine(a ?? -1);  


            //--------------------------------------
            //int? a = null;
            //int b = a ?? 0;
            //Console.WriteLine(b);

            // Typeof: degisken türünün CTS karsılıgını Type türünde tutar.örnegin a nın ekranda görüntüsü system.int32 dir.

            //Type a = typeof(int);
            //Console.WriteLine(a);

            //Type b = typeof(short);
            //Console.WriteLine(b);

            //Type c = typeof(char);
            //Console.WriteLine(c);

            //Type d = typeof(long);
            //Console.WriteLine(d);

            //Type e = typeof(float);
            //Console.WriteLine(e);

            //Type f = typeof(bool);
            //Console.WriteLine(c);

            //Type g = typeof(double);
            //Console.WriteLine(g);

            //Type h = typeof(byte);
            //Console.WriteLine(h);

            //----------------------------------------------------------------

            // Sizeof: kapladıgı alanı byte olarak verir.

            //int a = sizeof(int);
            //Console.WriteLine(a);

            //------------------------------------------------------

            //ornek 
            Type a = typeof(int);
            int b = sizeof(int);
            Console.WriteLine("int= veri türünün CTS karsılıgı {0} ve bellekte {1} byte kaplar", a, b);

            //Type c = typeof(long);
            //int d = sizeof(long);
            //Console.WriteLine("long= veri türünün CTS karsılıgı {0} ve bellekte {1} byte kaplar", c, d);

            //Type e = typeof(bool);
            //int f = sizeof(bool);
            //Console.WriteLine("bool= veri türünün CTS karsılıgı {0} ve bellekte {1} byte kaplar", e, f);

            //Type g = typeof(short);
            //int h = sizeof(short);
            //Console.WriteLine("short= veri türünün CTS karsılıgı {0} ve bellekte {1} byte kaplar", g, h);

            //------------------------------------------------------------------------------------

            //ornek-1
            // as operatorü: 
            //object i = "50";
            //string s = i as string;
            //Console.WriteLine(s);

            //ornek-2
            //int i = 50;
            //bool b1 = i is int; 
            //bool b2 = i is double; 
            //bool b3 = 12 is byte; 
            //bool b4 = 'c' is string;
            //bool b5 = 12f + 7 is int;

            //Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", b1, b2, b3, b4, b5);

            //ekrana true veya false oldugunu yazdırdık.

            //----------------------------------------------------------------------------------

            // verbatim text @:


            int x = 5;
            Console.WriteLine(@"c:\users\desktop{0}", x);


            //-------------------------------------------

            // ornekler::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

            //sayının tek mi çift oldugunu bulma

            //int x = 75;
            //int y = x%2;
            //Console.WriteLine(y==0 ? "sayi cift" : "sayi tek");

            //----------------------------------------------------

            //sayının 5 ve 7 ye tam bölünebildigini bulma

            //int x = 49;
            //int a = x % 5;
            //int b = x % 7;
            //bool bes = a == 0;
            //bool yedı = b == 0;

            //Console.WriteLine(bes && yedı ? "bölünebilir" : "bölünemez");

            //----------------------------------------------------

            //girilen sayının 3'ler basamagı 7 mi degil mi?

            //int x = 745;
            //int a = x / 100;

            //Console.WriteLine(a==7 ? "true" : "false");

            //------------------------------------------------------

            // girilen sayının 3'ler basamagındaki 2'lik tabandaki bit degeri 1 mi 0 mı?

            //1.yol=

            //int x = 352;
            //int y = 4;
            //int z = y & x;
            //Console.WriteLine(z == 4 ? "1" : "0");

            //2.yol=

            //int x = 352;
            //Console.WriteLine("sagdan ücüncü bit {0} {1}",x,((x>>3)&1)==1);



            //--------------------------------------------------------

            // Yamugun alanı? (not:int olarak girdigin double olarak tanınmlanmaz en az bir tane degerini double olarak gir.)

            //int a = 4;
            //int b = 5;
            //double h = 7.0;
            //double alan = ((a + b)*h / 2.0);

            //Console.WriteLine(alan);

            //---------------------------------------------------------

            // dünyadaki yercekimden agırlıgımız ayda %17 dir.o zaman ayda kaç kilosun?

            //double x = 52;
            //double y = (x * 0.17);
            //Console.WriteLine("Aydaki Agırlıgın:{0}", y);

            //------------------------------------------------------

            // verilen 4 basamaklı sayının 

            //int x = 1234;
            //int birler = x % 10;
            //int onlar = (x / 10) % 10;
            //int yüzler = (x/100) % 10;
            //int binler = (x/1000) % 10;
            //int toplam = birler+onlar+yüzler+binler;


            ////1-rakamları toplamı?

            //Console.WriteLine("1-cevap=toplam:{0}", toplam);

            //// 2-rakamları tersinden yazdır?

            //Console.WriteLine("2-cevap=" + birler+onlar+yüzler+binler);

            //// 3- son rakam başa gelecek sekilde yazdır?

            //Console.WriteLine("3-cevap=" + birler+binler+yüzler+onlar);

            //// 4 - 2 ile 3 üncü basamak yer degisterecek?

            //Console.WriteLine("4-cevap=" + binler+onlar+yüzler+birler);

            //-----------------------------------------------------------





        }
    }
}
