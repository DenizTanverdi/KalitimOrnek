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
        public KarePrizma(int kenar,double h):base(kenar)
        {
            yukseklik = h;
            this.alan =base.cevre*yukseklik+2* base.alan;
            this.hacim = base.alan* yukseklik;
            
            
        }
    }
}
