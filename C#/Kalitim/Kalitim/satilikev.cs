using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Kalitim
{
    class satilikev :ev
    {
        public int fiyat { get; set; }
        public string tel { get; set; }

        public void satilikgelsin()
        {

            Console.Write("Fiyat : "); fiyat = int.Parse(Console.ReadLine());
            Console.Write("Tel : "); tel = Console.ReadLine();
        }

    }
}
