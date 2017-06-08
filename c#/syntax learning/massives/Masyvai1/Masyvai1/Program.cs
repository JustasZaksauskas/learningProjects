using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masyvai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masyvas = new int[5];


            Console.WriteLine("iveskite 5 sakicius");
            for (int i = 0; i < 5; i++)
            {
               
                masyvas[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.Write(masyvas[i]);
            }

            Console.Write(masyvas[0]);
            Console.ReadLine();

        }
    }
}
