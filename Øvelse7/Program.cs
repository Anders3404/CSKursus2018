using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(beregn(1, 2));
            Console.WriteLine(beregn(1, 2,3));
            Console.WriteLine(beregn(1, 2,3,5));

            int[] test = { 1, 2, 3, 5 };

            Console.WriteLine(beregn2(test));

            int[] test2 = { 10, 7, 6, 3, 1, 50, 3 };
            var res3 = beregnOgSorterArray(test2);

            Console.WriteLine("********************");
            Console.WriteLine(res3.sum);
            Console.WriteLine("********************");
            Console.WriteLine(res3.gns);
            //Console.WriteLine(res3.ToString());





            
        }

        static int beregn(int a, int b)
        {
            return a + b;


        }
        static int beregn(int a, int b, int c)
        {
            return a + b + c;

        }

        static int beregn(int a, int b, int c, int d)
        {
            return a + b + c + d;

        }

        static int beregn2(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }

        public static ArrayResultat beregnOgSorterArray(int[] a)
        {
            ArrayResultat r;
            r.sum = 0;

            foreach (var item in a )
            {
                r.sum += item;
            }

            r.gns = r.sum / a.Length;

            Array.Sort(a);
            //r.list = Array.Sort(a);
            return r;
        }

        

    }
    struct ArrayResultat
    {
        public double sum;
        public double gns;
        

    }
}
