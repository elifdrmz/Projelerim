using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {

            ////--------------------------------------String metodları--------------------------------------------

            ////-------------compare ------------1.buyuk (1 )2.buyuk(-1) esit mi (0) alir

            //Console.WriteLine("------------compare-------");
            //string metin1 = "byte";
            //string metin2 = "Byte";
            //int sonuc = string.Compare(metin1, metin2);
            //Console.WriteLine($"string.Compare({metin1},{metin2})");
            //Console.WriteLine($"{metin1} ile {metin2}={sonuc}");

            ////case duyarlı degil(true ekleyerek büyük harf kücük harf duyarlı degil demek)
            //int sonuc2 = string.Compare(metin1, metin2, true);
            //Console.WriteLine($"string.Compare({metin1},{metin2}),(true)");
            //Console.WriteLine($"{metin1} ile {metin2}={sonuc2}");


            ////------------concat--------bitisik yazdır

            //Console.WriteLine("------------concat-------");
            //string sonuc3 = string.Concat(metin1, metin2);
            //Console.WriteLine($"string.concat({metin1},{metin2})");
            //Console.WriteLine($"{metin1} ile {metin2}={sonuc3}");

            ////------------indexOf-------- icinde varmi

            //Console.WriteLine("------------indexOf-------");
            //int sonuc4 = metin1.IndexOf("yt");
            //Console.WriteLine($"metin1.IndexOf(yt)");
            //Console.WriteLine($"{metin1} icerisinde yt={sonuc4}");

            ////-----------startwith-------- basliyor mu

            //Console.WriteLine("------------startwith-------");
            //bool sonuc5 = metin1.StartsWith("th");
            //Console.WriteLine($"metin1.StartsWith(th)");
            //Console.WriteLine($"{metin1} th ile basliyor mu={sonuc5}");

            ////-------------trim------------ silme

            //Console.WriteLine("------------trim-------");
            //string sonuc6 = metin1.Trim();
            //Console.WriteLine($"metin1.Trim()");
            //Console.WriteLine($"{metin1} bosluklari siler ={sonuc6}");

            //string sonuc7 = metin1.Trim('b');
            //Console.WriteLine($"metin1.Trim(b)");
            //Console.WriteLine($"{metin1} b harfini siler ={sonuc7}");

            ////------------remove-------------- den sonra siler

            //Console.WriteLine("------------remove-------");
            //string sonuc8 = metin1.Remove(2);
            //Console.WriteLine($"metin1.Remove(2)");
            //Console.WriteLine($"{metin1} 2 den sonra siler ={sonuc8}");

            ////-----------split ------------------ diziye donustur

            //Console.WriteLine("------------split-------");

            //string metin = "merhaba dünya nasilsin iyi misin";
            //string [] dizi=metin.Split(' ');

            //foreach (var item in dizi)
            //{
            //    Console.WriteLine(item);
            //}

            //string metin_1 = "merhaba.dünya.nasilsin.iyi.misin";
            //string[] dizi2 = metin_1.Split('.');

            //foreach (var item in dizi2)
            //{
            //    Console.WriteLine(item);
            //}

            ////-----------join-------------    diziyi birleştirmek için

            //Console.WriteLine("------------join-------");

            //string metin_2 = string.Join(".", dizi);

            //Console.WriteLine(metin_2);



            //*******************************************************************************************************

            //// ornek-----=> "eDaBit" olan string in sadece buyuk harflerin index numaralarini yazdiran dizi?


            //*** 90 yerine 'Z' de yazıp o otomatik 90 olarak algılar

            //string metin =  "mEhmeTaYaN";
            //char[] diziMetin = metin.ToCharArray();
            //int sayac = 0;

            ////kactane buyuk harf var onu buluyorum
            //foreach (char  item in diziMetin)
            //{
            //    if (item<='90')
            //    {
            //        sayac++;
            //    }

            //}

            ////buldugum buyuk harf kadar dizi olustuyorum
            //int[] indexArray = new int[sayac];

            //int sayac2 = 0;


            //for (int i = 0; i < metin.Length; i++)
            //{
            //    if ((char.Parse(metin.Substring(i,1)))<='90')
            //    {
            //        indexArray[sayac2] = i;
            //        sayac2++;
            //    }

            //}

            //foreach (var item in indexArray)
            //{
            //    Console.Write(item + " ");
            //}

            //*****************************************************************************************************************
            ////ornek------==> verilen kelimeler 5'ten buyukse ters cevir degilse aynı kalsin

            //string metin = "elif sevde a ali hakan hasan.";

            ////düz olarak diziye atama

            //string[] dizi = metin.Split(' ');


            //foreach (var item in dizi)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine ();

            ////5 karakterden buyuk olan kelimeleri ters cevirme

            //Console.WriteLine("5'ten büyükleri ters cevrilmis");

            //foreach (var item in dizi)
            //{
            //    if (item.Length >= 5)
            //    {
            //        char[] _char = item.ToArray();

            //        Console.Write(string.Concat(_char.Reverse()) + " ");

            //    }
            //    else
            //    {
            //        Console.Write(item + " ");
            //    }


            //    }





















        }
    }
}
