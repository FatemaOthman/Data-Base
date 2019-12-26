namespace Rentals
{
    partial class Employee
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
            this.label3 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.ContID = new System.Windows.Forms.ComboBox();
            this.OwnID = new System.Windows.Forms.ComboBox();
            this.Type = new System.Windows.Forms.ComboBox();
            this.MgrID = new System.Windows.Forms.ComboBox();
            this.Hdate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UnPay = new System.Windows.Forms.Button();
            this.Pay_Os_Salary = new System.Windows.Forms.Button();
            this.Search_SSN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SH_ALL = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CashSearch = new System.Windows.Forms.CheckBox();
            this.AcountantSearch = new System.Windows.Forms.CheckBox();
            this.ManagerSearch = new System.Windows.Forms.CheckBox();
            this.Search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SSN = new System.Windows.Forms.NumericUpDown();
            this.Salary = new System.Windows.Forms.NumericUpDown();
            this.PayManValue = new System.Windows.Forms.NumericUpDown();
            this.Pay_Manual = new System.Windows.Forms.Button();
            this.OSSalary = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.HasMGR = new System.Windows.Forms.CheckBox();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SSN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayManValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OSSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "ID";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(144, 88);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 47;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(87, 428);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 45;
            this.Add.Text = "Add ";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ContID
            // 
            this.ContID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ContID.FormattingEnabled = true;
            this.ContID.Location = new System.Drawing.Point(144, 394);
            this.ContID.Name = "ContID";
            this.ContID.Size = new System.Drawing.Size(121, 21);
            this.ContID.TabIndex = 44;
            // 
            // OwnID
            // 
            this.OwnID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OwnID.FormattingEnabled = true;
            this.OwnID.Location = new System.Drawing.Point(144, 357);
            this.OwnID.Name = "OwnID";
            this.OwnID.Size = new System.Drawing.Size(121, 21);
            this.OwnID.TabIndex = 43;
            // 
            // Type
            // 
            this.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(144, 254);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(121, 21);
            this.Type.TabIndex = 42;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // MgrID
            // 
            this.MgrID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MgrID.FormattingEnabled = true;
            this.MgrID.Location = new System.Drawing.Point(144, 297);
            this.MgrID.Name = "MgrID";
            this.MgrID.Size = new System.Drawing.Size(121, 21);
            this.MgrID.TabIndex = 41;
            // 
            // Hdate
            // 
            this.Hdate.Location = new System.Drawing.Point(144, 215);
            this.Hdate.Name = "Hdate";
            this.Hdate.Size = new System.Drawing.Size(200, 20);
            this.Hdate.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Contact ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Owner ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Manager ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Hiring Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Salary ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "SSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "First Name";
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(144, 51);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(100, 20);
            this.Lname.TabIndex = 28;
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(144, 12);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(100, 20);
            this.Fname.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(362, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(379, 343);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UnPay
            // 
            this.UnPay.Location = new System.Drawing.Point(563, 428);
            this.UnPay.Name = "UnPay";
            this.UnPay.Size = new System.Drawing.Size(84, 23);
            this.UnPay.TabIndex = 49;
            this.UnPay.Text = "UnPay";
            this.UnPay.UseVisualStyleBackColor = true;
            this.UnPay.Click += new System.EventHandler(this.UnPay_Click);
            // 
            // Pay_Os_Salary
            // 
            this.Pay_Os_Salary.Location = new System.Drawing.Point(396, 428);
            this.Pay_Os_Salary.Name = "Pay_Os_Salary";
            this.Pay_Os_Salary.Size = new System.Drawing.Size(142, 23);
            this.Pay_Os_Salary.TabIndex = 50;
            this.Pay_Os_Salary.Text = "Pay OutStanding Salary";
            this.Pay_Os_Salary.UseVisualStyleBackColor = true;
            this.Pay_Os_Salary.Click += new System.EventHandler(this.Pay_Os_Salary_Click);
            // 
            // Search_SSN
            // 
            this.Search_SSN.Location = new System.Drawing.Point(768, 200);
            this.Search_SSN.Name = "Search_SSN";
            this.Search_SSN.Size = new System.Drawing.Size(100, 20);
            this.Search_SSN.TabIndex = 51;
            this.Search_SSN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(765, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Search By SSN";
            // 
            // SH_ALL
            // 
            this.SH_ALL.Location = new System.Drawing.Point(829, 140);
            this.SH_ALL.Name = "SH_ALL";
            this.SH_ALL.Size = new System.Drawing.Size(75, 23);
            this.SH_ALL.TabIndex = 53;
            this.SH_ALL.Text = "Show ALL ";
            this.SH_ALL.UseVisualStyleBackColor = true;
            this.SH_ALL.Click += new System.EventHandler(this.SH_ALL_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CashSearch);
            this.groupBox1.Controls.Add(this.AcountantSearch);
            this.groupBox1.Controls.Add(this.ManagerSearch);
            this.groupBox1.Location = new System.Drawing.Point(768, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 119);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // CashSearch
            // 
            this.CashSearch.AutoSize = true;
            this.CashSearch.Location = new System.Drawing.Point(19, 75);
            this.CashSearch.Name = "CashSearch";
            this.CashSearch.Size = new System.Drawing.Size(94, 17);
            this.CashSearch.TabIndex = 2;
            this.CashSearch.Text = "Cash Collector";
            this.CashSearch.UseVisualStyleBackColor = true;
            // 
            // AcountantSearch
            // 
            this.AcountantSearch.AutoSize = true;
            this.AcountantSearch.Location = new System.Drawing.Point(19, 52);
            this.AcountantSearch.Name = "AcountantSearch";
            this.AcountantSearch.Size = new System.Drawing.Size(81, 17);
            this.AcountantSearch.TabIndex = 1;
            this.AcountantSearch.Text = "Accountant";
            this.AcountantSearch.UseVisualStyleBackColor = true;
            this.AcountantSearch.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ManagerSearch
            // 
            this.ManagerSearch.AutoSize = true;
            this.ManagerSearch.Location = new System.Drawing.Point(19, 29);
            this.ManagerSearch.Name = "ManagerSearch";
            this.ManagerSearch.Size = new System.Drawing.Size(68, 17);
            this.ManagerSearch.TabIndex = 0;
            this.ManagerSearch.Text = "Manager";
            this.ManagerSearch.UseVisualStyleBackColor = true;
            this.ManagerSearch.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(829, 236);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 58;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(284, 428);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 59;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // SSN
            // 
            this.SSN.Location = new System.Drawing.Point(144, 116);
            this.SSN.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.SSN.Name = "SSN";
            this.SSN.Size = new System.Drawing.Size(136, 20);
            this.SSN.TabIndex = 60;
            this.SSN.Value = new decimal(new int[] {
            1160000,
            0,
            0,
            0});
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(144, 179);
            this.Salary.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(136, 20);
            this.Salary.TabIndex = 61;
            this.Salary.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            // 
            // PayManValue
            // 
            this.PayManValue.Location = new System.Drawing.Point(396, 384);
            this.PayManValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PayManValue.Name = "PayManValue";
            this.PayManValue.Size = new System.Drawing.Size(142, 20);
            this.PayManValue.TabIndex = 62;
            this.PayManValue.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            // 
            // Pay_Manual
            // 
            this.Pay_Manual.Location = new System.Drawing.Point(563, 384);
            this.Pay_Manual.Name = "Pay_Manual";
            this.Pay_Manual.Size = new System.Drawing.Size(84, 26);
            this.Pay_Manual.TabIndex = 63;
            this.Pay_Manual.Text = "Pay Manually";
            this.Pay_Manual.UseVisualStyleBackColor = true;
            this.Pay_Manual.Click += new System.EventHandler(this.Pay_Manual_Click);
            // 
            // OSSalary
            // 
            this.OSSalary.Location = new System.Drawing.Point(145, 146);
            this.OSSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.OSSalary.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.OSSalary.Name = "OSSalary";
            this.OSSalary.Size = new System.Drawing.Size(135, 20);
            this.OSSalary.TabIndex = 65;
            this.OSSalary.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 66;
            this.label12.Text = "Outstanding Salary";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(190, 428);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 67;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // HasMGR
            // 
            this.HasMGR.AutoSize = true;
            this.HasMGR.Location = new System.Drawing.Point(144, 325);
            this.HasMGR.Name = "HasMGR";
            this.HasMGR.Size = new System.Drawing.Size(98, 17);
            this.HasMGR.TabIndex = 68;
            this.HasMGR.Text = "Has a manager";
            this.HasMGR.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(787, 396);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(117, 55);
            this.Back.TabIndex = 69;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 476);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.HasMGR);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.OSSalary);
            this.Controls.Add(this.Pay_Manual);
            this.Controls.Add(this.PayManValue);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SH_ALL);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Search_SSN);
            this.Controls.Add(this.Pay_Os_Salary);
            this.Controls.Add(this.UnPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ContID);
            this.Controls.Add(this.OwnID);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.MgrID);
            this.Controls.Add(this.Hdate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SSN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayManValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OSSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox ContID;
        private System.Windows.Forms.ComboBox OwnID;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.ComboBox MgrID;
        private System.Windows.Forms.DateTimePicker Hdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UnPay;
        private System.Windows.Forms.Button Pay_Os_Salary;
        private System.Windows.Forms.TextBox Search_SSN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button SH_ALL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ManagerSearch;
        private System.Windows.Forms.CheckBox CashSearch;
        private System.Windows.Forms.CheckBox AcountantSearch;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.NumericUpDown SSN;
        private System.Windows.Forms.NumericUpDown Salary;
        private System.Windows.Forms.NumericUpDown PayManValue;
        private System.Windows.Forms.Button Pay_Manual;
        private System.Windows.Forms.NumericUpDown OSSalary;
        private System.Windows.Forms.Label label12;
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        private System.Windows.Forms.Button Update;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        private System.Windows.Forms.CheckBox HasMGR;
        private System.Windows.Forms.Button Back;
    }
}