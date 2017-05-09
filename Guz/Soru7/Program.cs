using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru7
{
    class Program
    {
        static void Main(string[] args)
        {
            int uzun, kisa, alan, cevre;
            Console.Write("Dikdörtgenin uzun kenarının uzunluğunu giriniz: ");
            uzun = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dikdörtgenin kısa kenarının uzunluğunu giriniz: ");
            kisa = Convert.ToInt32(Console.ReadLine());


            alan = uzun * kisa;
            cevre = 2 * (uzun + kisa);

            Console.WriteLine("Dikdörtgenin alanı: {0}, çevresi: {1}", alan, cevre);

            Console.ReadKey();

        }
    }
}
