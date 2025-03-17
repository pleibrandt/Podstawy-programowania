using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7_iw
{
    class Program
    {
        static void Main(string[] args)
        {
            int rzym;
            Console.WriteLine("Podaj liczbe z zakresu 1 do 3999: ");
            rzym = Convert.ToInt32(Console.ReadLine());
            //TYSIACE
            if (rzym >= 1000)
            { Console.Write("M"); rzym -= 1000; }
            if (rzym >= 1000)
            { Console.Write("M"); rzym -= 1000; }
            if (rzym >= 1000)
            { Console.Write("M"); rzym -= 1000; }
            //SETKI
            if (rzym >= 900)
            { Console.Write("CM"); rzym -= 900; }
            if (rzym >= 800)
            { Console.Write("DCCC"); rzym -= 800; }
            if (rzym >= 700)
            { Console.Write("DCC"); rzym -= 700; }
            if (rzym >= 600)
            { Console.Write("DC"); rzym -= 600; }
            if (rzym >= 500)
            { Console.Write("D"); rzym -= 500; }
            if (rzym >= 400)
            { Console.Write("CD"); rzym -= 400; }
            if (rzym >= 300)
            { Console.Write("CCC"); rzym -= 300; }
            if (rzym >= 200)
            { Console.Write("CC"); rzym -= 200; }
            if (rzym >= 100)
            { Console.Write("C"); rzym -= 100; }
            //DZIESIATKI
            if (rzym >= 90)
            { Console.Write("XC"); rzym -= 90; }
            if (rzym >= 80)
            { Console.Write("LXXX"); rzym -= 80; }
            if (rzym >= 70)
            { Console.Write("LXX"); rzym -= 70; }
            if (rzym >= 60)
            { Console.Write("LX"); rzym -= 60; }
            if (rzym >= 50)
            { Console.Write("L"); rzym -= 50; }
            if (rzym >= 40)
            { Console.Write("XL"); rzym -= 40; }
            if (rzym >= 30)
            { Console.Write("XXX"); rzym -= 30; }
            if (rzym >= 20)
            { Console.Write("XX"); rzym -= 20; }
            if (rzym >= 10)
            { Console.Write("X"); rzym -= 10; }
            //JEDNOSCI
            switch (rzym)
            {
                case 1: Console.Write("I"); break;
                case 2: Console.Write("II"); break;
                case 3: Console.Write("III"); break;
                case 4: Console.Write("IV"); break;
                case 5: Console.Write("V"); break;
                case 6: Console.Write("VI"); break;
                case 7: Console.Write("VII"); break;
                case 8: Console.Write("VIII"); break;
                case 9: Console.Write("IX"); break;
            }
        }
    }
}
