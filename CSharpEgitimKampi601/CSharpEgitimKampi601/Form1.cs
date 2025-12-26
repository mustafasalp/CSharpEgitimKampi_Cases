using CSharpEgitimKampi601.Entities;
using CSharpEgitimKampi601.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpEgitimKampi601.Services;

namespace CSharpEgitimKampi601
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListCustomers();
        }

        public void ClearTextBoxes()
        {
            txtCustomerID.Clear();
            txtCustomerName.Clear();
            txtCustomerSurname.Clear();
            txtCustomerBalance.Clear();
            txtCustomerCity.Clear();
            txtCustomerShoppingCount.Clear();
        }
        private void ListCustomers()
        {
            dataGridView1.DataSource = customerOperations.GetAllCustomers();
        }

        CustomerOperations customerOperations = new CustomerOperations();
        // CustomerOperation objesi oluşturdum, CustomerOperation' sınıfındaki method'a obje üzerinden erişeceğim.

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string id = txtCustomerID.Text;
            var updateCustomer = new Customer()
            {
                CustomerName = txtCustomerName.Text,
                CustomerCity = txtCustomerCity.Text,
                CustomerBalance = decimal.Parse(txtCustomerBalance.Text),
                CustomerSurname = txtCustomerSurname.Text,
                CustomerShoppingCount = int.Parse(txtCustomerShoppingCount.Text),
                CustomerId = id
            };
            customerOperations.UpdateCustomer(updateCustomer);
            MessageBox.Show($"{id}'id li kullanıcı {updateCustomer.CustomerName} ismi ile başarıyla güncellendi");
            ClearTextBoxes();
            ListCustomers();
        }
        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerName = txtCustomerName.Text,
                CustomerSurname = txtCustomerSurname.Text,
                CustomerCity = txtCustomerCity.Text,
                CustomerBalance = decimal.Parse(txtCustomerBalance.Text),
                CustomerShoppingCount = int.Parse(txtCustomerShoppingCount.Text)
            }; // Customer infoları alındı(eklenecek customer), TextBoxlardan.

            customerOperations.AddCustomer(customer);
            MessageBox.Show($"{customer.CustomerName} isimli müşteri database'e başarıyla eklendi.",
                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
            ListCustomers();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            string customerId = txtCustomerID.Text;
            Customer deletedCustomer = customerOperations.GetCustomerById(customerId); // Find the deletedUser's name by it's id
            customerOperations.DeleteCustomer(customerId); // Then delete it.
            MessageBox.Show($"{deletedCustomer.CustomerName} isimli müşteri başarıyla silindi.");

            //MessageBox.Show($"{customerId} id'li müşteri başarıyla silindi.");
            
            ClearTextBoxes();
            ListCustomers();
        }

        private void btnListCustomer_Click(object sender, EventArgs e)
        {
            ListCustomers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            string id = txtCustomerID.Text;
            Customer customers = customerOperations.GetCustomerById(id);
            dataGridView1.DataSource = new List<Customer> { customers };
        }
    }
}