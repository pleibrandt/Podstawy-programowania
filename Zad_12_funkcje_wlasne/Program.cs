using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_12_funkcje_wlasne
{
    class Program
    {
        static int dec_to_oct(int n)
        {
            int m = n, a=0;
            int liczba = 0, dzies = 1;
            while (m >= 1)
            {
                m = m / 8;
                a++;
            }
            int[] tab = new int[a];
            int j = 0;
            while (n >= 1)
            {
                tab[j] = n % 8;
                n = n / 8;
                j++;
            }
            for (int i = 0; i <a; i++)
            {
                liczba = liczba + tab[i] * dzies;
                dzies = dzies * 10;
            }
            return liczba;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Podaj liczbe: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", dec_to_oct(n));
            Console.ReadKey(true);
        }
    }
}
