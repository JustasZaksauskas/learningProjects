using ComputerShop;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ComputerShop.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly User _user= new User() { Username= "user", Password="pwd"};

        public MainWindow()
        {
            InitializeComponent();
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                new BitmapImage(new Uri("C:/Users/acer/Documents/Visual Studio 2015/Projects/ComputerShop2/laptop2.jpg", UriKind.Absolute));
            this.Background = myBrush;
        }

        public string NameLabel { get; set; }

        private void Loginbutton_Click(object sender, RoutedEventArgs e)
        {
            if (UsernameTextBox.Text == _user.Username && PasswordTextBox.Password == _user.Password)
            {
                var VardasPrisijungusio = _user.Username.ToString();
                var WarehouseWindow = new WarehouseWindow();
                WarehouseWindow.GetGreet(VardasPrisijungusio);
                WarehouseWindow.VardasPrisijungusio = VardasPrisijungusio;
                WarehouseWindow.Show();
                this.Close();
            }
            else {
                Errorlabel.Content = "Incorrect password. Please try again";
            }
        }

        

    }
}
