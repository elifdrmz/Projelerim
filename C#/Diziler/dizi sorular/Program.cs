using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi_sorular
{
    class Program
    {
        static void Main(string[] args)
        {




            ////klavyeden 5 kere girilen degeri Array' atarak ekrana yazdır?

            ////uzunluk yaz

            //int uzunluk = int.Parse(Console.ReadLine());
            //int[] dizi = new int[uzunluk];


            ////sayıları gir

            //for (int i = 0; i < 5; i++)
            //{

            //    int deger = int.Parse(Console.ReadLine());
            //    dizi[i] = deger;

            //}

            ////sayıları yazdır

            //foreach (int item in dizi)
            //{
            //    Console.Write("{0} ", item);
            //}


            //******************************************************************************



            //int[] x = { 1,2,3,4,5,6,7};

            //int[] y=new int [10];
            //////1.yol    Array.Copy(x,y,2);
            //////2.yol    Array.Copy(x, 0, y, 0, 7);
            //foreach (var item in y)
            //{
            //    Console.WriteLine(item);
            //}


            ////Diziyi tersten yazdırma?

            //int[] x = { 1, 2, 3, 4, 5 };

            //for(int i=4;i>=0;i--)
            //{

            //    Console.WriteLine(x[i]);
            //}


            //*******************************************


            //// ekrandan girilen deger ile incelenip baslangıc ve son deger istenip ters dönüsecek aralık istensin ve o sekilde ekrana yazdır?



            //Console.WriteLine("Kac elemanli bir dizi gireceksin :");
            //int uzunluk=int.Parse(Console.ReadLine());

            ////dizi tanimlama
            //int[] dizi = new int[uzunluk];

            ////icini doldurma
            //for (int i = 0; i < uzunluk; i++)
            //{
            //    Console.Write("{0} elemani girin :",i + 1);
            //    int eleman = int.Parse(Console.ReadLine());
            //    dizi[i] = eleman;

            //}

            ////baslangic
            //Console.WriteLine("Baslangıc? ");
            //int bas = int.Parse(Console.ReadLine());

            ////son
            //Console.WriteLine("Son deger? ");
            //int son= int.Parse(Console.ReadLine());

            ////yer degistirme

            //for (int i = bas, j = son; i < j; i++, j--)

            //{
            //    int temp = dizi[i];
            //    dizi[i] = dizi[j];
            //    dizi[j] = temp;

            //}

            //foreach (var item in dizi)
            //{
            //    Console.Write(item + " ");
            //}


            //*********************************************************************


            //// tanimlanan dizinin son elemani?

            // 1.yontem

            //int[] x = { 1, 2, 3, 4, 5, 6, 7, 0, 0, 0};

            //for(int i=x.Length-1;i>=0;i--)
            //{
            //    if(x[i]==0)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("son deger={0}",x[i]);break;
            //    }

            //}


            //2.yöntem

            //int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 0, 0, 0 };

            //bool x = false;

            //for (int i = dizi.Length; i >= 0; i--) 
            //{
            //    if(dizi[i] !=0)
            //    {
            //        Console.WriteLine(dizi[i]);
            //        x = true;
            //        break;
            //    }
            //}

            //if(x==false)
            //{
            //    Console.WriteLine("yok");
            //}



            //********************************************************************************************************

            ////tanimlanan dizinin min ve max degerlerini veren?

            //int[] x = { 1, 2, 3, 4, 5, 6, 7, 0, 0, 0 };

            //int min = int.MaxValue;
            //int max = int.MinValue;

            //for(int i=0;i<x.Length;i++)
            //{
            //    if(x[i]<min)
            //    {
            //        min = x[i];
            //    }
            //    if(x[i]>max)
            //    {
            //        max = x[i];
            //    }


            //}

            //Console.WriteLine("minimum={0}", min);
            //Console.WriteLine("maximum={0}", max);



            //2.yontem foreach ile yap












            //*************************************************************************

            //// girilen sayilarin mutlak degerlerinin toplamini yazdiran?


            //int[] x = { 2, -1, 4, 8, 10 };
            //int toplam = 0;
            //for (int i=0;i<x.Length;i++)
            //{
            //    if(x[i]<0)
            //    {
            //        x[i]=x[i] * (-1);
            //        toplam = toplam + x[i];
            //    }

            //    toplam = toplam + x[i];
            //}

            //Console.WriteLine(toplam);



            //**********************************************************************************************************

            ////girilen sayilarin cift degrelerini eleyip yeni degiskene atama?

            //int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int sayac=0;

            //    foreach (var item in x)
            //    {
            //        if (item % 2 == 0)
            //        {
            //            sayac++;
            //        } 
            //    }


            //int []y= new int[ sayac ];
            //int sayac2 = 0;

            //for(int i=0; i<x.Length;i++)
            //{
            //    if(x[i]%2==0)
            //    {
            //        //yeni diziye ata
            //        y[sayac2] = x[i];
            //        Console.Write(y[sayac2] + " ");
            //        sayac2++;

            //    }

            //}

            //*****************************************************************************************

            //// girilen sayilarin tekrarini almayalim? (örn: 1,1,0,0,0,1,2) nin (1,0,2) olarak yazdirmak?


            //int[] dizi = { 1, 0, 0, 1, 4, 4, 5, 7, 4, 6 };

            //foreach (var item in dizi)
            //{
            //    Console.Write(item + " ");

            //}

            //Console.WriteLine();
            ////1 0 4 5 7 6 => 6 tane

            //int sayac = 0;

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    if (i == 0)
            //    {
            //        sayac++;
            //        continue;
            //    }
            //    bool isDifferent = true;

            //    for (int j = 0; j < i; j++)
            //    {
            //        int d_i = dizi[i];
            //        int d_j = dizi[j];
            //        if (d_i == d_j)
            //        {
            //            //esitse böyle sayi var
            //            isDifferent = false;
            //        }
            //    }

            //    if (isDifferent == true)
            //    {
            //        sayac++;
            //    }

            //}

            //int[] dizi2 = new int[sayac];
            ////yeni diziye atama-----------------------------------------------------------
            //int sayac2 = 0;
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    if (i == 0)
            //    {
            //        dizi2[sayac2] = dizi[i];

            //        sayac2++;
            //        continue;
            //    }
            //    bool isDifferent = true;

            //    for (int j = 0; j < i; j++)
            //    {
            //        int d_i = dizi[i];
            //        int d_j = dizi[j];
            //        if (d_i == d_j)
            //        {
            //            //esitse böyle sayi var
            //            isDifferent = false;
            //        }
            //    }

            //    if (isDifferent == true)
            //    {
            //        dizi2[sayac2] = dizi[i];

            //        sayac2++;
            //    }

            //}

            //foreach (var item in dizi2)
            //{
            //    Console.Write(item + " ");

            //}


            //***************************************************************************************************************

            //// girilen sayılarda ard arda yazılışında eksik olanı ver? (orn:{0,1,2,3,4,6,7,8,9} sonuc:5) sayılar karısıkta olabilir


            //int[] rakamlar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] dizi = { 1, 2, 3, 4, 6, 7, 8, 9, 10 };

            //for(int i=0; i < rakamlar.Length; i++)

            //{
            //    for (int k = 0; k < dizi.Length; k++)
            //    {

            //        if(rakamlar[i]==dizi[k])
            //        {
            //            break;

            //        }
            //        if(j+1==dizi.Length)
            //        {
            //            Console.WriteLine(rakamlar[i]);

            //        }
            //    }


            //}

            //  //2.yol

            //int[] dizi = { 2,5,9, 9};
            //  for(int j=0;j<=9;j++)
            //  {
            //      int sayac = 0;
            //      for (int i = 0; i < dizi.Length; i++)
            //      {
            //          if(dizi[i]==j)
            //          {
            //              sayac++;

            //          }
            //          if(sayac==0)
            //          {
            //              Console.Write("eksik sayilar={0}", j);
            //          }
            //      }
            //  }



            //**************************************************************************************


            //****************************************************************
            //string a="abc";
            //is operatoru,
            //bool mi= a is int;

            //(mi=false olur)


            //// girilen dizi icerisinde sadece integirlari alıcaz?(orn [1,2,"a","b"] => [1,2]

            //object[] dizi = { 1, "a", "b", 0, 15 };

            //int sayac = 0;

            //for(int i=0;i<dizi.Length;i++)
            //{
            //    bool a=dizi[i] is int;
            //    if (a == true)
            //    {
            //        sayac++;
            //    }

            //}


            //int sayac2 = 0;
            //int[] dizi2 = new int[sayac];

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    bool a = dizi[i] is int;
            //    if (a == true)
            //    {

            //        dizi2[sayac2] =(int) dizi[i];

            //        sayac2++;
            //    }

            //}


            //foreach (var item in dizi2)
            //{
            //    Console.Write(item + " ");
            //}



            //******************************************************************************************

            ////dizi icerisindeki en kucuk iki deger topla?

            //int[] dizi = { 19, 5, 42, 2, 77 };


            //int index = 0;
            //int toplam = 0;

            //for (int i = 0; i < 2; i++)
            //{
            //    int min = int.MaxValue;

            //    for (int k = 0; k < dizi.Length; k++)
            //{
            //    if (dizi[k] < min)
            //    {
            //            min = dizi[k];
            //            index = k;
            //    }

            //}

            //    toplam = toplam + dizi[index];
            //    dizi[index] = int.MaxValue;
            //}

            //Console.WriteLine(toplam);


            //***********************************************************************************************


            //// girilen string yazıların bas harfleri tek buyuk olarak yazdır?(orn= "mavis" => "Mavis" , "MABELLE" => "Mabelle")


            //string[] dizi = { "mavis", "MABELLE", "elif","SEVDE" };

            //for(int i=0;i<dizi.Length;i++)
            //{
            //    string ilk = dizi[i].Substring(0, 1).ToUpper();
            //    string son= dizi[i].Substring(1).ToLower();

            //    dizi[i] = ilk + son; 

            //}

            //foreach (var item in dizi)
            //{
            //    Console.Write(item + " ");

            //}


            //**********************************************************************************************


            //// diziyi kucukten buyuge dogru sırala?-------selection sort----------------

            //int[] dizi = { 14, 8, 34, 85, 90, 85, 96, 86, 38, 77, 97, 71, 63, 61, 44, 33 };

            //int index = 0;
            //int temp = 0;
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    int min = int.MaxValue;

            //    for (int k = i + 1; k < dizi.Length; k++)
            //    {
            //        //min bulma
            //        if (dizi[k] < min)

            //        {
            //            min = dizi[k];
            //            index = k;
            //        }
            //    }
            //    if (dizi[i] > dizi[index])
            //    {
            //        temp = dizi[i];
            //        dizi[i] = dizi[index];
            //        dizi[index] = temp;

            //    }

            //}

            //foreach (var item in dizi)
            //{
            //    Console.Write(item + " ");
            //}

            //**********************************************************************************************

            //************************************ODEV******************************************************

            ////Sıralı dizide istenenen deger var mı diye kontrol varsa kaçıncı index de? -------------Binary Search---------------------- -

            ////ornegin int[] dizi = { 1, 2, 3, 4, 5 } =>> 3 varmi? var 2.index de


            //int[] dizi = { 1, 3, 6, 10, 15, 20, 25, 30 };



            //int sayac = 0;

            //Console.Write("Hangi sayiyi bulmak istiyorsun=");
            //int sayi = int.Parse(Console.ReadLine());

            //int son_index = dizi.Length - 1;

            //int ilk_index = 0;


            //int index = (ilk_index + son_index) / 2;

            //do
            //{
            //    if (dizi[index] == sayi)
            //    {

            //        Console.WriteLine("sayiyi buldunuz---{0}. index", index);
            //        sayac++;
            //        Thread.Sleep(3000); break;

            //    }

            //    else if (dizi[index] > sayi)
            //    {


            //        son_index = index;
            //        index = (son_index + ilk_index) / 2;
            //    }

            //    else
            //    {
            //        ilk_index = index;

            //        index = (son_index + ilk_index) / 2;
            //    }


            //} while (dizi[index] == sayi);

            //if(sayi==dizi[ilk_index])
            //{
            //    Console.WriteLine("sayiyi buldunuz---{0}. index", ilk_index)
            //        sayac++;
            //}
            //else if(sayi==dizi[son_index])
            //{
            //    Console.WriteLine("sayiyi buldunuz---{0}. index", son_index);
            //    sayac++;
            //}

            //if(sayac==0)
            //{
            //    Console.WriteLine("sayi bulunmadi");
            //}

        }
    }
}
