using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_9_funkcje_wlasne
{
    class Program
    {
        static void delta(double a, double b, double c)
        {
            if (b * b - 4 * a * c > 0)
                Console.Write("Funkcja ma 2 pierwiastki");
            else if (b * b - 4 * a * c == 0)
                Console.Write("Funkcja ma 1 pierwiastek");
            else
                Console.Write("Funkcja ma 0 pierwiastków");
        }
        static void Main(string[] args)
        {
            Console.Write("Podaj a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            delta(a, b, c);
            Console.ReadKey(true);
        }
    }
}
