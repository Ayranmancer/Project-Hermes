namespace Hermes.Pages
{
    partial class frmChat
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChat));
            panel1 = new Panel();
            lstMessage = new ListBox();
            panel2 = new Panel();
            lstFriend = new ListBox();
            label2 = new Label();
            label1 = new Label();
            lstNewMsg = new ListBox();
            panel3 = new Panel();
            txtMessage = new TextBox();
            btnSend = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lstMessage);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 305);
            panel1.TabIndex = 0;
            // 
            // lstMessage
            // 
            lstMessage.BackColor = Color.Black;
            lstMessage.Dock = DockStyle.Fill;
            lstMessage.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lstMessage.ForeColor = Color.Lime;
            lstMessage.FormattingEnabled = true;
            lstMessage.ItemHeight = 19;
            lstMessage.Location = new Point(0, 0);
            lstMessage.Margin = new Padding(3, 2, 3, 2);
            lstMessage.Name = "lstMessage";
            lstMessage.Size = new Size(555, 305);
            lstMessage.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lstFriend);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lstNewMsg);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(555, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(145, 305);
            panel2.TabIndex = 1;
            // 
            // lstFriend
            // 
            lstFriend.BackColor = Color.Black;
            lstFriend.Dock = DockStyle.Fill;
            lstFriend.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lstFriend.ForeColor = Color.LightSkyBlue;
            lstFriend.FormattingEnabled = true;
            lstFriend.ItemHeight = 19;
            lstFriend.Location = new Point(0, 15);
            lstFriend.Margin = new Padding(3, 2, 3, 2);
            lstFriend.Name = "lstFriend";
            lstFriend.Size = new Size(145, 196);
            lstFriend.TabIndex = 0;
            lstFriend.SelectedIndexChanged += lstFriend_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Bottom;
            label2.Location = new Point(0, 211);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 3;
            label2.Text = "New Message ";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 2;
            label1.Text = "Friend List";
            // 
            // lstNewMsg
            // 
            lstNewMsg.Dock = DockStyle.Bottom;
            lstNewMsg.FormattingEnabled = true;
            lstNewMsg.ItemHeight = 15;
            lstNewMsg.Location = new Point(0, 226);
            lstNewMsg.Margin = new Padding(3, 2, 3, 2);
            lstNewMsg.Name = "lstNewMsg";
            lstNewMsg.Size = new Size(145, 79);
            lstNewMsg.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtMessage);
            panel3.Controls.Add(btnSend);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 305);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(700, 33);
            panel3.TabIndex = 2;
            // 
            // txtMessage
            // 
            txtMessage.BackColor = Color.Black;
            txtMessage.Dock = DockStyle.Fill;
            txtMessage.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtMessage.ForeColor = Color.White;
            txtMessage.Location = new Point(0, 0);
            txtMessage.Margin = new Padding(3, 2, 3, 2);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(618, 33);
            txtMessage.TabIndex = 0;
            txtMessage.TextChanged += textBox1_TextChanged;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.Black;
            btnSend.Dock = DockStyle.Right;
            btnSend.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(618, 0);
            btnSend.Margin = new Padding(3, 2, 3, 2);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(82, 33);
            btnSend.TabIndex = 1;
            btnSend.Text = "SEND";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1200;
            timer1.Tick += timer1_Tick;
            // 
            // frmChat
            // 
            AcceptButton = btnSend;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmChat";
            Text = "Chat Page";
            Load += frmChat_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private ListBox lstNewMsg;
        private ListBox lstFriend;
        private TextBox txtMessage;
        private Button btnSend;
        private ListBox lstMessage;
        private System.Windows.Forms.Timer timer1;
    }
}