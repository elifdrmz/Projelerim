using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("satilik ev mi? kiralik ev mi?");
            string istek = Console.ReadLine();

            kiralikev kiralikev = new kiralikev();
            satilikev satilikev = new satilikev();
            ev ev = new ev();

            if (istek=="satilik")
            {

                ev.evgelsin();
                satilikev.satilikgelsin();
            


            }
            else if (istek == "kiralik")
            {
                ev.evgelsin();
                kiralikev.kiralikgelsin();


            }




        }
    }
}
