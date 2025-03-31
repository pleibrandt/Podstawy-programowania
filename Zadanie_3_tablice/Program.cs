using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3_tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, pom;
            int[] tab = new int[1000];
            Console.Write("Ile liczb wpisac: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i<n; i++)
            {
                for(int j=1; j<n; j++)
                {
                    if (tab[j] < tab[j - 1])
                    {
                        pom = tab[j - 1];
                        tab[j - 1] = tab[j];
                        tab[j] = pom;
                    }
                }
            }
            Console.WriteLine("Posortowane elementy tablicy: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}, ", tab[i]);
            }
            Console.ReadKey(true);
        }
    }
}
