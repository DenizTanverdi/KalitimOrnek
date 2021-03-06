﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOrnek
{
    class Silindir:Daire
    {
        private double yukseklik;

        public double Yukseklik
        {
            get { return yukseklik; }
            set { yukseklik = value; }
        }
        public Silindir(double h,double r):base(r)
        {
            Yukseklik = h;
            Hacim = base.Alan * yukseklik;
            Alan = 2 * base.Alan + base.Cevre * yukseklik;
        }

    }
}
