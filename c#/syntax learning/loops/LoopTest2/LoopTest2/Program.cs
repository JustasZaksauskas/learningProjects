using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite piramides auksti");
            var aukstis = Convert.ToInt32(Console.ReadLine());
            int tarpai = 0;


            for (int i = aukstis; i >= 1; i--)
            {

                for (int k = 1; k <= tarpai; k++)
                {
                    Console.Write(" ");
                }

                tarpai++;

                for (int j = 1; j <=i; j++)
                {
                    if (i != 7)
                    {
                        Console.Write("*" + " ");
                    }
                    else {
                        Console.Write(i + " ");
                    }
                    
                }

                Console.WriteLine();
            }
            Console.ReadLine();
            
        }
    }
}
