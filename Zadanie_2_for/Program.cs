using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,pot=2;
            Console.WriteLine("Podaj potege: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<n; i++)
            {
                pot = pot * 2;
            }
            Console.WriteLine("2^{0}: {1}",n,pot);
            Console.ReadKey(true);
        }
    }
}
