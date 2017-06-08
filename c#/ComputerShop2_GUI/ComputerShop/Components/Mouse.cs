using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Components
{
    public enum MouseType {
        Optical, Laser, Wireless
    }
   public class Mouse : IODevice
    {
        public MouseType MouseType { get; set; }

    }
}
