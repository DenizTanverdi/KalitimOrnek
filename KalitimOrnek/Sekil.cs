using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOrnek
{
    class Sekil
    {
        string sekilTip;
        sekilBoyut sekilBoyut;
        double kenarSayisi;
        internal double alan;
        internal double cevre;
        internal double hacim;
        public double Cevre
        {
            get { return cevre; }
            set { cevre = value; }
        }
        public double Alan
        {
            get { return alan; }
            set { alan = value; }
        }
        public double Hacim
        {
            get { return hacim; }
            set { hacim = value; }
        }
        public string SekilTip
        {
            get
            {
                return sekilTip;
            }
            set
            {
                sekilTip = value;
            }
        }


        // public 
    }



    enum sekilBoyut
    {
        ikiBoyut = 1,
        ucBoyut = 2
    }

    
   

}

