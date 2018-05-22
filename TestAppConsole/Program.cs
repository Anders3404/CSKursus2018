using System;
using System.IO;
namespace TestAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string ínput = "Hello World";
            Console.WriteLine(ínput);
            Console.WriteLine("Press any key to write to file...");
            string inputcmd;
            inputcmd = Console.ReadLine();
            File.AppendAllText("c:\\temp\\minfil.txt", inputcmd + Environment.NewLine);

            //Console.WriteLine("Data written to file");
            string[] readtext = File.ReadAllLines("c:\\temp\\minfil.txt");

            foreach (string s in readtext)
            { Console.WriteLine(s); }
            Console.ReadLine();
            //TEST
            //TEST2
            Console.WriteLine("Hello World");
            
        }
    }
}
