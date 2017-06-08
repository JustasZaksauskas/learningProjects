using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Components
{
    public enum IOType {
        Mouse,
        Keyboard,
        CDrive
    }   

    public class IODevice : ComputerComponent
    {
        public IOType Type { get; set; }
    }
}
