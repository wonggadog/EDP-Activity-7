using System;
using System.Windows.Forms;

namespace Act5new
{
    public partial class Form1 : Form
    {
        private DatabaseConnection dbConnection;

        public Form1()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = text_username.Text;
            string password = txtpassword.Text;

            if (dbConnection.CheckCredentials(username, password))
            {
                // Close the current form
                this.Hide();

                // Create an instance of Form4 and show it
                Form4 form4 = new Form4(dbConnection);
                form4.ShowDialog(); // Use ShowDialog to make Form4 modal
            }
            else
            {
                MessageBox.Show("Account does not exist! Please check credentials then try again.");
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            text_username.Text = "";
            txtpassword.Text = "";
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2 and pass DatabaseConnection instance
            Form2 form2 = new Form2(dbConnection);

            // Show Form2
            form2.Show();
        }

        private void button_forgotpass_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2 and pass DatabaseConnection instance
            Form3 form3 = new Form3(dbConnection);

            // Show Form3
            form3.Show();
        }

        private void text_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_login_Click(object sender, EventArgs e)
        {

        }
    }
}
