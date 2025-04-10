using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_11_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, c;
            do
            {
                Console.WriteLine("Jaka objetosc chcesz policzyc?");
                Console.WriteLine("1 - objetosc kuli");
                Console.WriteLine("2 - objetosc stozka");
                Console.WriteLine("3 - objetosc walca");
                Console.WriteLine("4 - objetosc prostopadloscianu");
                Console.WriteLine("5 - objetosc szescianu");
                n = Convert.ToInt32(Console.ReadLine());

                switch(n)
                {
                    case 1:
                        Console.Write("Podaj promien: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Objetosc kuli wynosi: {0}",Math.PI * 4/3 * a * a * a);
                        break;
                    case 2:
                        Console.Write("Podaj promien: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Podaj wysokosc: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Objetosc stozka wynosi: {0}", 1 / 3 * Math.PI * a * a * b);
                        break;
                    case 3:
                        Console.Write("Podaj promien: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Podaj wysokosc: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Objetosc stozka wynosi: {0}",Math.PI*a*a*b);
                        break;
                    case 4:
                        Console.Write("Podaj dlugosc 1 krawedzi: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Podaj dlugosc 2 krawedzi: ");
                        b = Convert.ToInt32(Console.ReadLine()); 
                        Console.Write("Podaj dlugosc 3 krawedzi: ");
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Objetosc prostopadloscianu wynosi: {0}",a*b*c);
                        break;
                    case 5:
                        Console.Write("Podaj dlugosc krawedzi: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Objetosc szescianu wynosi: {0}",a*a*a);
                        break;
                    default:
                        Console.WriteLine("Nie istnieje taka opcja");
                        break;
                }
                Console.WriteLine("");
            } while (n != 0);
            Console.ReadKey(true);
        }
    }
}
