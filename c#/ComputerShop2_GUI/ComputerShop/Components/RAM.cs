using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Components
{
    public class RAM : ComputerComponent
    {
       
        public string Memory
        {
            get { return Memory + " GB"; }
            set { }
        }
    }
}
