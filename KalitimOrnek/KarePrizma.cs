using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOrnek
{
    class KarePrizma : kare
    {
        double yukseklik;
        public double Yukseklik { get { return yukseklik; } set { yukseklik = value; } }
        public KarePrizma(double kenar,double h)
        {
            yukseklik = h;
            this.alan =4*kenar*yukseklik+2* Math.Pow(kenar, 2);
            this.hacim = kenar*kenar* yukseklik;
            
            
        }
    }
}
