using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opsiyonel_parametreli_metodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            // ornek-1
            //1.durum
            int toplam1 = topla(2, 3, 4);
            // (2+3+4) ekran = toplam = 9 

            //2.durum
            int toplam2 = topla(2);
            // (2+0+0) ekran = toplam = 2 
            //burdaki sıfırlar asagıda atanandan gelir.

            //3.durum
            //named argument  y'i atlayıp z'ye deger ataması yapılır
            int toplam3 = topla(1, z: 5);
            //karısık sıra halindede yazılabilir
            int toplam4 = topla(z: 1, y: 5, x: 4);

            //************************************************
            // ornek-2
            //named argument   (okunabilirlik)
            string productName = "";
            namedArgument(productName, isValid: true, isPrime: false, isOdd: true);

            //**************************************************



        }


        //********************************************************
        // ornek-2
        static void namedArgument(string productName, bool isValid, bool isPrime, bool isOdd)
        {

        }

        //********************************************
        // ornek-1

        //burda x,y,z ye deger vermesende yukarıdaki topla parantezindeki degerleri yeni deger olarak alır.

        static int topla(int x, int y = 0, int z = 0)
        {
            int toplam = x + y + z;
            return toplam;
        }



    }
}
