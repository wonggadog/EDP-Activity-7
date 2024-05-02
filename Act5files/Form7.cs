using System;
using System.Data;
using System.Windows.Forms;
using Act5new;
using MySql.Data.MySqlClient;

namespace Act5new
{
    public partial class Form7 : Form
    {
        private string connectionString = "Server=localhost;Database=newalbum;Uid=root;Pwd=admin";

        public Form7()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Fetch data from the "orders" table
                    string ordersQuery = "SELECT * FROM orders";
                    MySqlCommand ordersCommand = new MySqlCommand(ordersQuery, connection);
                    MySqlDataAdapter ordersAdapter = new MySqlDataAdapter(ordersCommand);
                    DataTable ordersTable = new DataTable();
                    ordersAdapter.Fill(ordersTable);

                    // Fetch data from the "customers" table
                    string customersQuery = "SELECT * FROM customers";
                    MySqlCommand customersCommand = new MySqlCommand(customersQuery, connection);
                    MySqlDataAdapter customersAdapter = new MySqlDataAdapter(customersCommand);
                    DataTable customersTable = new DataTable();
                    customersAdapter.Fill(customersTable);

                    // Merge the two DataTables
                    ordersTable.Merge(customersTable);

                    // Bind the merged DataTable to the DataGridView
                    dataGridView1.DataSource = ordersTable;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // This method can be left empty or customized based on your requirements
        }

        private void export_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Generate Excel template using the class name
                DataTable data = (DataTable)dataGridView1.DataSource;
                byte[] excelBytes = ExcelReportGenerator.GenerateExcelTemplate(data);

                // Prompt user to save the Excel file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Export Excel File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the file path selected by the user
                    string filePath = saveFileDialog.FileName;

                    // Save the Excel file to the selected location
                    File.WriteAllBytes(filePath, excelBytes);

                    MessageBox.Show("Excel template exported successfully to: " + filePath, "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while exporting Excel template: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
