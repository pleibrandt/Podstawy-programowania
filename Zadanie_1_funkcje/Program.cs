using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1_funkcje
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Podaj a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Suma wynosi: {0}",suma(a,b));
        }

        static int suma(int a, int b)
        {
            return a + b;
        }
    }
}
