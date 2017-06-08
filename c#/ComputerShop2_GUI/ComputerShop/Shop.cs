using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    public class Shop
    {
        public Shop()
        {
            Warehouse = new List<Computer>();        }

        public List<Computer> Warehouse { get; set; }
        public object NameLabel { get; private set; }

        public void PutComputerIntoWarehouse(Computer computer) {
            computer.DateWhenAdded = DateTime.Now;
            Warehouse.Add(computer);
        }

        public void PutComputerIntoWarehouseComputer4()
        {
            Warehouse.Add(new Computer() { ID = 38999, Manufacturer = "acer", Model = "2525G", DateWhenAdded = DateTime.Now });
        }


        public Computer TakeComputerFromWarehouse(int index)
        {
            var item = Warehouse[index];
            Warehouse.Remove(item);
            return item;
        }


        public Computer TakeComputerFromWarehouse(Computer computer)
        {
            var index = Warehouse.IndexOf(computer);
            var item = Warehouse[index];
            Warehouse.Remove(item);

            return item;
        }


        public Computer TakeComputerFromWarehouseByID(int id) {
          var paimtasPC=  Warehouse.FirstOrDefault(computer => computer.ID == id);
            return paimtasPC;
        }

        public void PrintWarehouseContent() {
            foreach (var computer in Warehouse)
            {
                Console.WriteLine(computer.Manufacturer + " " + computer.Model);
            }
        }

        public List<Computer> GetAllComputers()
        {
            var allComputers = Warehouse.ToList();
            return allComputers;
        }

        public List<Computer> GetComputersByDate(DateTime date)
        {
            var computersByDate = Warehouse.Where(item => item.DateWhenAdded >= date).ToList();
            return computersByDate;
        }

        public List<Computer> GetComputersByManufacturer(string manufacturer)
        {
            var computersByRequestedManufacturer = Warehouse.Where(item => item.Manufacturer == manufacturer).ToList();
            return computersByRequestedManufacturer;
        }
        public List<Computer> GetComputersByModel(string model)
        {
            var computersByRequestedModel = Warehouse.Where(item => item.Model == model).ToList();
            return computersByRequestedModel;
        }

        public List<Computer> GetComputersByManufacturerAndModel(string manufacturer, string model)
        {
            var computersByManufacturerAndModel = Warehouse.Where(item => item.Manufacturer == manufacturer && item.Model == model).ToList();
            return computersByManufacturerAndModel;
        }

        public List<Computer> GetComputersByCPUManufacturerAndModel(string manufacturer, string model)
        {
            var computersByCPUManufacturerAndModel = Warehouse.Where(item => item.CPU.Manufacturer == manufacturer && item.CPU.Model == model).ToList();
            return computersByCPUManufacturerAndModel;
        }

        public Computer GetComputer(int index) {
            var item = Warehouse[index];
            return item;
        }

        public static string Greet(string greet)
        {

            return greet;
        }

        public List<Computer> GetComputersByManufacturerOnly(string manufacturer)
        {
            var computersByManufacturerOnly = Warehouse.Where(
                computer => computer.CPU.Manufacturer == manufacturer 
            || computer.GraphicCard.Manufacturer == manufacturer
            || computer.RAM.Manufacturer == manufacturer).ToList();
            return computersByManufacturerOnly;
        }

    }
}
