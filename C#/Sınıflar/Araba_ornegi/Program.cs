using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araba_ornegi
{
    class Program
    {
        static void Main(string[] args)
        {
            Marka marka = new Marka();
            Tofas tofas = new Tofas();
            Wolswogen wolswogen = new Wolswogen();
            Audi audi = new Audi();

            Console.WriteLine("---------Araba Markalari---------");
            marka.MarkaGoster();
            
            Console.Write("sectiginiz markanin ID numarasini giriniz : ");
            int secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    tofas.TofasGoster();break;

                case 2:
                    audi.AudiGoster(); break;

                case 3:
                    wolswogen.WolswogenGoster(); break;
            }

        }


    }
}
