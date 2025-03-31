using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 0;
            int[] tab = new int[1000];
            Console.Write("Ile liczb wpisac: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elementy tablicy w odwrotnej kolejnosci to: ");
            for (i = n-1; i >= 0; i--)
            {
                Console.Write("{0}, ", tab[i]);
            }
            Console.ReadKey(true);
        }
    }
}
