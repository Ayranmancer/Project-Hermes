namespace Hermes.Pages
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            btnAbort = new Button();
            btnRegister = new Button();
            txtRptNewPass = new TextBox();
            txtNewPassword = new TextBox();
            txtOldPassword = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // btnAbort
            // 
            btnAbort.Location = new Point(413, 228);
            btnAbort.Margin = new Padding(3, 2, 3, 2);
            btnAbort.Name = "btnAbort";
            btnAbort.Size = new Size(82, 22);
            btnAbort.TabIndex = 4;
            btnAbort.Text = "Abort";
            btnAbort.UseVisualStyleBackColor = true;
            btnAbort.Click += btnAbort_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(205, 228);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(82, 22);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Change";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtRptNewPass
            // 
            txtRptNewPass.Location = new Point(205, 182);
            txtRptNewPass.Margin = new Padding(3, 2, 3, 2);
            txtRptNewPass.Multiline = true;
            txtRptNewPass.Name = "txtRptNewPass";
            txtRptNewPass.PasswordChar = '*';
            txtRptNewPass.PlaceholderText = "New Password Repeat";
            txtRptNewPass.Size = new Size(291, 33);
            txtRptNewPass.TabIndex = 2;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(205, 136);
            txtNewPassword.Margin = new Padding(3, 2, 3, 2);
            txtNewPassword.Multiline = true;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.PlaceholderText = "New Password";
            txtNewPassword.Size = new Size(291, 33);
            txtNewPassword.TabIndex = 1;
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(205, 88);
            txtOldPassword.Margin = new Padding(3, 2, 3, 2);
            txtOldPassword.Multiline = true;
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.PlaceholderText = "Old Password";
            txtOldPassword.Size = new Size(291, 33);
            txtOldPassword.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(61, 94);
            label4.Name = "label4";
            label4.Size = new Size(111, 27);
            label4.TabIndex = 10;
            label4.Text = "Old Password";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(61, 136);
            label1.Name = "label1";
            label1.Size = new Size(119, 27);
            label1.TabIndex = 11;
            label1.Text = "New Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 189);
            label2.Name = "label2";
            label2.Size = new Size(175, 27);
            label2.TabIndex = 12;
            label2.Text = "Repeat New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(269, 49);
            label3.Name = "label3";
            label3.Size = new Size(141, 27);
            label3.TabIndex = 13;
            label3.Text = "Change Password";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.ForeColor = Color.LimeGreen;
            lblInfo.Location = new Point(121, 254);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(64, 23);
            lblInfo.TabIndex = 14;
            lblInfo.Text = "Welcome";
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(700, 338);
            Controls.Add(lblInfo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(btnAbort);
            Controls.Add(btnRegister);
            Controls.Add(txtRptNewPass);
            Controls.Add(txtNewPassword);
            Controls.Add(txtOldPassword);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmChangePassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Change Password ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAbort;
        private Button btnRegister;
        private TextBox txtRptNewPass;
        private TextBox txtNewPassword;
        private TextBox txtOldPassword;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblInfo;
    }
}