using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X değerini girin: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;

            for (int i = 1; i <= x; i++)
            {
                if (i % 3 == 0)
                {
                    toplam += i;
                }
            }

            Console.WriteLine("Toplam değeri: {0}", toplam);

            Console.ReadKey();
        }
    }
}
