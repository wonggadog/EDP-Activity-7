using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Act5new
{
    public partial class Form3 : Form
    {
        private DatabaseConnection dbConnection;

        public Form3(DatabaseConnection connection)
        {
            InitializeComponent();
            dbConnection = connection;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void recovery_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_recover_Click(object sender, EventArgs e)
        {
            string usernameToRecover = recovery_username.Text;

            // Assuming you have your connection string here
            string connectionString = "Server=localhost;Database=newalbum;Uid=root;Pwd=admin";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to retrieve the password for the given username
                    string query = "SELECT password FROM credentials WHERE username = @username";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", usernameToRecover);
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            // Password found
                            string password = result.ToString();
                            MessageBox.Show($"Username: {usernameToRecover}\nPassword: {password}", "Password Recovery");
                        }
                        else
                        {
                            // Username not found
                            MessageBox.Show("Username not found. Please try again.", "Password Recovery");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }
    }
}
