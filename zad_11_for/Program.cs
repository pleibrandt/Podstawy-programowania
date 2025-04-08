using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_11_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,suma=0, niep=1;
            Console.Write("Podaj n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                suma = suma + niep;
                niep = niep + 2;
            }
            Console.WriteLine("Suma początkowych liczby nieparzystych do n wynosi: {0}",suma);
        }
    }
}
