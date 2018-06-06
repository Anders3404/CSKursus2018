using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse8
{
    class Program
    {
        static void Main(string[] args)
        {
            Person A = new Person();

            
            A.Fornavn = "Anders";
            A.Efternavn = "Sørensen";
            A.Fødselsår = 1976;

            Console.WriteLine("Alder:" + A.Alder().ToString());
            Console.WriteLine("Fuldenavn: " + A.Fuldtnavn());
            Console.ReadLine();
        }
    }

    class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;


        public string Fuldtnavn()
        {
            return Fornavn + " " + Efternavn;

        }

        public int Alder()
        {
            return System.DateTime.Now.Year - this.Fødselsår;

        }

        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";

        }

        public Person(string Fornavn, string Efternavn, int Fødselsår)
        {
            this.Fornavn = Fornavn.ToUpper();
            this.Efternavn = Efternavn.ToUpper();
            this.Fødselsår = Fødselsår;
        }
    }
}


