using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {

            ////*****************************************ArrayList tanimlama*****************************

            //// --------------------capacity /Count ---------------------------ne kadar nesne icerdigi


            //ArrayList liste =new ArrayList();

            //Console.WriteLine($"Kapasite: {liste.Capacity}");
            //Console.WriteLine($"Count: {liste.Count}");


            ////-------------------Veri ekleme-----------------------------------

            //int attimi = liste.Add('a');

            ////atarsa int deger döner
            ////ekledikten sonra tekrar kapasitesini kontrol edelim

            //Console.WriteLine("Güncelleme");
            //Console.WriteLine($"Kapasite: {liste.Capacity}");
            //Console.WriteLine($"Count: {liste.Count}");

            //liste.Add(true);

            //liste.Add("aaa");

            //Console.WriteLine("Güncelleme");
            //Console.WriteLine($"Kapasite: {liste.Capacity}");
            //Console.WriteLine($"Count: {liste.Count}");

            //liste.Add("dsds");

            //Console.WriteLine("Güncelleme");
            //Console.WriteLine($"Kapasite: {liste.Capacity}");
            //Console.WriteLine($"Count: {liste.Count}");


            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item + " ");

            //}

            //// count birer birer attırır, kapasite count sayısına eşit olduktan sonra iki katı arttırır. bu şekilde sürekli artıs yapar.

            ////---------------------silme islemi-------------------------------------

            //liste.Remove("dsds");

            //Console.WriteLine("Güncelleme");
            //Console.WriteLine($"Kapasite: {liste.Capacity}");
            //Console.WriteLine($"Count: {liste.Count}");

            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item + " ");

            //}

            ////---------------------silme islemi index numarası belirkenip-----------------------

            //liste.RemoveAt(0);

            //Console.WriteLine("Güncelleme");
            //Console.WriteLine($"Kapasite: {liste.Capacity}");
            //Console.WriteLine($"Count: {liste.Count}");

            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item + " ");

            //}

            ////----------------silme islemi index numarası belirkenip kaç tane silmeyi -----------------------

            //liste.RemoveRange(0,2);

            //Console.WriteLine("Güncelleme");
            //Console.WriteLine($"Kapasite: {liste.Capacity}");
            //Console.WriteLine($"Count: {liste.Count}");

            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item + " ");

            //}



            ////-------------trimtosize----------------------------


            //liste.TrimToSize();


            //Console.WriteLine("Güncelleme");
            //Console.WriteLine($"Kapasite: {liste.Capacity}");
            //Console.WriteLine($"Count: {liste.Count}");


            ////--------------------AddRange------------------------------

            //var dizi = new int[4] { 1, 2, 3, 4 };
            //liste.AddRange(dizi);


            //Console.WriteLine("Güncelleme");
            //Console.WriteLine($"Kapasite: {liste.Capacity}");
            //Console.WriteLine($"Count: {liste.Count}");

            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item + " ");

            //}

            //ArrayList liste2 = new ArrayList() { 1, 2, 3 };
            //liste.AddRange(liste2);


            //Console.WriteLine("Güncelleme");
            //Console.WriteLine($"Kapasite: {liste.Capacity}");
            //Console.WriteLine($"Count: {liste.Count}");

            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item + " ");

            //}



            ////------------------clear--------------------------------   temizleme



            ////---------------contains-------------------------------- varmi

            //bool varmi = liste.Contains(3);
            //Console.WriteLine($"3 varmi :{varmi}");

            //Console.WriteLine("Güncelleme");
            //Console.WriteLine($"Kapasite: {liste.Capacity}");
            //Console.WriteLine($"Count: {liste.Count}");

            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item + " ");

            //}

            ////-------------indexOf-------------------------------- hangi indexde

            //int bulunanindex = liste.IndexOf(3);

            //Console.WriteLine($"3 handi indexde :{bulunanindex}");

            //Console.WriteLine("Güncelleme");
            //Console.WriteLine($"Kapasite: {liste.Capacity}");
            //Console.WriteLine($"Count: {liste.Count}");

            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item + " ");

            //}
            ////------------------insert---------------------- güncelleme yapar istenen degerin önüne yeni degeri atar

            //liste.Insert(bulunanindex, 77);

            //Console.WriteLine("Güncelleme");
            //Console.WriteLine($"Kapasite: {liste.Capacity}");
            //Console.WriteLine($"Count: {liste.Count}");

            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item + " ");

            //}

            ////----------------------setrange---------------------- girdigin indexden sonra girdigin yeni listeyi üzerine yazar

            //liste.SetRange(0, liste2);

            //Console.WriteLine("Güncelleme");
            //Console.WriteLine($"Kapasite: {liste.Capacity}");
            //Console.WriteLine($"Count: {liste.Count}");

            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item + " ");

            //}

            //*******************************************************************************

            ////     klavyden sıfır girilene kadar deger isteyip arraylist e at cıkısta girilen sayilari kucukten buyuge dogru sirala,
            //// en kucuk,en buyuk,ortalama yazdır?


            //ArrayList liste = new ArrayList();
            //int sayi = 0;


            //do
            //{

            //    Console.Write("sayi giriniz  : ");
            //    sayi = int.Parse(Console.ReadLine());
            //    if (sayi!=0)
            //    {
            //        liste.Add(sayi);
            //    }



            //} while (sayi!=0);


            ////foreach (var item in liste)
            ////{
            ////    Console.Write(item + "  ");

            ////}

            ////kucukten buyuge
            //liste.Sort();

            ////ters yazdırıp buyukten kucuk gormek istedigimiz icin
            //liste.Reverse();
            //foreach (var item in liste)
            //{
            //    Console.Write(item + "  ");
            //}

            //Console.WriteLine();

            //Console.WriteLine($"En Büyük Sayı : {liste[0]}");
            //Console.WriteLine($"En Küçük Sayı : {liste[liste.Count-1]}");

            //double ortalama = 0;
            //int toplam = 0;
            //foreach (var item in liste)
            //{
            //    toplam = toplam + (int)item;
            //}

            //ortalama = (double)toplam / liste.Count;
            //Console.WriteLine($"Ortalama : {ortalama}");

            //******************************************************************************

            //// arraylist de art arda en çok devam eden sayıyı arraylist e atmak?

            //ArrayList liste = new ArrayList() {1, 1, 1, 2, 2, 2, 2, 3, 3, 3,3,3,3};

            //if ((int)liste[liste.Count]==0)
            //{
            //    liste.Add(1);
            //}
            //else
            //{
            //    liste.Add(0);
            //}


            //ArrayList liste2 = new ArrayList();

            //int sayac = 0;
            //int sayi = 0;
            //int max = 0;


            //for ( int i= 0; i < liste.Count-1; i++)
            //{

            //        if ((int)liste[i] == (int)liste[i + 1])
            //        {
            //            sayac++;
            //        }
            //        else
            //        {
            //            if (sayac > max)
            //            {
            //                max = sayac;
            //                sayi = (int)liste[i];
            //            }
            //            sayac = 0;
            //        }

            //}


            //for (int k = 0; k <= max; k++)
            //{
            //    liste2.Add(sayi);
            //}

            //foreach (var item in liste2)
            //{
            //    Console.Write(item);
            //}





        }
    }
}
