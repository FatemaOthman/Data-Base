namespace Rentals
{
    partial class Leases
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.IPE = new System.Windows.Forms.NumericUpDown();
            this.IIE = new System.Windows.Forms.NumericUpDown();
            this.RAE = new System.Windows.Forms.NumericUpDown();
            this.DE = new System.Windows.Forms.NumericUpDown();
            this.SDE = new System.Windows.Forms.DateTimePicker();
            this.EDE = new System.Windows.Forms.DateTimePicker();
            this.ID = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.TenantE = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CollectorID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IIE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 49);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(776, 256);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "View All Leases";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(641, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(132, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "View Lease";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(568, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 33);
            this.button4.TabIndex = 19;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(714, 405);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 33);
            this.button5.TabIndex = 20;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Interest Interval";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Start Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(660, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "End Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Interest Percent";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(441, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Deposit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(308, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Rent Amount";
            // 
            // IPE
            // 
            this.IPE.Location = new System.Drawing.Point(28, 354);
            this.IPE.Name = "IPE";
            this.IPE.Size = new System.Drawing.Size(120, 22);
            this.IPE.TabIndex = 31;
            this.IPE.ValueChanged += new System.EventHandler(this.IPE_ValueChanged);
            // 
            // IIE
            // 
            this.IIE.Location = new System.Drawing.Point(176, 354);
            this.IIE.Name = "IIE";
            this.IIE.Size = new System.Drawing.Size(102, 22);
            this.IIE.TabIndex = 32;
            // 
            // RAE
            // 
            this.RAE.Location = new System.Drawing.Point(311, 354);
            this.RAE.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.RAE.Name = "RAE";
            this.RAE.Size = new System.Drawing.Size(87, 22);
            this.RAE.TabIndex = 33;
            // 
            // DE
            // 
            this.DE.Location = new System.Drawing.Point(414, 351);
            this.DE.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.DE.Name = "DE";
            this.DE.Size = new System.Drawing.Size(120, 22);
            this.DE.TabIndex = 34;
            this.DE.ValueChanged += new System.EventHandler(this.DE_ValueChanged);
            // 
            // SDE
            // 
            this.SDE.Location = new System.Drawing.Point(557, 351);
            this.SDE.Name = "SDE";
            this.SDE.Size = new System.Drawing.Size(83, 22);
            this.SDE.TabIndex = 35;
            this.SDE.Value = new System.DateTime(2018, 12, 20, 22, 31, 41, 0);
            // 
            // EDE
            // 
            this.EDE.Location = new System.Drawing.Point(663, 354);
            this.EDE.Name = "EDE";
            this.EDE.Size = new System.Drawing.Size(83, 22);
            this.EDE.TabIndex = 36;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(6, 11);
            this.ID.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(120, 22);
            this.ID.TabIndex = 37;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(724, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(57, 37);
            this.button6.TabIndex = 38;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // TenantE
            // 
            this.TenantE.FormattingEnabled = true;
            this.TenantE.Location = new System.Drawing.Point(27, 405);
            this.TenantE.Name = "TenantE";
            this.TenantE.Size = new System.Drawing.Size(121, 24);
            this.TenantE.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tenant";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(157, 405);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 41;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(284, 405);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Building";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Unit";
            // 
            // CollectorID
            // 
            this.CollectorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CollectorID.FormattingEnabled = true;
            this.CollectorID.Location = new System.Drawing.Point(414, 405);
            this.CollectorID.Name = "CollectorID";
            this.CollectorID.Size = new System.Drawing.Size(121, 24);
            this.CollectorID.TabIndex = 45;
            this.CollectorID.SelectedIndexChanged += new System.EventHandler(this.CollectorID_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Rent Collecter";
            // 
            // Leases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CollectorID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TenantE);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.EDE);
            this.Controls.Add(this.SDE);
            this.Controls.Add(this.DE);
            this.Controls.Add(this.RAE);
            this.Controls.Add(this.IIE);
            this.Controls.Add(this.IPE);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Leases";
            this.Text = "Leases";
            this.Load += new System.EventHandler(this.Leases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IIE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown IPE;
        private System.Windows.Forms.NumericUpDown IIE;
        private System.Windows.Forms.NumericUpDown RAE;
        private System.Windows.Forms.NumericUpDown DE;
        private System.Windows.Forms.DateTimePicker SDE;
        private System.Windows.Forms.DateTimePicker EDE;
        private System.Windows.Forms.NumericUpDown ID;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox TenantE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CollectorID;
        private System.Windows.Forms.Label label4;
    }
}