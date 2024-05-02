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
    public partial class Form5 : Form
    {

        private DatabaseConnection dbConnection;
        private string connectionString = "Server=localhost;Database=newalbum;Uid=root;Pwd=admin";

        public Form5(DatabaseConnection connection)
        {
            InitializeComponent();
            dbConnection = connection;
        }


        public Form5()
        {
            InitializeComponent();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string username = text_updateuser_previous.Text;
            string password = text_updatepwd_previous.Text;

            if (CheckAccountExists(username, password))
            {
                MessageBox.Show("This account is inside the database.");
            }
            else
            {
                MessageBox.Show("This account does not exist!");
            }
        }

        private bool CheckAccountExists(string username, string password)
        {
            bool accountExists = false;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM credentials WHERE username = @username AND password = @password";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        accountExists = true;
                    }
                }
            }

            return accountExists;
        }


        private void text_updateuser_previous_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_updatepwd_previous_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_updateuser_final_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_updatepwd_final_TextChanged(object sender, EventArgs e)
        {

        }


        private void button_updateconfirm_Click(object sender, EventArgs e)
        {
            string previousUsername = text_updateuser_previous.Text;
            string previousPassword = text_updatepwd_previous.Text;
            string newUsername = text_updateuser_final.Text;
            string newPassword = text_updatepwd_final.Text;

            if (UpdateAccount(previousUsername, previousPassword, newUsername, newPassword))
            {
                MessageBox.Show("Account Update Successful!");
            }
            else
            {
                MessageBox.Show("Error occurred in updating account");
            }
        }

        private bool UpdateAccount(string previousUsername, string previousPassword, string newUsername, string newPassword)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "UPDATE credentials SET username = @newUsername, password = @newPassword " +
                               "WHERE username = @previousUsername AND password = @previousPassword";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@newUsername", newUsername);
                    command.Parameters.AddWithValue("@newPassword", newPassword);
                    command.Parameters.AddWithValue("@previousUsername", previousUsername);
                    command.Parameters.AddWithValue("@previousPassword", previousPassword);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
