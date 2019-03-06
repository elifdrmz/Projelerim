using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace metot_hesap_makinesi_elif_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("islemi giriniz :  ");

            string formul = Console.ReadLine();



            ArrayList liste = listeyeat(formul);

            ArrayList listeyeni = yenilisteyap(liste);

            Console.WriteLine("sonuc : {0}", islemsonuc(liste));

        }

        static ArrayList listeyeat(string formul)
        {
            char[] dizi = formul.ToCharArray();

            ArrayList liste = new ArrayList();


            string sayac = "";
            string sayac2 = "";

            for (int i = 0; i < dizi.Length; i++)
            {

                if (dizi[i] >= '0' && dizi[i] <= '9' || dizi[i] == '.')
                {
                    sayac = sayac + dizi[i];

                    if (!(dizi[i + 1] >= '0' && dizi[i + 1] <= '9') && !(dizi[i + 1] == '.'))
                    {

                        liste.Add(sayac);
                        sayac = "";
                    }
                }


                if (dizi[i] == '(' || dizi[i] == ')' || dizi[i] == '+' || dizi[i] == '-' || dizi[i] == '*' || dizi[i] == '/')
                {
                    sayac2 = sayac2 + dizi[i];
                    liste.Add(sayac2);
                    sayac2 = "";
                }

            }


            return liste;

        }


        static ArrayList yenilisteyap(ArrayList liste)
        {
            int ilkparantez = 0;
            int sonparantez = 0;
            for (int i = 0; i < liste.Count; i++)
            {
                if ((string)liste[i] == ")")
                {
                    sonparantez = i;

                    for (int k = sonparantez; k > 0; k--)
                    {
                        if ((string)liste[k] == "(")
                        {
                            ilkparantez = k;

                            int listeuzunluk = ((sonparantez + 1) - ilkparantez);
                            ArrayList liste2 = new ArrayList();
                            for (int j = ilkparantez; j <= sonparantez; j++)
                            {
                                liste2.Add(liste[j]);
                            }

                            liste.RemoveRange(ilkparantez, listeuzunluk);

                            liste.Insert(ilkparantez, islemsonuc(liste2));

                        }
                    }

                }
            }

            return liste;
        }


        static string islemsonuc(ArrayList listex)
        {

            listex.Remove("(");
            listex.Remove(")");

            //s degeri string yapmak için yazdım
            string s = "";
            string sonuc = "";
            double deger = 0;
            int sayac = (listex.Count - 1) / 2;

            for (int i = 1; i < listex.Count; i++)
            {
                string islem = listex[i] as string;
                if (islem == "/")
                {
                    string a = listex[i - 1] as string;
                    double a1 = double.Parse(a);
                    string b = listex[i + 1] as string;
                    double b1 = double.Parse(b);
                    deger = a1 / b1;
                    s = deger + "";
                    listex.RemoveRange(i - 1, 3);
                    listex.Insert(i - 1, s);

                    i = 0;
                    sayac--;
                }

            }
            for (int k = 1; k < listex.Count; k++)
            {
                string islem = listex[k] as string;
                if (islem == "*")
                {
                    string a = listex[k - 1] as string;
                    double a1 = double.Parse(a);
                    string b = listex[k + 1] as string;
                    double b1 = double.Parse(b);
                    deger = a1 * b1;
                    s = deger + "";
                    listex.RemoveRange(k - 1, 3);
                    listex.Insert(k - 1, s);

                    k = 0;
                    sayac--;
                }

            }

            for (int l = 1; l < listex.Count; l++)
            {
                string islem = listex[l] as string;
                if (islem == "-")
                {
                    string a = listex[l - 1] as string;
                    double a1 = double.Parse(a);
                    string b = listex[l + 1] as string;
                    double b1 = double.Parse(b);
                    deger = a1 - b1;
                    s = deger + "";
                    listex.RemoveRange(l - 1, 3);
                    listex.Insert(l - 1, s);

                    l = 0;
                    sayac--;
                }

            }

            for (int j = 1; j < listex.Count; j++)
            {
                string islem = listex[j] as string;
                if (islem == "+")
                {
                    string a = listex[j - 1] as string;
                    double a1 = double.Parse(a);
                    string b = listex[j + 1] as string;
                    double b1 = double.Parse(b);
                    deger = a1 + b1;
                    s = deger + "";
                    listex.RemoveRange(j - 1, 3);
                    listex.Insert(j - 1, s);

                    j = 0;
                    sayac--;
                }

            }

            if (sayac == 0)
            {
                sonuc = s + "";
            }

            return sonuc;
        }
    
    }
}
