using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Components
{
    public class CPU : ComputerComponent
    {
        
        public decimal Frequency { get; set; }

        public override void PrintSomething()
        {
            base.PrintSomething();
            Console.WriteLine("CPU");
        }

        //public override void PrintStatus()
        //{
        //    Console.WriteLine("CPU veikia labai gerai");
        //}
    }
}
