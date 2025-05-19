using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_7_funkcje_wlasne
{
    class Program
    {
        static void pole_deltoidu(double p, double q)
        {
            Console.WriteLine("Pole deltoidu wynosi: {0}",p*q/2);
        }
        static void Main(string[] args)
        {
            double p, q;
            Console.Write("Podaj p: ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj q: ");
            q = Convert.ToInt32(Console.ReadLine());

            pole_deltoidu(p, q);
            Console.ReadKey(true);
        }
    }
}
