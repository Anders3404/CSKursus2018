using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates1
{
    class Program
    {
        //public delegate int BeregnDelegate(int a, int b);
        static void Main(string[] args)
        {
            int res = 0;
            res = Beregner(2, 2, Plus);
            Console.WriteLine(res);
            res = Beregner(2, 4, Gange);
            Console.WriteLine(res);


        }

        public static int Beregner(int a, int b, Func<int,int,int> funktion)
        {
            return funktion(a, b);
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;

        }

        public static int Gange(int a, int b)
        {
            return a * b;

        }

        public static int Modulus(int a, int b)
        {
            return a % b;
        }
    }



}
