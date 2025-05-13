using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_8_tablice_wlasne
{
    class Program
    {
        static void Sort(int[] tab)
        {
            int n = tab.Length;

            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (tab[j] > tab[j + 1])
                    {
                        int pom = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = pom;
                    }
        }
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Podaj ile bedzie wczytanych liczb z zakresu od 1 do 1000: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 1 || n > 1000);
            int[] tab = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Liczba {0}= ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            Sort(tab);
            for(int i=0; i<n; i++)
            {
                if (tab[i] % 2 == 0)
                    Console.WriteLine("{0}", tab[i]);
            }
            Console.ReadKey(true);
        }
    }
}
