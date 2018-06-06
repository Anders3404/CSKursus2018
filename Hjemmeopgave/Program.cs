using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hjemmeopgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Person k1 = new Person();
            Person k2 = new Person();

            k1.navn = "a";
            k2.navn = "b";

            Console.WriteLine("Person 1:" + k1.navn);
            Console.WriteLine("Person 2:" + k2.navn);

            k2.navn = k1.navn;

            Console.WriteLine("Person 1:" + k1.navn);
            Console.WriteLine("Person 2:" + k2.navn);

            k1.navn = "c";

            Console.WriteLine("Person 1:" + k1.navn);
            Console.WriteLine("Person 2:" + k2.navn);


            Console.ReadLine();

        }
    }

    class Person
    {
        public string navn;
    }
}
