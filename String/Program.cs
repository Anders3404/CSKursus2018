using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {

            char t = 'A';



                string navn = "Pelle Gris";

            Console.WriteLine(navn);

            //Man kan ikke ændre i en tekststreng direkte
            navn = navn.Replace('e', 'y');
            Console.WriteLine(navn);

            

            //Split en fil
            string csv="324;367;678;767";

            string[] aa = csv.Split(';');

            int alder = 10;
            string navn2 = "Pelle Gris";

            //Fra C# 6 kan man skrive tekst således
            string s = $"{navn2} er {alder} år gammel";

            Console.WriteLine(s);

            //Stop ur
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            sw.Stop();


            Console.WriteLine(sw.Elapsed);

            Console.ReadKey();
        }
    }
}
