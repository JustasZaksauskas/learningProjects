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
    /// Interaction logic for WarehouseWindow.xaml
    /// </summary>
    public partial class WarehouseWindow : Window
    {

        public Shop ComputerShop { get; set; }
        public string VardasPrisijungusio { get; internal set; }

        public WarehouseWindow()
        {
            ComputerShop = ComputerShopHelpers.CreateComputerShop();
            InitializeComponent();
            warehouseListBox.ItemsSource = ComputerShop.Warehouse;
            ComputerCountLabel2.Content = warehouseListBox.Items.Count.ToString();
            warehouseListBox.Items.Refresh();
            
            //backgroundui
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                new BitmapImage(new Uri("C:/Users/acer/Documents/Visual Studio 2015/Projects/ComputerShop2/laptop2.jpg", UriKind.Absolute));
            this.Background = myBrush;
        }


        public void GetGreet(string VardasPrisijungusio)
        {
            NameLabel.Content = VardasPrisijungusio;
        }


        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            var index = warehouseListBox.SelectedIndex;
            if (index==-1)
            {
                return;
            }
            ComputerShop.TakeComputerFromWarehouse(index);
            ComputerCountLabel2.Content = warehouseListBox.Items.Count.ToString();
            warehouseListBox.Items.Refresh();
        }


        private void FillterButton_Click(object sender, RoutedEventArgs e)
        {
            var manufacturer = ManufacturerTextBox.Text;
            if (manufacturer != "")
            {
                ComputerShop.Warehouse = ComputerShop.GetComputersByManufacturer(manufacturer);
                warehouseListBox.ItemsSource = ComputerShop.Warehouse;
                ComputerCountLabel2.Content = warehouseListBox.Items.Count.ToString();
                warehouseListBox.Items.Refresh();
            }
        }


        private void FillterByModelButton_Click(object sender, RoutedEventArgs e)
        {
            var model = ModelTextBox.Text;
            if (model != "")
            {
                ComputerShop.Warehouse = ComputerShop.GetComputersByModel(model);
                warehouseListBox.ItemsSource = ComputerShop.Warehouse;
                ComputerCountLabel2.Content = warehouseListBox.Items.Count.ToString();
                warehouseListBox.Items.Refresh();
            }
        }


        private void AddKnownComputer_Click(object sender, RoutedEventArgs e)
        {
            ComputerShop.PutComputerIntoWarehouseComputer4();
            warehouseListBox.Items.Refresh();
        }


        private void AddComputerByHandButton_Click(object sender, RoutedEventArgs e)
        {
            var AddComputerWindow = new AddComputerWindow();
                
                warehouseListBox.Items.Refresh();
                AddComputerWindow.ComputerShop = ComputerShop;
                AddComputerWindow.warehouseListBox = warehouseListBox;
                AddComputerWindow.ComputerCountLabel2 = ComputerCountLabel2;
                AddComputerWindow.Show();
        }


        private void AllComputersButton_Click(object sender, RoutedEventArgs e)
        {
            ComputerShop.Warehouse = ComputerShop.GetAllComputers();
            warehouseListBox.ItemsSource = ComputerShop.Warehouse.ToList();
            ComputerCountLabel2.Content = warehouseListBox.Items.Count.ToString();
            warehouseListBox.Items.Refresh();
            
        }

        private void DetailButton_Click(object sender, RoutedEventArgs e)
        {
            var index = warehouseListBox.SelectedIndex;
            if (index == -1)
            {
                return;
            }
            var DetailWindow = new DetailWindow(ComputerShop, index);
            DetailWindow.index = index;
            warehouseListBox.Items.Refresh();
            DetailWindow.ComputerShop = ComputerShop;
            DetailWindow.warehouseListBox = warehouseListBox;
            DetailWindow.Show();
        }
    }
}
