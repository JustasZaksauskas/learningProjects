using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School2
{
   public class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine(subject+" Explanation begins");
        }

        private string subject;

        public Teacher(string subject)
        {
            this.subject = subject;
        }


    }
}
