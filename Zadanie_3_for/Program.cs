using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0, a;
            Console.WriteLine("Podaj liczbe wieksza od 2: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a <= 2)
                Console.WriteLine("Liczba jest mniejsza lub rowna 2");
            else
            {
                for (int i = 1; i <= a; i++)
                {
                    sum += i;
                }
                Console.WriteLine("Wartosc zsumowana wynosi: {0}", sum);
            }
            Console.ReadKey(true);
        }
    }
}
