using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Zadanie_2_funkcje
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Podaj liczbe a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbe b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Maksimum z liczb {0} i {1} wynosi: {2}",a,b,max(a,b));
            Console.ReadKey(true);
        }

        static double max(double a, double b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
    }
}
