using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Versioning;
using System.Windows.Forms;
using MyFinancialCrm.Models;

namespace MyFinancialCrm
{
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();

        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            lblUserName.Text = CurrentUser.Username;
            txtUserId.Text = CurrentUser.UserId.ToString();
            LoadSpendings();
        }

        // 1. Listeleme: Sadece bu kullanıcının harcamalarını getir
        private void LoadSpendings()
        {
            var values = db.Spendings
                .Where(x => x.UserId == CurrentUser.UserId)
                .OrderByDescending(x => x.SpendingDate) // En yeni harcama en üstte
                .ToList();
            dataGridView1.DataSource = values;
        }

        private void btnSpendingList_Click(object sender, EventArgs e)
        {
            LoadSpendings();
        }

        // 2. Ekleme: Harcama başlığı, miktar ve tarihi kaydet
        private void btnSpendingAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtSpendingTitle.Text;
                decimal amount = decimal.Parse(txtSpendingAmount.Text);
                DateTime date = SpendingDate.Value; // Formdaki takvimden alınan tarih

                Spendings spending = new Spendings();
                spending.SpendingTitle = title;
                spending.SpendingAmount = amount;
                spending.SpendingDate = date;
                spending.UserId = CurrentUser.UserId;

                // Not: Kategorileri henüz ComboBox ile bağlamadığın için 
                // şimdilik varsayılan bir ID atıyoruz veya null bırakıyoruz.
                // spending.CategoryId = 1; 

                db.Spendings.Add(spending);
                db.SaveChanges();
                MessageBox.Show("Harcama başarıyla sisteme eklendi.", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadSpendings();
                ClearAllBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen miktar alanına geçerli bir sayı giriniz. " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Silme: ID ve UserId kontrolü ile sil
        private void btnSpendingDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSpendingId.Text)) return;

            int id = int.Parse(txtSpendingId.Text);
            var value = db.Spendings.FirstOrDefault(x => x.SpendingId == id && x.UserId == CurrentUser.UserId);

            if (value != null)
            {
                db.Spendings.Remove(value);
                db.SaveChanges();
                MessageBox.Show("Harcama başarıyla silindi.", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSpendings();
                ClearAllBoxes();
            }
            else
            {
                MessageBox.Show("Silinecek harcama bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 4. Güncelleme
        private void btnSpendingUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSpendingId.Text)) return;

            int id = int.Parse(txtSpendingId.Text);
            var value = db.Spendings.FirstOrDefault(x => x.SpendingId == id && x.UserId == CurrentUser.UserId);

            if (value != null)
            {
                value.SpendingTitle = txtSpendingTitle.Text;
                value.SpendingAmount = decimal.Parse(txtSpendingAmount.Text);
                value.SpendingDate = SpendingDate.Value;

                db.SaveChanges();
                MessageBox.Show("Harcama başarıyla güncellendi.", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSpendings();
                ClearAllBoxes();
            }
        }

        private void ClearAllBoxes()
        {
            txtSpendingId.Clear();
            txtSpendingTitle.Clear();
            txtSpendingAmount.Clear();
            SpendingDate.Value = DateTime.Now;
        }

        // Navigasyon Butonları
        private void btnExit_Click(object sender, EventArgs e)
        {
            CurrentUser.UserId = 0;
            CurrentUser.Username = null;
            CurrentUser.IsAdmin = false;

            var loginForm = Application.OpenForms.OfType<FrmLogin>().FirstOrDefault();
            if (loginForm != null)
            {
                loginForm.Show();
            }
            else
            {
                new FrmLogin().Show();
            }
            this.Close();
        }

        private void btnBillingsForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Close();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Close();
        }

        private void btnSettingsForm_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Close();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Close();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Close();
        }
    }
}