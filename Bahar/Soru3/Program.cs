using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            Sayi sayi1 = new Sayi();
            sayi1.Deger = 4;

            Sayi sayi2 = sayi1; // Referencing to sayi1
            sayi2.Deger = 5; // means: sayi1.Deger = 5; 

            int sayi3 = new int();
            sayi3 = 6;
            int sayi4 = sayi3; // not referencing only sets value, means: int sayi4 = 6;

            sayi4 = 7; // sets value

            Console.WriteLine(sayi1.Deger + " " + sayi2.Deger); // 5 5
            Console.WriteLine(sayi3 + " " + sayi4); // 6 7

            Console.ReadKey();
        }
    }

    class Sayi
    {
        public int Deger { get; set; }
    }

}

/*
 * Output
 * 
    5 5
    6 7
 * 
 */