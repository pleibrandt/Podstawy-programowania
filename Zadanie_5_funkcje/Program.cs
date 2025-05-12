using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5_funkcje
{
    class Program
    {
        static int czy_pierwsza(int liczba)
        {
            for(int i=2; i<liczba; i++)
            {
                if (liczba % i == 0)
                    return 0;
            }
            return 1;
        }
        static void Main(string[] args)
        {
            int liczba;
            Console.Write("Podaj liczbe: ");
            liczba = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", czy_pierwsza(liczba));
            Console.ReadKey(true);
        }
    }
}
