using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_14_funkcje_wlasne
{
    class Program
    {
        static int czy_kon_pierw(int a)
        {
            double pierw_a = Math.Sqrt(a);
            string dl_str = a.ToString();
            int dl = dl_str.Length;

            for(int i=1; i<=dl; i++)
            {
                if (a % Math.Pow(10,i) == pierw_a)
                    return 1;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Podaj liczbe: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}",czy_kon_pierw(n));
            Console.ReadKey(true);
        }
    }
}
