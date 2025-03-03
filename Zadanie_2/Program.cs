
using System;

namespace Zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.Write("Podaj imie: ");
            a = Console.ReadLine();
            Console.WriteLine("Witaj {0}!", a);
            Console.ReadKey(true);
        }
    }
}
