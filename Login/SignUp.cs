using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class SignUp : Form
    {

        SqlConnection connection = Form1.connection;


        public SignUp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Insert into Hermes_Table_1 (username,pass,re_pass,e_mail) values ('" + Cryptology.Encryption(textBox1.Text, 5) + "', '" + Cryptology.Encryption(textBox2.Text, 5) + "', '" + Cryptology.Encryption(textBox3.Text, 5) + "','" + Cryptology.Encryption(textBox4.Text, 5) + "' )", connection);
            //Cryptology.Encryption da key 5 kullanildi.
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("!!!", "Program");

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = Color.Silver;

            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.White;
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            char? none = null;
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Silver;
                textBox2.PasswordChar = Convert.ToChar(none);
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Re_Password")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.White;
                textBox3.PasswordChar = '*';
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            char? none = null;
            if (textBox3.Text == "")
            {
                textBox3.Text = "Re_Password";
                textBox3.ForeColor = Color.Silver;
                textBox3.PasswordChar = Convert.ToChar(none);
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "e-Mail")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.White;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {

            if (textBox4.Text == "")
            {
                textBox4.Text = "e-Mail";
                textBox4.ForeColor = Color.Silver;
            }
        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void SignUp_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void SignUp_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void SignUp_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
            // kayit ekranindan giris ekranina gecme 
        }
    }
}
