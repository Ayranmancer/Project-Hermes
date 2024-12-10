namespace Hermes.Pages
{
    partial class frmFindFriend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindFriend));
            txtFind = new TextBox();
            btnFind = new Button();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // txtFind
            // 
            txtFind.Location = new Point(173, 143);
            txtFind.Margin = new Padding(3, 2, 3, 2);
            txtFind.Multiline = true;
            txtFind.Name = "txtFind";
            txtFind.PlaceholderText = "User Name";
            txtFind.Size = new Size(345, 38);
            txtFind.TabIndex = 0;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(277, 200);
            btnFind.Margin = new Padding(3, 2, 3, 2);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(135, 31);
            btnFind.TabIndex = 1;
            btnFind.Text = "FIND";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.ForeColor = Color.LimeGreen;
            lblInfo.Location = new Point(312, 233);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(64, 23);
            lblInfo.TabIndex = 10;
            lblInfo.Text = "Welcome";
            // 
            // frmFindFriend
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(700, 338);
            Controls.Add(lblInfo);
            Controls.Add(btnFind);
            Controls.Add(txtFind);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmFindFriend";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Find & Add Friend";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFind;
        private Button btnFind;
        private Label lblInfo;
    }
}