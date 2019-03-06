using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıf_tanimlama1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////-----------------class ( student )----------------------

            //student student = new student();
            //student.ad = "Ali";
            //student.soyad = "Bak";
            //student.ogrenciID = 123;


            //------------------class (student) => private yapmıs hali-------------------

            //student student = new student();
            //student.OgrenciID = 123;
            //int oid = student.OgrenciID;
            //student.Ad = "elif";

            //if ("elif".Length < 6)
            //{
            //    //yeni deger iste
            //}
            //else
            //{

            //}


            ////------------------class ( insan )----------------------

            //insan insan = new insan();
            //insan.ad="elif";
            //insan.soyad = "durmaz";


            //------------------class (insan) => private yapmıs hali-------------------

            //student insan = new student();

            //-----------------------class (ogrenci)-------------------------------------

            ////**********************ornek*************************************************

            //Console.Write("kac ogrenci : ");
            //int sayi = int.Parse(Console.ReadLine());

            //ArrayList liste = new ArrayList();



            //for (int i = 0; i <sayi; i++)
            //{
            //    Ogrenci Ogrenci = new Ogrenci();
            //    Console.Write(" {0}. ogrencinin adi : ",i+1); Ogrenci.Ad = Console.ReadLine();
            //    Console.Write(" {0}. ogrencinin soyadi : ", i + 1); Ogrenci.Soyad= Console.ReadLine();
            //    Console.Write("{0}. ogrencinin numarasi : ", i + 1); Ogrenci.No = int.Parse(Console.ReadLine());
            //    Console.Write("{0}. ogrencinin ortalamasi : ", i + 1); Ogrenci.Ortalama =double.Parse(Console.ReadLine());
            //    liste.Add(Ogrenci);
            //}

            ////listeye attıgımız ogrencileri ekrana yazdirma

            //foreach (var item in liste)
            //{
            //    //Console.WriteLine(item);       //sadece item yazarsak sadece ogrenci yazar icerigini vermez o yuzden ogrenci olarak tanıtalim
            //    Console.WriteLine(((Ogrenci)item).Ad);
            //    Console.WriteLine(((Ogrenci)item).Soyad);
            //    Console.WriteLine(((Ogrenci)item).No);
            //    Console.WriteLine(((Ogrenci)item).Ortalama);
            //    Console.WriteLine("-------------------------------------------");

            //}

            //int index = 0;
            //int sayac = 0;
            //foreach (var item2 in liste)
            //{

            //    double min = 100;
            //    if (((Ogrenci)item2).Ortalama < min)
            //    {
            //        min = ((Ogrenci)item2).Ortalama;
            //        index = sayac;

            //    }

            //    sayac++;
            //}
            //Console.WriteLine("en dusuk ortalaması olan ogrenci");
            //Console.WriteLine(((Ogrenci)liste[index]).Ad);
            //Console.WriteLine(((Ogrenci)liste[index]).Soyad);
            //Console.WriteLine(((Ogrenci)liste[index]).No);

            ////**************************************************************************

        }
    }
}
