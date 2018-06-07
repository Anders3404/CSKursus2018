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
            Elev e1 = new Elev();

            e1.Fornavn = "Anders";
            e1.Efternavn = "Sørensen";
            e1.Klasselokale = "Til højre";


            Console.WriteLine(e1.Skriv());

            Instruktør i1 = new Instruktør();

            i1.Fornavn = "Mickey";
            i1.Efternavn = "Mouse";
            i1.NøgleID = 1;


            Person p1 = new Person();

            p1.Fornavn = "Donald";
            p1.Efternavn = "Duck";

            Console.WriteLine(i1.Skriv());

            Person[] lst = new Person[3];
                lst[0] = p1;
            lst[1] = i1;
            lst[2] = e1;

            foreach (var item in lst)
            {
                Console.WriteLine(item.Skriv());
            }





        }
    }

    public class Person
    {

        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public virtual string Skriv()
        {
            return Fornavn + " " + Efternavn;
        }
    }

    public class Elev : Person
    {
        public string Klasselokale { get; set; }

        public override string Skriv()
        {
            return Fornavn + " " + Efternavn + ". I klasselokale: " + Klasselokale;
        }

    }

    class Instruktør : Person
    {
        public int NøgleID { get; set; }

        public override string Skriv()
        {
            return Fornavn + " " + Efternavn + ". NøgleID: " + NøgleID;
        }


    }
}
