using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties1
{
    class Class1
    {
        public string Name { get; set; }

        private string Pavarde { get; set; }

        public int Amzius { get; private set; }

        public int Metai { get; }

        public string FullName
        {
            get
            {
                return Name + " " + Pavarde;
            }
        }

        public string FullName2 => Name + " " + Pavarde;

        public string FullName3
        {
            get { return Name; }
            set { }
        }

        public string ModernusVardas {
        get { return Name + "s"; }
            set { Name = value + "a"; }
        }



    }
}
