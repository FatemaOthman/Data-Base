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
    public partial class Owners : Form
    {
        Controller contobj;
        MainPage MM;
        public Owners(Controller contobj1, MainPage m1)
        {
            InitializeComponent();
            contobj = contobj1;
            MM = m1;
            Ownerscombobox.DataSource = contobj.GetOwnerLastNames();
            Ownerscombobox.DisplayMember = "Owner_LastName";
        }
        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Owners_Load(object sender, EventArgs e)
        {
           
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MM.Show();
        }


        private void Refresh_Click(object sender, EventArgs e)
        {
            OwnersData.DataSource = contobj.GetAllOwnerInfo();
            OwnersData.Refresh();
        }

        private void ViewAllOwners_Click(object sender, EventArgs e)
        {
            DataTable dt = contobj.GetAllOwnerInfo();
            OwnersData.DataSource = dt;
        }

        private void GetOwner_Click(object sender, EventArgs e)
        {
            DataTable dt = contobj.GetOwnerInfo(Ownerscombobox.Text);
            OwnersData.DataSource = dt;
            OwnersData.Refresh();
        }

        private void AddOwner_Click(object sender, EventArgs e)
        {
            

            if ( SSNText.Text == "" || FNText.Text == "" || LNText.Text == "" || PhoneNOText.Text =="" || AddressText.Text == "" || NoOfBuildingsText.Text =="" || IncomeText.Text == "")
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }
            int success = contobj.AddOwner(Convert.ToInt32(SSNText.Text), FNText.Text, LNText.Text, Convert.ToInt32(PhoneNOText.Text), AddressText.Text, Convert.ToInt32(NoOfBuildingsText.Text), Convert.ToInt32(IncomeText.Text));
            if (success == 1)
            {
                MessageBox.Show("Added.");
            }
            else
                MessageBox.Show("Owner not added.");

            
            OwnersData.Refresh();
        }

        private void UpdateExistingOwner_Click(object sender, EventArgs e)
        {
            int success =  contobj.UpdateOwnerBySSN(Convert.ToInt32(SSNText.Text), FNText.Text, LNText.Text, Convert.ToInt32(PhoneNOText.Text), AddressText.Text, Convert.ToInt32(NoOfBuildingsText.Text), Convert.ToInt32(IncomeText.Text));
            if (success == 1)
                MessageBox.Show("Updated.");
            else
                MessageBox.Show("Update failed. SSN you entered does not exist in the current database.");
        }

        private void OwnersData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SSNText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ownerscombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
