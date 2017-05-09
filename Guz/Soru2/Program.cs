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
            int[] t = new int[10] { 9, 2, 7, 4, 8, 1, 6, 5, 3, 0 };
            int k = 0;
            for (int i = 0; i < 10; i++) {
                if (t[i] % 2 == 0)
                {
                    int temp = t[i];
                    t[i] = t[k];
                    t[k] = temp;
                    k++;
                }
            }
            for (int i = 0; i < 10; i++)
                Console.WriteLine(t[i]);

            Console.ReadKey();
        }
    }
}

/*
 * Output
 * 
    2
    4
    8
    6
    0
    1
    9
    5
    3
    7
 * 
 */