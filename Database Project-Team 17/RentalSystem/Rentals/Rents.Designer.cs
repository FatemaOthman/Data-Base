namespace Rentals
{
    partial class Rents
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
            this.RS = new System.Windows.Forms.ComboBox();
            this.RC = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.RIDT = new System.Windows.Forms.TextBox();
            this.LIDT = new System.Windows.Forms.TextBox();
            this.RDD = new System.Windows.Forms.TextBox();
            this.RDDT = new System.Windows.Forms.TextBox();
            this.RIDL = new System.Windows.Forms.Label();
            this.LIDL = new System.Windows.Forms.Label();
            this.RAL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RST = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CIDT = new System.Windows.Forms.TextBox();
            this.Pay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.UNPAY = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Collecter = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tenants = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Units = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Button();
            this.RAN = new System.Windows.Forms.NumericUpDown();
            this.DueS = new System.Windows.Forms.DateTimePicker();
            this.DDA = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.BCC = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Unitname = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Tenantname = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Buildingname = new System.Windows.Forms.TextBox();
            this.ALL = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.Owners = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAN)).BeginInit();
            this.SuspendLayout();
            // 
            // RS
            // 
            this.RS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RS.FormattingEnabled = true;
            this.RS.Location = new System.Drawing.Point(104, 12);
            this.RS.Name = "RS";
            this.RS.Size = new System.Drawing.Size(121, 24);
            this.RS.TabIndex = 0;
            this.RS.SelectedIndexChanged += new System.EventHandler(this.RS_SelectedIndexChanged);
            // 
            // RC
            // 
            this.RC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RC.FormattingEnabled = true;
            this.RC.Location = new System.Drawing.Point(901, 337);
            this.RC.Name = "RC";
            this.RC.Size = new System.Drawing.Size(121, 24);
            this.RC.TabIndex = 1;
            this.RC.SelectedIndexChanged += new System.EventHandler(this.RC_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1279, 223);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Statues";
            // 
            // RIDT
            // 
            this.RIDT.Location = new System.Drawing.Point(32, 337);
            this.RIDT.Name = "RIDT";
            this.RIDT.ReadOnly = true;
            this.RIDT.Size = new System.Drawing.Size(142, 22);
            this.RIDT.TabIndex = 4;
            // 
            // LIDT
            // 
            this.LIDT.Location = new System.Drawing.Point(32, 391);
            this.LIDT.Name = "LIDT";
            this.LIDT.ReadOnly = true;
            this.LIDT.Size = new System.Drawing.Size(142, 22);
            this.LIDT.TabIndex = 5;
            // 
            // RDD
            // 
            this.RDD.Location = new System.Drawing.Point(193, 337);
            this.RDD.Name = "RDD";
            this.RDD.ReadOnly = true;
            this.RDD.Size = new System.Drawing.Size(131, 22);
            this.RDD.TabIndex = 6;
            // 
            // RDDT
            // 
            this.RDDT.Location = new System.Drawing.Point(193, 391);
            this.RDDT.Name = "RDDT";
            this.RDDT.ReadOnly = true;
            this.RDDT.Size = new System.Drawing.Size(131, 22);
            this.RDDT.TabIndex = 7;
            // 
            // RIDL
            // 
            this.RIDL.AutoSize = true;
            this.RIDL.Location = new System.Drawing.Point(47, 311);
            this.RIDL.Name = "RIDL";
            this.RIDL.Size = new System.Drawing.Size(55, 17);
            this.RIDL.TabIndex = 8;
            this.RIDL.Text = "Rent ID";
            // 
            // LIDL
            // 
            this.LIDL.AutoSize = true;
            this.LIDL.Location = new System.Drawing.Point(47, 371);
            this.LIDL.Name = "LIDL";
            this.LIDL.Size = new System.Drawing.Size(64, 17);
            this.LIDL.TabIndex = 9;
            this.LIDL.Text = "Lease ID";
            // 
            // RAL
            // 
            this.RAL.AutoSize = true;
            this.RAL.Location = new System.Drawing.Point(190, 311);
            this.RAL.Name = "RAL";
            this.RAL.Size = new System.Drawing.Size(90, 17);
            this.RAL.TabIndex = 10;
            this.RAL.Text = "Rent Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rent Due Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Rent Statues";
            // 
            // RST
            // 
            this.RST.Location = new System.Drawing.Point(346, 337);
            this.RST.Name = "RST";
            this.RST.ReadOnly = true;
            this.RST.Size = new System.Drawing.Size(123, 22);
            this.RST.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Collecter";
            // 
            // CIDT
            // 
            this.CIDT.Location = new System.Drawing.Point(346, 393);
            this.CIDT.Name = "CIDT";
            this.CIDT.ReadOnly = true;
            this.CIDT.Size = new System.Drawing.Size(123, 22);
            this.CIDT.TabIndex = 14;
            // 
            // Pay
            // 
            this.Pay.Location = new System.Drawing.Point(779, 330);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(75, 31);
            this.Pay.TabIndex = 16;
            this.Pay.Text = "Pay Rent";
            this.Pay.UseVisualStyleBackColor = true;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(917, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 48);
            this.button1.TabIndex = 17;
            this.button1.Text = "Change Collecter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(936, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Collecter";
            // 
            // UNPAY
            // 
            this.UNPAY.Location = new System.Drawing.Point(779, 382);
            this.UNPAY.Name = "UNPAY";
            this.UNPAY.Size = new System.Drawing.Size(75, 31);
            this.UNPAY.TabIndex = 19;
            this.UNPAY.Text = "UNPAY";
            this.UNPAY.UseVisualStyleBackColor = true;
            this.UNPAY.Click += new System.EventHandler(this.UNPAY_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Rent Above";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(615, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Collecter";
            // 
            // Collecter
            // 
            this.Collecter.FormattingEnabled = true;
            this.Collecter.Location = new System.Drawing.Point(684, 10);
            this.Collecter.Name = "Collecter";
            this.Collecter.Size = new System.Drawing.Size(126, 24);
            this.Collecter.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Due Date Before";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(844, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Tenant";
            // 
            // tenants
            // 
            this.tenants.FormattingEnabled = true;
            this.tenants.Location = new System.Drawing.Point(931, 46);
            this.tenants.Name = "tenants";
            this.tenants.Size = new System.Drawing.Size(121, 24);
            this.tenants.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(634, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Unit";
            // 
            // Units
            // 
            this.Units.FormattingEnabled = true;
            this.Units.Location = new System.Drawing.Point(684, 48);
            this.Units.Name = "Units";
            this.Units.Size = new System.Drawing.Size(126, 24);
            this.Units.TabIndex = 26;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(1095, 13);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 30;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // RAN
            // 
            this.RAN.Location = new System.Drawing.Point(105, 52);
            this.RAN.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.RAN.Name = "RAN";
            this.RAN.Size = new System.Drawing.Size(120, 22);
            this.RAN.TabIndex = 31;
            // 
            // DueS
            // 
            this.DueS.Location = new System.Drawing.Point(358, 48);
            this.DueS.Name = "DueS";
            this.DueS.Size = new System.Drawing.Size(241, 22);
            this.DueS.TabIndex = 32;
            this.DueS.Value = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            // 
            // DDA
            // 
            this.DDA.Location = new System.Drawing.Point(358, 14);
            this.DDA.Name = "DDA";
            this.DDA.Size = new System.Drawing.Size(241, 22);
            this.DDA.TabIndex = 34;
            this.DDA.Value = new System.DateTime(2018, 12, 1, 0, 0, 0, 0);
            this.DDA.ValueChanged += new System.EventHandler(this.DDA_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(238, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Due Date After";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1229, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 37);
            this.button2.TabIndex = 35;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(844, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = "Building";
            // 
            // BCC
            // 
            this.BCC.FormattingEnabled = true;
            this.BCC.Location = new System.Drawing.Point(931, 12);
            this.BCC.Name = "BCC";
            this.BCC.Size = new System.Drawing.Size(121, 24);
            this.BCC.TabIndex = 36;
            this.BCC.SelectedIndexChanged += new System.EventHandler(this.BCC_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(511, 373);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 17);
            this.label13.TabIndex = 41;
            this.label13.Text = "Unit";
            // 
            // Unitname
            // 
            this.Unitname.Location = new System.Drawing.Point(493, 393);
            this.Unitname.Name = "Unitname";
            this.Unitname.ReadOnly = true;
            this.Unitname.Size = new System.Drawing.Size(123, 22);
            this.Unitname.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(502, 317);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 17);
            this.label14.TabIndex = 39;
            this.label14.Text = "Tenant";
            // 
            // Tenantname
            // 
            this.Tenantname.Location = new System.Drawing.Point(493, 337);
            this.Tenantname.Name = "Tenantname";
            this.Tenantname.ReadOnly = true;
            this.Tenantname.Size = new System.Drawing.Size(123, 22);
            this.Tenantname.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(646, 317);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 17);
            this.label15.TabIndex = 43;
            this.label15.Text = "Building";
            // 
            // Buildingname
            // 
            this.Buildingname.Location = new System.Drawing.Point(637, 337);
            this.Buildingname.Name = "Buildingname";
            this.Buildingname.ReadOnly = true;
            this.Buildingname.Size = new System.Drawing.Size(123, 22);
            this.Buildingname.TabIndex = 42;
            // 
            // ALL
            // 
            this.ALL.Location = new System.Drawing.Point(1095, 46);
            this.ALL.Name = "ALL";
            this.ALL.Size = new System.Drawing.Size(75, 23);
            this.ALL.TabIndex = 44;
            this.ALL.Text = "Show All";
            this.ALL.UseVisualStyleBackColor = true;
            this.ALL.Click += new System.EventHandler(this.ALL_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(646, 373);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 17);
            this.label16.TabIndex = 46;
            this.label16.Text = "Owner";
            // 
            // Owners
            // 
            this.Owners.FormattingEnabled = true;
            this.Owners.Location = new System.Drawing.Point(637, 391);
            this.Owners.Name = "Owners";
            this.Owners.Size = new System.Drawing.Size(126, 24);
            this.Owners.TabIndex = 45;
            // 
            // Rents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1298, 450);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Owners);
            this.Controls.Add(this.ALL);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Buildingname);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Unitname);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Tenantname);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BCC);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DDA);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DueS);
            this.Controls.Add(this.RAN);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tenants);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Units);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Collecter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UNPAY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CIDT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RST);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RAL);
            this.Controls.Add(this.LIDL);
            this.Controls.Add(this.RIDL);
            this.Controls.Add(this.RDDT);
            this.Controls.Add(this.RDD);
            this.Controls.Add(this.LIDT);
            this.Controls.Add(this.RIDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RC);
            this.Controls.Add(this.RS);
            this.Name = "Rents";
            this.Text = "Rents";
            this.Load += new System.EventHandler(this.Rents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RS;
        private System.Windows.Forms.ComboBox RC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RIDT;
        private System.Windows.Forms.TextBox LIDT;
        private System.Windows.Forms.TextBox RDD;
        private System.Windows.Forms.TextBox RDDT;
        private System.Windows.Forms.Label RIDL;
        private System.Windows.Forms.Label LIDL;
        private System.Windows.Forms.Label RAL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RST;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CIDT;
        private System.Windows.Forms.Button Pay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button UNPAY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Collecter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox tenants;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Units;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.NumericUpDown RAN;
        private System.Windows.Forms.DateTimePicker DueS;
        private System.Windows.Forms.DateTimePicker DDA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox BCC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Unitname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Tenantname;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Buildingname;
        private System.Windows.Forms.Button ALL;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox Owners;
    }
}