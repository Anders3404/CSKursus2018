using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            sw.Start();


            for (int i = 1; i < 30; i++)
            {
                for (int y = 1; y <= 29; y++)
                {
                    if (y % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    string table = (i * y).ToString();
                    if ((i * y) > 50)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(table.PadLeft(4));

                    if ((y * i) % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    }
                    //Laver linieskift
                 
                }
                Console.WriteLine();

            }

            sw.Stop();

            Console.WriteLine(sw.ElapsedMilliseconds.ToString("N2"));

            Console.ReadKey();
        }
    }
}
