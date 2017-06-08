using ComputerShop.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    public class Computer : ComputerComponent
    {
        public Computer()
        {
            IODevices = new List<IODevice>();            
        }
        public int  ID { get; set; }
        public CPU CPU { get; set; }
        public RAM RAM { get; set; }
        public List<IODevice> IODevices { get; set; }
        public Screen Screen { get; set; }
        public GraphicCard GraphicCard { get; set; }
        public DateTime DateWhenAdded { get; set; }
        public string DateWhenAddedString { get { return DateWhenAdded.ToShortDateString(); } }

        public void TurnOff() {
            
        }

        public void TurnOn()
        {

        }

        public void Sleep()
        {

        }
    }
}
