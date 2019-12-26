using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Rentals
{
    public partial class SignIn : Form
    {
        Controller contobj; // The Main and only created Controller Object , it will be passed to other forms through Constructor
        public SignIn(Controller contobj1)
        {
            InitializeComponent();
            contobj = contobj1;

        }
        
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Extra
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Extra
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            
        }

        private void SI_Click(object sender, EventArgs e)
        {
            //This checks for Empty Textboxes
            long a;
            if (string.IsNullOrWhiteSpace(SIUN.Text) && string.IsNullOrWhiteSpace(SIP.Text))
            {
                MessageBox.Show("Please type in your username and password.");
            }
            else if (string.IsNullOrWhiteSpace(SIUN.Text) && !string.IsNullOrWhiteSpace(SIP.Text))
            {
                MessageBox.Show("Please type in your username correctly.");
            }
            else if (string.IsNullOrWhiteSpace(SIP.Text))
            {
                MessageBox.Show("Please type in your password correctly.");
            }
            //Checks if Only A Numeric Password Is Entered
            else if (!long.TryParse(SIP.Text, out a))
            {
                MessageBox.Show("Please type in your password correctly.");
            }
            //Signing in or refusing due to Data Mismatch
            else if (SIUN.Text != null && SIP.Text != null)
            {
                int condition = contobj.SignIn(SIUN.Text, Int32.Parse(SIP.Text));
                if (condition == 0)
                {
                    MessageBox.Show("Username or Password not Correct!");
                }
                else if (condition == 2)
                {
                    MessageBox.Show("The password you entered is incorrect.");
                }
                else
                {
                    this.Hide(); // Hides the SignIn form
                    MainPage Dashboard = new MainPage(contobj,this,contobj.GetUserPriv(SIUN.Text));//creating new main page form
                    Dashboard.Show();//showing the created main page form
                }
            }
         
        }

        private void SIUN_TextChanged(object sender, EventArgs e)
        {
          //Extra
        }
    }
}
