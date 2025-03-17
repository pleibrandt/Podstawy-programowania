using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5_iw
{
    class Program
    {
        static void Main(string[] args)
        {
            int rok;
            Console.WriteLine("Podaj rok: ");
            rok = Convert.ToInt32(Console.ReadLine());
            if(((rok%4==0) && (rok%100!=0)) || (rok%400==0))
                Console.WriteLine("Rok jest przystepny");
            else
                Console.WriteLine("Rok nie jest przystepny");
        }
    }
}
