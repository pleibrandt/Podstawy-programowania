using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_14_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, l_dwo;
            Console.Write("Podaj poczatek przedzialu: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj koniec przedzialu: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Znalezione trójki: ");
            for(int i=n; i<=m; i++)
            {
                for(int j=n; j<=m; j++)
                {
                    for(int k=n; k<=m; k++)
                    {
                        if ((Math.Sqrt(i * i + j * j) == k) && (i < j))
                            Console.WriteLine("{0}, {1}, {2}",i,j,k);
                    }
                }
            }
        }
    }
}
