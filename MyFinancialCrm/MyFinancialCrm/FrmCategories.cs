using MyFinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            txtUserId.Text = CurrentUser.UserId.ToString();
            lblUserName.Text = CurrentUser.Username;
            LoadCategories();
        }

        private void LoadCategories()
        {
            // Sadece bu kullanıcıya ait kategorileri listele
            var values = db.Categories
                .Where(x => x.UserId == CurrentUser.UserId)
                .ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }

        // --- CRUD İŞLEMLERİ ---

        private void btnCategoryAdd_Click(object sender, EventArgs e) // Kategori Ekleme
        {
            string categoryName = txtCategoryName.Text;

            if (string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Kategori adı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categories category = new Categories();
            category.CategoryName = categoryName;
            category.UserId = CurrentUser.UserId; // Güvenlik için UserId ataması

            db.Categories.Add(category);
            db.SaveChanges();
            MessageBox.Show("Kategori başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadCategories();
            txtCategoryName.Clear();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e) // Kategori Silme
        {
            if (string.IsNullOrWhiteSpace(txtCategoryId.Text)) return;

            int id = int.Parse(txtCategoryId.Text);
            // Sadece bu kullanıcıya ait mi kontrolü
            var value = db.Categories.FirstOrDefault(x => x.CategoryId == id && x.UserId == CurrentUser.UserId);

            if (value != null)
            {
                db.Categories.Remove(value);
                db.SaveChanges();
                MessageBox.Show("Kategori başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategories();
            }
            else
            {
                MessageBox.Show("Kategori bulunamadı veya silme yetkiniz yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e) // Kategori Güncelleme
        {
            if (string.IsNullOrWhiteSpace(txtCategoryId.Text)) return;

            int id = int.Parse(txtCategoryId.Text);
            var value = db.Categories.FirstOrDefault(x => x.CategoryId == id && x.UserId == CurrentUser.UserId);

            if (value != null)
            {
                value.CategoryName = txtCategoryName.Text;
                db.SaveChanges();
                MessageBox.Show("Kategori başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategories();
            }
        }

        // --- NAVİGASYON (FORM GEÇİŞLERİ) ---

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnSettingsForm_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Mevcut oturum bilgilerini temizle
            CurrentUser.UserId = 0;
            CurrentUser.Username = null;
            CurrentUser.IsAdmin = false;

            // Login formuna dön
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Close(); // Bu formu kapat, ama login açıldığı için uygulama kapanmaz
        }

        private void btnBillingsForm_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCategoryId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBankProcessesForm_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frm = new FrmBankProcesses();
            frm.Show();
            this.Close();
        }

        private void btnBillsForm_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Close();
        }
    }
}