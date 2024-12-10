namespace Hermes.Pages
{
    partial class frmCurrency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurrency));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            sourceCurrency = new ComboBox();
            destinationCurrency = new ComboBox();
            label3 = new Label();
            txtAmount = new TextBox();
            lblResult = new Label();
            value = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 31);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 0;
            label1.Text = "Source Currency:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 120);
            label2.Name = "label2";
            label2.Size = new Size(198, 25);
            label2.TabIndex = 1;
            label2.Text = "Destination Currency:";
            // 
            // sourceCurrency
            // 
            sourceCurrency.FormattingEnabled = true;
            sourceCurrency.Location = new Point(257, 36);
            sourceCurrency.Name = "sourceCurrency";
            sourceCurrency.Size = new Size(188, 23);
            sourceCurrency.TabIndex = 2;
            // 
            // destinationCurrency
            // 
            destinationCurrency.FormattingEnabled = true;
            destinationCurrency.Location = new Point(257, 120);
            destinationCurrency.Name = "destinationCurrency";
            destinationCurrency.Size = new Size(188, 23);
            destinationCurrency.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(29, 204);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 5;
            label3.Text = "Amount:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(257, 206);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(188, 23);
            txtAmount.TabIndex = 6;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResult.Location = new Point(366, 317);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(59, 21);
            lblResult.TabIndex = 7;
            lblResult.Text = "Result:";
            // 
            // value
            // 
            value.Location = new Point(59, 287);
            value.Name = "value";
            value.Size = new Size(142, 64);
            value.TabIndex = 8;
            value.Text = "Value";
            value.UseVisualStyleBackColor = true;
            value.Click += value_Click;
            // 
            // frmCurrency
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 516);
            Controls.Add(value);
            Controls.Add(lblResult);
            Controls.Add(txtAmount);
            Controls.Add(label3);
            Controls.Add(destinationCurrency);
            Controls.Add(sourceCurrency);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCurrency";
            Text = "Currency Convertor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Label label2;
        private ComboBox sourceCurrency;
        private ComboBox destinationCurrency;
        private Label label3;
        private TextBox txtAmount;
        private Label lblResult;
        private Button value;
    }
}