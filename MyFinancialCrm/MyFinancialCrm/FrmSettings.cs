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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyFinancialCrm
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            txtSettingsUsername.Text = CurrentUser.Username;
        }

        private void btnChangeInfos_Click(object sender, EventArgs e)
        {
            var updatedUsername = txtSettingsUsername.Text;
            var updatedPassword = txtSettingsPassword.Text;
            var updatedConfirmPassword = txtSettingsConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(updatedUsername) ||
                string.IsNullOrWhiteSpace(updatedPassword) ||
                string.IsNullOrWhiteSpace(updatedConfirmPassword))
            {
                MessageBox.Show("Tüm alanlar doldurulmalıdır.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (updatedPassword != updatedConfirmPassword)
            {
                MessageBox.Show("Şifreler eşleşmiyor.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearAllTextBoxes();
                return;
            }

            if (!IsUsernameAvailable(updatedUsername))
            {
                MessageBox.Show($"{updatedUsername} kullanıcı adı daha önce kullanılmış.", "Uyarı", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                ClearAllTextBoxes();
                return;
            }

            // 4. Güncelleme İşlemi
            try
            {
                // Mevcut kullanıcıyı veritabanından bul
                var user = db.Users.Find(CurrentUser.UserId);

                if (user != null)
                {
                    user.Username = updatedUsername;
                    // Yeni şifreyi helper ile hashliyoruz
                    user.PasswordHash = MyFinancialCrm.Helpers.PasswordHelper.HashPassword(updatedPassword);

                    db.SaveChanges();

                    // Session (Statik sınıf) bilgilerini de güncelle
                    CurrentUser.Username = updatedUsername;

                    MessageBox.Show("Bilgileriniz başarıyla güncellendi. Yeni şifrenizle giriş yapmanız için login ekranına yönlendiriliyorsunuz.", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CurrentUser.UserId = 0;
                    CurrentUser.Username = null;

                    FrmLogin frm = new FrmLogin();
                    frm.Show();
                    this.Close(); // Ayarlar formunu kapatır
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsUsernameAvailable(string username)
        {
            // db de öyle  bir kullanıcı varmı ki verilen username ile aynı username'e sahip
            // varsa false dön
            return !db.Users.Any(x => x.Username == username && x.UserId != CurrentUser.UserId);
        }

        private void ClearAllTextBoxes()
        {
            txtSettingsConfirmPassword.Clear();
            txtSettingsPassword.Clear();
            txtSettingsUsername.Clear();
        }

        private void linkGoToDashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Close(); // Ayarlar formunu kapatır
        }
    }
}
