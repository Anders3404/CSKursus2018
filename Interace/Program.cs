using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interace
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] a = new IDbFunktioner[4];
            a[0] = new Hund() { Navn = "Fido" };
            
            a[1] = new Ubåd();
            a[2] = new Hund();
            a[3] = new Ubåd();

            foreach (var item in a)
            {
                item.Gem();
            }

        }
    }

    class Hund : IDbFunktioner
    {
        public string Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer hund...");
        }

    }

    class Ubåd : IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Tubine { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer ubåd...");
        }
    }

    interface IDbFunktioner
    {
        void Gem();
        
    }
}
