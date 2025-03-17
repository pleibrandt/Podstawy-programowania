using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_8_iw
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, najw=0, poz=0;
            Console.WriteLine("Podaj 3 dlugosci odcinkow:");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if (a > b && a > c)
            { najw = a; poz = b + c; }
            if (b > a && b > c)
            { najw = b; poz = a + c; }
            if (c > a && c > b)
            { najw = c; poz = a + b; }

            if(poz>najw)
                Console.WriteLine("Mozna zrobic trojkat");
            else
                Console.WriteLine("Nie mozna zrobic trojkata");
        }
    }
}
