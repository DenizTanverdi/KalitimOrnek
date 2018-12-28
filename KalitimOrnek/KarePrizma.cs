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
            Hacim = base.Alan * yukseklik;
            Alan =base.Cevre*yukseklik+2* base.Alan;
         
            
            
        }
    }
}
