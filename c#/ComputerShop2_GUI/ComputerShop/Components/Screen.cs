using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Components
{
    public class Screen : ComputerComponent
    {
        
        public int ResolutionWidth { get; set; }
        public int ResolutionHeight { get; set; }
        public decimal ScreenSize { get; set; }
    }
}
