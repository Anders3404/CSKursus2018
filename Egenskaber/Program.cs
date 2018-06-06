using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v = new Vare();
            v.Navn = "Vare 1";
            v.Pris = 100.00;
            Console.WriteLine(v.PrismedMoms());
            Vare v2 = new Vare("Vare 2", 200);
            Console.WriteLine(v2.PrismedMoms());
            Console.ReadLine();
        }
    }

    class Vare
    {

        private string _navn;

        public string Navn
        {
            get {
                Console.WriteLine("Navn læses " + _navn);
                return _navn; }
            set {
                Console.WriteLine("Navn sættes " + value);
                _navn = value; }
        }

        private double _pris;

        public double Pris
        {
            get {
                Console.WriteLine("Pris Læses " + _pris.ToString());
                return _pris; }
            set {
                Console.WriteLine("Pris sættes: " + value.ToString());
                _pris = value; }
        }

        public double PrismedMoms ()
        {
            Console.WriteLine("Der regnes moms af beløbet");
            return  this.Pris * 1.25;

        }

        public Vare(string navn, double beløb)
        {
            this.Pris = beløb;
            this.Navn = navn;

        }

        public Vare()
        {

        }


    }
}
