using MySql.Data.MySqlClient;
using System.Data;
using System.Net.Http.Headers;
using System.Windows;
using System.Windows.Navigation;

namespace WpfLibrary1
{
    public class User
    {
        public static DataTable getTable()
        {
            string connectionString = @"Server=localhost;port=3306;Database=trade;User=root;Password=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string command = "select user_id, role_name, username, full_name from user join role on user.role_id = role.role_id";
            MySqlCommand cmd = new MySqlCommand(command, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        public static void add(int role, string fullName,string username, string password)
        {
            string connectionString = @"Server=localhost;port=3306;Database=trade;User=root;Password=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string command = "insert into user (role_id, full_name, username, password) values (@role,@fullname,@login,@pass)";
            MySqlCommand cmd = new MySqlCommand(command, connection);
            cmd.Parameters.Add("@login", MySqlDbType.VarChar, 50).Value = username;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar, 255).Value = password;
            cmd.Parameters.Add("@fullname", MySqlDbType.VarChar, 255).Value = fullName;
            cmd.Parameters.Add("@role", MySqlDbType.Int32).Value = role;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Вы успешно добавили запись");
        }
        public static void delete(int id)
        {
            string connectionString = @"Server=localhost;port=3306;Database=trade;User=root;Password=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string command = "delete from User  where user_id = @id";
            MySqlCommand cmd = new MySqlCommand(command, connection);
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            cmd.ExecuteNonQuery();
        }
    }
    public class Product
    {
        public static DataTable getTable()
        {
            string connectionString = @"Server=localhost;port=3306;Database=trade;User=root;Password=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string command = "select * from product";
            MySqlCommand cmd = new MySqlCommand(command, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        public static void delete(int id)
        {
            string connectionString = @"Server=localhost;port=3306;Database=trade;User=root;Password=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string command = "delete from product  where article = @id";
            MySqlCommand cmd = new MySqlCommand(command, connection);
            cmd.Parameters.Add("@id", MySqlDbType.VarChar, 10).Value = id;
            cmd.ExecuteNonQuery();
        }
        public static void add(string article, string name, string unit, decimal price, int max_disc,string manufacturer, string supplier, string category, int current_discount, int quantity, string description)
        {
            string connectionString = @"Server=localhost;port=3306;Database=trade;User=root;Password=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string command = "insert into product (article, name, unit, price,max_discount,manufacturer,supplier,category,current_discount,quantity,description)" +
                " values (@article, @name, @unit, @price,@max_discount,@manufacturer,@supplier,@category,@current_discount,@quantity,@description)";
            MySqlCommand cmd = new MySqlCommand(command, connection);
            cmd.Parameters.Add("@article", MySqlDbType.VarChar, 10).Value = article;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar, 255).Value = name;
            cmd.Parameters.Add("@unit", MySqlDbType.VarChar, 10).Value = unit;
            cmd.Parameters.Add("@price", MySqlDbType.Decimal).Value = price;
            cmd.Parameters.Add("@max_discount", MySqlDbType.Int32).Value = max_disc;
            cmd.Parameters.Add("@manufacturer", MySqlDbType.VarChar, 255).Value = manufacturer;
            cmd.Parameters.Add("@supplier", MySqlDbType.VarChar, 255).Value = supplier;
            cmd.Parameters.Add("@category", MySqlDbType.VarChar,255).Value = category;
            cmd.Parameters.Add("@current_discount", MySqlDbType.Int32).Value = current_discount;
            cmd.Parameters.Add("@quantity", MySqlDbType.Int32).Value = quantity;
            cmd.Parameters.Add("@description", MySqlDbType.VarChar, 255).Value = description;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Вы успешно добавили запись");
        }
    }
}
