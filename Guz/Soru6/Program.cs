using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] maaslar = new int[10];

            for (int i = 0; i < 10; i++){

                Console.Write("{0}. çalışanın maaşını giriniz: ", i + 1);
                
                maaslar[i] = Convert.ToInt32(Console.ReadLine());
            }

            double ortalama = maaslar.Sum() / (double) 10;

            Console.WriteLine("10 çalışanın maaş ortalaması: {0}", ortalama);

            Console.ReadKey();


        }
    }
}
