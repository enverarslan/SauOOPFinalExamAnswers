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
            try
            {
                int i, j, k;

                Console.Write("1. Sayıyı girin: ");

                i = Convert.ToInt32(Console.ReadLine());

                Console.Write("2. Sayıyı girin: ");

                j = Convert.ToInt32(Console.ReadLine());

                Console.Write("3. Sayıyı girin: ");

                k = Convert.ToInt32(Console.ReadLine());


                if (i > j && i > k)
                {
                    Console.WriteLine("En büyük sayı: {0}", i);
                }
                else if (j > i && j > k)
                {
                    Console.WriteLine("En büyük sayı: {0}", j);
                }
                else if (k > i && k > j)
                {
                    Console.WriteLine("En büyük sayı: {0}", k);
                }
                else
                {
                    Console.WriteLine("Sayılar birbirine eşit.");                    
                } 

            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen sadece sayı girin.");
            }

            Console.ReadKey();
        }
    }
}
