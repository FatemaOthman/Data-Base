namespace Rentals
{
    partial class Buildings
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
            this.ShowB = new System.Windows.Forms.DataGridView();
            this.GetBname = new System.Windows.Forms.ComboBox();
            this.ShowBdbyName = new System.Windows.Forms.Button();
            this.GetAllBds = new System.Windows.Forms.Button();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.BStreet = new System.Windows.Forms.TextBox();
            this.BDistrict = new System.Windows.Forms.TextBox();
            this.Bname = new System.Windows.Forms.TextBox();
            this.BCity = new System.Windows.Forms.TextBox();
            this.Bnum = new System.Windows.Forms.TextBox();
            this.BnumOfUnits = new System.Windows.Forms.TextBox();
            this.BOwnerId = new System.Windows.Forms.TextBox();
            this.BckButton = new System.Windows.Forms.Button();
            this.AddBuilding = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UpdateBuilding = new System.Windows.Forms.Button();
            this.DeleteB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShowB)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowB
            // 
            this.ShowB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowB.Location = new System.Drawing.Point(12, 123);
            this.ShowB.Name = "ShowB";
            this.ShowB.RowTemplate.Height = 24;
            this.ShowB.Size = new System.Drawing.Size(835, 249);
            this.ShowB.TabIndex = 0;
            this.ShowB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowB_CellContentClick);
            // 
            // GetBname
            // 
            this.GetBname.FormattingEnabled = true;
            this.GetBname.Location = new System.Drawing.Point(12, 12);
            this.GetBname.Name = "GetBname";
            this.GetBname.Size = new System.Drawing.Size(121, 24);
            this.GetBname.TabIndex = 1;
            this.GetBname.SelectedIndexChanged += new System.EventHandler(this.GetBname_SelectedIndexChanged);
            // 
            // ShowBdbyName
            // 
            this.ShowBdbyName.Location = new System.Drawing.Point(172, 6);
            this.ShowBdbyName.Name = "ShowBdbyName";
            this.ShowBdbyName.Size = new System.Drawing.Size(159, 34);
            this.ShowBdbyName.TabIndex = 2;
            this.ShowBdbyName.Text = "View Building";
            this.ShowBdbyName.UseVisualStyleBackColor = true;
            this.ShowBdbyName.Click += new System.EventHandler(this.ShowBdbyName_Click);
            // 
            // GetAllBds
            // 
            this.GetAllBds.Location = new System.Drawing.Point(398, 6);
            this.GetAllBds.Name = "GetAllBds";
            this.GetAllBds.Size = new System.Drawing.Size(214, 34);
            this.GetAllBds.TabIndex = 3;
            this.GetAllBds.Text = "View all buildings ";
            this.GetAllBds.UseVisualStyleBackColor = true;
            this.GetAllBds.Click += new System.EventHandler(this.GetAllBds_Click);
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(1053, 115);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(100, 22);
            this.IDtxt.TabIndex = 4;
            // 
            // BStreet
            // 
            this.BStreet.Location = new System.Drawing.Point(1053, 171);
            this.BStreet.Name = "BStreet";
            this.BStreet.Size = new System.Drawing.Size(100, 22);
            this.BStreet.TabIndex = 5;
            // 
            // BDistrict
            // 
            this.BDistrict.Location = new System.Drawing.Point(1053, 227);
            this.BDistrict.Name = "BDistrict";
            this.BDistrict.Size = new System.Drawing.Size(100, 22);
            this.BDistrict.TabIndex = 6;
            // 
            // Bname
            // 
            this.Bname.Location = new System.Drawing.Point(1053, 143);
            this.Bname.Name = "Bname";
            this.Bname.Size = new System.Drawing.Size(100, 22);
            this.Bname.TabIndex = 7;
            // 
            // BCity
            // 
            this.BCity.Location = new System.Drawing.Point(1053, 199);
            this.BCity.Name = "BCity";
            this.BCity.Size = new System.Drawing.Size(100, 22);
            this.BCity.TabIndex = 8;
            // 
            // Bnum
            // 
            this.Bnum.Location = new System.Drawing.Point(1053, 255);
            this.Bnum.Name = "Bnum";
            this.Bnum.Size = new System.Drawing.Size(100, 22);
            this.Bnum.TabIndex = 9;
            // 
            // BnumOfUnits
            // 
            this.BnumOfUnits.Location = new System.Drawing.Point(1053, 283);
            this.BnumOfUnits.Name = "BnumOfUnits";
            this.BnumOfUnits.Size = new System.Drawing.Size(100, 22);
            this.BnumOfUnits.TabIndex = 10;
            // 
            // BOwnerId
            // 
            this.BOwnerId.Location = new System.Drawing.Point(1053, 311);
            this.BOwnerId.Name = "BOwnerId";
            this.BOwnerId.Size = new System.Drawing.Size(100, 22);
            this.BOwnerId.TabIndex = 11;
            // 
            // BckButton
            // 
            this.BckButton.Location = new System.Drawing.Point(1220, 12);
            this.BckButton.Name = "BckButton";
            this.BckButton.Size = new System.Drawing.Size(75, 23);
            this.BckButton.TabIndex = 12;
            this.BckButton.Text = "Back";
            this.BckButton.UseVisualStyleBackColor = true;
            this.BckButton.Click += new System.EventHandler(this.BckButton_Click);
            // 
            // AddBuilding
            // 
            this.AddBuilding.Location = new System.Drawing.Point(1053, 358);
            this.AddBuilding.Name = "AddBuilding";
            this.AddBuilding.Size = new System.Drawing.Size(110, 27);
            this.AddBuilding.TabIndex = 13;
            this.AddBuilding.Text = "Add Building";
            this.AddBuilding.UseVisualStyleBackColor = true;
            this.AddBuilding.Click += new System.EventHandler(this.AddBuilding_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(906, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(906, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(906, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Street";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(906, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(906, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "District";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(906, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Building Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(906, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Num Of Units";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(906, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Owner ID";
            // 
            // UpdateBuilding
            // 
            this.UpdateBuilding.Location = new System.Drawing.Point(1053, 403);
            this.UpdateBuilding.Name = "UpdateBuilding";
            this.UpdateBuilding.Size = new System.Drawing.Size(155, 35);
            this.UpdateBuilding.TabIndex = 24;
            this.UpdateBuilding.Text = "Update Building";
            this.UpdateBuilding.UseVisualStyleBackColor = true;
            this.UpdateBuilding.Click += new System.EventHandler(this.UpdateBuilding_Click_1);
            // 
            // DeleteB
            // 
            this.DeleteB.Location = new System.Drawing.Point(712, 6);
            this.DeleteB.Name = "DeleteB";
            this.DeleteB.Size = new System.Drawing.Size(104, 33);
            this.DeleteB.TabIndex = 25;
            this.DeleteB.Text = "Delete";
            this.DeleteB.UseVisualStyleBackColor = true;
            this.DeleteB.Click += new System.EventHandler(this.DeleteB_Click);
            // 
            // Buildings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 450);
            this.Controls.Add(this.DeleteB);
            this.Controls.Add(this.UpdateBuilding);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBuilding);
            this.Controls.Add(this.BckButton);
            this.Controls.Add(this.BOwnerId);
            this.Controls.Add(this.BnumOfUnits);
            this.Controls.Add(this.Bnum);
            this.Controls.Add(this.BCity);
            this.Controls.Add(this.Bname);
            this.Controls.Add(this.BDistrict);
            this.Controls.Add(this.BStreet);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.GetAllBds);
            this.Controls.Add(this.ShowBdbyName);
            this.Controls.Add(this.GetBname);
            this.Controls.Add(this.ShowB);
            this.Name = "Buildings";
            this.Text = "Buildings";
            this.Load += new System.EventHandler(this.Buildings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ShowB;
        private System.Windows.Forms.ComboBox GetBname;
        private System.Windows.Forms.Button ShowBdbyName;
        private System.Windows.Forms.Button GetAllBds;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.TextBox BStreet;
        private System.Windows.Forms.TextBox BDistrict;
        private System.Windows.Forms.TextBox Bname;
        private System.Windows.Forms.TextBox BCity;
        private System.Windows.Forms.TextBox Bnum;
        private System.Windows.Forms.TextBox BnumOfUnits;
        private System.Windows.Forms.TextBox BOwnerId;
        private System.Windows.Forms.Button BckButton;
        private System.Windows.Forms.Button AddBuilding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button UpdateBuilding;
        private System.Windows.Forms.Button DeleteB;
    }
}