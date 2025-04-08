using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_13_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,dod;
            Console.Write("Podaj n: ");
            n = Convert.ToInt32(Console.ReadLine());
            dod = n;
            for(int i=1; i<=n; i++)
            {
                if(i==n)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("X");
                    }
                }
                else
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (j == n)
                            Console.Write("X");
                        else if (dod == j)
                            Console.Write("X");
                        else
                            Console.Write(" ");
                    }
                }
                dod--;
                Console.WriteLine("");
            }
        }
    }
}
