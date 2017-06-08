using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedCal
{
    class Program
    {
        static void Main(string[] args)
        {
            //inset lenght
            Console.WriteLine("Iveskite atstuma metrais");
            var atstumas = Convert.ToInt32(Console.ReadLine());

      
            //insert time
            Console.WriteLine("Iveskite laika sekundemi");
            var laikas = Convert.ToInt32(Console.ReadLine());

            //convert m/s to km/h
            //calculate speed
            var greitis = 3.6 * (atstumas / laikas);

            Console.WriteLine("Greits km/h yra:" + Math.Round(greitis, 0));
            Console.ReadLine();

        }
    }
}
