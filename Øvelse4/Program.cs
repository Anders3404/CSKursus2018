using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse4
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";

            string samletnavn = fornavn + " " + efternavn;

            string navnStort = samletnavn.ToUpper();

            string navnLille = samletnavn.ToLower();

            string del = samletnavn.Substring(7, 4);
            Console.WriteLine("**************");

            //Find det automatisk
            string del2 = samletnavn.Substring(samletnavn.IndexOf("Cron"),4);
            Console.WriteLine(del2);

            string[] aa = samletnavn.Split(' ');

            for (int i = 0; i < aa.Length; i++)
            {
                Console.WriteLine(aa[i]);
            }

            Console.WriteLine("Press any key!");
            Console.ReadKey();

        }
    }
}
