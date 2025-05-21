using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_13_dunkcje_wlasne
{
    class Program
    {
        static int czy_kw(int a)
        {
            int b = 1;
            while(a>=b*b)
            {
                if (a == b * b)
                    return 1;
                b++;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj liczbe: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}",czy_kw(a));
            Console.ReadKey(true);
        }
    }
}
