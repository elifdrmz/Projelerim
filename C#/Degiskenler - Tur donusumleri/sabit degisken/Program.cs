using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_12_19_sabit_degisken
{
    class Program
    {
     
        static void Main(string[] args)
        {
     
            {
                const int a = 5;
                const string b = "deneme";

                // a = 7; hata verir cünkü const ile a degiskenini sabit olarak atadık.
            }

            {
                // burda islemler icin hepsi const oldugundan sabit degerler cıkar ve hata vermez.
                const int a = 5;
                const int b = a + 7;
                const int c = a * b;

            }

            {
                // int a = 5; 
                //const int b = a + 8;
                // burdaki a degeri const olarak tanımlamadıgımız icin degisebilecegi düsündügü icin hata verir.
            }


        }
    }
}
