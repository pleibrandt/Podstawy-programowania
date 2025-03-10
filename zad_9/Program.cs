

using System;

namespace zad_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;
            Console.Write("Podaj liczbe: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbe: ");
            b = Convert.ToInt32(Console.ReadLine());
            sum = a * a + b * b;
            Console.WriteLine("Suma kwadratow wynosi: {0}", sum);
            Console.ReadKey(true);

        }
    }
}
