using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Kalitim
{
    class kiralikev:ev
    {
        public int fiyat { get; set; }
        public string tel { get; set; }
        public int depozito { get; set; }
        public string sozlesme { get; set; }

        public void kiralikgelsin()
        {
            Console.Write("Fiyat : "); fiyat = int.Parse(Console.ReadLine());
            Console.Write("Tel : ");tel = Console.ReadLine();
            Console.Write("Depozito : "); depozito = int.Parse(Console.ReadLine());
            Console.Write("Sozlesme Tarihi : "); sozlesme = Console.ReadLine();

        }
       



    }
}
