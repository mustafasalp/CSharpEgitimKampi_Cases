// FrmRegister.cs
using MyFinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCrm.Helpers;

namespace MyFinancialCrm
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisterCreate_Click(object sender, EventArgs e)
        {
            var username = txtRegisterUsername.Text;
            var password = txtRegisterPassword.Text;
            var passwordConfirm = txtRegisterConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(passwordConfirm))
            {
                MessageBox.Show("Tüm alanlar doldurulmalıdır.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != passwordConfirm)
            {
                MessageBox.Show("Şifreler eşleşmiyor.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearAllTextBoxes();
                return;
            }

            if (!IsValid(username))
            {
                MessageBox.Show($"{username} kullanıcı adı daha önce kullanılmış.", "Uyarı", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                ClearAllTextBoxes();
                return;
            }

            var user = new Users
            {
                Username = username,
                PasswordHash = PasswordHelper.HashPassword(password),
                // Hatanın çözümü buradadır:
                CreatedAt = DateTime.Now
            };

            db.Users.Add(user);
            db.SaveChanges();

            MessageBox.Show("Kayıt başarılı.", "Bilgi",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private bool IsValid(string username)
        {
            // db de öyle  bir kullanıcı varmı ki verilen username ile aynı username'e sahip
            // varsa false dön
            return !db.Users.Any(x => x.Username == username); 
        }
        
        private void ClearAllTextBoxes()
        {
            txtRegisterConfirmPassword.Clear();
            txtRegisterPassword.Clear();
            txtRegisterUsername.Clear();
        }
    }
}
