using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Abstract
{
    abstract class aclsMobilya
    {
        public string vs_Colour;
        abstract public void GiveOutput();
    }

    class armchair : aclsMobilya
    {
        public string vs_Fabric;
        public override void GiveOutput()
        {
            Console.WriteLine("Kanepemizin Özellikleri");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Kanepe rengi : {0}",vs_Colour);
            Console.WriteLine("Kanepe kumaşı : {0}", vs_Fabric);

        }
    }

    class table : aclsMobilya
    {
        public string vs_Equip;
        public override void GiveOutput()
        {
            Console.WriteLine("Masanın Özellikleri");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Masa rengi : {0}", vs_Colour);
            Console.WriteLine("Masa malzemesi : {0}", vs_Equip);

        }
    }

}
