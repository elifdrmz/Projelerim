using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._12._2018
{
    class Program
    {
        static void Main(string[] args)
        {


            ////polindrom sayi bulma?

            //Console.WriteLine("yazı giriniz");
            //string duz = Console.ReadLine();

            //int uzunluk = duz.Length;
            //string duzalt = duz.Substring(0,duz);

            //string ters = "";
            //for (int i = duz.Length - 1; i >= 0; i--);
            //{
            //    ters = ters + duz.Substring(i,1);
            //}

            //if(duz==ters)
            //{
            //    Console.WriteLine("polidrom sayi");

            //}

            //else
            //{
            //    Console.WriteLine("polidrom sayi degil");
            //}



            ////polindron ornek 

            //string metin = "kabak";
            //bool ispolindrom = true;

            //for (int i = 0, j = metin.Length - 1; i < j; i++, j--) ;
            //{
            //    if(metin.Substring(i,1)==metin.Substring(j,1))
            //    {
            //        continue;
            //    }
            //    ispolidrom = false;
            //    break;
            //}

            //Console.WriteLine($"{metin}:{ispolindrom}");


            //revize et hatalar var?

            //*************************************************************************


            //// klavyeden rakamları farklı 3 basamakli pozitif sayı girip girilmedigini kontrolunun yapilmasi?


            //Console.Write("sayi giriniz=");
            //string sayi = (Console.ReadLine());



            //if (sayi.Substring(0, 1) == "-")
            //{
            //    Console.WriteLine("sayi negatif olamaz");
            //}


            //else
            //{
            //    int index = 0;

            //    for (int i = 0; i < sayi.Length; i++)
            //    {
            //        if (sayi.Substring(i, 1) == "0")
            //        {
            //            continue;
            //        }

            //        index = i;
            //        break;
            //    }

            //    string asilSayi = sayi.Substring(index);


            //    //---asıl sayıyı bulduk yukarıda şimdi işleme devam-----

            //    if (asilSayi.Length == 3)
            //    {
            //        bool isDiffrent = true;

            //        for (int i = 0; i < asilSayi.Length; i++)
            //        {

            //            for (int k = i + 1; k < asilSayi.Length; k++)
            //            {
            //                if (asilSayi.Substring(i, 1) == asilSayi.Substring(k, 1))
            //                {
            //                    isDiffrent = false;
            //                    break;
            //                }
            //            }

            //            if (!isDiffrent)
            //            {
            //                break;
            //            }

            //        }

            //        Console.WriteLine($"sayinin basamaklari farkli mi?    { isDiffrent}");

            //    }
            //    else
            //    {
            //        Console.WriteLine("3 basamakli sayigiriniz.");
            //    }


            //}



           
            







        }
    }
}
