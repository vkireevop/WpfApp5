using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp5.views
{
    /// <summary>
    /// Логика взаимодействия для Product.xaml
    /// </summary>
    public partial class Product : Window
    {
        public Product()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            AddDialog.Visibility = Visibility.Hidden;
            dialog.Visibility = Visibility.Hidden;
            DataGridRefresh();
        }
        public void DataGridRefresh()
        {
            DataTable dataTable = WpfLibrary1.Product.getTable();
            dataGrid.ItemsSource = dataTable.DefaultView;
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            this.Close();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            dialog.Visibility = Visibility.Visible;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddDialog.Visibility = Visibility.Visible;
        }

        private void deletestroke_Click(object sender, RoutedEventArgs e)
        {
            WpfLibrary1.Product.delete(Convert.ToInt32(IdToDelete.Text));
            DataGridRefresh();
        }

        private void cancelDelete_Click(object sender, RoutedEventArgs e)
        {
            dialog.Visibility = Visibility.Hidden;
        }

        private void AcceptAdd_Click(object sender, RoutedEventArgs e)
        {
            WpfLibrary1.Product.add(AddArticle.Text, AddName.Text, AddUnit.Text, Convert.ToDecimal(AddPrice.Text),Convert.ToInt32(AddMaxDiscount.Text),AddManufacturer.Text,AddSupplier.Text,AddCategory.Text,Convert.ToInt32(AddCurrentDiscount.Text),Convert.ToInt32(AddQuantity.Text),AddDescription.Text);
            MessageBox.Show("Вы успешно добавили запись");
            DataGridRefresh();
        }

        private void CancelAdd_Click(object sender, RoutedEventArgs e)
        {
            AddDialog.Visibility = Visibility.Hidden;
        }
    }
}
    
