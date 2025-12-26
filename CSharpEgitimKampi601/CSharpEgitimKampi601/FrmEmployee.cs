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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        string connectionString = "Server=localhost;port=5432;Database=CustomerDb;user Id=postgres;Password=002580";
        
        void ClearTextBoxes()
        {
            txtEmployeeSalary.Clear();
            txtEmpoyeeName.Clear();
            txtEmpoyeeSurname.Clear();
            txtEmpoyeeId.Clear();
        }

        void EmployeeList() // Employees table'ın daki tüm employee'leri list edicek.
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM employees";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        void DepartmentList() // Employees table'ın daki tüm departmen'leri list edicek. -> comboBox için.
        {
            var connection = new NpgsqlConnection(connectionString); // Bağlantı oluştur
            connection.Open(); // Bağlantı açar.
            string query = "SELECT * FROM departments"; // query yazılır.
            var command = new NpgsqlCommand(query, connection); // query o connection'a command olarak atanır.(Executable command olur.)
            var adapter = new NpgsqlDataAdapter(command); // SQL sonucunu alıp dataTable'a aktaracak bir adaptör nesnesi oluşturulur.
            DataTable dataTable = new DataTable(); // DataTable'ı oluşturduk.
            adapter.Fill(dataTable); // adaptör aracılığı ile doldurduk.
            cmbEmpoyeeDepartment.DisplayMember = "DepartmentName"; // Bize(Kullanıcıya) value'e lar gözüksün
            cmbEmpoyeeDepartment.ValueMember = "DepartmentId"; // Fakat arka planda Id'ler çalışsın.
            cmbEmpoyeeDepartment.DataSource = dataTable; // 
            connection.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            EmployeeList();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            EmployeeList();
            DepartmentList(); // Form yüklendiğinde çağırılsın. Zaten her form load olduğunda yeni eklenmiş department gelecek.
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string employeeName = txtEmpoyeeName.Text;
            string employeeSurname = txtEmpoyeeSurname.Text;
            decimal employeeSalary = decimal.Parse(txtEmployeeSalary.Text);
            int departmentId = int.Parse(cmbEmpoyeeDepartment.SelectedValue.ToString());
             
            // Infos are taken.

            var connection = new NpgsqlConnection(connectionString); // Bağlantı oluştur
            connection.Open(); // Bağlantı açar.
            string query = "INSERT INTO employees (employeename, employeesurname, employeeSalary, departmentid) " +
                "VALUES (@employeeName, @employeeSurname, @employeeSalary, @departmentId)";
            var command = new NpgsqlCommand(query, connection); // query o connection'a command olarak atanır.(Executable command olur.
            command.Parameters.AddWithValue("@employeeName", employeeName);
            command.Parameters.AddWithValue("@employeeSurname", employeeSurname);
            command.Parameters.AddWithValue("@employeeSalary", employeeSalary);
            command.Parameters.AddWithValue("@departmentId", departmentId);
            command.ExecuteNonQuery();
            MessageBox.Show($"{employeeName} isimli çalışan ekleme işlemi başarılı.");
            connection.Close();
            EmployeeList();
            ClearTextBoxes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtEmpoyeeId.Text); // Id'yi al.
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "DELETE FROM employees WHERE employeeid = @employeeId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@employeeId", id);
            command.ExecuteNonQuery(); // command execute edilecek.
            MessageBox.Show($"{id} 'id li müşteri silme işlemi başarılı");
            connection.Close();
            EmployeeList();
            ClearTextBoxes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string employeeName = txtEmpoyeeName.Text;
            string employeeSurname = txtEmpoyeeSurname.Text;
            decimal employeeSalary = decimal.Parse(txtEmployeeSalary.Text);
            int employeeId = int.Parse(txtEmpoyeeId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "UPDATE employees " +
                "SET employeename=@employeeName, " +
                "employeeSurname=@employeeSurname, " +
                "employeeSalary=@employeeSalary " +
                "WHERE employeeid=@employeeId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@employeeName", employeeName);
            command.Parameters.AddWithValue("@employeeSurname", employeeSurname);
            command.Parameters.AddWithValue("@employeeSalary", employeeSalary);
            command.Parameters.AddWithValue("@employeeId", employeeId);
            command.ExecuteNonQuery();
            MessageBox.Show($"{employeeId} 'id li çalışan güncelleme işlemi başarılı");
            connection.Close();
            EmployeeList();
            ClearTextBoxes();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            FrmDepartment frmAddDepartment = new FrmDepartment();
            this.Hide();
            frmAddDepartment.ShowDialog();
            this.Show();

            DepartmentList();
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {

            //var connection = new NpgsqlConnection(connectionString);
            //connection.Open();
            //string query = "SELECT * FROM employees";
            //var command = new NpgsqlCommand(query, connection);
            //var adapter = new NpgsqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //dataGridView1.DataSource = dataTable;
            //connection.Close();

            int id = int.Parse(txtEmpoyeeId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM employees WHERE employeeid = @employeeId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@employeeId", id);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable); // adapter'e gelecek sonuçları bir DataTable'a doldur.
            dataGridView1.DataSource = dataTable;
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
