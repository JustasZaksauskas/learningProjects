using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Components
{
    public class GraphicCard : ComputerComponent
    {
        
        public string Memory
        {
            get { return Memory + " GB"; }
            set { }
        }

        public override void PrintStatus()
        {
            Console.WriteLine("Screen doesnt work, because where is not plug in");
        }
    }
}
