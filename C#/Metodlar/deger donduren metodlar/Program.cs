using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deger_donduren_metodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            ////soru1== iki sayının toplamını veren?

            //int sayi1 = 10;
            //int sayi2 = 5;

            //int toplam = topla(sayi1, sayi2);

            //Console.WriteLine("{0} + {1} + {2}", sayi1, sayi2, toplam);


            //*************************************************************
            ////saru2==asalsa true, degilse false donduren?

            //Console.Write("sayi giriniz : ");
            //int sayi = int.Parse(Console.ReadLine());

            //bool sonuc= asalkontrolet(sayi);


            //Console.WriteLine(sonuc);

            //************************************************************

            //soru3:10 elemanlı bir dizi içerisine atayan sayiuret() isimli bir metot yazınız.
            //      dizinin elemanlarını ekrana yazdıran diziyazdir() isimli bir metot daha yazarak elemanları ekrana yazdırınız.
            //      daha sonra bu dizi içerisindeki en büyük sayı degerini bulan enbuyukbul() isimli, en küçük degeri bulan enkucuk() isimli iki metot daha yazınız.
            //enbuyuk ve enkucuk metotlarından dönen sayıları ekrana yazdıran program kodlarını yazınız?

            //Console.WriteLine("Hangi degerler arasında sayi uretmek istiyorsun");
            //Console.Write("deger1 : ");
            //int deger1 = int.Parse(Console.ReadLine());
            //Console.Write("deger2 : ");
            //int deger2 = int.Parse(Console.ReadLine());


            //int[] dizi = sayiuret(deger1, deger2);


            //diziyazdir(dizi);

            //int enbuyuk = enbuyukbul(dizi);
            //int enkucuk = enkucukbul(dizi);

            //Console.WriteLine(enbuyuk);

            //Console.WriteLine(enkucuk);



        }

        //soru3:

        static int[] sayiuret(int deger1, int deger2)
        {
            Random r = new Random();
            int[] dizi = new int[10];
            for (int i = 0; i < 10; i++)
            {

                dizi[i] = r.Next(deger1, deger2);


            }

            return dizi;
        }

        static void diziyazdir(int[] dizi)
        {
            foreach (var item in dizi)
            {
                Console.Write(item + " ");
            }

        }

        static int enbuyukbul(int[] dizi)
        {
            Array.Sort(dizi);
            Array.Reverse(dizi);
            return dizi[0];
        }

        static int enkucukbul(int[] dizi)
        {
            Array.Sort(dizi);
            return dizi[0];
        }


        //************************************************************

        //saru2:
        static bool asalkontrolet(int sayi)

        {

            bool isPrime = true;
            if (sayi > 1)
            {


                for (int i = 2; i <= sayi / 2; i++)
                {
                    if (sayi % i == 0)
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

        //***********************************************************************


        //soru1:

        static int topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }







    
}
}
