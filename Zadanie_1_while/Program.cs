using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1_while
{
    class Program
    {
        static void Main(string[] args)
        {
            uint a, b;
            Console.Write("Podaj poczatek przedzialu: ");
            a = Convert.ToUInt32(Console.ReadLine());
            do
            {
                Console.Write("Podaj koniec przedzialu (wiekszy od poczatku): ");
                b = Convert.ToUInt32(Console.ReadLine());
            } while (b < a);

            do
            {
                if (a % 2 == 0)
                    Console.Write("{0}  ", a);
                a++;
            } while (a <= b);
            Console.ReadKey(true);
        }
    }
}
