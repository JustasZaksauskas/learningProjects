using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masyvai4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] atsakymai = new string[2, 4] {
               {"1", "2", "3", "4"},
               {"a", "b", "c", "d"},
            };

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(atsakymai[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}
