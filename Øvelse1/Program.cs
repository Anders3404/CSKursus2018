using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse1
{
    class Program
    {
        static void Main(string[] args)
        {
            int heltal = 10;
            heltal++;
            heltal--;
            heltal += 20;
            Console.WriteLine(heltal.ToString());

            double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal *= 2;
            Console.WriteLine(kommatal.ToString());

            FilTyper Ft = FilTyper.csv;
            Console.WriteLine(Ft);
            Console.WriteLine((int)Ft);

            DateTime dato = DateTime.Now;
            Console.WriteLine(dato.ToString("ddMMyy"));
            Console.WriteLine(dato.ToString("dMy"));
            Console.WriteLine(dato.ToLongDateString());


            Person p;
            p.id = 1;
            p.Navn = "Mikkel";

            Console.WriteLine(p.Navn);





            Console.ReadKey();
        }
public enum FilTyper
        {
            csv,
            pdf,
            txt
        }

        struct Person
        {
            public int id;
            public string Navn;
                }
    }
}
