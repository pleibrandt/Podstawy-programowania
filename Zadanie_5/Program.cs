using System;


namespace Zadanie_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h, r;

            Console.Write("Podaj wysokość: ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj promien kola: ");
            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Objetosc wynosi: {0}", 1.0/3*Math.PI*r*r*h);
            Console.WriteLine("Pole calkowite wynosi: {0}", Math.PI*r*r+Math.PI*r*Math.Sqrt(h*h+r*r));
            Console.ReadKey(true);
        }
    }
}
