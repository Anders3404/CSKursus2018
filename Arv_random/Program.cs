using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_random
{
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.NextBool());
            Console.WriteLine(r.NextBool2());

        }
    }

    class UdvidetRandom : System.Random
    {

        public bool NextBool() //Min løsning
        {
            Random rnd = new System.Random();

            int _værdi = rnd.Next(1, 1002);

            if (_værdi <= 500)
            {
                return true;
            }
            else
            {
                return false;    
            }


        }

        public bool NextBool2() //Løsning fra opgaven
        {
            return this.Next(1, 1002) < 500;
        }

    }
}
