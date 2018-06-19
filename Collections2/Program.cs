using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bunke b =new Bunke();
            b.TilføjKort(new Kort() { Kulør = "Spar", Værdi=2 });
            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 12 });
            b.TilføjKort(new Kort() { Kulør = "Klør", Værdi = 11 });
            b.TilføjKort(new Kort() { Kulør = "Spar", Værdi = 7 });
            b.Vis();
            b.Antal();
            Console.WriteLine("Der fjernes " + b.Fjernkort().ToString());
            b.Vis();
            b.Antal();
            Console.WriteLine("Der fjernes " + b.Fjernkort().ToString());
            b.Vis();
            b.Antal();
            Console.WriteLine("Der fjernes " + b.Fjernkort().ToString());
            b.Vis();
            b.Antal();
            Console.WriteLine("Der fjernes " + b.Fjernkort().ToString());
            b.Vis();
            b.Antal();
 



        }
    }

    public class Kort
    {
        public string Kulør { get; set; }
        public int Værdi { get; set; }
        public override string ToString()
        {
            return this.Kulør + " " + this.Værdi;
        }

    }

    public class Bunke
    {
        private Stack<Kort> bunke = new Stack<Kort>();

        public void TilføjKort(Kort K)
        {
            if (bunke.Count < 4)
            bunke.Push(K);
            else
            {
                Console.WriteLine("Fusk, for mange kort i bunken");
            }
        }

        public Kort Fjernkort()
        {
            if (bunke.Count > 0)
            {
               return bunke.Pop();
            }
            return null;
            
        }

        public void Vis()
        {
            foreach (var item in bunke)
            {
                Console.WriteLine(item);
                

            }
            Console.WriteLine();
        }

        public void Antal()
        {
            if (bunke.Count == 0)
            {
                Console.WriteLine("Bunken er tom");

            }
            else if (bunke.Count > 0)
            {
                Console.WriteLine("Der er " + bunke.Count.ToString() + " kort i bunken");
            }
        }

    }
}
