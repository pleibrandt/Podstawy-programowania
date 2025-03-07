
using System;

namespace Zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Podaj dwie liczby: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iloraz wynosi: {0}, a reszta z dzielenia wynosi: {1}",a/b, a%b);
        }
    }
}
