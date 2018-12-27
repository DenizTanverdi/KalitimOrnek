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

