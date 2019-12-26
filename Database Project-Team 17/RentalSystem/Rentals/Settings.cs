using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentals
{
    public partial class Settings : Form
    {
        Controller contobj;//creating controller to get it from prev form
        MainPage p;//creating the previous form
        int privi;
        public Settings(Controller contobj1, MainPage pointer,int priv)
        {
            InitializeComponent();
            contobj = contobj1;//taking the previous's form controller
            p = pointer;//taking an object from the previous form
            privi = priv;
            if (privi != 1)
            {

                User.Enabled = false;
                UP.Enabled = false;
                UCP.Enabled = false;
                UT.Enabled = false;
                button1.Enabled = false;
                UUT.Enabled = false;


            }
            string[] PrivNames = new string[3] { "Admin","Accountant","Cash Collecter" };//filling the commbobox
            string[] PrivNames1 = new string[3] { "Admin", "Accountant", "Cash Collecter" };//filling the commbobox
            UT.DataSource = PrivNames;//filling the commbobox
            UUT.DataSource = PrivNames1;//filling the commbobox
            UT.Refresh();//refreshinng the combobox
            UUT.Refresh();//refreshinng the combobox


        }

        private void label3_Click(object sender, EventArgs e)
        {
           //Extra
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Extra
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UP.Text) || string.IsNullOrWhiteSpace(UCP.Text) || string.IsNullOrWhiteSpace(User.Text))
            {
                MessageBox.Show("Please complete all fields.");
            }
            else if (UP.Text != UCP.Text)
            {
                MessageBox.Show("Passwords don't match.");
            }
            else
            {


                int priv = 0;
                if ((string)UT.SelectedValue == "Admin")
                    priv = 1;
                else if ((string)UT.SelectedValue == "Accountant")
                    priv = 2;
                else
                    priv = 3;
                
                int userverification = contobj.CreateUser(User.Text, UP.Text, Convert.ToInt16(priv));
                if (userverification == 1)
                {
                    MessageBox.Show("User created successfully.");

                }
                else
                {
                    MessageBox.Show("User Creation failed.");
                }


            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
       
            p.Show();
        }

        private void UU_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UUN.Text) || string.IsNullOrWhiteSpace(UUCP.Text) || string.IsNullOrWhiteSpace(UUNP.Text) || string.IsNullOrWhiteSpace(UUOP.Text) || string.IsNullOrWhiteSpace(UUNT.Text))
            {
                MessageBox.Show("Please complete all fields.");
            }
            else if (UUCP.Text != UUNP.Text)
            {
                MessageBox.Show("Passwords don't match.");
            }
            else
            {


                int priv = 0;
                if ((string)UUT.SelectedValue == "Admin")
                    priv = 1;
                else if ((string)UUT.SelectedValue == "Accountant")
                    priv = 2;
                else
                    priv = 3;
                int userverification = 0;
                if (privi == 1)
                {
                    userverification = contobj.UpdateUser(Int32.Parse(UUOP.Text), Int32.Parse(UUNP.Text), priv, UUN.Text.ToString(), UUNT.Text.ToString());
                }

                else
                {
                    userverification = contobj.UpdateUser1(Int32.Parse(UUOP.Text), Int32.Parse(UUNP.Text), UUN.Text.ToString(), UUNT.Text.ToString());
                }
                if (userverification == 1)
                {
                    MessageBox.Show("User Updated successfully.");

                }
                else
                {
                    MessageBox.Show("User updating failed.");
                }


            }
        }

        private void UUT_SelectedIndexChanged(object sender, EventArgs e)
        {
           //Extra
        }

        private void UT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
