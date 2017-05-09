using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {

            var liste = new List<int> { 1, 6, 3, 8, 3 };
            liste.RemoveAt(3); // 1,6,3,3
            liste.Add(7); // 1,6,3,3,7
            liste.RemoveAt(3); // 1,6,3,7

            foreach (var eleman in liste)
            {
                Console.Write(eleman);
            }

            // 1637

            Console.ReadKey();
        }
    }
}

/*
 * Output
    
    1637

 * 
 */