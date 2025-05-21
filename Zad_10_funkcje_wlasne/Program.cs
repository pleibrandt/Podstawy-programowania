using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_10_funkcje_wlasne
{
    class Program
    {
        static void NWD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

            Console.WriteLine("Największy wspólny dzielnik (NWD) to: " + a);
        }
        static void Main(string[] args)
        {
            Console.Write("Podaj a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            NWD(a, b);
            Console.ReadKey(true);
        }
    }
}
