using System;
using System.Linq;
using System.Windows.Forms;
using MyFinancialCrm.Models;

namespace MyFinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            // Kullanıcı adını yazdır
            lblBanksUserName.Text = CurrentUser.Username;

            // 1. Banka Bakiyeleri (Sadece bu kullanıcıya ait ve ilgili banka başlığına göre)
            var ziraatBankBalance = db.Banks
                .Where(x => x.BankTitle == "Ziraat Bankası" && x.UserId == CurrentUser.UserId)
                .Select(y => (decimal?)y.BankBalance)
                .FirstOrDefault() ?? 0;

            var vakifbankBalance = db.Banks
                .Where(x => x.BankTitle == "Vakıfbank" && x.UserId == CurrentUser.UserId)
                .Select(y => (decimal?)y.BankBalance)
                .FirstOrDefault() ?? 0;

            var isbankBalance = db.Banks
                .Where(x => x.BankTitle == "İş Bankası" && x.UserId == CurrentUser.UserId)
                .Select(y => (decimal?)y.BankBalance)
                .FirstOrDefault() ?? 0;

            var qnbBalance = db.Banks
                .Where(x => x.BankTitle == "QNB" && x.UserId == CurrentUser.UserId)
                .Select(y => (decimal?)y.BankBalance)
                .FirstOrDefault() ?? 0;

            var garantiBalance = db.Banks
                .Where(x => x.BankTitle == "Garanti BBVA" && x.UserId == CurrentUser.UserId)
                .Select(y => (decimal?)y.BankBalance)
                .FirstOrDefault() ?? 0;

            var denizBankBalance = db.Banks
                .Where(x => x.BankTitle == "DenizBank" && x.UserId == CurrentUser.UserId)
                .Select(y => (decimal?)y.BankBalance)
                .FirstOrDefault() ?? 0;

            lblZiraatBankBalance.Text = ziraatBankBalance.ToString("N2") + " ₺";
            lblVakifBankBalance.Text = vakifbankBalance.ToString("N2") + " ₺";
            lblisBankBalance.Text = isbankBalance.ToString("N2") + " ₺";
            lblQNBbalance.Text = qnbBalance.ToString("N2") + " ₺";
            lblDenizBankBalance.Text = denizBankBalance.ToString("N2") + " ₺";
            lblGarantiBalance.Text = garantiBalance.ToString("N2") + " ₺";

            // 2. Banka Hareketleri (Sadece bu kullanıcıya ait son 5 hareket)
            // Kullanıcının tüm hareketlerini tarih sırasına göre listeye alalım
            var userProcesses = db.BankProcesses
                .Where(x => x.UserId == CurrentUser.UserId)
                .OrderByDescending(x => x.BankProcessId)
                .Take(5)
                .ToList();

            // Labelleri temizleyelim (Varsayılan metinler kalmasın)
            lblBankProcess1.Text = "İşlem Bulunmuyor";
            lblBankProcess2.Text = "İşlem Bulunmuyor";
            lblBankProcess3.Text = "İşlem Bulunmuyor";
            lblBankProcess4.Text = "İşlem Bulunmuyor";
            lblBankProcess5.Text = "İşlem Bulunmuyor";

            // Kaç tane veri geldiyse sırayla yazdıralım (Null hatasını önlemek için döngü veya tekli kontrol)
            if (userProcesses.Count >= 1)
                lblBankProcess1.Text = userProcesses[0].Description + " - " + userProcesses[0].Amount + " - " + userProcesses[0].ProcessDate?.ToString("dd.MM.yyyy");

            if (userProcesses.Count >= 2)
                lblBankProcess2.Text = userProcesses[1].Description + " - " + userProcesses[1].Amount + " - " + userProcesses[1].ProcessDate?.ToString("dd.MM.yyyy");

            if (userProcesses.Count >= 3)
                lblBankProcess3.Text = userProcesses[2].Description + " - " + userProcesses[2].Amount + " - " + userProcesses[2].ProcessDate?.ToString("dd.MM.yyyy");

            if (userProcesses.Count >= 4)
                lblBankProcess4.Text = userProcesses[3].Description + " - " + userProcesses[3].Amount + " - " + userProcesses[3].ProcessDate?.ToString("dd.MM.yyyy");

            if (userProcesses.Count >= 5)
                lblBankProcess5.Text = userProcesses[4].Description + " - " + userProcesses[4].Amount + " - " + userProcesses[4].ProcessDate?.ToString("dd.MM.yyyy");
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnBankDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
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
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Close(); // Bu formu kapat, ama login açıldığı için uygulama kapanmaz
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSpendingsForm_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Close();
        }

        // Diğer sidebar buton yönlendirmelerini buraya ekleyebilirsin
    }
}