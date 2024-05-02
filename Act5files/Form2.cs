using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Act5new
{
    public partial class Form2 : Form
    {
        private DatabaseConnection dbConnection;
        private string connectionString = "Server=localhost;Database=newalbum;Uid=root;Pwd=admin";

        public Form2(DatabaseConnection connection)
        {
            InitializeComponent();
            dbConnection = connection;
        }

        private void button_registercomplete_Click(object sender, EventArgs e)
        {
            string username = register_username.Text;
            string password = register_password.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                if (InsertUser(username, password))
                {
                    MessageBox.Show("User registered successfully!");
                    // Clear the text fields after successful registration
                    register_username.Text = "";
                    register_password.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to register user. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
        }

        private bool InsertUser(string username, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO credentials (username, password) VALUES (@username, @password)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.ExecuteNonQuery();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        private void register_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
