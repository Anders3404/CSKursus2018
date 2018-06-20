using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            FileCheck();

            do
            {

            } while (true);
        }

        private static void FileCheck()
        {
            FileSystemWatcher w = new FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.Changed += W_Changed;
            w.Created += (s, e) => { Console.WriteLine("Oprettet " + e.FullPath); };
            w.Deleted += (s, e) => { Console.WriteLine("Filen er slettet.  " + e.FullPath); };
        }

        private static void W_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Tekst er tilføjet: " + e.Name);
        }
    }
}
