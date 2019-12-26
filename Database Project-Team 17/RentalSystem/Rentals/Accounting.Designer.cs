namespace Rentals
{
    partial class Accounting
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
            this.label1 = new System.Windows.Forms.Label();
            this.Ownersbox = new System.Windows.Forms.ComboBox();
            this.Income = new System.Windows.Forms.Label();
            this.minus = new System.Windows.Forms.Label();
            this.Expenses = new System.Windows.Forms.Label();
            this.equal = new System.Windows.Forms.Label();
            this.Profit = new System.Windows.Forms.Label();
            this.OneOwner = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick Owner";
            // 
            // Ownersbox
            // 
            this.Ownersbox.FormattingEnabled = true;
            this.Ownersbox.Location = new System.Drawing.Point(60, 108);
            this.Ownersbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ownersbox.Name = "Ownersbox";
            this.Ownersbox.Size = new System.Drawing.Size(160, 24);
            this.Ownersbox.TabIndex = 1;
            // 
            // Income
            // 
            this.Income.AutoSize = true;
            this.Income.Location = new System.Drawing.Point(88, 208);
            this.Income.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Income.Name = "Income";
            this.Income.Size = new System.Drawing.Size(16, 17);
            this.Income.TabIndex = 2;
            this.Income.Text = "0";
            // 
            // minus
            // 
            this.minus.AutoSize = true;
            this.minus.Location = new System.Drawing.Point(143, 208);
            this.minus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(13, 17);
            this.minus.TabIndex = 3;
            this.minus.Text = "-";
            // 
            // Expenses
            // 
            this.Expenses.AutoSize = true;
            this.Expenses.Location = new System.Drawing.Point(164, 208);
            this.Expenses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Expenses.Name = "Expenses";
            this.Expenses.Size = new System.Drawing.Size(16, 17);
            this.Expenses.TabIndex = 4;
            this.Expenses.Text = "0";
            this.Expenses.Click += new System.EventHandler(this.Expenses_Click);
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Location = new System.Drawing.Point(243, 208);
            this.equal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(16, 17);
            this.equal.TabIndex = 5;
            this.equal.Text = "=";
            // 
            // Profit
            // 
            this.Profit.AutoSize = true;
            this.Profit.Location = new System.Drawing.Point(268, 208);
            this.Profit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Profit.Name = "Profit";
            this.Profit.Size = new System.Drawing.Size(16, 17);
            this.Profit.TabIndex = 6;
            this.Profit.Text = "0";
            // 
            // OneOwner
            // 
            this.OneOwner.Location = new System.Drawing.Point(247, 106);
            this.OneOwner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OneOwner.Name = "OneOwner";
            this.OneOwner.Size = new System.Drawing.Size(100, 28);
            this.OneOwner.TabIndex = 7;
            this.OneOwner.Text = "One Owner";
            this.OneOwner.UseVisualStyleBackColor = true;
            this.OneOwner.Click += new System.EventHandler(this.OneOwner_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 108);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "All Owners";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Profit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Expenses";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Income";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Accounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 266);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OneOwner);
            this.Controls.Add(this.Profit);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.Expenses);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.Income);
            this.Controls.Add(this.Ownersbox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Accounting";
            this.Text = "Accounting";
            this.Load += new System.EventHandler(this.Accounting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Ownersbox;
        private System.Windows.Forms.Label Income;
        private System.Windows.Forms.Label minus;
        private System.Windows.Forms.Label Expenses;
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.Label Profit;
        private System.Windows.Forms.Button OneOwner;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}