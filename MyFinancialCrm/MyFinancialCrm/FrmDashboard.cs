using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCrm.Models;

namespace MyFinancialCrm
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();
        List<Bills> billList = new List<Bills>();
        int index = -1;
        int lastMaxId = 0;

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDashboardUserName.Text = CurrentUser.Username.ToString();
            TotalBalancePrint();
            PrintListing();
            LastBankProcessPrint();
            Chart1Print();
            Chart2Print();

        }

        private void timer1_Tick(object sender, EventArgs e) // timer ticks by 1s
        {
            // Yeni Fatura eklenmesi başka form da olduğundan zaten bu form'a tekrar geçildiğinde form.Load()Çalışacak
            // kapatılırkenn this.Close() denilmek şartı ile.

            if (billList.Count == 0)
                return;

            index++; // Global index'e 1 ata.

            if (index >= billList.Count) // Eğer eşit veya büyük olursa index baştan başlasın
                index = 0;

            // bill'e ata ve yazdır.
            var bill = billList[index];
            lblBillTitle.Text = bill.BillTitle;
            lblBillAmount.Text = bill.BillAmount.ToString() + "₺"; 
        }

        private void LastBankProcessPrint()
        {
            var lastProcess = db.BankProcesses
                .Where(x => x.UserId == CurrentUser.UserId) // Filtre eklendi
                .OrderByDescending(x => x.BankProcessId)
                .FirstOrDefault();

            if (lastProcess != null)
            {
                lblLastBankProcessAmount.Text = (lastProcess.Amount ?? 0).ToString("N2") + " ₺";
                lblLastBankProcessDescription.Text = lastProcess.Description;
            }
            else
            {
                lblLastBankProcessAmount.Text = "0.00 ₺";
                lblLastBankProcessDescription.Text = "İşlem bulunamadı.";
            }
        }

        // 1. Toplam Bakiyeyi Sadece Giriş Yapan Kullanıcı İçin Hesapla
        private void TotalBalancePrint()
        {
            var totalBalance = db.Banks
                .Where(x => x.UserId == CurrentUser.UserId) // Filtre eklendi
                .Sum(x => (decimal?)x.BankBalance) ?? 0; // Null kontrolü için cast

            lblTotalBalance.Text = totalBalance.ToString("N2") + " ₺";
        }

        // 2. Faturaları Kullanıcıya Göre Listele
        private void PrintListing()
        {
            billList = db.Bills
                .Where(x => x.UserId == CurrentUser.UserId) // Filtre eklendi
                .OrderBy(x => x.BillId)
                .ToList();

            if (billList.Count > 0)
                lastMaxId = billList.Max(x => x.BillId);
        }

        // 4. Chart 1: Banka Bakiyeleri (Kullanıcıya Özel)
        private void Chart1Print()
        {
            var bankData = db.Banks
                .Where(x => x.UserId == CurrentUser.UserId) // Filtre eklendi
                .Select(x => new
                {
                    x.BankTitle,
                    x.BankBalance
                }).ToList();

            chart1.Series.Clear();
            var series = chart1.Series.Add("BankBalances");

            foreach (var item in bankData)
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
            }
        }

        // 5. Chart 2: Fatura Dağılımı (Kullanıcıya Özel)
        private void Chart2Print()
        {
            var billData = db.Bills
                .Where(x => x.UserId == CurrentUser.UserId) // Filtre eklendi
                .Select(x => new
                {
                    x.BillTitle,
                    x.BillAmount
                }).ToList();

            chart2.Series.Clear();
            var series = chart2.Series.Add("Faturalar");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            foreach (var item in billData)
            {
                series.Points.AddXY(item.BillTitle, item.BillAmount);
            }
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            // Temel Giderlerim kısmı.
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Close();
        }

        private void btnBillsForm_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Close(); // Mevcut Dashboard formunu kapatır
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Close(); // Mevcut Dashboard formunu kapatır
        }

        private void btnSettingsDashboard_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
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
            // Login formuna dön (Application.OpenForms ile bul)
            var loginForm = Application.OpenForms.OfType<FrmLogin>().FirstOrDefault();
            if (loginForm != null)
            {
                loginForm.Show();
            }
            else
            {
                // Eğer login formu bulunamazsa (beklenmedik durum), yeni oluştur
                new FrmLogin().Show();
            }
            
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