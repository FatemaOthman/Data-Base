namespace Rentals
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.SUusername = new System.Windows.Forms.Label();
            this.SUpassword = new System.Windows.Forms.Label();
            this.SUconfirmpassword = new System.Windows.Forms.Label();
            this.UserType = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.UP = new System.Windows.Forms.TextBox();
            this.UCP = new System.Windows.Forms.TextBox();
            this.UT = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentsManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UUN = new System.Windows.Forms.TextBox();
            this.UUOP = new System.Windows.Forms.TextBox();
            this.UUNP = new System.Windows.Forms.TextBox();
            this.UUCP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UUT = new System.Windows.Forms.ComboBox();
            this.UU = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.NUUN = new System.Windows.Forms.Label();
            this.UUNT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentsManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "New User Creation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SUusername
            // 
            this.SUusername.AutoSize = true;
            this.SUusername.Location = new System.Drawing.Point(59, 46);
            this.SUusername.Name = "SUusername";
            this.SUusername.Size = new System.Drawing.Size(79, 17);
            this.SUusername.TabIndex = 1;
            this.SUusername.Text = "User Name";
            // 
            // SUpassword
            // 
            this.SUpassword.AutoSize = true;
            this.SUpassword.Location = new System.Drawing.Point(59, 82);
            this.SUpassword.Name = "SUpassword";
            this.SUpassword.Size = new System.Drawing.Size(69, 17);
            this.SUpassword.TabIndex = 2;
            this.SUpassword.Text = "Password";
            this.SUpassword.Click += new System.EventHandler(this.label3_Click);
            // 
            // SUconfirmpassword
            // 
            this.SUconfirmpassword.AutoSize = true;
            this.SUconfirmpassword.Location = new System.Drawing.Point(35, 118);
            this.SUconfirmpassword.Name = "SUconfirmpassword";
            this.SUconfirmpassword.Size = new System.Drawing.Size(121, 17);
            this.SUconfirmpassword.TabIndex = 3;
            this.SUconfirmpassword.Text = "Confirm Password";
            // 
            // UserType
            // 
            this.UserType.AutoSize = true;
            this.UserType.Location = new System.Drawing.Point(59, 154);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(74, 17);
            this.UserType.TabIndex = 4;
            this.UserType.Text = "User Type";
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(191, 39);
            this.User.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(100, 22);
            this.User.TabIndex = 5;
            // 
            // UP
            // 
            this.UP.Location = new System.Drawing.Point(191, 78);
            this.UP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UP.Name = "UP";
            this.UP.Size = new System.Drawing.Size(100, 22);
            this.UP.TabIndex = 6;
            this.UP.UseSystemPasswordChar = true;
            // 
            // UCP
            // 
            this.UCP.Location = new System.Drawing.Point(191, 113);
            this.UCP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UCP.Name = "UCP";
            this.UCP.Size = new System.Drawing.Size(100, 22);
            this.UCP.TabIndex = 7;
            this.UCP.UseSystemPasswordChar = true;
            // 
            // UT
            // 
            this.UT.DisplayMember = "User_Priv";
            this.UT.FormattingEnabled = true;
            this.UT.Location = new System.Drawing.Point(191, 149);
            this.UT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UT.Name = "UT";
            this.UT.Size = new System.Drawing.Size(121, 24);
            this.UT.TabIndex = 8;
            this.UT.ValueMember = "User_Priv";
            this.UT.SelectedIndexChanged += new System.EventHandler(this.UT_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Font = new System.Drawing.Font("Goudy Stout", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(87, 231);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create User";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.Location = new System.Drawing.Point(691, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 37);
            this.button2.TabIndex = 20;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Update User";
            // 
            // UUN
            // 
            this.UUN.Location = new System.Drawing.Point(481, 37);
            this.UUN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UUN.Name = "UUN";
            this.UUN.Size = new System.Drawing.Size(100, 22);
            this.UUN.TabIndex = 13;
            // 
            // UUOP
            // 
            this.UUOP.Location = new System.Drawing.Point(481, 110);
            this.UUOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UUOP.Name = "UUOP";
            this.UUOP.Size = new System.Drawing.Size(100, 22);
            this.UUOP.TabIndex = 15;
            this.UUOP.UseSystemPasswordChar = true;
            // 
            // UUNP
            // 
            this.UUNP.Location = new System.Drawing.Point(481, 145);
            this.UUNP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UUNP.Name = "UUNP";
            this.UUNP.Size = new System.Drawing.Size(100, 22);
            this.UUNP.TabIndex = 16;
            this.UUNP.UseSystemPasswordChar = true;
            // 
            // UUCP
            // 
            this.UUCP.Location = new System.Drawing.Point(481, 181);
            this.UUCP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UUCP.Name = "UUCP";
            this.UUCP.Size = new System.Drawing.Size(100, 22);
            this.UUCP.TabIndex = 17;
            this.UUCP.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "User Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Old Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Confirm Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "New Password";
            // 
            // UUT
            // 
            this.UUT.DisplayMember = "User_Priv";
            this.UUT.FormattingEnabled = true;
            this.UUT.Location = new System.Drawing.Point(481, 217);
            this.UUT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UUT.Name = "UUT";
            this.UUT.Size = new System.Drawing.Size(121, 24);
            this.UUT.TabIndex = 18;
            this.UUT.ValueMember = "User_Priv";
            this.UUT.SelectedIndexChanged += new System.EventHandler(this.UUT_SelectedIndexChanged);
            // 
            // UU
            // 
            this.UU.BackColor = System.Drawing.SystemColors.Menu;
            this.UU.Font = new System.Drawing.Font("Goudy Stout", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UU.Location = new System.Drawing.Point(404, 260);
            this.UU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UU.Name = "UU";
            this.UU.Size = new System.Drawing.Size(227, 23);
            this.UU.TabIndex = 19;
            this.UU.Text = "Update User";
            this.UU.UseVisualStyleBackColor = false;
            this.UU.Click += new System.EventHandler(this.UU_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "User Type";
            // 
            // NUUN
            // 
            this.NUUN.AutoSize = true;
            this.NUUN.Location = new System.Drawing.Point(355, 78);
            this.NUUN.Name = "NUUN";
            this.NUUN.Size = new System.Drawing.Size(110, 17);
            this.NUUN.TabIndex = 25;
            this.NUUN.Text = "New User Name";
            // 
            // UUNT
            // 
            this.UUNT.Location = new System.Drawing.Point(481, 74);
            this.UUNT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UUNT.Name = "UUNT";
            this.UUNT.Size = new System.Drawing.Size(100, 22);
            this.UUNT.TabIndex = 14;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(752, 347);
            this.Controls.Add(this.NUUN);
            this.Controls.Add(this.UUNT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UU);
            this.Controls.Add(this.UUT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UUCP);
            this.Controls.Add(this.UUNP);
            this.Controls.Add(this.UUOP);
            this.Controls.Add(this.UUN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UT);
            this.Controls.Add(this.UCP);
            this.Controls.Add(this.UP);
            this.Controls.Add(this.User);
            this.Controls.Add(this.UserType);
            this.Controls.Add(this.SUconfirmpassword);
            this.Controls.Add(this.SUpassword);
            this.Controls.Add(this.SUusername);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentsManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SUusername;
        private System.Windows.Forms.Label SUpassword;
        private System.Windows.Forms.Label SUconfirmpassword;
        private System.Windows.Forms.Label UserType;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox UP;
        private System.Windows.Forms.TextBox UCP;
        private System.Windows.Forms.ComboBox UT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.BindingSource rentsManagementDataSetBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UUN;
        private System.Windows.Forms.TextBox UUOP;
        private System.Windows.Forms.TextBox UUNP;
        private System.Windows.Forms.TextBox UUCP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox UUT;
        private System.Windows.Forms.Button UU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label NUUN;
        private System.Windows.Forms.TextBox UUNT;
  

        
    }
}