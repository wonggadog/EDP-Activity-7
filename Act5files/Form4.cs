using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Act5new;

namespace Act5new
{
    public partial class Form4 : Form
    {

        private DatabaseConnection dbConnection;
        private string connectionString = "Server=localhost;Database=newalbum;Uid=root;Pwd=admin";

        public Form4(DatabaseConnection connection)
        {
            InitializeComponent();
            dbConnection = connection;
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        //report gen
        private void button3_Click(object sender, EventArgs e)
        {
            // Create an instance of Form7
            Form7 form7 = new Form7();

            // Show Form7
            form7.Show();
        }


        private void button_dashboard_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_dashboard_delete_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2 and pass DatabaseConnection instance
            Form6 form6 = new Form6(dbConnection);

            // Show Form2
            form6.Show();
        }

        private void button_dashboard_register_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2 and pass DatabaseConnection instance
            Form2 form2 = new Form2(dbConnection);

            // Show Form2
            form2.Show();
        }

        private void button_dashboard_updateacc_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2 and pass DatabaseConnection instance
            Form5 form5 = new Form5(dbConnection);

            // Show Form3
            form5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button_dashboard_abt_Click(object sender, EventArgs e)
        {

        }


    }
}
