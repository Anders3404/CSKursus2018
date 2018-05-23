using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse6
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine( res );

            double res2 = BeregnAreal(5);
            Console.WriteLine(res2);
            Udskriv();
            Udskriv("Dette er en test");

            double res3 = BeregnMoms(100.35);
            Console.WriteLine(res3);

            double res4 = BeregnMoms(100.35,0.25);
            Console.WriteLine(res4);

            int[] løn = { 10000, 5000, 30000 };
            double gns2 = gns(løn);
            Console.WriteLine(gns2);



            Console.ReadKey();
        }


        static int LægSammen(int a, int b)
        {
            return a + b;
        }

        static double BeregnAreal (int radius)
        {
            return  radius * radius * System.Math.PI;

        }

        static double BeregnMoms(double beløb, double momsPct=0.25)
        {
            return beløb * momsPct;
        }

        static double gns(int[] månedsløn)
        {
            double sum = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum +=månedsløn[i];
            }

            return sum / månedsløn.Length;
        }

        static void Udskriv (string input)
        {

            Console.WriteLine(input);
        }

        static void Udskriv ()
        {
            Console.WriteLine();
        }
    }

}
