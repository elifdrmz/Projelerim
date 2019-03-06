using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametre_sayisi_belli_olmayan
{
    class Program
    {
        static void Main(string[] args)
        {
            //1---------------
            int toplam = topla(1, 2, 3, 4, 5);

            //2--------------------
            int toplam2 = topla2("merhaba",1, 2, 3, 4, 5);


        }



        //2----string yada başka bir degişken aldırırsak
        static int topla2(string isim,params int[] sayilar)
        {
            int toplam2 = 0;
            foreach (var item in sayilar)
            {
                toplam2 = toplam2+ item;
            }
            return toplam2;
        }

        //1----------
        static int topla(params int[] sayilar)
        {
            int toplam = 0;
            foreach (var item in sayilar)
            {
                toplam = toplam + item;
            }
            return toplam;
        }







    }
}
