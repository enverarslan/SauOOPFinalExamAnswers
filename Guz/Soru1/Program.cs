using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.ReadKey();
            
        }

        public Program() {
            for (int i = 10; i > 2; i--)
                Console.Write(i);
        }
    }
}

/*
 * Output 
 * 
 * 109876543
 *  
 */

