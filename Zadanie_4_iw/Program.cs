using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4_iw
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, najm, najw;
            Console.WriteLine("Podaj 5 liczb: ");

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            e = Convert.ToDouble(Console.ReadLine());

            najm = a;
            if (b < najm)
                najm = b;
            if (c < najm)
                najm = c;
            if (d < najm)
                najm = d;
            if (e < najm)
                najm = e;

            najw = a;
            if (b > najw)
                najw = b;
            if (c > najw)
                najw = c;
            if (d > najw)
                najw = d;
            if (e > najw)
                najw = e;

            Console.WriteLine("Najmniejsza liczba to {0}, a najwieksza to {1}",najm,najw);
        }
    }
}
