namespace Hermes.Pages
{
    partial class frmRockPaperScissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRockPaperScissors));
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            CPU_PIC = new PictureBox();
            PLAYER_PIC = new PictureBox();
            lblCPUchoice = new Label();
            lblPlayerchoice = new Label();
            lblPlayerresult = new Label();
            lblCPUresult = new Label();
            ((System.ComponentModel.ISupportInitialize)CPU_PIC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PLAYER_PIC).BeginInit();
            SuspendLayout();
            // 
            // btnRock
            // 
            btnRock.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRock.Location = new Point(58, 344);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(145, 65);
            btnRock.TabIndex = 0;
            btnRock.Tag = "R";
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += MakeChoiceEvent;
            // 
            // btnPaper
            // 
            btnPaper.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPaper.Location = new Point(281, 344);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(145, 65);
            btnPaper.TabIndex = 1;
            btnPaper.Tag = "P";
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += MakeChoiceEvent;
            // 
            // btnScissors
            // 
            btnScissors.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnScissors.Location = new Point(491, 344);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(145, 65);
            btnScissors.TabIndex = 2;
            btnScissors.Tag = "S";
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += MakeChoiceEvent;
            // 
            // CPU_PIC
            // 
            CPU_PIC.Location = new Point(307, 46);
            CPU_PIC.Name = "CPU_PIC";
            CPU_PIC.Size = new Size(100, 100);
            CPU_PIC.SizeMode = PictureBoxSizeMode.Zoom;
            CPU_PIC.TabIndex = 3;
            CPU_PIC.TabStop = false;
            CPU_PIC.Click += MakeChoiceEvent;
            // 
            // PLAYER_PIC
            // 
            PLAYER_PIC.Location = new Point(307, 183);
            PLAYER_PIC.Name = "PLAYER_PIC";
            PLAYER_PIC.Size = new Size(100, 100);
            PLAYER_PIC.SizeMode = PictureBoxSizeMode.Zoom;
            PLAYER_PIC.TabIndex = 4;
            PLAYER_PIC.TabStop = false;
            // 
            // lblCPUchoice
            // 
            lblCPUchoice.AutoSize = true;
            lblCPUchoice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCPUchoice.ForeColor = Color.WhiteSmoke;
            lblCPUchoice.Location = new Point(281, 9);
            lblCPUchoice.Name = "lblCPUchoice";
            lblCPUchoice.Size = new Size(159, 25);
            lblCPUchoice.TabIndex = 5;
            lblCPUchoice.Text = "Computer Choice";
            // 
            // lblPlayerchoice
            // 
            lblPlayerchoice.AutoSize = true;
            lblPlayerchoice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayerchoice.ForeColor = Color.WhiteSmoke;
            lblPlayerchoice.Location = new Point(281, 301);
            lblPlayerchoice.Name = "lblPlayerchoice";
            lblPlayerchoice.Size = new Size(127, 25);
            lblPlayerchoice.TabIndex = 6;
            lblPlayerchoice.Text = "Player Choice";
            // 
            // lblPlayerresult
            // 
            lblPlayerresult.AutoSize = true;
            lblPlayerresult.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayerresult.ForeColor = Color.WhiteSmoke;
            lblPlayerresult.Location = new Point(58, 159);
            lblPlayerresult.Name = "lblPlayerresult";
            lblPlayerresult.Size = new Size(119, 25);
            lblPlayerresult.TabIndex = 7;
            lblPlayerresult.Text = "Player Result";
            // 
            // lblCPUresult
            // 
            lblCPUresult.AutoSize = true;
            lblCPUresult.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCPUresult.ForeColor = Color.WhiteSmoke;
            lblCPUresult.Location = new Point(517, 159);
            lblCPUresult.Name = "lblCPUresult";
            lblCPUresult.Size = new Size(151, 25);
            lblCPUresult.TabIndex = 8;
            lblCPUresult.Text = "Computer Result";
            // 
            // frmRockPaperScissors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(756, 452);
            Controls.Add(lblCPUresult);
            Controls.Add(lblPlayerresult);
            Controls.Add(lblPlayerchoice);
            Controls.Add(lblCPUchoice);
            Controls.Add(PLAYER_PIC);
            Controls.Add(CPU_PIC);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRockPaperScissors";
            Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)CPU_PIC).EndInit();
            ((System.ComponentModel.ISupportInitialize)PLAYER_PIC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private PictureBox CPU_PIC;
        private PictureBox PLAYER_PIC;
        private Label lblCPUchoice;
        private Label lblPlayerchoice;
        private Label lblPlayerresult;
        private Label lblCPUresult;
    }
}