namespace Rentals
{
    partial class Tenants
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
            this.addSSN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.TextBox();
            this.PhoneNUM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddTenant = new System.Windows.Forms.Button();
            this.ShowTenants = new System.Windows.Forms.DataGridView();
            this.Select_t = new System.Windows.Forms.ComboBox();
            this.ViewALL = new System.Windows.Forms.Button();
            this.View_Tenant = new System.Windows.Forms.Button();
            this.BackB = new System.Windows.Forms.Button();
            this.Buildings = new System.Windows.Forms.ComboBox();
            this.UNITS = new System.Windows.Forms.ComboBox();
            this.Building_name = new System.Windows.Forms.Label();
            this.UnitNum = new System.Windows.Forms.Label();
            this.IDtext = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.UpdateTB = new System.Windows.Forms.Button();
            this.DeleteT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShowTenants)).BeginInit();
            this.SuspendLayout();
            // 
            // addSSN
            // 
            this.addSSN.Location = new System.Drawing.Point(905, 135);
            this.addSSN.Name = "addSSN";
            this.addSSN.Size = new System.Drawing.Size(100, 22);
            this.addSSN.TabIndex = 0;
            this.addSSN.TextChanged += new System.EventHandler(this.addSSN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(784, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "SSN";
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(905, 163);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(100, 22);
            this.Fname.TabIndex = 2;
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(905, 191);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(100, 22);
            this.Lname.TabIndex = 3;
            // 
            // PhoneNUM
            // 
            this.PhoneNUM.Location = new System.Drawing.Point(905, 219);
            this.PhoneNUM.Name = "PhoneNUM";
            this.PhoneNUM.Size = new System.Drawing.Size(100, 22);
            this.PhoneNUM.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(784, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(784, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(784, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone Number";
            // 
            // AddTenant
            // 
            this.AddTenant.Location = new System.Drawing.Point(905, 314);
            this.AddTenant.Name = "AddTenant";
            this.AddTenant.Size = new System.Drawing.Size(116, 23);
            this.AddTenant.TabIndex = 9;
            this.AddTenant.Text = "Add Tenant";
            this.AddTenant.UseVisualStyleBackColor = true;
            this.AddTenant.Click += new System.EventHandler(this.AddTenant_Click);
            // 
            // ShowTenants
            // 
            this.ShowTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowTenants.Location = new System.Drawing.Point(21, 104);
            this.ShowTenants.Name = "ShowTenants";
            this.ShowTenants.RowTemplate.Height = 24;
            this.ShowTenants.Size = new System.Drawing.Size(671, 233);
            this.ShowTenants.TabIndex = 10;
            this.ShowTenants.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowTenants_CellContentClick);
            // 
            // Select_t
            // 
            this.Select_t.FormattingEnabled = true;
            this.Select_t.Location = new System.Drawing.Point(12, 22);
            this.Select_t.Name = "Select_t";
            this.Select_t.Size = new System.Drawing.Size(121, 24);
            this.Select_t.TabIndex = 11;
            this.Select_t.SelectedIndexChanged += new System.EventHandler(this.Select_t_SelectedIndexChanged);
            // 
            // ViewALL
            // 
            this.ViewALL.Location = new System.Drawing.Point(414, 23);
            this.ViewALL.Name = "ViewALL";
            this.ViewALL.Size = new System.Drawing.Size(187, 23);
            this.ViewALL.TabIndex = 12;
            this.ViewALL.Text = "View All Tenants";
            this.ViewALL.UseVisualStyleBackColor = true;
            this.ViewALL.Click += new System.EventHandler(this.ViewALL_Click);
            // 
            // View_Tenant
            // 
            this.View_Tenant.Location = new System.Drawing.Point(168, 23);
            this.View_Tenant.Name = "View_Tenant";
            this.View_Tenant.Size = new System.Drawing.Size(126, 23);
            this.View_Tenant.TabIndex = 13;
            this.View_Tenant.Text = "View Tenant";
            this.View_Tenant.UseVisualStyleBackColor = true;
            this.View_Tenant.Click += new System.EventHandler(this.View_Tenant_Click);
            // 
            // BackB
            // 
            this.BackB.Location = new System.Drawing.Point(1142, 23);
            this.BackB.Name = "BackB";
            this.BackB.Size = new System.Drawing.Size(75, 23);
            this.BackB.TabIndex = 15;
            this.BackB.Text = "Back";
            this.BackB.UseVisualStyleBackColor = true;
            this.BackB.Click += new System.EventHandler(this.BackB_Click);
            // 
            // Buildings
            // 
            this.Buildings.FormattingEnabled = true;
            this.Buildings.Location = new System.Drawing.Point(905, 247);
            this.Buildings.Name = "Buildings";
            this.Buildings.Size = new System.Drawing.Size(121, 24);
            this.Buildings.TabIndex = 16;
            this.Buildings.SelectedIndexChanged += new System.EventHandler(this.Buildings_SelectedIndexChanged);
            // 
            // UNITS
            // 
            this.UNITS.FormattingEnabled = true;
            this.UNITS.Location = new System.Drawing.Point(905, 277);
            this.UNITS.Name = "UNITS";
            this.UNITS.Size = new System.Drawing.Size(121, 24);
            this.UNITS.TabIndex = 17;
            this.UNITS.SelectedIndexChanged += new System.EventHandler(this.UNITS_SelectedIndexChanged);
            // 
            // Building_name
            // 
            this.Building_name.AutoSize = true;
            this.Building_name.Location = new System.Drawing.Point(784, 254);
            this.Building_name.Name = "Building_name";
            this.Building_name.Size = new System.Drawing.Size(58, 17);
            this.Building_name.TabIndex = 18;
            this.Building_name.Text = "Building";
            // 
            // UnitNum
            // 
            this.UnitNum.AutoSize = true;
            this.UnitNum.Location = new System.Drawing.Point(784, 284);
            this.UnitNum.Name = "UnitNum";
            this.UnitNum.Size = new System.Drawing.Size(33, 17);
            this.UnitNum.TabIndex = 19;
            this.UnitNum.Text = "Unit";
            // 
            // IDtext
            // 
            this.IDtext.Location = new System.Drawing.Point(905, 107);
            this.IDtext.Name = "IDtext";
            this.IDtext.Size = new System.Drawing.Size(100, 22);
            this.IDtext.TabIndex = 21;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(784, 112);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(21, 17);
            this.ID.TabIndex = 23;
            this.ID.Text = "ID";
            // 
            // UpdateTB
            // 
            this.UpdateTB.Location = new System.Drawing.Point(905, 356);
            this.UpdateTB.Name = "UpdateTB";
            this.UpdateTB.Size = new System.Drawing.Size(188, 34);
            this.UpdateTB.TabIndex = 24;
            this.UpdateTB.Text = "Update Existing Tenant";
            this.UpdateTB.UseVisualStyleBackColor = true;
            this.UpdateTB.Click += new System.EventHandler(this.UpdateTB_Click);
            // 
            // DeleteT
            // 
            this.DeleteT.Location = new System.Drawing.Point(689, 22);
            this.DeleteT.Name = "DeleteT";
            this.DeleteT.Size = new System.Drawing.Size(75, 23);
            this.DeleteT.TabIndex = 25;
            this.DeleteT.Text = "delete";
            this.DeleteT.UseVisualStyleBackColor = true;
            this.DeleteT.Click += new System.EventHandler(this.DeleteT_Click);
            // 
            // Tenants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 478);
            this.Controls.Add(this.DeleteT);
            this.Controls.Add(this.UpdateTB);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.IDtext);
            this.Controls.Add(this.UnitNum);
            this.Controls.Add(this.Building_name);
            this.Controls.Add(this.UNITS);
            this.Controls.Add(this.Buildings);
            this.Controls.Add(this.BackB);
            this.Controls.Add(this.View_Tenant);
            this.Controls.Add(this.ViewALL);
            this.Controls.Add(this.Select_t);
            this.Controls.Add(this.ShowTenants);
            this.Controls.Add(this.AddTenant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PhoneNUM);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addSSN);
            this.Name = "Tenants";
            this.Text = "Tenants";
            this.Load += new System.EventHandler(this.Tenants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowTenants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addSSN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox PhoneNUM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddTenant;
        private System.Windows.Forms.DataGridView ShowTenants;
        private System.Windows.Forms.ComboBox Select_t;
        private System.Windows.Forms.Button ViewALL;
        private System.Windows.Forms.Button View_Tenant;
        private System.Windows.Forms.Button BackB;
        private System.Windows.Forms.ComboBox Buildings;
        private System.Windows.Forms.ComboBox UNITS;
        private System.Windows.Forms.Label Building_name;
        private System.Windows.Forms.Label UnitNum;
        private System.Windows.Forms.TextBox IDtext;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button UpdateTB;
        private System.Windows.Forms.Button DeleteT;
    }
}