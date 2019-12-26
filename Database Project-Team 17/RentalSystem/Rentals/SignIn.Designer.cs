namespace Rentals
{
    partial class SignIn
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
            this.UserName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.SI = new System.Windows.Forms.Button();
            this.SIUN = new System.Windows.Forms.TextBox();
            this.SIP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(180, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UserName.Location = new System.Drawing.Point(119, 33);
            this.UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(60, 13);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "User Name";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Password.Location = new System.Drawing.Point(219, 33);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // SI
            // 
            this.SI.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SI.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.SI.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.SI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SI.Font = new System.Drawing.Font("Goudy Stout", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SI.Location = new System.Drawing.Point(137, 127);
            this.SI.Margin = new System.Windows.Forms.Padding(2);
            this.SI.Name = "SI";
            this.SI.Size = new System.Drawing.Size(105, 28);
            this.SI.TabIndex = 3;
            this.SI.Text = "Sign In";
            this.SI.UseVisualStyleBackColor = false;
            this.SI.Click += new System.EventHandler(this.SI_Click);
            // 
            // SIUN
            // 
            this.SIUN.Location = new System.Drawing.Point(112, 69);
            this.SIUN.Margin = new System.Windows.Forms.Padding(2);
            this.SIUN.Name = "SIUN";
            this.SIUN.Size = new System.Drawing.Size(76, 20);
            this.SIUN.TabIndex = 4;
            this.SIUN.TextChanged += new System.EventHandler(this.SIUN_TextChanged);
            // 
            // SIP
            // 
            this.SIP.Location = new System.Drawing.Point(208, 69);
            this.SIP.Margin = new System.Windows.Forms.Padding(2);
            this.SIP.Name = "SIP";
            this.SIP.Size = new System.Drawing.Size(76, 20);
            this.SIP.TabIndex = 5;
            this.SIP.UseSystemPasswordChar = true;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(380, 164);
            this.Controls.Add(this.SIP);
            this.Controls.Add(this.SIUN);
            this.Controls.Add(this.SI);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignIn";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button SI;
        private System.Windows.Forms.TextBox SIUN;
        private System.Windows.Forms.TextBox SIP;
    }
}

