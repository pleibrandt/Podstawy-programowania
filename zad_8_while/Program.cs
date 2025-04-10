using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_8_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, n=2, dziel=0;
            Console.Write("Podaj liczbe: ");
            a = Convert.ToInt32(Console.ReadLine());

            while(n<a)
            {
                if (a % n == 0)
                {
                    dziel++;
                }
                n++;
            }
            if(dziel==0)
                Console.WriteLine("Liczba jest pierwsza");
            else
                Console.WriteLine("Liczba nie jest pierwsza");
            Console.ReadKey(true);
        }
    }
}
