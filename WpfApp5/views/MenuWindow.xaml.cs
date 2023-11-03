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

namespace WpfApp5.views
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void User_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.Show();
            this.Close();
        }
        private void Product_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.Show();
            this.Close();
        }
        private void Orders_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
