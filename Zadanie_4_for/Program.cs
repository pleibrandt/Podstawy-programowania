using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            Console.WriteLine("Podaj dwie liczby naturalne: ");
            n = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadKey(true);
        }
    }
}
