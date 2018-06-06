using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber4
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Console.ReadKey();
        }
    }

    class Terning
    {

        private int _værdi;
        private static Random rnd = new Random();

        public int værdi
        {
            get {
                Console.WriteLine("Der hentes en værdi");
                return _værdi; }
            set {
                Console.WriteLine("Der sættes en værdi");
                if (value <1 || value > 6)
                {
                    _værdi = 1;
                }
                else
                {
                    _værdi = value;
                }
            }
                
        }

        public Terning (int værdi)
        {
            if (værdi >= 1 || værdi  <= 6)
            {
                this.Ryst();
                this.værdi = værdi;
            }
            else
            {
                this.værdi = 0;
            }
            
        }

        public Terning()
        {
            this.Ryst();
        }

        public void Ryst ()
        {
           this.værdi= rnd.Next(1, 7);

        }

        public void Skriv ()
        {
            Console.WriteLine("[" + this.værdi + "]");

        }
    }
}
