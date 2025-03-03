

using System;

namespace Zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Podaj bok a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj bok b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Obwód wynosi: {0}", a+a+b+b);
            Console.WriteLine("Pole wynosi: {0}", a*b);
            Console.ReadKey(true);
        }
    }
}
