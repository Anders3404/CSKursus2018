using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] løn = { 1000, 20000, 15000, 20000, 30000, 15000 };
        
        int lønsum = 0;

            for (int i = 0; i < løn.Length; i++)
            {
                Console.WriteLine(løn[i]);
                lønsum += løn[i];
            }

            double løngns = lønsum / løn.Length; 
            Console.WriteLine("Gennemsnit:" + løngns.ToString("N2") );

            Console.ReadKey();
        }
    }
}
