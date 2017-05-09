using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            double k, alan;

            Console.Write("a için değer giriniz: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b için değer giriniz: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("c için değer giriniz: ");
            c = Convert.ToInt32(Console.ReadLine());

            k = 0.5 * (a + b + c);

            alan = Math.Sqrt(k * (k - a) * (k - b) * (k - c)); // uses square root or will be using Math.Pow(value, 1/2) accepted.

            Console.WriteLine(alan);

            Console.ReadKey();
        }
    }
}
