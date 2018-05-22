using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleVariabler
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Int32 i ;
            String s;
            s=Console.ReadLine();
            if (Int32.TryParse(s, out i))
                Int32.TryParse(s, out i);
            else Console.WriteLine(s + " is not an integer");



            int ii;

            String ss;
            ss = Console.ReadLine();
            if (Int32.TryParse(ss, out ii))
                Int32.TryParse(ss, out ii);
            else Console.WriteLine(ss + " is not an integer");

            if (i<ii)
            {
                Console.WriteLine(i.ToString() + " is less than " + ii.ToString());
            }

            if (ii < i)
            {
                Console.WriteLine(ii.ToString() + " is less than " + i.ToString());
            }

            Console.WriteLine("----");


            //Dato beregninger
            System.DateTime d1 = System.DateTime.Now;
            System.DateTime d2 = System.DateTime.Today;

            Console.WriteLine("Now: " + d1.ToString());
            Console.WriteLine("Today: " + d2.ToString());
            System.TimeSpan ts = d2.Subtract(d1);



            Console.WriteLine(ts.ToString());

            Console.ReadKey();



        }
    }
}
