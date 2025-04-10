using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_9_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,sum=0;
            Console.Write("Podaj liczbe: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n > 0)
            {
                sum = sum + (n % 10);
                n = n / 10;
            }
            Console.Write("Suma liczb wynosi: {0}", sum);
            Console.ReadKey(true);
        }
    }
}
