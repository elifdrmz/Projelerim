using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_12_19_operatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            //+ operatorü
            int x = 5;
            int y = 6;
            int z = x + y;

            //- operatorü
            z = z - 1;

            // /operatorü

            int t = z / y;

            //Console.WriteLine("{2}/{1}:{0}",t,y,z);

            //-------------------------------------------------


            //t = z / 0;
            //Console.WriteLine("int{1}/int{0}", t, z);

            //------------------------------------------------


            //ondalıklı sayıya bölme
            //double v;
            //v = z / 2.7;

            //Console.WriteLine("int{1}/double2.7:{0}", v, z);

            //------------------------------------------------

            //kıyas operatoru örnek:

            int a = 0;
            int b = 4;
            int c =a>b?1:2;


            Console.WriteLine(a >= 0 ? "dogru" : "yanlıs");

            Console.WriteLine(c);

            Console.WriteLine(a >= 0 ? a==0? "sıfır" : "pozitif":"negatif");
        }
    }
}
