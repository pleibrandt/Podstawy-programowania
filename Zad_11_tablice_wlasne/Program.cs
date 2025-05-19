using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_11_tablice_wlasne
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,m,a=0;
            Console.Write("Podaj liczbe naturalna: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0} w systemie osemkowym wynosi: ",n);
            m = n;
            while (m >= 1)
            {
                m = m / 8;
                a++;
            }
            int[] tab = new int[a];
            int j=0;
            while (n>=1)
            {
                tab[j] = n % 8;
                n = n / 8;
                j++;
            }
            for(int i=a-1; i>=0; i--)
            {
                Console.Write("{0}", tab[i]);
            }
            Console.ReadKey(true);
        }
    }
}
