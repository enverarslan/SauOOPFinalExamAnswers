using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 5, sayi2 = 2;
            float sonuc = sayi1 / sayi2; // int to int divison. not float representing. for 2.5 result: atleast one side must be float type: 2.0 or 5.0
            Console.WriteLine(sonuc);
            Console.ReadKey();
        }
    }
}

/*
 * Output: 2
 * 
 */
