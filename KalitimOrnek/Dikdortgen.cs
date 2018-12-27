using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOrnek
{
    class dikDörtgen : Sekil
    {
        double kısaKenar, uzunKenar;
        public double KısaKenar { get { return kısaKenar; } set { kısaKenar = value; } }
        public double UzunKenar { get { return uzunKenar; } set { uzunKenar = value; } }
        public double Cevre
        {
            get { return cevre; }
            set { cevre = 2*(kısaKenar +uzunKenar); }
        }
        public double Alan
        {
            get { return alan; }
            set { alan = kısaKenar *uzunKenar; }
        }
        public dikDörtgen(double kısa,double uzun)
        {
            KısaKenar = kısa;
            UzunKenar = uzun;
            this.Alan = kısa;
            this.Cevre = uzun;
        }
    }
}
