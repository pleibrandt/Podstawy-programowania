using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_7_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i=1, silnia=1;
            Console.Write("Podaj n: ");
            n = Convert.ToInt32(Console.ReadLine());

            while(i<n+1)
            {
                silnia = silnia * i;
                i++;
            }
            Console.WriteLine("{0}! = {1}",n,silnia);
            Console.ReadKey(true);
        }
    }
}
