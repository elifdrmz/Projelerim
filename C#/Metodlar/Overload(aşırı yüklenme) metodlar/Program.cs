using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_aşırı_yüklenme__metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //ornek-1
            int toplam = topla(1, 2); //=> 1 e gider

            //**************************
            //ornek-2
            byte a = 1;
            byte b = 2;

            int toplam2 = topla(a, b);

            //**************************

            //ornek-3
            //string substring metodunu kendimiz yazalim?

            //1-
            string metin = "deneme";
            int index = 0;
            string metin1 = substring(metin, index);

            //ekran : metin2 = deneme (index e 0 verdigimiz için, o index den baslayıp metnin sonuna kadar yazar)

            //2-
            string metin2 = "deneme";
            int index2 = 0;
            int length2 = 2;
            string metin3 = substring(metin2, index2, length2);
            //ekran : metin2 = deneme (index e 0 verdigimiz için, o index den baslayıp istenen lenght e kadar yazar)

            //**************************


        }

        //ornek-1
        //1-
        static int topla(int x, int y)
        {
            return x + y;

        }

        //2-
        static int topla(int x, int y, int z = 3)
        {
            return x + y + z;

        }
        //*************************

        //ornek-2
        static int topla(byte a, byte b)
        {
            return a + b;

        }

        //******************************

        //ornek-3
        //1-
        static string substring(string metin, int index)
        {
            string s = "";
            for (int i = index; i < metin.Length; i++)
            {
                s = s + metin[i];
            }
            return s;

        }

        //2-
        static string substring(string metin2, int index2, int lenght2)
        {
            string s2 = "";
            for (int i = index2; i < index2 + lenght2; i++)
            {
                s2 = s2 + metin2[i];
            }
            return s2;

        }

        //************************************************



    }
}
