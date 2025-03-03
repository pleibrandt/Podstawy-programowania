

using System;

namespace Zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Podaj liczbe: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Szescian liczby wynosi: {0}", a*a*a);
            Console.ReadKey(true);
        }
    }
}
