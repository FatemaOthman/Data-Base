namespace Rentals
{
    partial class Expenses
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
            this.Amount = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.Owners = new System.Windows.Forms.ComboBox();
            this.Leases = new System.Windows.Forms.ComboBox();
            this.Reason = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddExpense = new System.Windows.Forms.Button();
            this.ExpenseID = new System.Windows.Forms.ComboBox();
            this.UpdateExpense = new System.Windows.Forms.Button();
            this.DeleteExpense = new System.Windows.Forms.Button();
            this.ExpenseView = new System.Windows.Forms.DataGridView();
            this.ViewAllOwners = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseView)).BeginInit();
            this.SuspendLayout();
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(117, 95);
            this.Amount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(160, 22);
            this.Amount.TabIndex = 0;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(117, 143);
            this.date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(239, 22);
            this.date.TabIndex = 1;
            // 
            // Owners
            // 
            this.Owners.FormattingEnabled = true;
            this.Owners.Location = new System.Drawing.Point(117, 32);
            this.Owners.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Owners.Name = "Owners";
            this.Owners.Size = new System.Drawing.Size(160, 24);
            this.Owners.TabIndex = 3;
            // 
            // Leases
            // 
            this.Leases.FormattingEnabled = true;
            this.Leases.Location = new System.Drawing.Point(117, 246);
            this.Leases.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Leases.Name = "Leases";
            this.Leases.Size = new System.Drawing.Size(160, 24);
            this.Leases.TabIndex = 4;
            // 
            // Reason
            // 
            this.Reason.Location = new System.Drawing.Point(117, 193);
            this.Reason.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reason.Name = "Reason";
            this.Reason.Size = new System.Drawing.Size(160, 22);
            this.Reason.TabIndex = 5;
            this.Reason.TextChanged += new System.EventHandler(this.Reason_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Owner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Reason";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lease (if any)";
            // 
            // AddExpense
            // 
            this.AddExpense.Location = new System.Drawing.Point(149, 308);
            this.AddExpense.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddExpense.Name = "AddExpense";
            this.AddExpense.Size = new System.Drawing.Size(129, 28);
            this.AddExpense.TabIndex = 11;
            this.AddExpense.Text = "Add Expense";
            this.AddExpense.UseVisualStyleBackColor = true;
            this.AddExpense.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExpenseID
            // 
            this.ExpenseID.FormattingEnabled = true;
            this.ExpenseID.Location = new System.Drawing.Point(371, 32);
            this.ExpenseID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExpenseID.Name = "ExpenseID";
            this.ExpenseID.Size = new System.Drawing.Size(160, 24);
            this.ExpenseID.TabIndex = 12;
            // 
            // UpdateExpense
            // 
            this.UpdateExpense.Location = new System.Drawing.Point(371, 64);
            this.UpdateExpense.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateExpense.Name = "UpdateExpense";
            this.UpdateExpense.Size = new System.Drawing.Size(129, 28);
            this.UpdateExpense.TabIndex = 13;
            this.UpdateExpense.Text = "Update Expense";
            this.UpdateExpense.UseVisualStyleBackColor = true;
            this.UpdateExpense.Click += new System.EventHandler(this.UpdateExpense_Click);
            // 
            // DeleteExpense
            // 
            this.DeleteExpense.Location = new System.Drawing.Point(371, 100);
            this.DeleteExpense.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteExpense.Name = "DeleteExpense";
            this.DeleteExpense.Size = new System.Drawing.Size(129, 28);
            this.DeleteExpense.TabIndex = 14;
            this.DeleteExpense.Text = "Delete Expense";
            this.DeleteExpense.UseVisualStyleBackColor = true;
            this.DeleteExpense.Click += new System.EventHandler(this.DeleteExpense_Click);
            // 
            // ExpenseView
            // 
            this.ExpenseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpenseView.Location = new System.Drawing.Point(356, 207);
            this.ExpenseView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExpenseView.Name = "ExpenseView";
            this.ExpenseView.Size = new System.Drawing.Size(680, 346);
            this.ExpenseView.TabIndex = 15;
            // 
            // ViewAllOwners
            // 
            this.ViewAllOwners.Location = new System.Drawing.Point(863, 171);
            this.ViewAllOwners.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewAllOwners.Name = "ViewAllOwners";
            this.ViewAllOwners.Size = new System.Drawing.Size(173, 28);
            this.ViewAllOwners.TabIndex = 16;
            this.ViewAllOwners.Text = "View All Expenses";
            this.ViewAllOwners.UseVisualStyleBackColor = true;
            this.ViewAllOwners.Click += new System.EventHandler(this.ViewAllOwners_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Update the expense by ID";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(980, 11);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 38);
            this.Back.TabIndex = 19;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ViewAllOwners);
            this.Controls.Add(this.ExpenseView);
            this.Controls.Add(this.DeleteExpense);
            this.Controls.Add(this.UpdateExpense);
            this.Controls.Add(this.ExpenseID);
            this.Controls.Add(this.AddExpense);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reason);
            this.Controls.Add(this.Leases);
            this.Controls.Add(this.Owners);
            this.Controls.Add(this.date);
            this.Controls.Add(this.Amount);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Expenses";
            this.Text = "Expenses";
            this.Load += new System.EventHandler(this.Expenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox Owners;
        private System.Windows.Forms.ComboBox Leases;
        private System.Windows.Forms.TextBox Reason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddExpense;
        private System.Windows.Forms.ComboBox ExpenseID;
        private System.Windows.Forms.Button UpdateExpense;
        private System.Windows.Forms.Button DeleteExpense;
        private System.Windows.Forms.DataGridView ExpenseView;
        private System.Windows.Forms.Button ViewAllOwners;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Back;
    }
}