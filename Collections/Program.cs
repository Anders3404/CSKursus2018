using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.List<Person> p = new List<Person>();
            p.Add(new Person() { Id = 4, Navn = "A" });
            p.Add(new Person() { Id = 3, Navn = "B" });
            p.Add(new Person() { Id = 2, Navn = "C" });
            p.Add(new Person() { Id = 1, Navn = "D" });

            
            foreach (var item in p)
            {
                Console.WriteLine(item.Id.ToString() + " " + item.Navn);
            }



            System.Collections.Generic.Dictionary<int, Person> p2 = new Dictionary<int, Person>();

            p2.Add(1, new Person { Id = 1, Navn = "Anders" });
            p2.Add(2, new Person { Id = 2, Navn = "Linda" });
            p2.Add(3, new Person { Id = 3, Navn = "Ville" });
            p2.Add(4, new Person { Id = 4, Navn = "Gunvald" });

            Console.WriteLine(p2[3].Navn);

            foreach (var item in p2)
            {
                Console.WriteLine(item.Key.ToString());
                Console.WriteLine(p2[item.Key].Navn);
            }

        }
    }

    class Person 
    {
        public int Id { get; set; }
        public string Navn { get; set; }



    }    
}
