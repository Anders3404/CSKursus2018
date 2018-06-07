using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Elev p1 = new Elev();

            p1.Fornavn = "Anders";
            p1.Efternavn = "Sørensen";
            p1.Klasselokale "Til højre"
            

            

            Console.WriteLine(p1.FuldtNavn());

        }
    }

    public class Person
    {

        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }
    }

    public class Elev : Person
    {
        public string Klasselokale { get; set; }


    }

    class Instruktør : Person
    {
        public int NøgleID { get; set; }
    }
}
