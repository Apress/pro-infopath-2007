namespace Converter_Addin
{
    partial class Converter
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
            this.lstFromCurrency = new System.Windows.Forms.ListBox();
            this.lstToCurrency = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFromAmount = new System.Windows.Forms.TextBox();
            this.txtToAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFromCurrency
            // 
            this.lstFromCurrency.FormattingEnabled = true;
            this.lstFromCurrency.Items.AddRange(new object[] {
            "AUD - Australian Dollar",
            "CAD - Canadian Dollar",
            "EUR - Euro",
            "GBP - Great Britain Pound",
            "JPY - Japanese Yen",
            "USD - US Dollar"});
            this.lstFromCurrency.Location = new System.Drawing.Point(12, 35);
            this.lstFromCurrency.Name = "lstFromCurrency";
            this.lstFromCurrency.Size = new System.Drawing.Size(120, 95);
            this.lstFromCurrency.TabIndex = 0;
            // 
            // lstToCurrency
            // 
            this.lstToCurrency.FormattingEnabled = true;
            this.lstToCurrency.Items.AddRange(new object[] {
            "AUD - Australian Dollar",
            "CAD - Canadian Dollar",
            "EUR - Euro",
            "GBP - Great Britain Pound",
            "JPY - Japanese Yen",
            "USD - US Dollar"});
            this.lstToCurrency.Location = new System.Drawing.Point(160, 35);
            this.lstToCurrency.Name = "lstToCurrency";
            this.lstToCurrency.Size = new System.Drawing.Size(120, 95);
            this.lstToCurrency.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount";
            // 
            // txtFromAmount
            // 
            this.txtFromAmount.Location = new System.Drawing.Point(12, 163);
            this.txtFromAmount.Name = "txtFromAmount";
            this.txtFromAmount.Size = new System.Drawing.Size(100, 20);
            this.txtFromAmount.TabIndex = 4;
            // 
            // txtToAmount
            // 
            this.txtToAmount.Location = new System.Drawing.Point(163, 162);
            this.txtToAmount.Name = "txtToAmount";
            this.txtToAmount.Size = new System.Drawing.Size(100, 20);
            this.txtToAmount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "To";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 240);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtToAmount);
            this.Controls.Add(this.txtFromAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstToCurrency);
            this.Controls.Add(this.lstFromCurrency);
            this.Name = "Converter";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFromCurrency;
        private System.Windows.Forms.ListBox lstToCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFromAmount;
        private System.Windows.Forms.TextBox txtToAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}