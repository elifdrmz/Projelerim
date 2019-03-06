using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deger_dondurmeyen_metodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            //Geri dönüş değeri ve parametre-listesi boş olan, ekrana “Merhaba Dünya” yazdıran metodu tanımlayıp program içerisinde kullanımına bir örnek veriniz.
            #region Soru1
            //MerhabaDunyaYaz();

            #endregion
            //----------------------------------------------------------------------------------------
            //Klavyeden girilen bir tam sayının karesini ekrana yazan  metodu ve bu metodun program içerisinde kullanımını gösteren programın kodunu yazınız.
            #region Soru2
            //Console.Write("Bir Sayı Gir:");
            //int sayi=int.Parse(Console.ReadLine());
            //KareAl2(sayi);
            #endregion

            //Klavyeden girilen bir mesajı ekrana N defa yazdıran metodun kodunu yazınız.
            #region Soru3
            //Console.Write("Yazı:");
            //string yazi = Console.ReadLine();
            //Console.Write("Kaç Defa:");
            //int kacDefa = int.Parse(Console.ReadLine());
            //NDefaYaz(yazi, kacDefa);
            #endregion

            //Parametre olarak gönderilen bir dizinin toplamını ekrana yazdıran metodun kodlarını yazınız.
            #region Soru4

            //int[] dizi = new int[5] { 1,2,3,4,5};
            //DiziyiTopla(dizi);
            #endregion

            //Parametre olarak gönderilen iki sayıdan büyük olanı ekrana yazdıran metodun kodlarını yazınız.
            #region Soru5
            //Console.Write("Sayi 1: ");
            //int sayi1 =int.Parse(Console.ReadLine());

            //Console.Write("Sayi 2: ");
            //int sayi2 = int.Parse(Console.ReadLine());

            //BuyukSayiyiBul(sayi1,sayi2);
            #endregion

            //Parametre olarak gönderilen kullanıcı adı ve şifreyi kontrol eden, önceden belirlenmiş olan bir kullanıcı adı ve şifreyle karşılaştıran metodun kodlarını yazınız.
            #region Soru6
            //Console.Write("Kullanıcı Adı: ");
            //string kadi = Console.ReadLine();

            //Console.Write("Sifre ");
            //string sifre = Console.ReadLine();

            //GirisYap(kadi,sifre);
            #endregion
            //Klavyeden girilerek parametre olarak gönderilen bir sayının, asal sayı olup olmadığını kontrol eden, eğer sayı asal ise ekrana «Asaldır» değilse «Asal Değildir» değeri yazan metodu yazınız.
            #region Soru7
            //Console.Write("Sayi Gir: ");
            //int sayi =int.Parse(Console.ReadLine());

            //AsalKontrolEt(sayi);
            #endregion
            #region Ref-Deger
            //değer tipli
            int sayi = 5;
            SayiyiDegistir(sayi);
            Console.WriteLine("sayi:{0}", sayi);

            //ref tipli
            var dizi = new int[] { 1, 2 };
            DiziyiDegistir(dizi);
            Console.WriteLine("dizi:{0}{1}", dizi[0], dizi[1]);
            #endregion

        }
        //ref
        static void DiziyiDegistir(int[] dizi2)
        {
            dizi2[0] = 0;
            Console.WriteLine("dizi2:{0}{1}", dizi2[0], dizi2[1]);
        }
        //deger
        static void SayiyiDegistir(int sayi)
        {
            sayi = 7;
            Console.WriteLine("sayi 2:{0}", sayi);
        }
        //soru7
        static void AsalKontrolEt(int sayi)
        {
            if (sayi > 1)
            {
                bool isPrime = true;
                for (int i = 2; i <= sayi / 2; i++)
                {
                    if (sayi % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine(isPrime ? "Asal" : "Asal Değil");
            }
            else
            {
                Console.WriteLine("Asal Değil");
            }
        }

        //Soru6
        static void GirisYap(string kadi, string sifre)
        {
            if (kadi.ToLower() == "admin" && sifre.ToLower() == "admin")
                Console.WriteLine("Giriş Başarılı");
            else
                Console.WriteLine("Giriş Başarısız");
        }
        //Soru 5
        static void BuyukSayiyiBul(int sayi1, int sayi2)
        {
            if (sayi1 > sayi2)
            {
                Console.WriteLine("Büyük Sayi :{0}", sayi1);
            }
            else
            {
                Console.WriteLine("Büyük Sayi :{0}", sayi2);
            }
        }
        //Soru 4
        static void DiziyiTopla(int[] dizi)
        {
            int toplam = 0;
            foreach (var item in dizi)
            {
                toplam = toplam + item;
            }
            Console.WriteLine("Dizinin toplamı {0}'dır.", toplam);
        }
        //soru3
        static void NDefaYaz(string neYazilacak, int kacDefaYazilacak)
        {
            for (int i = 0; i < kacDefaYazilacak; i++)
            {
                Console.WriteLine(neYazilacak);
            }
        }
        //soru1
        static void MerhabaDunyaYaz()
        {
            Console.WriteLine("Merhaba Dünya");
        }
        //soru2
        static void KareAl(int sayi)
        {
            Console.WriteLine($"Verilen {sayi}'nın karesi {sayi * sayi}'dır.");
        }
        //soru2
        static void KareAl2(int sayi)
        {
            Console.WriteLine($"Verilen {sayi}'nın karesi {sayi * sayi}'dır.");
        }

    











    }
}
