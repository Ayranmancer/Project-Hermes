namespace Hermes.Pages
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            txtEmail = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            btnAbort = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblInfo = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(197, 122);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(291, 33);
            txtEmail.TabIndex = 0;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(197, 171);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "User Name";
            txtUserName.Size = new Size(291, 33);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(197, 217);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(291, 33);
            txtPassword.TabIndex = 2;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(197, 262);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(82, 22);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnAbort
            // 
            btnAbort.Location = new Point(405, 262);
            btnAbort.Margin = new Padding(3, 2, 3, 2);
            btnAbort.Name = "btnAbort";
            btnAbort.Size = new Size(82, 22);
            btnAbort.TabIndex = 4;
            btnAbort.Text = "Abort";
            btnAbort.UseVisualStyleBackColor = true;
            btnAbort.Click += btnAbort_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(250, 82);
            label1.Name = "label1";
            label1.Size = new Size(138, 27);
            label1.TabIndex = 5;
            label1.Text = "Register For Chat";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(116, 122);
            label2.Name = "label2";
            label2.Size = new Size(52, 27);
            label2.TabIndex = 6;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(74, 178);
            label3.Name = "label3";
            label3.Size = new Size(91, 27);
            label3.TabIndex = 7;
            label3.Text = "User Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(74, 224);
            label4.Name = "label4";
            label4.Size = new Size(83, 27);
            label4.TabIndex = 8;
            label4.Text = "Password";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.ForeColor = Color.LimeGreen;
            lblInfo.Location = new Point(93, 285);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(64, 23);
            lblInfo.TabIndex = 9;
            lblInfo.Text = "Welcome";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(366, 293);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(121, 15);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Go To The Login Page";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(700, 338);
            Controls.Add(linkLabel1);
            Controls.Add(lblInfo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAbort);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtEmail);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmRegister";
            Load += frmRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnRegister;
        private Button btnAbort;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblInfo;
        private LinkLabel linkLabel1;
    }
}