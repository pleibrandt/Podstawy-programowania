using System;
using System.Reflection;


namespace zad_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Podaj numer wyrazu ciągu: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("N-ty wyraz ciagu wynosi: {0}",3*n-1);
            Console.ReadKey(true);
        }
    }
}
