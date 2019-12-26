namespace Rentals
{
    partial class Owners
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
            this.Ownerscombobox = new System.Windows.Forms.ComboBox();
            this.OwnersData = new System.Windows.Forms.DataGridView();
            this.ViewAllOwners = new System.Windows.Forms.Button();
            this.SSNText = new System.Windows.Forms.TextBox();
            this.FNText = new System.Windows.Forms.TextBox();
            this.LNText = new System.Windows.Forms.TextBox();
            this.PhoneNOText = new System.Windows.Forms.TextBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.NoOfBuildingsText = new System.Windows.Forms.TextBox();
            this.IncomeText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddOwner = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.GetOwner = new System.Windows.Forms.Button();
            this.UpdateExistingOwner = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OwnersData)).BeginInit();
            this.SuspendLayout();
            // 
            // Ownerscombobox
            // 
            this.Ownerscombobox.FormattingEnabled = true;
            this.Ownerscombobox.Location = new System.Drawing.Point(11, 10);
            this.Ownerscombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ownerscombobox.Name = "Ownerscombobox";
            this.Ownerscombobox.Size = new System.Drawing.Size(108, 24);
            this.Ownerscombobox.TabIndex = 0;
            this.Ownerscombobox.SelectedIndexChanged += new System.EventHandler(this.Ownerscombobox_SelectedIndexChanged);
            // 
            // OwnersData
            // 
            this.OwnersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OwnersData.Location = new System.Drawing.Point(11, 78);
            this.OwnersData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OwnersData.Name = "OwnersData";
            this.OwnersData.RowTemplate.Height = 28;
            this.OwnersData.Size = new System.Drawing.Size(543, 258);
            this.OwnersData.TabIndex = 1;
            this.OwnersData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OwnersData_CellContentClick);
            // 
            // ViewAllOwners
            // 
            this.ViewAllOwners.Location = new System.Drawing.Point(246, 10);
            this.ViewAllOwners.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewAllOwners.Name = "ViewAllOwners";
            this.ViewAllOwners.Size = new System.Drawing.Size(164, 29);
            this.ViewAllOwners.TabIndex = 3;
            this.ViewAllOwners.Text = "View All Owners";
            this.ViewAllOwners.UseVisualStyleBackColor = true;
            this.ViewAllOwners.Click += new System.EventHandler(this.ViewAllOwners_Click);
            // 
            // SSNText
            // 
            this.SSNText.Location = new System.Drawing.Point(743, 69);
            this.SSNText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SSNText.Name = "SSNText";
            this.SSNText.Size = new System.Drawing.Size(89, 22);
            this.SSNText.TabIndex = 5;
            this.SSNText.TextChanged += new System.EventHandler(this.SSNText_TextChanged);
            // 
            // FNText
            // 
            this.FNText.Location = new System.Drawing.Point(743, 109);
            this.FNText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FNText.Name = "FNText";
            this.FNText.Size = new System.Drawing.Size(89, 22);
            this.FNText.TabIndex = 6;
            // 
            // LNText
            // 
            this.LNText.Location = new System.Drawing.Point(743, 152);
            this.LNText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LNText.Name = "LNText";
            this.LNText.Size = new System.Drawing.Size(89, 22);
            this.LNText.TabIndex = 7;
            // 
            // PhoneNOText
            // 
            this.PhoneNOText.Location = new System.Drawing.Point(743, 198);
            this.PhoneNOText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneNOText.Name = "PhoneNOText";
            this.PhoneNOText.Size = new System.Drawing.Size(89, 22);
            this.PhoneNOText.TabIndex = 8;
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(743, 242);
            this.AddressText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(89, 22);
            this.AddressText.TabIndex = 9;
            // 
            // NoOfBuildingsText
            // 
            this.NoOfBuildingsText.Location = new System.Drawing.Point(743, 282);
            this.NoOfBuildingsText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NoOfBuildingsText.Name = "NoOfBuildingsText";
            this.NoOfBuildingsText.Size = new System.Drawing.Size(89, 22);
            this.NoOfBuildingsText.TabIndex = 10;
            // 
            // IncomeText
            // 
            this.IncomeText.Location = new System.Drawing.Point(743, 323);
            this.IncomeText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IncomeText.Name = "IncomeText";
            this.IncomeText.Size = new System.Drawing.Size(89, 22);
            this.IncomeText.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "SSN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(595, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Phone Number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(595, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(595, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Number of Buildings";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(595, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Income";
            // 
            // AddOwner
            // 
            this.AddOwner.Location = new System.Drawing.Point(854, 314);
            this.AddOwner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddOwner.Name = "AddOwner";
            this.AddOwner.Size = new System.Drawing.Size(102, 30);
            this.AddOwner.TabIndex = 20;
            this.AddOwner.Text = "Add Owner";
            this.AddOwner.UseVisualStyleBackColor = true;
            this.AddOwner.Click += new System.EventHandler(this.AddOwner_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(438, 13);
            this.Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(116, 26);
            this.Refresh.TabIndex = 21;
            this.Refresh.Text = "Refresh List";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(854, 11);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(102, 38);
            this.Back.TabIndex = 22;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // GetOwner
            // 
            this.GetOwner.Location = new System.Drawing.Point(135, 10);
            this.GetOwner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetOwner.Name = "GetOwner";
            this.GetOwner.Size = new System.Drawing.Size(87, 39);
            this.GetOwner.TabIndex = 23;
            this.GetOwner.Text = "Get Owner";
            this.GetOwner.UseVisualStyleBackColor = true;
            this.GetOwner.Click += new System.EventHandler(this.GetOwner_Click);
            // 
            // UpdateExistingOwner
            // 
            this.UpdateExistingOwner.Location = new System.Drawing.Point(743, 369);
            this.UpdateExistingOwner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateExistingOwner.Name = "UpdateExistingOwner";
            this.UpdateExistingOwner.Size = new System.Drawing.Size(213, 34);
            this.UpdateExistingOwner.TabIndex = 24;
            this.UpdateExistingOwner.Text = "Update Existing Owner";
            this.UpdateExistingOwner.UseVisualStyleBackColor = true;
            this.UpdateExistingOwner.Click += new System.EventHandler(this.UpdateExistingOwner_Click);
            // 
            // Owners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 439);
            this.Controls.Add(this.UpdateExistingOwner);
            this.Controls.Add(this.GetOwner);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.AddOwner);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IncomeText);
            this.Controls.Add(this.NoOfBuildingsText);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.PhoneNOText);
            this.Controls.Add(this.LNText);
            this.Controls.Add(this.FNText);
            this.Controls.Add(this.SSNText);
            this.Controls.Add(this.ViewAllOwners);
            this.Controls.Add(this.OwnersData);
            this.Controls.Add(this.Ownerscombobox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Owners";
            this.Text = "Owners";
            this.Load += new System.EventHandler(this.Owners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OwnersData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Ownerscombobox;
        private System.Windows.Forms.DataGridView OwnersData;
        private System.Windows.Forms.Button ViewAllOwners;
        private System.Windows.Forms.TextBox SSNText;
        private System.Windows.Forms.TextBox FNText;
        private System.Windows.Forms.TextBox LNText;
        private System.Windows.Forms.TextBox PhoneNOText;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.TextBox NoOfBuildingsText;
        private System.Windows.Forms.TextBox IncomeText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        private System.Windows.Forms.Button Refresh;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        private System.Windows.Forms.Button AddOwner;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button GetOwner;
        private System.Windows.Forms.Button UpdateExistingOwner;
    }
}