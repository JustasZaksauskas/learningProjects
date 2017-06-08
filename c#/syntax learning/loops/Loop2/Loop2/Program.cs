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
            Console.WriteLine("ivesti skaiciu:");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(skaicius + "x" + i + "=" + skaicius * i);
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{skaicius} x {i} = {skaicius * i}");
            }


            Console.ReadLine();
        }
    }
}
