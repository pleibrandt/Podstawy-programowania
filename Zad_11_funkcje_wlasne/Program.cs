using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_11_funkcje_wlasne
{
    class Program
    {
        static void NWW(int a, int b)
        {
            int a1 = a, b1 = b;
            while (a1 != b1)
            {
                if (a1 > b1)
                    a1 -= b1;
                else
                    b1 -= a1;
            }

            Console.WriteLine("Najmniejsza wspólna wielokrotność to: " + a*b/a1);
        }
        static void Main(string[] args)
        {
            Console.Write("Podaj a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            NWW(a, b);
            Console.ReadKey(true);
        }
    }
}
