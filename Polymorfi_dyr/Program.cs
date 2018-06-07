using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfi_dyr
{
    class Program
    {
        static void Main(string[] args)
        {
            Dyr d1 = new Dyr();

            d1.Navn = "Trunte";

            Hund h1 = new Hund();
            h1.Navn = "Fido";

            Kat k1 = new Kat();
            k1.Navn = "Garfield";

            d1.SigNoget();
            h1.SigNoget();
            k1.SigNoget();

            Console.WriteLine("************");

            Dyr[] dyr = new Dyr[20];
            for (int i = 0; i < dyr.Length; i++)
            {
                dyr[i] = Dyr.TilfældigtDyr();
            }

            foreach (var item in dyr)
            {
                item.SigNoget();
            }

            


        }
    }

    class Dyr
    {
        public string Navn { get; set; }
        static Random rnd_navn = new Random();
        static Random rnd_dyr = new Random();
        static Random rnd = new Random();

        public virtual void SigNoget()
        {
            Console.WriteLine( "Jeg er et dyr og hedder " + Navn);
        }

        public static Dyr TilfældigtDyr() //Min løsning
        {
            string _navn;
            string sti = @"x:\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);

            

            _navn=navne[rnd_navn.Next(0, navne.Length)].ToString();

            

            if (rnd_dyr.Next(1,3)==1)
            {
                return new Hund() { Navn = _navn };

            }
            else
            {
                return new Kat() { Navn = _navn };
            }


        }

        public static Dyr TilfældigtDyr2()  //Løsning fra opgave
        {
            
            string sti = @"x:\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);

            int index = rnd.Next(0, navne.Length);

            if (index % 2 == 0)
            {
                return new Hund() { Navn = navne[index] };

            }
            else
            {
                return new Kat() { Navn = navne[index] };
            }


        }

    }

    class Hund : Dyr
    {
        
        public override void SigNoget()
        {
            Console.WriteLine( "Jeg er en hund og hedder " + Navn);
        }

    }

    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine( "Jeg er en kat og hedder " + Navn);
        }
    }
}

