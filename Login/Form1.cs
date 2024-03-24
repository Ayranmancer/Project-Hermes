using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Login
{
    public partial class Form1 : Form
    {

        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JEI1A7L\\SQLEXPRESS; Initial Catalog=Project-Hermes-Reborn; Integrated Security=TRUE");
        // Initial Catalog isimleri farkli !!!

        public Form1()
        {
            InitializeComponent();
        }

        //merhaba selam
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        char? none = null;
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Silver;
                textBox2.PasswordChar = Convert.ToChar(none);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //bug olursa burayi sil 
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string pass = textBox2.Text;
            bool isThere = false;

            connection.Open();
            SqlCommand command = new SqlCommand("Select *from Hermes_Table_1", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (username == Cryptology.Decryption (reader["username"].ToString().TrimEnd(),5) && pass == Cryptology.Decryption (reader["pass"].ToString().TrimEnd(),5))
                // Cryptology.Decryption keyi 5 
                {
                    isThere = true;
                    break;
                }

                else
                {
                    isThere = false;
                }
            }

            connection.Close();

            if (isThere)
            {
                MessageBox.Show("Welcome!!", "Program");
            }

            else
            {
                MessageBox.Show("Login Failed!!", "Program");
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
            // giris ekranindan kayit ekranina gecme 
        }
    }
}
