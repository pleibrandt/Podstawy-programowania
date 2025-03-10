

using System;

namespace zad_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, obw, pole;
            Console.Write("Podaj dlugosc promienia: ");
            r = Convert.ToDouble(Console.ReadLine());
            obw = 2 * Math.PI * r;
            pole = Math.PI * r * r;
            Console.WriteLine("Obwod kola wynosi {0}, a pole kola wynosi {1}", obw, pole);
            Console.ReadKey(true);

        }
    }
}
