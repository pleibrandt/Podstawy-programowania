using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_struktury
{
    struct Uczen
    {
        public string imie, nazwisko;
        public int[] oceny;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Podaj liczbe uczniow: ");
            n = Convert.ToInt32(Console.ReadLine());

            Uczen[] Ludzie = new Uczen[n];
            int ile_ocen;
            for(int i=0; i<n; i++)
            {
                Console.Write("Podaj imie ucznia {0}: ", i+1);
                Ludzie[i].imie = Convert.ToString(Console.ReadLine());
                Console.Write("Podaj nazwisko ucznia {0}: ", i+1);
                Ludzie[i].nazwisko = Convert.ToString(Console.ReadLine());
                Console.Write("Podaj ile uczen ma ocen: ");
                ile_ocen = Convert.ToInt32(Console.ReadLine());

                Ludzie[i].oceny = new int[ile_ocen];

                for(int j=0; j<ile_ocen; j++)
                {
                    Console.Write("Podaj ocene nr {0} ucznia {1} {2}: ", j+1, Ludzie[i].imie, Ludzie[i].nazwisko);
                    Ludzie[i].oceny[j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("");
            }

            for(int i=0; i<n; i++)
            {
                Console.Write("Uczen {0}:\nImie: {1}, Nazwisko: {2}, Oceny: ", i+1, Ludzie[i].imie, Ludzie[i].nazwisko);
                foreach(int j in Ludzie[i].oceny)
                {
                    Console.Write("{0}, ", j);
                }
                Console.WriteLine("");
            }
            Console.ReadKey(true);

        }
    }
}
