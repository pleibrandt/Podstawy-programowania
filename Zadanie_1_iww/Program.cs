using System;

namespace Zadanie_1_iww
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Podaj wspolrzedna x punktu: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj wspolrzedna y punktu: ");
            y = Convert.ToInt32(Console.ReadLine());
            if(x > 0 && y > 0)
                Console.WriteLine("Pierwsza cwiartka");
            if (x < 0 && y > 0)
                Console.WriteLine("Druga cwiartka");
            if (x < 0 && y < 0)
                Console.WriteLine("Trzecia cwiartka");
            if (x > 0 && y < 0)
                Console.WriteLine("Czwarta cwiartka");

            Console.ReadKey(true);
        }
    }
}
