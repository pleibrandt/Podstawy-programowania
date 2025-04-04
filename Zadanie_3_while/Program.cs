using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum=0;
            Console.Write("Podaj a: ");
            a = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Podaj b: ");
                b = Convert.ToInt32(Console.ReadLine());
            } while (b < a);

            while (a <= b)
            {
                sum = sum + a;
                a++;
            }
            Console.WriteLine("Suma elementow wynosi: {0}",sum);
            Console.ReadKey(true);
        }
    }
}
