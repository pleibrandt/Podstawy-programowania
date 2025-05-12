using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_reku
{
    class Program
    {
        static int fibb(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return fibb(n - 1) + fibb(n - 2);
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Podaj liczbe n, ktora jest n-tym wyrazem ciagu fibbonacciego: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} wyraz ciagu fibbonaciego wynosi: {1}", n, fibb(n));
            Console.ReadKey(true);
        }
    }
}
