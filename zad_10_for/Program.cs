using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_10_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int ile;
            Console.Write("Podaj ile poda liczb podzielnych przez 7: ");
            ile = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<ile; i++)
            {
                Console.Write("{0}, ", i * 7);
            }
            Console.ReadKey(true);
        }
    }
}
