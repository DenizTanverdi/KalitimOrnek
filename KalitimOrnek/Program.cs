using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            kare k = new kare(5);
            dikDörtgen dk = new dikDörtgen(5,3);
            KarePrizma kp = new KarePrizma(5,4);
            Daire d = new Daire(3);
            Silindir s = new Silindir(3,3);
            Console.WriteLine($"Karenin Alan :{k.alan}");
            Console.WriteLine($"Karenin Cevresi:{ k.cevre}");
            Console.WriteLine($"Dikdörtgenin Alanı :{dk.alan}");
            Console.WriteLine($"Dikdörtgenin Cevresi:{ dk.cevre}");
            Console.WriteLine($"Kare Prizmanın Alanı :{kp.alan}");
            Console.WriteLine($"Kare Prizmanın Hacmi:{ kp.hacim}");
            Console.WriteLine($"Dairenın Alanı :{d.alan}");
            Console.WriteLine($"DDairenın Cevresi:{ d.cevre}");
            Console.WriteLine($"Silindirin Alanı :{s.alan}");
            Console.WriteLine($"Silindirin hacmi:{ s.hacim}");

            Console.ReadLine();
                
        }
    }
   
   
}
