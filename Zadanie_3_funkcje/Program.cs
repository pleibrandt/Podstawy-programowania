using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3_funkcje
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            Console.Write("Podaj dlugosc promienia: ");
            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Pole kola wynosi: {0}",pole_kola(r));
        }

        static double pole_kola(double r)
        {
            return Math.PI * r * r;
        }
    }
}
