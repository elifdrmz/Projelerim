using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_12_18_ondaliklisayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ondalikli Sayilar");

            //Float tanımlama (32bit - 4bayte - işaretli - 7 digit)
            // float sayi_float = 12.4; f olarak tanımlamadığım için double olarak varsaydı. Hata verdi

            float sayi_float = 12.4f;
            Console.WriteLine($"Float sayi_Float:{sayi_float}");

            float sayi2_float = 12.123456789f;
            Console.WriteLine($"Float sayi_float:{sayi2_float}");

            // float sayi4_float = 12; burda f yazmasak bile 12 yi int olarak aldığından tür dönüşümüne müsait olduğundan hata vermez

            float sayi3_float = 1234567.8f;
            Console.WriteLine($"Float sayi_float:{sayi3_float}");

            //--------------------------------------------------------------------------------------


            // Double tanımlama (64bit - 8bayte - işaretli - 15-16 duyarlılık)

            double sayi_double = 12.3;
            //double sayi1_double = 12.3d;  burada ister d yazma ister yazma hata vermez otomatik olarak double alacaktır.

            double sayi2_double = 12.12345678912345;
            Console.WriteLine($"double sayi_double:{sayi2_double}");

             






        }
    }
}
