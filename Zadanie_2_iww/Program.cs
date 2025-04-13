using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_iww
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2;
            double a, b;
            Console.Write("Podaj wspolrzedna x punktu A: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wspolrzedna y punktu A: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wspolrzedna x punktu B: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wspolrzedna y punktu B: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            a = (y2 - y1) / (x2 - x1);
            b = y1 - x1 * ((y2 - y1) / (x2 - x1));
            Console.WriteLine("Funkcja przechodząca przez te dwa punkty ma postać: f(x) = {0}x ",a);
            if (b >= 0)
                Console.Write("+ {0}", b);
            else
                Console.Write("- {0}", b * (-1));
        }
    }
}
