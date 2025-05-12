using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4_funkcje
{
    class Program
    {
        static int ile_cyfr(int liczba)
        {
            int ile = 0;
            while(liczba > 0)
            {
                ile++;
                liczba = liczba / 10;
            }
            return ile;
        }
        static void Main(string[] args)
        {
            int liczba;
            Console.Write("Podaj liczbe: ");
            liczba = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Liczba cyfr wynosi: {0}", ile_cyfr(liczba));
            Console.ReadKey(true);
        }
    }
}
