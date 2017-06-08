using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu");
            var skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu;");
            var skaicius2 = Convert.ToInt32(Console.ReadLine());

            if (skaicius1 == skaicius2) {
                Console.WriteLine("skaiciai yra lygus");
            } else {
                Console.WriteLine("skaiciai nera lygus");
                    }
            Console.ReadLine();

        }
    }
}
