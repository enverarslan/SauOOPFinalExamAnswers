using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3
{
    class Program {
        int i = 10;
        int j;
        char z = (char)5;
        bool b;
        static void Main(string[] args) {
            Program p = new Program();
            p.amethod();
            Console.ReadKey();
        }
        public void amethod() {
            Console.WriteLine(j);
            Console.WriteLine(b);
        }
    }
}

/*
 * Output
 * 
    0
    False 
 * 
 */