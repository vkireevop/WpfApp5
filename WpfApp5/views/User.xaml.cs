using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WpfApp5.views
{
    /// <summary>
    /// Логика взаимодействия для User.xaml
    /// </summary>
    public partial class User : Window
    {
        public User()
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
            DataTable dataTable = WpfLibrary1.User.getTable();
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
            string connectionString = @"Server=localhost;port=3306;Database=trade;User=root;Password=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string command = "select * from role";
            MySqlCommand cmd = new MySqlCommand(command, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            comboBox1.ItemsSource = dataTable.DefaultView;  
            comboBox1.DisplayMemberPath = dataTable.Columns[1].ToString();
            comboBox1.SelectedValuePath = dataTable.Columns[0].ToString();
        }

        private void deletestroke_Click(object sender, RoutedEventArgs e)
        {
            WpfLibrary1.User.delete(Convert.ToInt32(IdToDelete.Text));
            DataGridRefresh();
        }

        private void cancelDelete_Click(object sender, RoutedEventArgs e)
        {
            dialog.Visibility = Visibility.Hidden;
        }

        private void AcceptAdd_Click(object sender, RoutedEventArgs e)
        {
            WpfLibrary1.User.add(Convert.ToInt32(comboBox1.SelectedValue), AddFullname.Text, AddLogin.Text, AddPass.Text);
            MessageBox.Show("Вы успешно добавили запись");
            DataGridRefresh();
        }

        private void CancelAdd_Click(object sender, RoutedEventArgs e)
        {
            AddDialog.Visibility = Visibility.Hidden;
        }
    }
}
