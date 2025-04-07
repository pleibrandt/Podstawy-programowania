using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_9_iw
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta ;
            Console.Write("Podaj a, b i c: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            delta = b * b - 4 * a * c;
            Console.WriteLine("Delta wynosi: {0}", delta);
            if(delta < 0)
                Console.WriteLine("Funkcja nie posiada miejsc zerowych");
            if(delta==0)
            {
                Console.WriteLine("Miejsce zerowe funkcji wynosi: {0}", (-b - Math.Sqrt(delta)) / 2 * a);
            }
            if (delta > 0)
            {
                Console.WriteLine("Miejsca zerowe funkcji wynosza: {0} i {1}", (-b - Math.Sqrt(delta)) / 2 * a, (-b + Math.Sqrt(delta)) / 2 * a);
            }
            Console.ReadKey(true);
        }
    }
}
