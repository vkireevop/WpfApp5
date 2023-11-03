
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
using WpfApp5.views;

namespace WpfApp5
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

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = @"Server=localhost;port=3306;Database=trade;User=root;Password=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string command = "select role_name from user join role on user.role_id = role.role_id where username = @login and password = @password";
            MySqlCommand cmd = new MySqlCommand(command, connection);
            cmd.Parameters.Add("@login", MySqlDbType.VarChar, 50).Value = UsernameTextBox.Text;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar, 255).Value = PasswordBox.Text;
            if (cmd.ExecuteScalar() != null) {
                MessageBox.Show(Convert.ToString(cmd.ExecuteScalar()));
                MenuWindow menuWindow = new MenuWindow();
                menuWindow.Show();
                this.Close();
            }
            else {
                MessageBox.Show("не успех");
                   }

        }
    }
}
