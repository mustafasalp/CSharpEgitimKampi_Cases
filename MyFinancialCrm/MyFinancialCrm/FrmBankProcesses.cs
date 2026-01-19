using MyFinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    public partial class FrmBankProcesses : Form
    {
        public FrmBankProcesses()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Mevcut oturum bilgilerini temizle
            CurrentUser.UserId = 0;
            CurrentUser.Username = null;
            CurrentUser.IsAdmin = false;

            // Login formuna dön
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

        private void btnBillingsForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Close();
        }

        private void FrmBankProcesses_Load(object sender, EventArgs e)
        {
            txtUserId.Text = CurrentUser.UserId.ToString();
            lblUserName.Text = CurrentUser.Username;
            
            // UI Düzeltmeleri
            this.Text = "Banka Hareketleri";
            label1.Text = "İşlem Id:";
            label2.Text = "Açıklama:";
            label4.Text = "Miktar:";
            label3.Text = "Tarih:";
            btnSpendingList.Text = "İşlem Listele";
            btnSpendingAdd.Text = "İşlem Ekle";
            btnSpendingDelete.Text = "İşlem Sil";
            btnSpendingUpdate.Text = "İşlem Güncelle";

            LoadBankProcesses();
        }

        private void LoadBankProcesses()
        {
            // Sadece bu kullanıcıya ait kategorileri listele
            var values = db.BankProcesses
                .Where(x => x.UserId == CurrentUser.UserId)
                .ToList();
            dataGridView1.DataSource = values;
        }

        private void btnSpendingList_Click(object sender, EventArgs e)
        {
            LoadBankProcesses();
        }

        private void btnSpendingAdd_Click(object sender, EventArgs e)
        {
            string bankProcessName = txtSpendingTitle.Text;
            decimal bankProcessAmount = decimal.Parse(txtSpendingAmount.Text.ToString());

            if (string.IsNullOrWhiteSpace(bankProcessName))
            {
                MessageBox.Show("İşlem adı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BankProcesses process = new BankProcesses();
            process.Description = bankProcessName;
            process.Amount = bankProcessAmount;
            process.UserId = CurrentUser.UserId; // Güvenlik için UserId ataması

            db.BankProcesses.Add(process);
            db.SaveChanges();
            MessageBox.Show("İşlem başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadBankProcesses();
            txtSpendingTitle.Clear();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Close();
        }

        private void btnSpendingDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSpendingId.Text)) return;

            int id = int.Parse(txtSpendingId.Text);
            // Sadece bu kullanıcıya ait mi kontrolü
            var value = db.BankProcesses.FirstOrDefault(x => x.BankProcessId == id && x.UserId == CurrentUser.UserId);

            if (value != null)
            {
                db.BankProcesses.Remove(value);
                db.SaveChanges();
                MessageBox.Show("İşlem başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBankProcesses();
            }
            else
            {
                MessageBox.Show("İşlem bulunamadı veya silme yetkiniz yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSpendingUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSpendingId.Text)) return;

            int id = int.Parse(txtSpendingId.Text);
            var value = db.BankProcesses.FirstOrDefault(x => x.BankProcessId == id && x.UserId == CurrentUser.UserId);

            if (value != null)
            {
                value.Description = txtSpendingTitle.Text;
                value.Amount = decimal.Parse(txtSpendingAmount.Text.ToString());
                db.SaveChanges();
                MessageBox.Show("Kategori başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBankProcesses();
            }
        }
    }
}
