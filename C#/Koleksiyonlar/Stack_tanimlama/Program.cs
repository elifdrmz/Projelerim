using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stack_tanimlama
{
    class Program
    {
        static void Main(string[] args)
        {

            ////-----------------------------Stack(Yigin) tanımlama------------------------------------

            ////------------push--------------------------atma
            //Stack yigin = new Stack();
            //yigin.Push(1);
            //yigin.Push(2);
            //yigin.Push(3);
            //yigin.Push(4);


            ////----------pop------------------------------çekme

            ////en son atılan degeri ilk alır
            //yigin.Pop();
            //yigin.Pop();

            ////-------------peek-----------------------------çıkmayı bekleyen degeri gösterir,

            //Console.WriteLine(yigin.Peek());


            ////-------------foreach-------------------ekrana yazma

            //foreach (var item in yigin)
            //{
            //    Console.WriteLine(item);
            //}

            ////--------------ToArray-------------------- Array etma

            //object[] dizi = yigin.ToArray();

            ////---------------clone----------------------kopyalama

            //object clone = yigin.Clone();
            //Stack yeniyigin = (Stack)clone;

            ////---------------contains-----------------içinde varmi?

            //bool iss = yigin.Contains(1);


            ////*************************************************************************
            //// stack içindeki degerleri tersten yazdırma?


            //Stack yiginx = new Stack();

            //int sayi;
            //do
            //{
            //Console.Write("sayi giriniz :");
            //sayi = int.Parse(Console.ReadLine());
            //    if (sayi!=0)
            //    {
            //        yiginx.Push(sayi);
            //    }


            //} while (sayi!=0);

            //foreach (var item in yiginx)
            //{
            //    Console.Write(item+" ");
            //}


            ////***pop yaptikca count degistigi icin problem yasanıyor, o yüzden yiginx.count u bir yere atayıp for icine o yazılmali.

            //for (int i = 0; i < yiginx.Count; i++)
            //{
            //    Console.Write(yiginx.Pop());
            //}


        //************************************************************

        //// parantez kullanim hatasi bulma?

        //string yazi = "((((1+2)+(4*8)+9";

        //    Stack yiginy = new Stack();

        //    int sayac = 0;
        //    int sayac2 = 0;

        //    for (int i = 0; i < yazi.Length; i++)
        //    {
        //        if (yazi.Substring(i,1)=="("|| yazi.Substring(i, 1) == ")")
        //        {
        //            yiginy.Push(yazi.Substring(i, 1));
        //        }
                
        //    }

        //    int uzunluk = yiginy.Count;
        //    for (int i = 0; i < uzunluk; i++)
        //    {
        //        if ((string)yiginy.Peek() == "(")
        //        {
        //            sayac++;
        //            yiginy.Pop();
        //        }
        //        else if ((string)yiginy.Peek() == ")")
        //        {
        //            sayac2++;
        //            yiginy.Pop();
        //        }

        //    }

        //    if (sayac == sayac2)
        //    {
        //        Console.WriteLine("parantez kullanimi dogru");
        //    }
            
        //    else if (sayac>sayac2)
        //    {
        //        int adet = sayac - sayac2;
        //        Console.WriteLine("parantez kullanimi hatali, {0} (  eksik", adet);

        //    }

        //    else
        //    {
        //        int adet2 = sayac2 - sayac;
        //        Console.WriteLine("parantez kullanimi hatali, {0} )  eksik", adet2);
                
        //    }


            

        }
    }
}
