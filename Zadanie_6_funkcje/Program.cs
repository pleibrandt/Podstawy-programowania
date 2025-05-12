using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6_funkcje
{
    class Program
    {
        static void kwadrat(int a, char kon, char wyp)
        {
            for(int i=0; i<a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (i == 0 || i == a - 1)
                    {
                        Console.Write("{0}", kon);
                    }
                    else if (j == 0 || j == a - 1)
                    {
                        Console.Write("{0}", kon);
                    }
                    else
                        Console.Write("{0}", wyp);
                }
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            int a;
            char kon, wyp;
            Console.Write("Podaj dlugosc boku: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj znak kontura: ");
            kon = Convert.ToChar(Console.ReadLine());
            Console.Write("Podaj znak wypelnienia: ");
            wyp = Convert.ToChar(Console.ReadLine());

            kwadrat(a, kon, wyp);
            Console.ReadKey(true);
        }
    }
}
