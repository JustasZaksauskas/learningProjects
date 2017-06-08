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
            Console.WriteLine("Iveskite pazymi");
            var pazymys = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Iveskite antra skaiciu");
            //var skaicius2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Iveskite trecia skaiciu");
            //var skaicius3 = Convert.ToInt32(Console.ReadLine());

            if (pazymys > 10 || pazymys < 1) {
                Console.WriteLine("ivedete ne pazymi");
                return;
            }

            switch (pazymys)
            {
                case 10:
                    Console.WriteLine(" yra puiku");
                    break;
                case 9:
                case 8:
                    Console.WriteLine(" labai gerai");
                    break;
                case 7:
                case 6:
                    Console.WriteLine("gerai");
                    break;
                case 5:
                    Console.WriteLine("vid");
                    break;
                case 4:
                    Console.WriteLine("bent teigiamas");
                    break;         
                default:
                    Console.WriteLine("blogai");
                    break;
            }


            //if (pazymys==10)
            //{
            //    Console.WriteLine(" yra puiku");
            //}
            //else if(pazymys==9 || pazymys==8)
            //{
            //    Console.WriteLine(" labai gerai");
            //}
            // else if (pazymys == 7 || pazymys == 6)
            //{
            //    Console.WriteLine("gerai");
            //}
            //if (pazymys == 5)
            //{
            //    Console.WriteLine("vid");
            //}
            //if (pazymys == 4)
            //{
            //    Console.WriteLine("bent teigiamsa");
            //}
            //else {
            //    Console.WriteLine("blogai");
            //}


            Console.ReadLine();

            //Console.WriteLine(string.Concat(vardas, " ", pavarde, " gime ", vieta));
            //pasako kaip norime suformotuoti savo string formata
            // Console.WriteLine(string.Format("{0} {1} gyvena {2}", vardas, pavarde, vieta));
        }
    }
}
