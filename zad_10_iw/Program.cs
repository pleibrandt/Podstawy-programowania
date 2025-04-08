using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_10_iw
{
    class Program
    {
        static void Main(string[] args)
        {
            uint liczba, pomoc = 100000, a=0;
            do
            {
                Console.Write("Podaj liczbe w zakresie 1 - 1 000 000: ");
                liczba = Convert.ToUInt32(Console.ReadLine());
            } while (liczba > 1000000);

            Console.WriteLine("Liczba slownie: ");
            if (liczba == 1000000)
                Console.Write("Milion");
            if (liczba == 0)
                Console.Write("Zero");

            if (liczba > pomoc)
            {
                if (liczba >= pomoc * 9 && liczba < pomoc * 10)
                {
                    Console.Write("Dziewiecset ");
                    liczba = liczba - pomoc * 9;
                }
                if (liczba >= pomoc * 8 && liczba < pomoc * 9)
                {
                    Console.Write("Osiemset ");
                    liczba = liczba - pomoc * 8;
                }
                if (liczba >= pomoc * 7 && liczba < pomoc * 8)
                {
                    Console.Write("Siedemset ");
                    liczba = liczba - pomoc * 7;
                }
                if (liczba >= pomoc * 6 && liczba < pomoc * 7)
                {
                    Console.Write("Szescset ");
                    liczba = liczba - pomoc * 6;
                }
                if (liczba >= pomoc * 5 && liczba < pomoc * 6)
                {
                    Console.Write("Piecset ");
                    liczba = liczba - pomoc * 5;
                }
                if (liczba >= pomoc * 4 && liczba < pomoc * 5)
                {
                    Console.Write("Czterysta ");
                    liczba = liczba - pomoc * 4;
                }
                if (liczba >= pomoc * 3 && liczba < pomoc * 4)
                {
                    Console.Write("Trzysta ");
                    liczba = liczba - pomoc * 3;
                }
                if (liczba >= pomoc * 2 && liczba < pomoc * 3)
                {
                    Console.Write("Dwiescie ");
                    liczba = liczba - pomoc * 2;
                }
                if (liczba >= pomoc * 1 && liczba < pomoc * 2)
                {
                    Console.Write("Sto ");
                    liczba = liczba - pomoc * 1;
                }
            }
            pomoc = pomoc / 10;
            if (liczba > pomoc)
            {
                if (liczba >= pomoc * 9 && liczba < pomoc * 10)
                {
                    Console.Write("Dziewiecdziesiat ");
                    liczba = liczba - pomoc * 9;
                }
                if (liczba >= pomoc * 8 && liczba < pomoc * 9)
                {
                    Console.Write("Osiemdziesiat ");
                    liczba = liczba - pomoc * 8;
                }
                if (liczba >= pomoc * 7 && liczba < pomoc * 8)
                {
                    Console.Write("Siedemdziesiat ");
                    liczba = liczba - pomoc * 7;
                }
                if (liczba >= pomoc * 6 && liczba < pomoc * 7)
                {
                    Console.Write("Szescdziesiat ");
                    liczba = liczba - pomoc * 6;
                }
                if (liczba >= pomoc * 5 && liczba < pomoc * 6)
                {
                    Console.Write("Piecdziesiat ");
                    liczba = liczba - pomoc * 5;
                }
                if (liczba >= pomoc * 4 && liczba < pomoc * 5)
                {
                    Console.Write("Czterdziesci ");
                    liczba = liczba - pomoc * 4;
                }
                if (liczba >= pomoc * 3 && liczba < pomoc * 4)
                {
                    Console.Write("Trzydziesci ");
                    liczba = liczba - pomoc * 3;
                }
                if (liczba >= pomoc * 2 && liczba < pomoc * 3)
                {
                    Console.Write("Dwadziescia ");
                    liczba = liczba - pomoc * 2;
                }
                if (liczba >= pomoc * 1 && liczba < pomoc * 2)
                {
                    pomoc = pomoc / 10;
                    liczba = liczba - pomoc * 1;
                    if (liczba >= pomoc * 9 && liczba < pomoc * 10)
                    {
                        Console.Write("Dziewietnascie ");
                        liczba = liczba - pomoc * 9;
                    }
                    else if (liczba >= pomoc * 8 && liczba < pomoc * 9)
                    {
                        Console.Write("Osiemnascie ");
                        liczba = liczba - pomoc * 8;
                    }
                    else if (liczba >= pomoc * 7 && liczba < pomoc * 8)
                    {
                        Console.Write("Siedemnascie ");
                        liczba = liczba - pomoc * 7;
                    }
                    else if (liczba >= pomoc * 6 && liczba < pomoc * 7)
                    {
                        Console.Write("Szesnascie ");
                        liczba = liczba - pomoc * 6;
                    }
                    else if (liczba >= pomoc * 5 && liczba < pomoc * 6)
                    {
                        Console.Write("Pietnascie ");
                        liczba = liczba - pomoc * 5;
                    }
                    else if (liczba >= pomoc * 4 && liczba < pomoc * 5)
                    {
                        Console.Write("Czternascie ");
                        liczba = liczba - pomoc * 4;
                    }
                    else if (liczba >= pomoc * 3 && liczba < pomoc * 4)
                    {
                        Console.Write("Trzynascie ");
                        liczba = liczba - pomoc * 3;
                    }
                    else if (liczba >= pomoc * 2 && liczba < pomoc * 3)
                    {
                        Console.Write("Dwanascie ");
                        liczba = liczba - pomoc * 2;
                    }
                    else if (liczba >= pomoc * 1 && liczba < pomoc * 2)
                    {
                        Console.Write("Jedynascie ");
                        liczba = liczba - pomoc * 1;
                    }
                    else
                    {
                        Console.Write("Dziesiec ");
                        liczba = liczba - pomoc * 1;
                    }
                }
            }
            pomoc = pomoc / 10;
            if (liczba > pomoc)
            {
                if (liczba >= pomoc * 9 && liczba < pomoc * 10)
                {
                    Console.Write("Dziewiec ");
                    liczba = liczba - pomoc * 9;
                }
                if (liczba >= pomoc * 8 && liczba < pomoc * 9)
                {
                    Console.Write("Osiem ");
                    liczba = liczba - pomoc * 8;
                }
                if (liczba >= pomoc * 7 && liczba < pomoc * 8)
                {
                    Console.Write("Siedem ");
                    liczba = liczba - pomoc * 7;
                }
                if (liczba >= pomoc * 6 && liczba < pomoc * 7)
                {
                    Console.Write("Szesc ");
                    liczba = liczba - pomoc * 6;
                }
                if (liczba >= pomoc * 5 && liczba < pomoc * 6)
                {
                    Console.Write("Piec ");
                    liczba = liczba - pomoc * 5;
                }
                if (liczba >= pomoc * 4 && liczba < pomoc * 5)
                {
                    Console.Write("Cztery ");
                    liczba = liczba - pomoc * 4;
                }
                if (liczba >= pomoc * 3 && liczba < pomoc * 4)
                {
                    Console.Write("Trzy ");
                    liczba = liczba - pomoc * 3;
                }
                if (liczba >= pomoc * 2 && liczba < pomoc * 3)
                {
                    Console.Write("Dwa ");
                    liczba = liczba - pomoc * 2;
                }
                if (liczba >= pomoc * 1 && liczba < pomoc * 2)
                {
                    Console.Write("Jeden ");
                    liczba = liczba - pomoc * 1;
                }
            }
            pomoc = pomoc / 10;

            //setki
            if (liczba > pomoc)
            {
                if (liczba >= pomoc * 9 && liczba < pomoc * 10)
                {
                    Console.Write("Dziewiecset ");
                    liczba = liczba - pomoc * 9;
                }
                if (liczba >= pomoc * 8 && liczba < pomoc * 9)
                {
                    Console.Write("Osiemset ");
                    liczba = liczba - pomoc * 8;
                }
                if (liczba >= pomoc * 7 && liczba < pomoc * 8)
                {
                    Console.Write("Siedemset ");
                    liczba = liczba - pomoc * 7;
                }
                if (liczba >= pomoc * 6 && liczba < pomoc * 7)
                {
                    Console.Write("Szescset ");
                    liczba = liczba - pomoc * 6;
                }
                if (liczba >= pomoc * 5 && liczba < pomoc * 6)
                {
                    Console.Write("Piecset ");
                    liczba = liczba - pomoc * 5;
                }
                if (liczba >= pomoc * 4 && liczba < pomoc * 5)
                {
                    Console.Write("Czterysta ");
                    liczba = liczba - pomoc * 4;
                }
                if (liczba >= pomoc * 3 && liczba < pomoc * 4)
                {
                    Console.Write("Trzysta ");
                    liczba = liczba - pomoc * 3;
                }
                if (liczba >= pomoc * 2 && liczba < pomoc * 3)
                {
                    Console.Write("Dwiescie ");
                    liczba = liczba - pomoc * 2;
                }
                if (liczba >= pomoc * 1 && liczba < pomoc * 2)
                {
                    Console.Write("Sto ");
                    liczba = liczba - pomoc * 1;
                }
            }
            pomoc = pomoc / 10;
            if (liczba > pomoc)
            {
                if (liczba >= pomoc * 9 && liczba < pomoc * 10)
                {
                    Console.Write("Dziewiecdziesiat ");
                    liczba = liczba - pomoc * 9;
                }
                if (liczba >= pomoc * 8 && liczba < pomoc * 9)
                {
                    Console.Write("Osiemdziesiat ");
                    liczba = liczba - pomoc * 8;
                }
                if (liczba >= pomoc * 7 && liczba < pomoc * 8)
                {
                    Console.Write("Siedemdziesiat ");
                    liczba = liczba - pomoc * 7;
                }
                if (liczba >= pomoc * 6 && liczba < pomoc * 7)
                {
                    Console.Write("Szescdziesiat ");
                    liczba = liczba - pomoc * 6;
                }
                if (liczba >= pomoc * 5 && liczba < pomoc * 6)
                {
                    Console.Write("Piecdziesiat ");
                    liczba = liczba - pomoc * 5;
                }
                if (liczba >= pomoc * 4 && liczba < pomoc * 5)
                {
                    Console.Write("Czterdziesci ");
                    liczba = liczba - pomoc * 4;
                }
                if (liczba >= pomoc * 3 && liczba < pomoc * 4)
                {
                    Console.Write("Trzydziesci ");
                    liczba = liczba - pomoc * 3;
                }
                if (liczba >= pomoc * 2 && liczba < pomoc * 3)
                {
                    Console.Write("Dwadziescia ");
                    liczba = liczba - pomoc * 2;
                }
                if (liczba >= pomoc * 1 && liczba < pomoc * 2)
                {
                    pomoc = pomoc / 10;
                    liczba = liczba - pomoc * 1;
                    if (liczba >= pomoc * 9 && liczba < pomoc * 10)
                    {
                        Console.Write("Dziewietnascie ");
                        liczba = liczba - pomoc * 9;
                    }
                    else if (liczba >= pomoc * 8 && liczba < pomoc * 9)
                    {
                        Console.Write("Osiemnascie ");
                        liczba = liczba - pomoc * 8;
                    }
                    else if (liczba >= pomoc * 7 && liczba < pomoc * 8)
                    {
                        Console.Write("Siedemnascie ");
                        liczba = liczba - pomoc * 7;
                    }
                    else if (liczba >= pomoc * 6 && liczba < pomoc * 7)
                    {
                        Console.Write("Szesnascie ");
                        liczba = liczba - pomoc * 6;
                    }
                    else if (liczba >= pomoc * 5 && liczba < pomoc * 6)
                    {
                        Console.Write("Pietnascie ");
                        liczba = liczba - pomoc * 5;
                    }
                    else if (liczba >= pomoc * 4 && liczba < pomoc * 5)
                    {
                        Console.Write("Czternascie ");
                        liczba = liczba - pomoc * 4;
                    }
                    else if (liczba >= pomoc * 3 && liczba < pomoc * 4)
                    {
                        Console.Write("Trzynascie ");
                        liczba = liczba - pomoc * 3;
                    }
                    else if (liczba >= pomoc * 2 && liczba < pomoc * 3)
                    {
                        Console.Write("Dwanascie ");
                        liczba = liczba - pomoc * 2;
                    }
                    else if (liczba >= pomoc * 1 && liczba < pomoc * 2)
                    {
                        Console.Write("Jedynascie ");
                        liczba = liczba - pomoc * 1;
                    }
                    else
                    {
                        Console.Write("Dziesiec ");
                        liczba = liczba - pomoc * 1;
                    }
                }
            }
            pomoc = pomoc / 10;
            Console.WriteLine("{0}    {1}",liczba,pomoc);
            if (liczba >= pomoc)
            {
                if (liczba >= pomoc * 9 && liczba < pomoc * 10)
                {
                    Console.Write("Dziewiec ");
                    liczba = liczba - pomoc * 9;
                }
                if (liczba >= pomoc * 8 && liczba < pomoc * 9)
                {
                    Console.Write("Osiem ");
                    liczba = liczba - pomoc * 8;
                }
                if (liczba >= pomoc * 7 && liczba < pomoc * 8)
                {
                    Console.Write("Siedem ");
                    liczba = liczba - pomoc * 7;
                }
                if (liczba >= pomoc * 6 && liczba < pomoc * 7)
                {
                    Console.Write("Szesc ");
                    liczba = liczba - pomoc * 6;
                }
                if (liczba >= pomoc * 5 && liczba < pomoc * 6)
                {
                    Console.Write("Piec ");
                    liczba = liczba - pomoc * 5;
                }
                if (liczba >= pomoc * 4 && liczba < pomoc * 5)
                {
                    Console.Write("Cztery ");
                    liczba = liczba - pomoc * 4;
                }
                if (liczba >= pomoc * 3 && liczba < pomoc * 4)
                {
                    Console.Write("Trzy ");
                    liczba = liczba - pomoc * 3;
                }
                if (liczba >= pomoc * 2 && liczba < pomoc * 3)
                {
                    Console.Write("Dwa ");
                    liczba = liczba - pomoc * 2;
                }
                if (liczba >= pomoc * 1 && liczba < pomoc * 2)
                {
                    Console.Write("Jeden ");
                    liczba = liczba - pomoc * 1;
                }
            }
            Console.ReadKey(true);
        }
    }
}
