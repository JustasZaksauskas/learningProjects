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
            Console.WriteLine("Iveskite varda");
            var vardas = Console.ReadLine();
            Console.WriteLine("Iveskite pavarde");
            var pavarde = Console.ReadLine();
            Console.WriteLine("Iveskite amziu");
            var amzius = Convert.ToInt32(Console.ReadLine());

            if (amzius>=18)
            {
                Console.WriteLine(string.Concat(vardas, " ", pavarde, " gali balsuoti rinkimuose "));
            }
            else
            {
                Console.WriteLine(string.Concat(vardas, " ", pavarde, " negali balsuoti rinkimuose "));
            }
            Console.ReadLine();

            //Console.WriteLine(string.Concat(vardas, " ", pavarde, " gime ", vieta));
            //pasako kaip norime suformotuoti savo string formata
           // Console.WriteLine(string.Format("{0} {1} gyvena {2}", vardas, pavarde, vieta));



        }
    }
}
