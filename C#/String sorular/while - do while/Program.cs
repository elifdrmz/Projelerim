using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while___do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 0 dan 20 ye kadar olan cift sayıları ekrana yazdıran program?

            //int sayac = 0;
            //while (sayac <= 20)

            //{
            //    Console.WriteLine("cift sayılar=", sayac);
            //}

            //sayac = sayac + 2;


            //***********************************************************************

            //// Kullanıcıdan sıfır sayısı girilene  kadar girilmis tüm sayıları toplayan programı while 
            //// döngüsü yardımıyla yapınız?


            //Console.Write("Bir sayi girin, 0 girersen biter");
            //int sayi = int.Parse(Console.ReadLine());

            //int toplam = 0;
            //while (sayi != 0)

            //{
            //    toplam = toplam + sayi;
            //    Console.Write("Bir sayi girin, 0 girersen biter");
            //    sayi = int.Parse(Console.ReadLine());

            //}

            //Console.WriteLine("toplam:{0}",toplam);

            //********************************************************************

            //// Girilen sayi asal mi?

            //int bolen = 2;
            //Console.Write("sayi giriniz=");
            //int sayi = int.Parse(Console.ReadLine());


            //while (sayi >= bolen)
            //{
            //    if (sayi == 2)
            //    {
            //        Console.WriteLine("sayi asaldir");
            //        break;
            //    }


            //    if (sayi % bolen == 0)
            //    {
            //        Console.WriteLine("sayi asal degildir");
            //        break;
            //    }


            //        bolen++;

            //        if (sayi == bolen)
            //        {
            //            Console.WriteLine("sayi asaldir");
            //        break;
            //    }
            //}

            //************************************************************************


            //// girilen sayının faktoriyeli?

            //Console.Write("sayi giriniz=");
            //int sayi = int.Parse(Console.ReadLine());

            //int faktoriyel = 1;
            //int sayac = 1;


            //while (sayac <= sayi)

            //{

            //    faktoriyel = faktoriyel * sayac;

            //    sayac++;
            //}


            //Console.WriteLine("faktoriyel={0}", faktoriyel);


            //********************************************


            //// bilgisayarın ürettigi sayıyla tahmin edilen sayının 5 hakla bulunması?


            //Random r = new Random();
            //int uretilen_sayi = r.Next(1, 100);

            //int hak = 5;

            //while (hak <= 5)
            //{
            //    Console.Write("sayi giriniz=");
            //    int tahmin_sayi = int.Parse(Console.ReadLine());

            //    if (uretilen_sayi > tahmin_sayi)

            //        {
            //            Console.WriteLine("daha buyuk sayi giriniz");

            //         }
            //     else
            //        {

            //            Console.WriteLine("daha kucuk sayi giriniz");

            //        }

            //    hak--;
            //    if (hak >0)
            //    {
            //        Console.WriteLine("kalan hakkınız={0}", hak);

            //    }
            //    else
            //    {
            //        Console.WriteLine("hakkınız bitmistir");
            //        break;
            //    }



            //    if (uretilen_sayi == tahmin_sayi)
            //    {
            //        Console.WriteLine("basarılı giris");
            //    }

            //  }

            //**************************************************************************
            //// do while 

            //// 1 den 20 ye kadar olan tek sayilari ekrana yazdiriniz?

            //int sayac = 1;
            //int toplam = 0;
            //do
            //{

            //    Console.WriteLine(sayac);
            //    sayac = sayac + 2;

            //}

            //while (sayac < 21);

            //*******************************************

            //// toplama oyunu?



            //int puan = 0;
            //int dogrucevap = 0;
            //int yanliscevap = 0;

            //string s = "";

            //do
            //{
            //    Random r = new Random();
            //    double A = r.Next(1, 100);
            //    double B = r.Next(1, 100);

            //    Console.WriteLine("A={0}    B={1}    A+B=?", A, B);
            //    Console.Write("A+B=");
            //    double cevap = double.Parse(Console.ReadLine());

            //    double sonuc = A + B;

            //    if (sonuc == cevap) 
            //    {
            //        Console.WriteLine("Tebrikler Bildiniz");
            //        puan = puan + 5;
            //        dogrucevap++;
            //    }


            //     else
            //     {
            //        Console.WriteLine("üzgünüm Bilemediniz");
            //        puan = puan - 2;
            //        yanliscevap++;

            //    }

            //    Console.WriteLine("Tekrar Oynamak İstiyormusunuz? (e/h)");
            //    s = Console.ReadLine();


            //}while (s.ToUpper() == "E");

            //Console.WriteLine("Puaniniz={0}", puan);

            //Console.WriteLine("dogru sayiniz={0}", dogrucevap);

            //Console.WriteLine("yanlis sayiniz={0}", yanliscevap);

            //*******************************************************************


            //// yukarıdaki oyunda işlemi bilgisayar kendi secicek?


            //    int puan = 0;
            //    int dogrucevap = 0;
            //    int yanliscevap = 0;

            //    string s = "";

            //    double cevap = 0;
            //    double sonuc = 0;


            //    do
            //    {
            //        Random r = new Random();
            //        double A = r.Next(1, 100);
            //        double B = r.Next(1, 100);
            //        int islem = r.Next(1, 5);

            //        switch (islem)
            //        {
            //            case 1:
            //                Console.WriteLine("A={0}    B={1}    A+B=?", A, B);
            //                Console.Write("A+B=");
            //                cevap = double.Parse(Console.ReadLine());
            //                sonuc = A + B;
            //                break;

            //            case 2:
            //                Console.WriteLine("A={0}    B={1}    A-B=?", A, B);
            //                Console.Write("A-B=");
            //                cevap = double.Parse(Console.ReadLine());
            //                sonuc = A - B;
            //                break;

            //            case 3:
            //                Console.WriteLine("A={0}    B={1}    A*B=?", A, B);
            //                Console.Write("A*B=");
            //                cevap = double.Parse(Console.ReadLine());
            //                sonuc = A * B;
            //                break;

            //            case 4:
            //                Console.WriteLine("A={0}    B={1}    A/B=?", A, B);
            //                Console.Write("A/B=");
            //                cevap = double.Parse(Console.ReadLine());
            //                sonuc = A / B;
            //                break;
            //        }

            //    }


            //        if (sonuc == cevap)
            //    {
            //        Console.WriteLine("Tebrikler Bildiniz");
            //        puan = puan + 5;
            //        dogrucevap++;
            //    }


            //    else
            //    {
            //        Console.WriteLine("üzgünüm Bilemediniz");
            //        puan = puan - 2;
            //        yanliscevap++;

            //    }

            //    Console.WriteLine("Tekrar Oynamak İstiyormusunuz? (e/h)");
            //    s = Console.ReadLine();


            //} while (s.ToUpper() == "E");

            //    Console.WriteLine("Puaniniz={0}", puan);

            //    Console.WriteLine("dogru sayiniz={0}", dogrucevap);

            //    Console.WriteLine("yanlis sayiniz={0}", yanliscevap);





            //    revize ettttttttttttttttttttttttttttttttttttt

            //****************************************************************


            //// klavteden girilen 10 sayı icerisinden
            //// a) 100-200 arasindaki sayilarin adeti
            //// b)100'den kucuk sayilarin toplami
            //// c) 200'den buyuk sayilardan da 4'e kalansiz bolunebilenlerini ekrana yazdıran programı do-while dongusu ve if
            //// komutuyla yaziniz?

            //int toplam = 0;
            //int sayac = 0;
            //int i;
            //string a = "";

            //for (i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Lutfen sayi degerini giriniz");
            //    int sayi = int.Parse(Console.ReadLine());

            //    if (sayi > 100 && sayi < 200)
            //    {
            //        sayac = sayac + 1;
            //    }

            //    if(sayi<100)
            //    {
            //        toplam = toplam + sayi;
            //    }

            //    if(sayi>200 && sayi%4==0)
            //    {


            //        a = a + " " + sayi.ToString();

            //    }


            // }


            //Console.WriteLine("a) {0}", sayac);
            //Console.WriteLine("b) {0}", toplam);
            //Console.WriteLine("c) {0}", a);



            ////2.yol-------------------------------------------

            //int sayac = 1;
            //int adet = 0;
            //int toplam = 0;
            //string s = "";

            //do
            //{

            //    Console.Write("Lutfen sayi giriniz");
            //    int sayi = int.Parse(Console.ReadLine());

            //    if (sayi > 100 && sayi < 200)
            //    {
            //        adet++;
            //    }

            //    else if (sayi <= 100)
            //    {
            //        toplam = toplam + sayi;
            //    }

            //    else if (sayi >= 200 && sayi % 4 == 0)
            //    {
            //        s = s + " , " + sayi;                                  //sayi.Tostring yazmasakta s string olarak alır cünkü sayidan once string degerle toplandıgından
            //    }

            //    sayac++;

            //} while (sayac < 11);


            //Console.WriteLine("a) {0} \n b) {1} \n c) {2}", adet, toplam, s);


            //***************************************************************************************

            ////1000 ile 2000 arasındaki snsli sayilari ekrana yazdıran(orn=ABCD, A+C=B+D olacak)

            //int i;
            //string s = "";

            //for (i = 1; i < int.MaxValue; i++)

            //{
            //    Random r = new Random();
            //    int sayi = r.Next(1000, 9999);

            //    Thread.Sleep(500);

            //    int A = sayi/1000;

            //    int B = (sayi / 100)%10;

            //    int C = (sayi / 10) % 10;

            //    int D = sayi % 10;

            //    if (A + C == B + D)

            //    {
            //        s = sayi.ToString();
            //        Console.WriteLine("sayilar={0}", s);
            //    }
            //}

            //***************************************************************


            //// klavyeden rasgale girilen sıfır bulana kadar en kucuk ve en buyuk sayısı ekrana yazdıran?


            //int sayac = 1;
            //int maksimum = int.MinValue;
            //int minimum = int.MaxValue;

            //Console.WriteLine("ilk sayi 0 olamaz");
            //                                            //ilk girilen sayının sıfır olması durumunda yapılacak işlemi yap eksik kaldı

            //do
            //{
            //    Console.Write("sayi girin=");
            //    int sayi = int.Parse(Console.ReadLine());

            //    if (sayi == 0)
            //    {

            //        Console.WriteLine("islem bitmistir."); break;

            //    }


            //    if (maksimum < sayi)
            //    {
            //        maksimum = sayi;
            //    }

            //    if (minimum > sayi)
            //    {
            //       minimum = sayi;
            //    }

            //    sayac++;

            //} while (sayac<int.MaxValue);


            //Console.WriteLine("maksimum sayi={0} \nminimum sayi={1}", maksimum, minimum);




            // buna mutlaka bak kafama yatmayan şey var(işlem hatalı değil)



        }
    }
}
