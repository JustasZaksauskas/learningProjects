using ComputerShop.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    public static class ComputerShopHelpers
    {
        public static Shop CreateComputerShop() {
            //Sukurti 1 kompiuteriu parduotuve
            var computerShop = new Shop();

            //Sukurti 3 kompiuteris
            var computer = new Computer();
            computer.ID = 38001;
            computer.Manufacturer = "Apple";
            computer.Model = "Macbook Pro Retina";
            computer.DateWhenAdded = DateTime.Now;

            var computer2 = new Computer();
            computer2.ID = 38002;
            computer2.Manufacturer = "acer";
            computer2.Model = "5750G";
            computer2.DateWhenAdded = DateTime.Now.AddDays(-1);

            var computer3 = new Computer();
            computer3.ID = 38003;
            computer3.Manufacturer = "Asus";
            computer3.Model = "Inspiron 15";
            computer3.DateWhenAdded = DateTime.Now.AddDays(-2);

            var computer4 = new Computer();
            computer4.ID = 38004;
            computer4.Manufacturer = "Lenovo";
            computer4.Model = "6675H";
            computer4.DateWhenAdded = DateTime.Now.AddDays(-2);

            var computer5 = new Computer();
            computer5.ID = 38005;
            computer5.Manufacturer = "acer";
            computer5.Model = "6575G";
            computer5.DateWhenAdded = DateTime.Now.AddDays(-2);

            var computer6 = new Computer();
            computer6.ID = 38006;
            computer6.Manufacturer = "Dell";
            computer6.Model = "Inspirion 15";
            computer6.DateWhenAdded = DateTime.Now.AddDays(-2);

            var screen = new Screen();
            screen.Manufacturer = "Apple";
            screen.Model = "Pro123";
            var screen2 = new Screen();
            screen.Manufacturer = "HDScreens";
            screen.Model = "HD";
            computer.Screen = screen;
            computer2.Screen = screen2;
            computer3.Screen = screen2;

            var ioDevice = new IODevice();
            ioDevice.Type = IOType.Mouse;
            ioDevice.Manufacturer = "Logitech";
            ioDevice.Model = "G156";
            computer.IODevices.Add(ioDevice);
            computer2.IODevices.Add(ioDevice);
            computer3.IODevices.Add(ioDevice);


            var mouse = new Mouse();
            mouse.Type = IOType.Mouse;
            mouse.Manufacturer = "Logitech";
            mouse.Model = "G156";
            mouse.MouseType = MouseType.Laser;


            var RAM = new RAM();
            RAM.Manufacturer = "Transcend";
            RAM.Model = "DDR3";
            RAM.Memory = "8";
            computer.RAM = RAM;
            computer2.RAM = RAM;
            computer3.RAM = RAM;

            var CPU = new CPU();
            CPU.Manufacturer = "intel";
            CPU.Model = "i5";
            computer.CPU = CPU;
            computer2.CPU = CPU;
            computer3.CPU = CPU;


            var GraphicCard = new GraphicCard();
            GraphicCard.Manufacturer = "NVIDIA";
            GraphicCard.Model = "GTX 1080";
            GraphicCard.Memory = "8";
            computer.GraphicCard = GraphicCard;
            computer2.GraphicCard = GraphicCard;
            computer3.GraphicCard = GraphicCard;

            //Padeti i sandeli 3 kompiuterius
            computerShop.PutComputerIntoWarehouse(computer);
            computerShop.PutComputerIntoWarehouse(computer2);
            computerShop.PutComputerIntoWarehouse(computer3);
            computerShop.PutComputerIntoWarehouse(computer4);
            computerShop.PutComputerIntoWarehouse(computer5);
            computerShop.PutComputerIntoWarehouse(computer6);

            return computerShop;
        }

    }
}
