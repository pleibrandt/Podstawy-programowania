using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_15_funkcje_wlasne
{
    class Program
    {
        static void choinka(int n)
        {
            int a = 1,m = n;
            for(int i=0; i<n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(" ");
                for (int j = 0; j < a; j++)
                    Console.Write("*");
                a = a + 2;
                m = m - 1;
                Console.WriteLine("");
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < n-1; j++)
                    Console.Write(" ");
                for (int j = 0; j < 3; j++)
                    Console.Write("*");

                Console.WriteLine("");
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Podaj dlugosc choinki: ");
            int n = Convert.ToInt32(Console.ReadLine());
            choinka(n);
            Console.ReadKey(true);
        }
    }
}
