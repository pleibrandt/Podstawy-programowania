using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1_reku
{
    class Program
    {
        static int silnia(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * silnia(n - 1);
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Podaj liczbe do silni: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Silnia wynosi: {0}",silnia(n));
            Console.ReadKey(true);


        }
    }
}
