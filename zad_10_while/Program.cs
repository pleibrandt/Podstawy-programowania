using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_10_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0, n;
            do
            {
                Console.Write("Podaj liczbe: ");
                n = Convert.ToInt32(Console.ReadLine());
                sum = sum + n;
            } while (n != 0);
            Console.WriteLine("Suma liczb wynosi: {0}",sum);
            Console.ReadKey(true);
        }
    }
}
