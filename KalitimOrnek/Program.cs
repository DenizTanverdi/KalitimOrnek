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
            Console.WriteLine($"Karenin Alan :{dk.alan}");
            Console.WriteLine($"Karenin Cevresi:{ dk.cevre}");
         
            Console.ReadLine();
                
        }
    }
   
   
}
