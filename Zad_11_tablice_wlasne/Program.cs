using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_11_tablice_wlasne
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Podaj liczbe naturalna: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0} w systemie osemkowym wynosi: ",n);
            while (n>=1)
            {
                Console.Write("{0}", n % 8);
                n = n / 8;
            }
            Console.ReadKey(true);
        }
    }
}
