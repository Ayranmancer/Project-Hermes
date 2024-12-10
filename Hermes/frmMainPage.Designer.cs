namespace Hermes
{
    partial class frmMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPage));
            menuStrip = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            addFriendToolStripMenuItem = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            pagesToolStripMenuItem = new ToolStripMenuItem();
            charPageToolStripMenuItem = new ToolStripMenuItem();
            gamesToolStripMenuItem = new ToolStripMenuItem();
            pongToolStripMenuItem = new ToolStripMenuItem();
            currencyConverterToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            rockPaperScissorsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileMenu, pagesToolStripMenuItem, gamesToolStripMenuItem, currencyConverterToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(738, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, addFriendToolStripMenuItem, registerToolStripMenuItem, changePasswordToolStripMenuItem, exitToolStripMenuItem });
            fileMenu.ImageTransparentColor = SystemColors.ActiveBorder;
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(37, 20);
            fileMenu.Text = "&File";
            fileMenu.Click += fileMenu_Click;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(168, 22);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // addFriendToolStripMenuItem
            // 
            addFriendToolStripMenuItem.Name = "addFriendToolStripMenuItem";
            addFriendToolStripMenuItem.Size = new Size(168, 22);
            addFriendToolStripMenuItem.Text = "Add Friend";
            addFriendToolStripMenuItem.Click += addFriendToolStripMenuItem_Click;
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(168, 22);
            registerToolStripMenuItem.Text = "Register";
            registerToolStripMenuItem.Click += registerToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(168, 22);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(168, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += ExitToolsStripMenuItem_Click;
            // 
            // pagesToolStripMenuItem
            // 
            pagesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { charPageToolStripMenuItem });
            pagesToolStripMenuItem.Name = "pagesToolStripMenuItem";
            pagesToolStripMenuItem.Size = new Size(50, 20);
            pagesToolStripMenuItem.Text = "Pages";
            pagesToolStripMenuItem.Click += pagesToolStripMenuItem_Click;
            // 
            // charPageToolStripMenuItem
            // 
            charPageToolStripMenuItem.Name = "charPageToolStripMenuItem";
            charPageToolStripMenuItem.Size = new Size(128, 22);
            charPageToolStripMenuItem.Text = "Chat Page";
            charPageToolStripMenuItem.Click += charPageToolStripMenuItem_Click;
            // 
            // gamesToolStripMenuItem
            // 
            gamesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pongToolStripMenuItem, rockPaperScissorsToolStripMenuItem });
            gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            gamesToolStripMenuItem.Size = new Size(55, 20);
            gamesToolStripMenuItem.Text = "Games";
            // 
            // pongToolStripMenuItem
            // 
            pongToolStripMenuItem.Name = "pongToolStripMenuItem";
            pongToolStripMenuItem.Size = new Size(180, 22);
            pongToolStripMenuItem.Text = "Pong";
            pongToolStripMenuItem.Click += pongToolStripMenuItem_Click;
            // 
            // currencyConverterToolStripMenuItem
            // 
            currencyConverterToolStripMenuItem.Name = "currencyConverterToolStripMenuItem";
            currencyConverterToolStripMenuItem.Size = new Size(125, 20);
            currencyConverterToolStripMenuItem.Text = " Currency Converter";
            currencyConverterToolStripMenuItem.Click += currencyConverterToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 501);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 17, 0);
            statusStrip.Size = new Size(738, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(39, 17);
            toolStripStatusLabel.Text = "Status";
            // 
            // rockPaperScissorsToolStripMenuItem
            // 
            rockPaperScissorsToolStripMenuItem.Name = "rockPaperScissorsToolStripMenuItem";
            rockPaperScissorsToolStripMenuItem.Size = new Size(180, 22);
            rockPaperScissorsToolStripMenuItem.Text = "Rock Paper Scissors";
            rockPaperScissorsToolStripMenuItem.Click += rockPaperScissorsToolStripMenuItem_Click;
            // 
            // frmMainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(738, 523);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4);
            Name = "frmMainPage";
            Text = "Main Page";
            Load += frmMainPage_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem pagesToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem charPageToolStripMenuItem;
        private ToolStripMenuItem addFriendToolStripMenuItem;
        private ToolStripMenuItem gamesToolStripMenuItem;
        private ToolStripMenuItem pongToolStripMenuItem;
        private ToolStripMenuItem currencyConverterToolStripMenuItem;
        private ToolStripMenuItem rockPaperScissorsToolStripMenuItem;
    }
}



