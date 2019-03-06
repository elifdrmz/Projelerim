using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._01._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            armchair armchair = new armchair();
            Console.Write("Kanepe rengi : ");
            armchair.vs_Colour = Console.ReadLine();
            Console.Write("Kanepe kumaşı : ");
            armchair.vs_Fabric = Console.ReadLine();

            table table = new table();
            Console.Write("Masa rengi : ");
            table.vs_Colour = Console.ReadLine();
            Console.Write("Masa malzemesi : ");
            table.vs_Equip = Console.ReadLine();

            armchair.GiveOutput();
            table.GiveOutput();


            Console.ReadKey();

        }
    }
}
