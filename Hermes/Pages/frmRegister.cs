using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hermes.Data;
using Hermes.Data.Models;
using System.Security.Cryptography;

namespace Hermes.Pages
{
    public partial class frmRegister : Form
    {

        private readonly ApplicationDbContext _context = new ApplicationDbContext();  


        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (IsUniqeUser())
            {


                User user = new User()
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = txtUserName.Text,
                    Email = txtEmail.Text,
                    Password = SHA256Hash(txtPassword.Text),
                };

                _context.Users.Add(user);
                _context.SaveChanges();

                lblInfo.ForeColor = Color.Green;
                lblInfo.Text = "Your Registration was successful";

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
            txtUserName.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
        }

        private bool IsUniqeUser()
        {
            if (String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = "Fill in all fields";
                return false;
            }
            else
            {
                if (_context.Users.FirstOrDefault(x => x.UserName == txtUserName.Text) != null) 
                {
                    lblInfo.ForeColor = Color.Red;
                    lblInfo.Text = "This User Name is already in use";
                    return false;
                }

                if (_context.Users.FirstOrDefault(x => x.Email == txtEmail.Text) != null)
                {
                    lblInfo.ForeColor = Color.Red;
                    lblInfo.Text = "This email is already in use";
                    return false;
                }
            }
            return true;
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Dispose();
            frm.ShowDialog();
        }
    }
}
