using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_8_funkcje_wlasne
{
    class Program
    {
        static int czy_przystepny(int rok)
        {
            if ((rok % 4 == 0 && rok % 100 != 0) || (rok % 400 == 0))
                return 1;
            else
                return 0;
        }
        static void Main(string[] args)
        {
            int rok;
            Console.Write("Podaj rok: ");
            rok = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0}", czy_przystepny(rok));
            Console.ReadKey(true);
        }
    }
}
