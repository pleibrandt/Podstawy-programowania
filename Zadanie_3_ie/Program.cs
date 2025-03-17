

using System;

namespace Zadanie_3_ie
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, najw, najm;
            Console.WriteLine("Podaj 3 liczby: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            if (a > b && a > c)
                najw = a;
            else if (b > a && b > c)
                najw = b;
            else
                najw = c;

            if (a < b && a < c)
                najm = a;
            else if (b < a && b < c)
                najm = b;
            else
                najm = c;

            Console.WriteLine("Najmniejsza liczba jest {0}, a najwieksza jest {1}",najm, najw);

        }
    }
}
