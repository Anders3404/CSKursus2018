using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Fornavn = "Bo";
            p1.Efternavn = "Bo";
            Console.WriteLine(p1.Fuldtnavn());

            Person p2 = new Person();
            p2.Fornavn = "Anders";
            p2.Efternavn = "Sørensen";
            Console.WriteLine(p2.Fuldtnavn());

            Console.ReadKey();
            


        }
    }

    class Person
    {
        public string Fornavn { get; set; }

        private string _efternavn;

        public string Efternavn
        {
            get { return _efternavn; }
            set {
                if (value.Length<3)
                {
                    _efternavn = "";
                }
                else
                {
                _efternavn = value;
                }
            }
        }

        public string Fuldtnavn ()
        {
            return this.Fornavn + " " + this._efternavn;
        }


    }


}
