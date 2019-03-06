using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizinin_yardimci_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //**********************************************************************************************

            // //---------------------------------------Dizinin yardimci metodlari-------------------------------

            //int[] dizi = { 1, 4, 5, 3, 8, 5, 3, 6, 8 };

            //foreach (var item in dizi)
            //{
            //    Console.Write(item + " ");

            //}

            //Console.WriteLine();
            ////---------------------------------Array Sort------------------------

            //Array.Sort(dizi);
            //Console.WriteLine("Array.Sort edildikten sonra");
            //foreach (var item in dizi)
            //{
            //    Console.Write(item + " ");

            //}

            ////---------------------------Array Reverse---------------------- diziyi tersten yazar
            //Console.WriteLine();

            //Array.Reverse(dizi);
            //Console.WriteLine("Array.Reverse edildikten sonra");
            //foreach (var item in dizi)
            //{
            //    Console.Write(item + " ");

            //}

            ////-------------------------Array Contains----------------------- dizideki degerin olup olmadıgı (true/false)
            //Console.WriteLine();

            //bool varmi = dizi.Contains(3);
            //if (varmi)
            //{

            //    Console.WriteLine("Dizideki aradiginiz deger:{0}", varmi);

            //}

            // //----------------------------İndex of------------------- aradıgın deger hangi index de oldugu


            // // (örnegin 3 ün hangi indexde oldugunu verir)

            //int index= Array.IndexOf(dizi, 3);

            // Console.WriteLine(index);

            // //2.yol

            // Console.WriteLine(Array.IndexOf(dizi,3));

            // //----------------------------
            // //İndex of (örnegin 5 ten sonrasına bakıp 3 ün hangi indexde oldugunu verir)

            // int index2 = Array.IndexOf(dizi, 3,5);

            // Console.WriteLine(index2);

            // //------------------------------Lasindex of----------------


            // //Array.LasIndexOf()

            // Console.WriteLine("Array.LasIndexOf(dizi,3) edildikten sonra");
            // int index3 = Array.LastIndexOf(dizi, 3);
            // Console.WriteLine(index3);

            // //---------------------------------------------


            // //Array boyutlandırma

            // Array.Resize(ref dizi, 20);
            // foreach (var item in dizi)
            // {
            //     Console.Write(item + " ");
            // }


            // //-----------------------------------------------

            // //istedigim degere gelip yeni diziyi o boyutta bitir
            // int[] dizi2 = Array.FindAll(dizi, I => I == 3);



            //**********************************************************************************************************
            //******************************************ODEV******************************************

            //string[] dizi = new string[5];

            //string cikis = "";
            //do
            //{
            //    bas:
            //    Console.Clear();
            //    Console.WriteLine("Yapmak istediginiz islemi secin");
            //    Console.WriteLine("1.Kullanici Ekle \n2.Kullanici Sil \n3.Kullanici Guncelle \n4.Listele \n5.Cikis");
            //    Console.WriteLine("----------------------------------------");
            //    string islem = Console.ReadLine();


            //    switch (islem)
            //    {
            //        #region kullanici ekle
            //        case "1":
            //            string son = "";

            //            do
            //            {
            //                Console.Clear();
            //                Console.WriteLine("Kullanici ekrani \n------------------------------------");
            //                Console.Write("Kullanici adi=");
            //                string ad = Console.ReadLine();

            //                bool varmi = dizi.Contains(ad);

            //                if (varmi)
            //                {
            //                    Console.WriteLine("Boyle bir kullanici var,tekrar deneyin");
            //                }
            //                else
            //                {
            //                    for (int i = 0; i <= dizi.Length; i++)
            //                    {
            //                        if (i == dizi.Length)
            //                        {
            //                            Console.WriteLine("Kullanici dolu"); goto bas;
            //                        }
            //                        else if (dizi[i] == null)
            //                        {
            //                            dizi[i] = ad;
            //                            Console.WriteLine("Kullanici girisi basarili"); break;
            //                        }

            //                    }
            //                }
            //                Console.Write("devam etmek istiyor musun(e/h)=");
            //                son = Console.ReadLine();

            //            } while (son == "e");
            //            break;
            //        #endregion


            //        #region kullanici sil
            //        case "2":

            //            string son2 = "";
            //            do
            //            {
            //                Console.Write("Silmek istediginiz kullanici=");
            //            string sil = Console.ReadLine();

            //            bool varmi2 = dizi.Contains(sil);

            //            if (varmi2)
            //            {
            //                for (int k = 0; k < dizi.Length; k++)
            //                {
            //                    if (dizi[k] == sil)
            //                    {
            //                        dizi[k] = null;
            //                    }

            //                }
            //            }

            //            else
            //            {
            //                Console.WriteLine("Boyle bir kullanici yok");

            //            }
            //                Console.Write("devam etmek istiyor musun(e/h)=");
            //                son2 = Console.ReadLine();

            //            } while (son2 == "e");

            //            break;
            //        #endregion

            //        #region kullanici guncelle
            //        case "3":
            //            Console.Write("Guncellemek istediginiz kullanici=");
            //            string guncel = Console.ReadLine();
            //            Console.Write("Yeni kullanici adi=");
            //            string yeniad = Console.ReadLine();

            //            for (int j = 0; j < dizi.Length; j++)
            //            {
            //                if (dizi[j] == guncel)
            //                {
            //                    dizi[j] = yeniad;
            //                }

            //            }


            //            break;
            //        #endregion

            //        #region liste
            //        case "4":


            //            foreach (var item in dizi)
            //            {
            //                Console.Write(item + " ");

            //            }

            //            Thread.Sleep(5000);

            //            break;
            //        #endregion


            //        #region cikis
            //        case "5":
            //            Console.Write("cikis istiyor musunuz?(e/h)=");
            //            cikis = Console.ReadLine();

            //            break;
            //            #endregion
            //    }

            //} while (cikis != "e");


        }
    }
}
