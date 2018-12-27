using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOrnek
{
    class kare : Sekil
    {
        int kenarUzunlugu;
        public int KenarUzunlugu
        {
            get
            {
                return kenarUzunlugu;
            }
            set
            {
                if(kenarUzunlugu>0)
                kenarUzunlugu = value;
                else
                    Console.WriteLine("Sıfırdan farklı bir değer giriniz ");
            }
        }

        public double Cevre
        {
            get { return cevre; }
            set { cevre = kenarUzunlugu * 4; }
        }


        public double Alan
        {
            get { return alan; }
            set { alan = kenarUzunlugu * kenarUzunlugu; }
        }
        public kare(int kenar)
        {
            KenarUzunlugu = kenar;
        }

    }
}
