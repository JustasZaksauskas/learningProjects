using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ivesti skaiciu:");
            var aukstis = Convert.ToInt32(Console.ReadLine());

            int tarpai = aukstis - 1;
            //atspausdina eilutes
            for (int i = 1; i <= aukstis; i++)
            {
                for (int k = tarpai; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                tarpai--;
                //Console.WriteLine(i);
                //atsapausdina skaicius
                for (int j = 1 ; j <= i ; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
