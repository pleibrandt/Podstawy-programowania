using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k,a=0,b=0;
            Console.Write("Podaj n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj k: ");
            k = Convert.ToInt32(Console.ReadLine());

            while(a<n)
            {
                while (b < k)
                {
                    Console.Write("*");
                    b++;
                }
                Console.WriteLine("");
                a++;
                b = 0;
            }
            Console.ReadKey(true);
        }
    }
}
