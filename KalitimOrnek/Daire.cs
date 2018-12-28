using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOrnek
{
    class Daire : Sekil
    {
        double yariCap;
        double pi = Math.PI;
        public double YariCap { get { return yariCap; } set { yariCap = value; } }
        public Daire(double y)
        {
            yariCap = y;
            this.alan = pi * Math.Pow(yariCap, 2);
            this.cevre = 2 * pi * yariCap;
        }
        public Daire()
        {

        }
    }
}
