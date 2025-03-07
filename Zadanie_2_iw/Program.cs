
using System;

namespace Zadanie_2_iw
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj liczbe: ");
            a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("Liczba jest dodatnia.");
            }
            else if(a < 0)
            {
                Console.WriteLine("Liczba jest ujemna.");
            }
            else
            {
                Console.Write("Liczba jest równa 0.");
            }
                Console.ReadKey(true);
        }
    }
}
