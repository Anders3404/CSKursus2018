using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber2
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t1 = new Trekant(10, 100);
            Console.WriteLine(t1.Areal);
            Trekant t2 = new Trekant();
            Console.WriteLine(t2.Areal);

            Console.ReadLine();
        }
    }

    class Trekant
    {
        private double _højde;

        public double Højde
        {
            get { return _højde; }
            private set { _højde = value; }
        }

        private double _grundlinje;

        public double Grundlinje
        {
            get { return _grundlinje; }
            private set { _grundlinje = value; }
        }

        public Trekant(double højde, double grundlinje)
            {
            this.Højde= højde;
            this.Grundlinje=grundlinje;
            }

        public Trekant()
        {
            this.Højde = 10;
            this.Grundlinje = 30;

        }

        private double _areal;

        public double Areal
        {
            get {
                 return this.Højde * this.Grundlinje * 0.5;
            }
            
        }

    }

}
