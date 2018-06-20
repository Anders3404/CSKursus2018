using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates3
{
    class Program
    {
        //public delegate int BeregnDelegate(int a, int b);
        static void Main(string[] args)
        {
            int res = 0;
            res = Beregner(2, 2, Plus);
            Console.WriteLine(res);
            res = Beregner(2, 4, Minus);
            Console.WriteLine(res);
            Console.WriteLine("**********");
            res = Beregner(3, 4, FindtilFældigFunktion());
            Console.WriteLine(res);


        }

        public static int Beregner(int a, int b, Func<int, int, int> funktion)
        {
            return funktion(a, b);
        }

        public static Func<int,int,int> FindtilFældigFunktion ()
        {
            if (System.DateTime.Now.Millisecond <= 250)
                return Plus;
            if (System.DateTime.Now.Millisecond <= 500)
                return Minus;
            if (System.DateTime.Now.Millisecond <= 750)
                return Gange;
            return Divider;
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

        public static double Modulus(double a, double b)
        {
            return a % b;
        }
    }



}
