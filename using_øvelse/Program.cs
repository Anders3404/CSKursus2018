using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using_øvelse
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList a = new System.Collections.ArrayList();
            using (System.IO.StreamReader stream = System.IO.File.OpenText(@"x:\dyrenavne.txt"))
            {
                while (stream.Peek() != -1)
                {
                    string navn = stream.ReadLine();
                    a.Add(navn);
                    

                }
            }
            a.Sort();

            foreach (var item in a)
            {
                Console.WriteLine(  item.ToString());

            }

        }
    }

    class Person : IComparable
    {
        public string Navn { get; set; }

        public int CompareTo (object obj)
        {
            Person p = (Person)obj;
            return String.Compare(this.Navn, p.Navn);
        }
    }
}
