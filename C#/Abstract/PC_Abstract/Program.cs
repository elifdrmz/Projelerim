using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            armchair achair = new armchair();
            achair.vs_Colour = Console.ReadLine();
            achair.vs_Fabric = Console.ReadLine();

            table table1 = new table();
            table1.vs_Colour = Console.ReadLine();
            table1.vs_Equip = Console.ReadLine();

            achair.GiveOutput();
            table1.GiveOutput();

            Console.ReadKey();
       
        }
    }
}
