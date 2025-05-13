using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_7_tablice_wlasne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int n, najm=0, najw=0;
            do {
                Console.Write("Podaj ile bedzie wczytanych liczb z zakresu od 1 do 1000: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 1 || n > 1000);
            
            for(int i=0; i<n; i++)
            {
                Console.Write("Liczba {0}= ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
                if(i==0)
                {
                    najw = tab[i];
                    najm = tab[i];
                }
                if (tab[i] > najw)
                    najw = tab[i];
                if (tab[i] < najm)
                    najm = tab[i];
            }
            Console.WriteLine("Najwieksza liczba to: {0}", najw);
            Console.WriteLine("Najmniejsza liczba to: {0}", najm);
            Console.ReadKey(true);
        }
    }
}
