using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMI
{
    class Program
    {
        static void Main(string[] args)
        {
            //nuskaitytit ugi ir svori
            Console.WriteLine("Insert your length, m: ");
            var ugis = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert your weight, kg: ");
            var svoris = Convert.ToInt32(Console.ReadLine());

            //suskaiciuoti kmi 

            //atspasusdinti
            KMIcalculator kmiobject = new KMIcalculator();

            var kmi = kmiobject.GetKMI(ugis, svoris);

            Console.WriteLine(string.Format("Your KMI is : {0}", Math.Round(kmi,2)));
            //Console.WriteLine(Math.Round(kmi.GetKMI(ugis, svoris), 2));
            Console.ReadLine();
            //  Console.WriteLine(string.Format("Pirmas sakicius yra {0}, antras skaicius yra {1}", skaicius2, skaicius1));

           // kmiobject.PrintKMIStatus(kmi);
            
        }
    }
}
