using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School2
{
    public class Student : Person
    {
        public decimal Avarage { get; set; }

        static void GoToClasses() {
            Console.WriteLine("I'm going to classes");
        }


    }
}
