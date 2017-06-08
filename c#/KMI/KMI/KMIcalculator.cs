using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMI
{
    public class KMIcalculator : ICalculator
    {
        public double GetKMI(double ugis, int svoris) {
            var kmi = svoris / (Math.Pow(Convert.ToDouble(ugis) ,2));
            return kmi;
        }


        //public void PrintKMIStatus(double kmi) {
        //    Console.WriteLine("esi plonas");
        //}

        public void PrintResult(double result)
        {
            Console.WriteLine("esi plonas");
        }
    }
}
