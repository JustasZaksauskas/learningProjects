using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School2
{
    public class Person
    {
        public int Age { get; set; }
        public string FullName { get; set; }


        public void ShowAge()
        {
            Console.WriteLine($"I'm {Age} years old");
        }

        public void Greet() {
            Console.WriteLine("Hello");
        }

    }

}
