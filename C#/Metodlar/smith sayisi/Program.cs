using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace smith_sayisi
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi = 728;

            //1- sayının rakamları toplamı
            int sayirakamlaritoplami = rakamlaritopla(sayi);


            //2-asal bolenleri listele

            ArrayList liste = asallistegetir(sayi);

            //2- asal liste bolenlerin toplamı

            int asaltoplam = asaltoplamgetir (liste);


            Console.WriteLine((asaltoplam == sayirakamlaritoplami) ? "sayi asaldir" : "sayi asal degildir");




        }

        static int rakamlaritopla(int sayi)
        {
            int toplam = 0;
            do
            {
                int kalan = sayi % 10;
                toplam = toplam + kalan;
                sayi = sayi / 10;

            } while (sayi >= 1);

            return (toplam);

        }


        static bool asalkontrolet(int bolen)
        {
            bool isPrime = true;
            if (bolen > 1)
            {
                for (int k = 2; k <= bolen / 2; k++)
                {
                    if (bolen % k == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                return isPrime;
            }
            else
            {
                return isPrime;
            }
        }


        static ArrayList asallistegetir(int sayi)
        {
            ArrayList liste = new ArrayList();
            for (int i = 2; i <= sayi; i++)
            {
                if (asalkontrolet(i))
                {
                    if (sayi % i == 0)
                    {
                        sayi = sayi / i;
                        liste.Add(i);
                        i--;
                    }
                }
            }
            return liste;
        }

        static int asaltoplamgetir(ArrayList liste)
        {
            int asaltoplam = 0;
            foreach (var item in liste)
            {
                asaltoplam = asaltoplam + rakamlaritopla((int)item);
            }
            return asaltoplam;
        }




       
    }
}










