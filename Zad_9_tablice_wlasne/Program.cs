using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_9_tablice_wlasne
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Podaj ile bedzie wczytanych liczb z zakresu od 1 do 1000: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 1 || n > 1000);
            double[] tab = new double[n];
            double sum=0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Liczba {0}= ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + tab[i] * tab[i];
            }
            Console.WriteLine("Suma kwadratow liczb wynosi: {0}", sum);
            Console.ReadKey(true);
        }
    }
}
