using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHILE1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveski fraze");
            var fraze = Console.ReadLine();

            int i = 0;
            while (i<10)
            {
                Console.WriteLine($"{i+1} {fraze}");
                i++;
            }
            Console.ReadLine();
        }
    }
}
