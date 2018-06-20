using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates1
{
    class Program
    {
        public delegate int BeregnDelegate(int a, int b);
        static void Main(string[] args)
        {
            BeregnDelegate s = new BeregnDelegate(Gange);
            int res = Beregner(1003, 1000054, s);
            Console.WriteLine(res);

            BeregnDelegate s1 = Minus;
            int res2 = Beregner(1, 1, s1);
            Console.WriteLine(res2);

            int res3 = Beregner(111111, 123456789, Gange);
            Console.WriteLine(res3.ToString());
        }

        public static int Beregner(int a, int b, BeregnDelegate funktion)
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

        public static int Gange (int a, int b)
        {
            return a * b;

        }
    }

    

}
