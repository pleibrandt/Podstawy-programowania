using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_12_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int h,dod;
            Console.Write("Podaj wysokosc piramidy: ");
            h = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=h; i++)
            {
                dod = i;
                for(int j=0; j<i; j++)
                {
                    Console.Write("{0} ", dod);
                    dod = dod + i;
                }
                Console.WriteLine("");
            }
            Console.ReadKey(true);
        }
    }
}
