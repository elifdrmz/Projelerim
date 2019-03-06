using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_
{
    class Program
    {
        static void Main(string[] args)
        {

            //// kütüphanede açık olmayanlar icin 

            ////System.Collections.Hashtable;

            ////**********************************HashTable Tanimlama*************************************

            ////--------------------count--------------------------

            //Hashtable htable = new Hashtable();
            //Console.WriteLine($"count :{htable.Count}");

            ////--------ekleme----------

            //htable.Add(1, "bir");
            //htable.Add(2, "iki");
            //htable.Add(3, "uc");
            //htable.Add(4, "dort");
            //htable.Add("bes", 5);

            ////ekrana yazdirma

            //foreach (DictionaryEntry item in htable)
            //{

            //    //Console.WriteLine(item.GetType());
            //    //ekrana yazan şey (DictionaryEntry) ==> yukaridaki var yerine yazariz.

            //    Console.WriteLine(item.Key + "          " + item.Value);
            //}

            ////2.yol------------------
            //foreach (var item in htable)
            //{

            //    Console.WriteLine(((DictionaryEntry)item).Key + "            " + ((DictionaryEntry)item).Value);
            //}


            ////-------------------------silme islemi----------------------------

            //htable.Remove("bes");

            ////bes sildikten sonra

            //Console.WriteLine("bes sildikten sonra");

            //foreach (DictionaryEntry item in htable)
            //{

            //    Console.WriteLine(item.Key + "          " + item.Value);
            //}


            ////if de true false kontrolu -- key de arama

            //Console.WriteLine("Key: if de true false kontrolu orn 3 degeri varmi");
            //if (htable.ContainsKey(3))
            //{
            //    Console.WriteLine("3 degeri");
            //}
            //else
            //{
            //    Console.WriteLine("3 degeri");
            //}


            ////if de true false kontrolu -- value de arama

            //Console.WriteLine("Value: if de true false kontrolu orn iki degeri varmi");
            //if (htable.ContainsKey("iki"))
            //{
            //    Console.WriteLine("iki degeri");
            //}
            //else
            //{
            //    Console.WriteLine("iki degeri");
            //}

            ////-------------------------------copyTo-------------------

            //// htable array e atma işlemi
            ////Keys:
            //var array = new object[10];
            //htable.Keys.CopyTo(array, 0);

            //foreach (var item in htable.Keys)
            //{
            //    Console.WriteLine(item);
            //}
            ////Values:
            //var array2 = new object[10];
            //htable.Values.CopyTo(array2, 0);

            //foreach (var item in htable.Values)
            //{
            //    Console.WriteLine(item);
            //}

            ////*****************************************************************
            ////ingilizce sozluk?

            //Hashtable sozluk = new Hashtable()

            //{
            //{"yarın", "tomorrow"},
            //{"bugün", "today"},
            //{"hava", "weather"},
            //{"gökyüzü", "sky"},
            //{"karlı", "snowy"},
            //{"güneşli", "sunny"},
            //{"bulutlu", "cloudy"},
            //{"açık", "unclouded"},
            //{"kapalı", "skyless"},
            //};

            //Console.Write("cevirmek istediğin cümleyi gir  : ");
            //string cumle = Console.ReadLine();
            //string[] kelimeler = cumle.Split(' ');
            //string ceviri = "";


            //foreach (string kelime in kelimeler)
            //{
            //    bool isTranslated = false;

            //    foreach (DictionaryEntry item in sozluk)
            //    {
            //        if (kelime == item.Key.ToString())
            //        {
            //            ceviri = ceviri + " " + item.Value;
            //            isTranslated = true;
            //        }


            //    }

            //    if (!isTranslated)
            //    {
            //        ceviri = ceviri + "****";
            //    }


            //}

            //Console.WriteLine(ceviri);


        }
    }
}
