using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1_struktury
{
    struct Osoba
    {
        public string imie, nazwisko;
        public int rok_urodzenia;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Osoba o;
            Console.Write("Podaj imie: ");
            o.imie = Convert.ToString(Console.ReadLine());
            Console.Write("Podaj nazwisko: ");
            o.nazwisko = Convert.ToString(Console.ReadLine());
            Console.Write("Podaj rok urodzenia: ");
            o.rok_urodzenia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nImie: {0} \nNazwisko: {1} \nRok urodzenia: {2}",o.imie,o.nazwisko,o.rok_urodzenia);
            Console.ReadKey(true);
        }
    }
}
