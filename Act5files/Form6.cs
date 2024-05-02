using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act5new
{
    public partial class Form6 : Form
    {
        private DatabaseConnection dbConnection;
        private string connectionString = "Server=localhost;Database=newalbum;Uid=root;Pwd=admin";

        public Form6(DatabaseConnection connection)
        {
            InitializeComponent();
            dbConnection = connection;
        }

        private void delete_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_deleteconfirm_Click(object sender, EventArgs e)
        {
            string username = delete_username.Text;
            string password = delete_password.Text;

            if (DeleteAccount(username, password))
            {
                MessageBox.Show("Account deletion successful! We're sorry to see you go :(");
            }
            else
            {
                MessageBox.Show("Error in deletion! Please check account credentials and try again.");
            }
        }

        private bool DeleteAccount(string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM credentials WHERE username = @username AND password = @password";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        // Handle exception if any
                        Console.WriteLine("Exception occurred: " + ex.Message);
                        return false;
                    }
                }
            }
        }
    }
}