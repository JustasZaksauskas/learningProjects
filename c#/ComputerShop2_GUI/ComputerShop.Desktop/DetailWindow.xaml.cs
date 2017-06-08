using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ComputerShop.Desktop
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        public int index { get; internal set; }
        public Shop ComputerShop { get; internal set; }
        public ListBox warehouseListBox { get; internal set; }
        public Computer Computer { get; set; }

        public DetailWindow(Shop shop, int index) {
            ComputerShop = shop;
            Computer = ComputerShop.GetComputer(index);
            InitializeComponent();

            //backgroundui
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                new BitmapImage(new Uri("C:/Users/acer/Documents/Visual Studio 2015/Projects/ComputerShop2/laptop2.jpg", UriKind.Absolute));
            this.Background = myBrush;

            ComputerID.Text = "ID: " + Computer.ID.ToString();
            ComputerManufacturer.Text = "Manufacturer: " + Computer.Manufacturer;
            ComputerModel.Text = "Model: " + Computer.Model;
            ComputerCPU.Text = "CPU: " + Computer.CPU.Manufacturer + " " + Computer.CPU.Model;
            ComputerGraphicCard.Text = "GraphicCard: " + Computer.GraphicCard.Manufacturer + " " + Computer.GraphicCard.Model;
            ComputerRAM.Text = "RAM: " + Computer.RAM.Manufacturer + " 8 GB";

        }
    }
}
