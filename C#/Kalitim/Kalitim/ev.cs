using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    class ev
    {

        public string ilce { get; set; }
        public double alan { get; set; }
        public string adres { get; set; }
        public int odasayisi { get; set; }
        public string isinma { get; set; }

        public void evgelsin()
        {
            Console.Write("İlçe : "); ilce = Console.ReadLine();
            Console.Write("Alan : "); alan = double.Parse(Console.ReadLine());
            Console.Write("Adres : "); adres = Console.ReadLine();
            Console.Write("Oda Sayısı : "); odasayisi = int.Parse(Console.ReadLine());
            Console.Write("Isınma : "); isinma = Console.ReadLine();


        }

    }
}
