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
    /// Interaction logic for AddComputerWindow.xaml
    /// </summary>
    public partial class AddComputerWindow : Window
    {
        internal ListBox warehouseListBox;
        public Computer addedComputer { get; set; }
        public Shop ComputerShop { get; internal set; }
        public Label ComputerCountLabel2 { get; internal set; }

        public AddComputerWindow()
        {
            InitializeComponent();
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                new BitmapImage(new Uri("C:/Users/acer/Documents/Visual Studio 2015/Projects/ComputerShop2/laptop2.jpg", UriKind.Absolute));
            this.Background = myBrush;
        }

        public void AddComputerButton_Click(object sender, RoutedEventArgs e)
        {
            Computer addedComputer = new Computer();
            GetAddedComputer();
            addedComputer = GetAddedComputer();
            ComputerShop.Warehouse.Add(addedComputer);
            warehouseListBox.ItemsSource = ComputerShop.Warehouse;
            ComputerCountLabel2.Content = warehouseListBox.Items.Count.ToString();
            warehouseListBox.Items.Refresh();
            Close();
        }

        public Computer GetAddedComputer() {
            var addedComputer = new Computer();
            addedComputer.ID = Convert.ToInt32(IDTextBox.Text);
            addedComputer.Manufacturer = ManufacturerTextBox.Text;
            addedComputer.Model = ModelTextBox.Text;
            addedComputer.DateWhenAdded = DateTime.Now;
            return addedComputer;
        }

    }
}
