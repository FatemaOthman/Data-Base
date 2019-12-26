namespace Rentals
{
    partial class Contacts
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
            this.Contactsgrid = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.ShowAllContacts = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.identifier = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Get = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Contactsgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Contactsgrid
            // 
            this.Contactsgrid.AllowUserToAddRows = false;
            this.Contactsgrid.AllowUserToDeleteRows = false;
            this.Contactsgrid.AllowUserToResizeRows = false;
            this.Contactsgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Contactsgrid.Location = new System.Drawing.Point(11, 176);
            this.Contactsgrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Contactsgrid.Name = "Contactsgrid";
            this.Contactsgrid.ReadOnly = true;
            this.Contactsgrid.RowTemplate.Height = 28;
            this.Contactsgrid.Size = new System.Drawing.Size(820, 174);
            this.Contactsgrid.TabIndex = 0;
            this.Contactsgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Contactsgrid_CellContentClick);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(10, 46);
            this.FirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(89, 22);
            this.FirstName.TabIndex = 1;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(124, 46);
            this.LastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(89, 22);
            this.LastName.TabIndex = 2;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(233, 46);
            this.PhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(89, 22);
            this.PhoneNumber.TabIndex = 3;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(342, 46);
            this.Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(89, 22);
            this.Email.TabIndex = 4;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(451, 46);
            this.Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(89, 22);
            this.Address.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(563, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Status";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(672, 42);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(67, 30);
            this.Add.TabIndex = 13;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(212, 97);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(67, 27);
            this.Update.TabIndex = 14;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // ShowAllContacts
            // 
            this.ShowAllContacts.Location = new System.Drawing.Point(17, 126);
            this.ShowAllContacts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowAllContacts.Name = "ShowAllContacts";
            this.ShowAllContacts.Size = new System.Drawing.Size(172, 38);
            this.ShowAllContacts.TabIndex = 15;
            this.ShowAllContacts.Text = "Show all Contacts";
            this.ShowAllContacts.UseVisualStyleBackColor = true;
            this.ShowAllContacts.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "ID (Leave empty when adding)";
            // 
            // identifier
            // 
            this.identifier.Location = new System.Drawing.Point(11, 100);
            this.identifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.identifier.Name = "identifier";
            this.identifier.Size = new System.Drawing.Size(89, 22);
            this.identifier.TabIndex = 16;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(306, 97);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(67, 27);
            this.Delete.TabIndex = 18;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Get
            // 
            this.Get.Location = new System.Drawing.Point(390, 97);
            this.Get.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(79, 27);
            this.Get.TabIndex = 19;
            this.Get.Text = "Get";
            this.Get.UseVisualStyleBackColor = true;
            this.Get.Click += new System.EventHandler(this.Get_Click);
            // 
            // Status
            // 
            this.Status.FormattingEnabled = true;
            this.Status.Location = new System.Drawing.Point(559, 45);
            this.Status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(108, 24);
            this.Status.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(784, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 37);
            this.button2.TabIndex = 36;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 360);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Get);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.identifier);
            this.Controls.Add(this.ShowAllContacts);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Contactsgrid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Contacts";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Contacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Contactsgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Contactsgrid;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Add;
        private new System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button ShowAllContacts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox identifier;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Get;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Button button2;
    }
}