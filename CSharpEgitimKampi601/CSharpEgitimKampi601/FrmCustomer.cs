using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
            GetAllCustomers();
        }

        string connectionString = "Server=localhost;port=5432;Database=CustomerDb;user Id=postgres;Password=002580"; 
    
        void GetAllCustomers()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM customers";   
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void btnListCustomer_Click(object sender, EventArgs e)
        {
            GetAllCustomers();
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string customerSurname = txtCustomerSurname.Text;
            string customerCity = txtCustomerCity.Text;
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO customers(customerName, CustomerSurname, CustomerCity) VALUES" +
                "(@customerName, @customerSurname, @customerCity)";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerName", customerName);
            command.Parameters.AddWithValue("@customerSurname", customerSurname);
            command.Parameters.AddWithValue("@customerCity", customerCity);
            command.ExecuteNonQuery();
            MessageBox.Show($"{customerName} isimli müşteri ekleme işlemi başarılı");
            connection.Close();
            GetAllCustomers();
            ClearAllTextBoxes();
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCustomerID.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "DELETE FROM customers WHERE customerId = @customerId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerId", id);
            command.ExecuteNonQuery();
            MessageBox.Show($"{id} 'id li müşteri silme işlemi başarılı");
            connection.Close();
            GetAllCustomers();
            ClearAllTextBoxes();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string customerSurname = txtCustomerSurname.Text;
            string customerCity = txtCustomerCity.Text;
            int id = int.Parse(txtCustomerID.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "UPDATE customers " +
                "SET CustomerName=@customerName, " +
                "CustomerSurname=@customerSurname, " +
                "CustomerCity=@customerCity " +
                "WHERE CustomerId=@customerId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerName", customerName);
            command.Parameters.AddWithValue("@customerCity", customerCity);
            command.Parameters.AddWithValue("@customerSurname", customerSurname);
            command.Parameters.AddWithValue("@customerId", id);
            command.ExecuteNonQuery();
            MessageBox.Show($"{id} 'id li müşteri güncelleme işlemi başarılı");
            connection.Close();
            GetAllCustomers();
            ClearAllTextBoxes();
        }

        private void ClearAllTextBoxes()
        {
            txtCustomerCity.Clear();
            txtCustomerID.Clear();
            txtCustomerSurname.Clear();
            txtCustomerName.Clear();
        }
    }
}