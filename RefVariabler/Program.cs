using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefVariabler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            //De er tomme
            int[] myIntArray;
            int[,] myIntArray2;
            myIntArray = new int[5];

            //multi dimensionel array
            myIntArray2 = new int[5, 2];

            //Lav en array med 9 værdier
            int[] myInt3Array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(myInt3Array[0].ToString());

            //Giv en ting i array en værdi
            myInt3Array[0] = 10;
            Console.WriteLine(myInt3Array[0].ToString());


            //Giver fejl da array er defineret til 9
            //myInt3Array[10] = 1;

            Console.WriteLine("*****************");

            //Loop igennem alle 
            foreach (int i in myInt3Array)
            {
                Console.WriteLine("{0} ",i);
            }

            //loop igennem alle via tæller

            for (int i = 0; i < myInt3Array.Length; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("********SORTERET *********");

            //Sorter array
            Array.Sort(myInt3Array);
            foreach (int i in myInt3Array)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();



        }
    }
}
