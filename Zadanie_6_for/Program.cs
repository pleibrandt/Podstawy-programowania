using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a=1;
            Console.WriteLine("Podaj liczbe naturalna: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= n - 2 - a/2; j++)
                    Console.Write(" ");
                for (int j = 0; j < a; j++)
                    Console.Write("*");
                a+=2;
                Console.WriteLine("");
            }
            Console.ReadKey(true);
        }
    }
}
