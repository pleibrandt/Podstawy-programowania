using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_12_tablice_wlasne
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, a = 0;
            Console.Write("Podaj liczbe naturalna: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0} w systemie osemkowym wynosi: ", n);
            m = n;
            while (m >= 1)
            {
                m = m / 16;
                a++;
            }
            string[] tab = new string[a];
            int j = 0;
            while (n >= 1)
            {
                if(n % 16 == 10)
                {
                    tab[j] = "A";
                }
                else if(n % 16 == 11)
                {
                    tab[j] = "B";
                }
                else if (n % 16 == 12)
                {
                    tab[j] = "C";
                }
                else if (n % 16 == 13)
                {
                    tab[j] = "D";
                }
                else if (n % 16 == 14)
                {
                    tab[j] = "E";
                }
                else if (n % 16 == 15)
                {
                    tab[j] = "F";
                }
                else
                {
                    m = n % 16;
                    tab[j] = m.ToString();
                }
                n = n / 16;
                j++;
            }
            for (int i = a - 1; i >= 0; i--)
            {
                Console.Write("{0}", tab[i]);
            }
            Console.ReadKey(true);
        }
    }
}
