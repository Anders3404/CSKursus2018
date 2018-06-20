using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    class Program
    {
        static void Main(string[] args)
        {
            Maskine m = new Maskine();
            m.Log = Console.WriteLine;
            m.Log += AppendLog;

            

            for (int i = 0; i < 99; i++)
            {
                Random waittime = new Random();

                m.Start();
                m.Stop();
                System.Threading.Thread.Sleep(waittime.Next(1000,10000));
                m.Start();
                m.Stop(); 
            }
        }

        static void AppendLog(string txt)
            {
            System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");
        }
        
    }
    public delegate void LogDelegate(string txt);

    public class Maskine
    {
        public LogDelegate Log { get; set; }
        public void Start()
        {
            Log(DateTime.Now.ToUniversalTime() + " Starter");
        }

        public void Stop()
        {
            Log(DateTime.Now.ToUniversalTime() + " Stopper");
        }
    }
}
