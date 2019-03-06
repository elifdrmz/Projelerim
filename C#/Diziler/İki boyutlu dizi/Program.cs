using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İki_boyutlu_dizi
{
    class Program
    {
        static void Main(string[] args)
        {
            //matrisi ekrena yazdıran kod
            #region MatrisYazdırma
            int[,] dizi = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(1); j++)
                {
                    Console.Write(dizi[i, j] + " ");
                }
                Console.WriteLine();
            }
            int sayac = 0;
            foreach (var item in dizi)
            {
                sayac++;
                Console.Write(item + " ");
                if (sayac % dizi.GetLength(1) == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("----------------");
            #endregion
            //-----------------------------
            //iki matrisi toplayan kod
            #region MatrisToplamları
            int[,] matris1 = { { 0, 1, 2 }, { 2, 1, 3 } };
            int[,] matris2 = { { 4, 1, 5 }, { 0, 2, 3 } };
            int[,] toplamMatris = new int[matris1.GetLength(0), matris1.GetLength(1)];

            for (int i = 0; i < toplamMatris.GetLength(0); i++)
            {
                for (int j = 0; j < toplamMatris.GetLength(1); j++)
                {
                    toplamMatris[i, j] = matris1[i, j] + matris2[i, j];
                }
            }
            sayac = 0;
            Console.WriteLine("Matrisler Toplamı");
            Console.WriteLine("--------------------------");
            foreach (var item in toplamMatris)
            {
                sayac++;
                Console.Write(item + " ");
                if (sayac % toplamMatris.GetLength(1) == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Matrisler Toplamı For ile");
            Console.WriteLine("--------------------------");
            for (int i = 0; i < toplamMatris.GetLength(0); i++)
            {
                for (int j = 0; j < toplamMatris.GetLength(1); j++)
                {
                    toplamMatris[i, j] = matris1[i, j] + matris2[i, j];
                    Console.Write(toplamMatris[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endregion
            //-----------------------------




        }
    }
}
