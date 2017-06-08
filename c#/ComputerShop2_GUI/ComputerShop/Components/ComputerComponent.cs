using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Components
{
    public abstract class ComputerComponent
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public void PrintManufacturerAndName() {
            Console.WriteLine("Gamintojas: " + Manufacturer + "Modelis " + Model);
        }


        //sita galima overridint (perasyti)
        public virtual void PrintSomething() {
            
            Console.WriteLine("Component");
        }

        //visi komponentai galetu isspausdinti savo statusa. neturi logikos tiktai isprintinti. visi komponentai!!
        //public abstract void PrintStatus();

        public virtual void PrintStatus() {
            Console.WriteLine("Allthing is great");
        }

    }
}
