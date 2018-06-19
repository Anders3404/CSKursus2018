using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_icompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[8];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 50, Navn = "Tonto" };
            hunde[2] = new Hund() { Alder = 11, Navn = "Lady" };
            hunde[3] = new Hund() { Alder = 22, Navn = "Rex" };
            hunde[4] = new Hund() { Alder = 21, Navn = "King" };
            hunde[5] = new Hund() { Alder = 11, Navn = "Pjevs" };
            hunde[6] = new Hund() { Alder = 11, Navn = "Andy" };
            hunde[7] = new Hund() { Alder = 1, Navn = "Fido" };
            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);

            }
        }
    }

    class Hund : IComparable
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(object obj)
        {
            //Hund h = obj as Hund;
            //if (h.Alder > this.Alder)
            //    return -1;
            //if (h.Alder < this.Alder)
            //    return 1;
            //return 0;

            Hund h = (Hund)obj;
            return String.Compare(this.Navn, h.Navn);
            
        }
    }

    

}
