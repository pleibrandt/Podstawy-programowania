using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5_tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a=0;
            int[] bin = new int[1000];
            Console.Write("Podaj liczbe: ");
            n = Convert.ToInt32(Console.ReadLine());
            while(n>=1)
            {
                bin[a] = n % 2;
                a++;
                n = n / 2;
            }
            Console.WriteLine("Binarna wyniesie: ");
            for(int i=a-1; i>=0; i--)
            {
                Console.Write("{0}", bin[i]);
            }

        }
    }
}
