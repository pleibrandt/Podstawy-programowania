using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6_iw
{
    class Program
    {
        static void Main(string[] args)
        {
            int miesiac;
            Console.WriteLine("Podaj numer miesiaca: ");
            miesiac = Convert.ToInt32(Console.ReadLine());
            switch(miesiac)
            {
                case 1: Console.WriteLine("Styczen");   break;
                case 2: Console.WriteLine("Luty");  break;
                case 3: Console.WriteLine("Marzec"); break;
                case 4: Console.WriteLine("Kwiecien");  break;
                case 5: Console.WriteLine("Maj");   break;
                case 6: Console.WriteLine("Czerwiec");  break;
                case 7: Console.WriteLine("Lipiec");    break;
                case 8: Console.WriteLine("Sierpien");  break;
                case 9: Console.WriteLine("Wrzesien");  break;
                case 10: Console.WriteLine("Pazdziernik");  break;
                case 11: Console.WriteLine("Listopad"); break;
                case 12: Console.WriteLine("Grzudzien");    break;
                default: Console.WriteLine("Nie istnieje taki miesiac");   break;
            }
        }
    }
}
