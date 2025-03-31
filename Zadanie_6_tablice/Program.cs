using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6_tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dni_tygodnia = new string[] {"poniedzialek","wtorek","sroda","czwartek","piatek","sobota","niedziela"};
            foreach(string c in dni_tygodnia)
            {
                Console.WriteLine(c);
            }
        }
    }
}
