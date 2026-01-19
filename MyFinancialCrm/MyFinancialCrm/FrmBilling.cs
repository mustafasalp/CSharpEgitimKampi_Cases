using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MyFinancialCrm.Models;

namespace MyFinancialCrm
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            txtUserId.Text = CurrentUser.UserId.ToString();
            lblUserName.Text = CurrentUser.Username;
            LoadBills();
        }

        // 1. Sadece giriş yapan kullanıcının faturalarını yükle
        private void LoadBills()
        {
            var values = db.Bills
                .Where(x => x.UserId == CurrentUser.UserId) // Filtre eklendi
                .ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            LoadBills();
        }

        // 2. Yeni fatura eklerken UserId bilgisini ata
        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtBillTitle.Text;
                decimal amount = decimal.Parse(txtAmount.Text);
                string period = txtTimePeriod.Text;

                Bills bill = new Bills();
                bill.BillTitle = title;
                bill.BillAmount = amount;
                bill.BillPeriod = period;
                bill.UserId = CurrentUser.UserId; // Giriş yapan kullanıcının ID'si atandı

                db.Bills.Add(bill);
                db.SaveChanges();
                MessageBox.Show("Ödeme başarılı bir şekilde sisteme eklendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadBills();
                ClearAllBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // 3. Silme işleminde güvenlik kontrolü (Sadece kendi faturası mı?)
        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);

            // Faturayı hem ID hem de UserId ile buluyoruz (Güvenlik için)
            var removeValue = db.Bills.FirstOrDefault(x => x.BillId == id && x.UserId == CurrentUser.UserId);

            if (removeValue != null)
            {
                db.Bills.Remove(removeValue);
                db.SaveChanges();
                MessageBox.Show("Ödeme başarılı bir şekilde sistemden silindi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silinecek fatura bulunamadı veya bu faturayı silme yetkiniz yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            LoadBills();
            ClearAllBoxes();
        }

        // 4. Güncelleme işleminde güvenlik kontrolü
        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            var values = db.Bills.FirstOrDefault(x => x.BillId == id && x.UserId == CurrentUser.UserId);

            if (values != null)
            {
                values.BillPeriod = txtTimePeriod.Text;
                values.BillTitle = txtBillTitle.Text;
                values.BillAmount = decimal.Parse(txtAmount.Text);

                db.SaveChanges();
                MessageBox.Show("Ödeme başarılı bir şekilde güncellendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Güncellenecek fatura bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            LoadBills();
            ClearAllBoxes();
        }

        private void ClearAllBoxes()
        {
            txtBillTitle.Clear();
            txtBillId.Clear();
            txtTimePeriod.Clear();
            txtAmount.Clear();
        } 

        // Sidebar Butonları - Formlar Arası Geçiş
        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Close();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // empty
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Mevcut oturum bilgilerini temizle
            CurrentUser.UserId = 0;
            CurrentUser.Username = null;
            CurrentUser.IsAdmin = false;

            // Login formuna dön
            var loginForm = Application.OpenForms.OfType<FrmLogin>().FirstOrDefault();
            if (loginForm != null)
            {
                loginForm.Show();
            }
            else
            {
                new FrmLogin().Show();
            }
            this.Close(); // Bu formu kapat
        }

        private void btnSettingsForm_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Close();
        }

        private void btnCategoriesForm_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Close();
        }
    }
}