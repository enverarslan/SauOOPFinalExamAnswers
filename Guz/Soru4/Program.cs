using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru4
{
    class Program { 
        static void Main(string[] args) { 
            int[] a = new int[] { 1, 2, 3, 4 };
            Degisim.degistir(a); 
            Console.WriteLine(a[0]);
            Console.ReadKey();
        }
    }
    class Degisim {
        public static void degistir(int[] a) {
            a[0] = 7;
        }
    } 
}

/**
 * Output
 *
 * 
    7
 * 
 */
