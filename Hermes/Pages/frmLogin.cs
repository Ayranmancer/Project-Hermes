using Hermes.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Hermes.Pages
{
    public partial class frmLogin : Form
    {

        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _context.Users.FirstOrDefault(x => x.UserName == txtUserName.Text && x.Password == SHA256Hash(txtPassword.Text));

            if (user == null || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Username or password is incorrect");
                ClearAllText();
            }
            else
            {
                frmMainPage.userId = user.Id;
                frmMainPage.userName = user.UserName;
                MessageBox.Show("Welcome");
                this.Close();
            }

        }
        string SHA256Hash(string input)
        {
            var inputBytes = Encoding.UTF8.GetBytes(input);
            var inputHash = SHA256.HashData(inputBytes);
            return Convert.ToHexString(inputHash);
        }

        void ClearAllText()
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }


        private void btnAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frm = new frmRegister();
            this.Dispose();
            frm.ShowDialog();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
