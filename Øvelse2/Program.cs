using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1.ToString("F"));

            d1 = d1.AddDays(10);
            Console.WriteLine(d1);

            d1 = d1.AddMinutes(20);
            Console.WriteLine(d1.ToLongTimeString());

            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1.ToLongDateString());

            DateTime d2 = DateTime.Now;
            DateTime d3 = new DateTime(2018, 8, 1, 12, 0, 0);
            TimeSpan t1 = d3.Subtract(d2);
            Console.WriteLine(t1.Days.ToString() + " dage");

            TimeSpan t2 = new TimeSpan(16,0,0);
            Console.WriteLine(t2);

            TimeSpan t3 = new TimeSpan(0, 30, 0);
            Console.WriteLine(t3);

            TimeSpan t4 = t2 - t3;
            TimeSpan t6 = t2.Subtract(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t6);

            TimeSpan t5 = t2 + t3;
            Console.WriteLine(t5);




            Console.ReadKey();



        }
    }
}
