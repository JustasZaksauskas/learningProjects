using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sarasas = { };

            {
                Console.WriteLine("Kiek zalgiris turi pergaliu?");
                Console.WriteLine("a. 0");
                Console.WriteLine("b. 11");
                Console.WriteLine("c. 5");
                Console.WriteLine("d. 19");

                Console.ReadLine();

                string atsakymas = string.Empty;

                Console.WriteLine("Iveskite atsakymo varianta a b c d");
                while (ArTeisingasAtsakymas(atsakymas))
                {
                    atsakymas = Console.ReadLine().ToLower();
                    if (ArTeisingasAtsakymas(atsakymas))
                    {
                        Console.WriteLine("dar karta ");
                    }
                }
                Console.WriteLine("atsakymas teisingas");
                Console.ReadLine();

            }
        }
            private static bool ArTeisingasAtsakymas(string atsakymas) {
            return (atsakymas != "b" && atsakymas != "11");
        }
    }
}


