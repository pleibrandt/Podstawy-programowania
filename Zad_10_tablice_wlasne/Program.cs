using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_10_tablice_wlasne
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Podaj ile bedzie wczytanych liczb z zakresu od 1 do 1000: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 1 || n > 1000);
            double[] tab = new double[n];
            double dod =0, uje = 0, zera=0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Liczba {0}= ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
                if (tab[i] > 0)
                    dod++;
                if (tab[i] < 0)
                    uje++;
                if (tab[i] == 0)
                    zera++;
            }
            Console.WriteLine("Liczba liczb dodatnich: {0}", dod);
            Console.WriteLine("Liczba liczb ujemnych: {0}", uje);
            Console.WriteLine("Liczba zer: {0}", zera);
            Console.ReadKey(true);
        }
    }
}
