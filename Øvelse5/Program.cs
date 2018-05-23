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
            for (int i = 1; i < 21; i++)
            {
                for (int y = 1; y <= 21; y++)
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


            

            Console.ReadKey();
        }
    }
}
