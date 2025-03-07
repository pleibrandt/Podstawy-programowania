using System;
using System.Reflection;


namespace Zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Podaj dwie liczby: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Suma wynosi: {0}, różnica wynosi: {1}, iloczyn wynosi: {2}, iloraz wynosi: {3}", a + b, a - b, a * b, a / b);
            Console.ReadKey(true);
        }
    }
}
