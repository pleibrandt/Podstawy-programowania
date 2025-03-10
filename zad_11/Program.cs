

using System;

namespace zad_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, h, pole_c, obj;
            Console.Write("Podaj dlugosc boku: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj dlugosc boku: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj dlugosc wysokosci: ");
            h = Convert.ToDouble(Console.ReadLine());
            pole_c = a * b * 2 + a * h * 2 + b * h * 2;
            obj = a * b * h;
            Console.WriteLine("Pole calkowite prostopadloscianu wynosi {0}, a jego objetosc wynosi {1}", pole_c, obj);
            Console.ReadKey(true);

        }
    }
}
