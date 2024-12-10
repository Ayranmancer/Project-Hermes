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

    public partial class frmChangePassword : Form
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtOldPassword.Text) || String.IsNullOrEmpty(txtNewPassword.Text) || String.IsNullOrEmpty(SHA256Hash(txtRptNewPass.Text)))
            {
                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = "Fill in all fields";
            }
            else
            {
                var user = _context.Users.FirstOrDefault(x => x.UserName == frmMainPage.userName && x.Password == SHA256Hash(txtOldPassword.Text));

                if (user == null)
                {
                    lblInfo.ForeColor = Color.Red;
                    lblInfo.Text = "You entered an incorrect password";
                }
                else
                {
                    if (txtNewPassword.Text != txtRptNewPass.Text)
                    {
                        lblInfo.ForeColor = Color.Red;
                        lblInfo.Text = "Passwords are not the same";
                    }
                    else
                    {
                        user.Password = SHA256Hash(txtNewPassword.Text);
                        _context.Users.Update(user);
                        _context.SaveChanges();

                        lblInfo.ForeColor = Color.Green;
                        lblInfo.Text = "Passwords has changed";
                    }
                }
                ClearAllTextBox();
            }
        }
        string SHA256Hash(string input)
        {
            var inputBytes = Encoding.UTF8.GetBytes(input);
            var inputHash = SHA256.HashData(inputBytes);
            return Convert.ToHexString(inputHash);
        }

        void ClearAllTextBox()
        {
            txtNewPassword.Clear();
            txtOldPassword.Clear();
            txtRptNewPass.Clear();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
