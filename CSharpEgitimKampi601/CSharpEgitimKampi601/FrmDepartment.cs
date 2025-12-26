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
    public partial class FrmDepartment : Form
    {
        public FrmDepartment()
        {
            InitializeComponent();
        }

        string connectionString = "Server=localhost;port=5432;Database=CustomerDb;user Id=postgres;Password=002580";

        void ClearTextBoxes()
        {
            txtDepartmentID.Clear();
            txtDepartmentName.Clear();
        }

        void DepartmentList() // Employees table'ın daki tüm employee'leri list edicek.
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM departments";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            DepartmentList();
        }

        private void btnListDepartment_Click(object sender, EventArgs e)
        {
            DepartmentList();
        }

        private void btnCreateDepartment_Click(object sender, EventArgs e)
        {
            string departmentName = txtDepartmentName.Text;

            // Infos are taken.

            var connection = new NpgsqlConnection(connectionString); // Bağlantı oluştur
            connection.Open(); // Bağlantı açar.
            string query = "INSERT INTO departments (departmentname) " +
                "VALUES (@departmentName)";
            var command = new NpgsqlCommand(query, connection); // query o connection'a command olarak atanır.Executable command olur.
            command.Parameters.AddWithValue("@departmentName", departmentName);
            command.ExecuteNonQuery();
            MessageBox.Show($"{departmentName} isimli departman ekleme işlemi başarılı.");
            connection.Close();
            DepartmentList();
            ClearTextBoxes();
        }

        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDepartmentID.Text);

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            // 1️⃣ Çalışan sayısını al
            string countQuery = "SELECT COUNT(*) FROM employees WHERE departmentid = @id";
            var countCmd = new NpgsqlCommand(countQuery, connection);
            countCmd.Parameters.AddWithValue("@id", id);
            int employeeCount = Convert.ToInt32(countCmd.ExecuteScalar());

            // 2️⃣ Kullanıcıya sor
            DialogResult result = MessageBox.Show(
                $"Bu departmana bağlı {employeeCount} çalışan da silinecek.\nEmin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
            {
                connection.Close();
                return;
            }

            // 3️⃣ Departmanı sil
            string deleteQuery = "DELETE FROM departments WHERE departmentid = @departmentId";
            var deleteCmd = new NpgsqlCommand(deleteQuery, connection);
            deleteCmd.Parameters.AddWithValue("@departmentId", id);
            deleteCmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Departman silindi.");
            DepartmentList();
            ClearTextBoxes();
        }

        private void btnUpdateDepartment_Click(object sender, EventArgs e)
        {
            string departmentName = txtDepartmentName.Text;
            int departmentId = int.Parse(txtDepartmentID.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "UPDATE departments " +
                "SET departmentname=@departmentName " +
                "WHERE departmentid=@departmentId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@departmentName", departmentName);
            command.Parameters.AddWithValue("@departmentId", departmentId);
            command.ExecuteNonQuery();
            MessageBox.Show($"{departmentId} 'id li departman ismi {departmentName} olarak güncellendi");
            connection.Close();
            DepartmentList();
            ClearTextBoxes();
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDepartmentID.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM departments WHERE departmentid = @departmentId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@departmentId", id);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable); // adapter'e gelecek sonuçları bir DataTable'a doldur.
            dataGridView1.DataSource = dataTable;
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}