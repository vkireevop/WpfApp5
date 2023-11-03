using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WpfLibrary1.Tests
{
    [TestClass()]
    public class UserTests
    {
        [TestMethod()]
        public void getTableTest()
        {
            
            Assert.Fail();
        }
        [TestMethod()]
        public void connectionTest()
        {
            string connectionString = @"Server=localhost;port=3306;Database=trade;User=root;Password=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try {
                connection.Open();
                }

            catch (Exception e)
            {
                Assert.Fail($"Failed to connect to the database: {e.Message}");
            }
            finally
            { 
                connection.Close();
            }
        }
        [TestMethod()]
        public void connectionTest1()
        {
            string connectionString = @"Server=+localhost;port=3306;Database=trade;User=root;Password=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }

            catch (Exception e)
            {
                Assert.Fail($"Failed to connect to the database: {e.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        [TestMethod()]
        public void connectionTest2()
        {
            string connectionString = @"Server=localhost;port=3306;Database=trade;User=root;Password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }

            catch (Exception e)
            {
                Assert.Fail($"Failed to connect to the database: {e.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        [TestMethod()]
        public void connectionTest3()
        {
            string connectionString = @"Server=localhost;port=3306;Database=trade;User=;Password=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }

            catch (Exception e)
            {
                Assert.Fail($"Failed to connect to the database: {e.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        [TestMethod()]
        public void connectionTest4()
        {
            string connectionString = @"Server=localhost;port=3306;Database=;User=root;Password=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }

            catch (Exception e)
            {
                Assert.Fail($"Failed to connect to the database: {e.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        [TestMethod()]
        public void connectionTest5()
        {
            string connectionString = @"Server=localhost;port=;Database=trade;User=root;Password=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }

            catch (Exception e)
            {
                Assert.Fail($"Failed to connect to the database: {e.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        [TestMethod()]
        public void connectionTest6()
        {
            string connectionString = @"Server=localhost;port=3306;Database=trade;User=root;Password=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }

            catch (Exception e)
            {
                Assert.Fail($"Failed to connect to the database: {e.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        [TestMethod()]
        public void addTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void deleteTest()
        {
            Assert.Fail();
        }
    }
}