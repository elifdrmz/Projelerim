using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Hesap_Makinesi___
{
    class Program
    {
        static void Main(string[] args)
        {

        git:
            Console.WriteLine("||...:::'''***### işlemler ###***''':::...||");
            Console.WriteLine("||----------------------------------------||");
            Console.WriteLine("||A. Toplama    || F. Karekök             ||");
            Console.WriteLine("||B. Cıkarma    || G. Açının Sinüs'ü      ||");
            Console.WriteLine("||C. Carpma     || H. Açının Cosinüs'ü    ||");
            Console.WriteLine("||D. Bolme      || I. Açının Tanjant'ı    ||");
            Console.WriteLine("||E. Üs Alma    || J. Açının Cotanjant'ı  ||");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Lütfen yapmak istediginiz işlemin harf kodunu giriniz. ");
            string t = Console.ReadLine();

            if (t.ToUpper() == "A")
            {
                Console.Clear();
                Console.WriteLine("||TOPLAMA ISLEMI||");
                Console.WriteLine("||--------------||");
                Console.WriteLine("Lütfen ilk sayiyi giriniz.");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lütfen 2. sayiyi giriniz.");
                double sayi2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"{sayi1} + {sayi2} = {(sayi1 + sayi2)}");
            }

            else if (t.ToUpper() == "B")
            {
                Console.Clear();
                Console.WriteLine("||CIKARMA ISLEMI||");
                Console.WriteLine("||--------------||");
                Console.WriteLine("Lütfen ilk sayiyi giriniz.");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lütfen 2. sayiyi giriniz.");
                double sayi2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"{sayi1} - {sayi2} = {(sayi1 - sayi2)}");
            }

            else if (t.ToUpper() == "C")
            {
                Console.Clear();
                Console.WriteLine("||CARPMA ISLEMI||");
                Console.WriteLine("||-------------||");
                Console.WriteLine("Lütfen ilk sayiyi giriniz.");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lütfen 2. sayiyi giriniz.");
                double sayi2 = Convert.ToDouble(Console.ReadLine());
                double carpim = sayi1 * sayi2;
                Console.WriteLine($"{sayi1} * {sayi2} = {carpim}");
            }

            else if (t.ToUpper() == "D")
            {
                Console.Clear();
                Console.WriteLine("||BOLME ISLEMI||");
                Console.WriteLine("||------------||");
                Console.WriteLine("Lütfen ilk sayiyi giriniz.");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lütfen 2. sayiyi giriniz.");
                double sayi2 = Convert.ToDouble(Console.ReadLine());
                double bolum = sayi1 / sayi2;
                Console.WriteLine($"{sayi1} / {sayi2} = {bolum}");
            }

            else if (t.ToUpper() == "E")
            {
                Console.Clear();
                Console.WriteLine("||US ALMA ISLEMI||");
                Console.WriteLine("||--------------||");
                Console.WriteLine("Lütfen üssü alıncak sayıyı giriniz.");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lütfen üs kısmındaki sayiyi giriniz.");
                double sayi2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($" {sayi1}^{sayi2} = {Math.Pow(sayi1, sayi2)}");
            }

            else if (t.ToUpper() == "F")
            {
                Console.Clear();
                Console.WriteLine("||KAREKOK ISLEMI||");
                Console.WriteLine("||--------------||");
                Console.WriteLine("Lütfen karekök alınacak sayiyi giriniz.");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{sayi1}^(1/2) = {Math.Sqrt(sayi1)}");
            }

            else if (t.ToUpper() == "G")
            {
                Console.Clear();
                Console.WriteLine("||ACININ SINUS'U||");
                Console.WriteLine("||--------------||");
                Console.WriteLine("Bir açı ölçüsü (derece cinsinden) giriniz.");
                double a = Convert.ToDouble(Console.ReadLine());
                double degree = Math.PI * a / 180.0;
                double deg = Math.Sin(degree);
                Console.WriteLine("Sin{0} = {1}", a, deg);
            }

            else if (t.ToUpper() == "H")
            {
                Console.Clear();
                Console.WriteLine("||ACININ COSINUS'U||");
                Console.WriteLine("||----------------||");
                Console.WriteLine("Bir açı ölçüsü(derece cinsinden) giriniz.");
                double a = Convert.ToDouble(Console.ReadLine());
                double degree = Math.PI * a / 180.0;
                double deg = Math.Cos(degree);

                Console.WriteLine("Cos{0} = {1}", a, deg);
            }

            else if (t.ToUpper() == "I")
            {
                Console.Clear();
                Console.WriteLine("||ACININ TANJANT'I||");
                Console.WriteLine("||----------------||");
                Console.WriteLine("Bir açı ölçüsü(derece cinsinden) giriniz.");
                double a = Convert.ToDouble(Console.ReadLine());
                double degree = Math.PI * a / 180.0;
                double deg = Math.Tan(degree);
                Console.WriteLine("Tan{0} = {1}", a, deg);
            }

            else if (t.ToUpper() == "J")
            {
                Console.Clear();
                Console.WriteLine("||ACININ COTANJANT'I||");
                Console.WriteLine("||------------------||");
                Console.WriteLine("Bir açı ölçüsü(derece cinsinden) giriniz.");
                double a = Convert.ToDouble(Console.ReadLine());
                double degree = Math.PI * a / 180.0;
                double deg = Math.Tan(degree);

                Console.WriteLine("Tan{0} = {1}", a, deg);
            }

            else
            {
                Console.WriteLine("Yanlış Bir Deger girdiniz.");
                Thread.Sleep(1000);
            }

            Console.WriteLine("\nTekrar İşlem yapmak istiyor musunuz? (E/H)");
            string basadon2 = Console.ReadLine();

            if (basadon2.ToUpper() == "E")
            {
                Console.Clear();
                goto git;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sistem kapatılıyor.");
                Thread.Sleep(1000);
                Console.Write("...3...");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Sistem kapatılıyor.");
                Console.Write("...2...");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Sistem kapatılıyor.");
                Console.WriteLine("...1...");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("\nHave A Nice DAY ;)");
                Thread.Sleep(1000);
            }
        }
    }
}
