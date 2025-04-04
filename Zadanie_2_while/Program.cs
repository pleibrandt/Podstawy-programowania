using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,a=1;
            Console.WriteLine("Podaj n: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (a <= n)
            {
                Console.WriteLine("a({0})={1}",a,2*a-1);
                a++;
            }
            Console.ReadKey(true);
        }
    }
}
