using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOrnek
{
    /// <summary>
    /// Kare sınıfı ve metotları
    /// </summary>
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
                if(value>0)
                kenarUzunlugu = value;
                else
                    Console.WriteLine("Sıfırdan farklı bir değer giriniz ");
            }
        }
        /// <summary>
        /// karenin cevresini hesaplar.
        /// </summary>
        public double Cevre
        {
            get { return cevre; }
            set { cevre = kenarUzunlugu * 4; }
        }

        /// <summary>
        /// karenin alanını hesaplar.
        /// </summary>
        public double Alan
        {
            get { return alan; }
            set { alan = kenarUzunlugu * kenarUzunlugu; }
        }
        /// <summary>
        /// Kare sınıfıdır.kenar uzunluğu parametresini alır.
        /// </summary>
        /// <param name="kenar"></param>
        public kare(int kenar)
        {
            
            KenarUzunlugu = kenar;
            this.Cevre = kenar;
            this.Alan = kenar;
        }

    }
}
