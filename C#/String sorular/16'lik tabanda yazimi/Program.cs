using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_lik_tabanda_yazimi
{
    class Program
    {
        static void Main(string[] args)
        {

            //***********************************************************************************


            // girilen sayının 16lık tabandaki degeri?



            Console.Write("sayi girin=");
            int sayi = int.Parse(Console.ReadLine());

            int kalan;
            String s = "";



            do
            {

                kalan = sayi % 16;

                if (kalan > 9)
                {
                    switch (kalan)
                    {
                        case 10:
                            s = s + "A"; break;
                        case 11:
                            s = s + "B"; break;
                        case 12:
                            s = s + "C"; break;
                        case 13:
                            s = s + "D"; break;
                        case 14:
                            s = s + "E"; break;
                        case 15:
                            s = s + "F"; break;
                    }


                }

                else
                {
                    s = s + kalan;
                }

                sayi = sayi / 16;


            } while (sayi != 0);


            //Console.WriteLine("16'lik tabanda degeri:{0}", s);

            // sayımız=12315 16lık tabanda 301B olması lazım. fakat kotumuz bize B103 olarak verdi.Bunu tersine çevirmem gerek




            string ters = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                ters = ters + s.Substring(i, 1);

            }

            Console.WriteLine("16'lik tabanda degeri:{0}", ters);
        }
    }
}
