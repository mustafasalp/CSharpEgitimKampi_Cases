// FrmLogin.cs
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtLoginUsername.Text;
            var password = txtLoginPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Tüm alanlar doldurulmalıdır.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = AuthenticateUser(username, password);

            if (user == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearAllTextBoxes();
                return;
            }

            // Session set -> CurrentUser set ediliyor.
            // İçeride kullanacağız.
            CurrentUser.UserId = user.UserId;
            CurrentUser.Username = user.Username;
            CurrentUser.IsAdmin = user.IsAdmin;

            MessageBox.Show($"Giriş başarılı hoşgeldiniz {user.Username}", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }
        private Users AuthenticateUser(string username, string password)
        {
            string hashedPassword = PasswordHelper.HashPassword(password);

            // Ölye bir kullanıcı yok ise null dönecek
            return db.Users.FirstOrDefault(x =>
                x.Username == username &&
                x.PasswordHash == hashedPassword);
        }

        private void ClearAllTextBoxes()
        {
            txtLoginUsername.Clear();
            txtLoginPassword.Clear();
        }

        private void linkGoToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (FrmRegister frm = new FrmRegister())
            {
                frm.ShowDialog();
            }
        }
    }
}
