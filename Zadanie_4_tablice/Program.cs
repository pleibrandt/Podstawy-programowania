using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4_tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum=0;
            int[] tab = new int[1000];
            Console.Write("Ile liczb wpisac: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                sum = sum + tab[i];
            }
            Console.WriteLine("Suma elementów tablicy wynosi: {0}",sum);
            Console.ReadKey(true);
        }
    }
}
