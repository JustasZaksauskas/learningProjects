using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLenghtAndArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //read lenght
            Console.WriteLine("Insert radiuus:");
            int spindulys = Convert.ToInt32(Console.ReadLine());
            // var spindulys2 = Convert.ToInt32(Console.ReadLine()); KONVERTUOT REIKIA NES IVEDAM MES I STRING
            //calcuteate lenght
            var ilgis = 2 * Math.PI * spindulys;
            //calculate area
            var plotas = Math.PI * Math.Pow(spindulys, 2);
            //write
            Console.WriteLine("Apskritimo ilgis:" + Math.Round(ilgis, 2) + "  Apskritimo plots " + Math.Round(plotas, 2));
            Console.ReadLine();
        }
    }
}
