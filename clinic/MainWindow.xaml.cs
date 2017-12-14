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

namespace clinic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login_Management managementLogin = new Login_Management();
            managementLogin.Owner = this; //panjereye valede panjereye login ra taeen mikonad
            managementLogin.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Login_Doctor doctorLogin = new Login_Doctor();
            doctorLogin.Owner = this; //panjereye valede panjereye login ra taeen mikonad
            doctorLogin.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Login_Reception receptionLogin = new Login_Reception();
            receptionLogin.Owner = this;
            receptionLogin.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Login_Laboratory laboratoryLogin = new Login_Laboratory();
            laboratoryLogin.Owner = this;
            laboratoryLogin.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Login_Injections injectionLogin = new Login_Injections();
            injectionLogin.Owner = this;
            injectionLogin.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Login_Inventory inventoryLogin = new Login_Inventory();
            inventoryLogin.Owner = this;
            inventoryLogin.ShowDialog();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
