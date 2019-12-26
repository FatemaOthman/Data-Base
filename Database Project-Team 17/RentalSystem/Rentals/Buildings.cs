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
    public partial class Buildings : Form
    {

        MainPage Mai;
        Controller contobj;
      

        public Buildings(Controller contobje, MainPage M1,int priv)
        {
            InitializeComponent();
            contobj = contobje;
            Mai = M1;
      
            GetBname.DataSource = contobj.GetBuildingsName();
            GetBname.DisplayMember = "Building_Name";
        }

        private void Buildings_Load(object sender, EventArgs e)
        {

        }

        private void GetBname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShowBdbyName_Click(object sender, EventArgs e)
        {
            DataTable dat = contobj.GetBuildingsByName(GetBname.Text);
            ShowB.DataSource = dat;
            ShowB.Refresh();
        }


        private void ShowB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ShowB.SelectedCells.Count > 0)
            {

                int selectedrowindex = ShowB.SelectedCells[0].RowIndex;

                DataGridViewRow selectedrow = ShowB.Rows[selectedrowindex];
                IDtxt.Text = selectedrow.Cells["Building_Id"].Value.ToString();
                Bname.Text = selectedrow.Cells["Building_Name"].Value.ToString();
                BStreet.Text = selectedrow.Cells["Building_Street"].Value.ToString();
                BCity.Text = selectedrow.Cells["Building_City"].Value.ToString();
                BDistrict.Text = selectedrow.Cells["Building_District"].Value.ToString();
                Bnum.Text = selectedrow.Cells["Building_Number"].Value.ToString();
                BnumOfUnits.Text = selectedrow.Cells["Building_NumberOfUnits"].Value.ToString();
                BOwnerId.Text = selectedrow.Cells["Building_OwnerId"].Value.ToString();
            }


        }

        private void GetAllBds_Click(object sender, EventArgs e)
        {
            DataTable dat = contobj.GetAllBuildings();
            ShowB.DataSource = dat;


        }

        private void AddBuilding_Click(object sender, EventArgs e)
        {


            if (Bname.Text == "" || BStreet.Text == "" || BCity.Text == "" || BDistrict.Text == "" || Bnum.Text == "" || BnumOfUnits.Text == "" || BOwnerId.Text == "")
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }
            // feh error bytl3 de district !!!

            int success = contobj.AddBuildings(Bname.Text, BStreet.Text, BCity.Text, BDistrict.Text, Convert.ToInt32(Bnum.Text), Convert.ToInt32(BnumOfUnits.Text), Convert.ToInt32(BOwnerId.Text));
            if (success == 1)
            {
                MessageBox.Show("Added.");
            }
            else
                MessageBox.Show("Building not added.");


            //          AddBuilding.Refresh();
            GetAllBds_Click(sender, e);

        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            object z = contobj.GetUnitsIdFORB(Convert.ToInt32(IDtxt.Text));
            if (z == null)
            {
                int success = contobj.DeleteBuilding(Convert.ToInt32(IDtxt.Text));
                if (success == 1)
                    MessageBox.Show("Empty Building deleted.");
                else
                    MessageBox.Show("Building couldn't be deleted.");
            }

            else
            {
                string ts = z.ToString();
                int s = contobj.deleteUR_UId(Convert.ToInt32(ts));
                if (s == 1)
                {


                    int c = contobj.deleteUNIT(Convert.ToInt32(ts));
                    int success = contobj.DeleteBuilding(Convert.ToInt32(IDtxt.Text));
                    MessageBox.Show("Building with all units is deleted.");


                }

                else

                    MessageBox.Show(" Building couldn't be deleted. Delete Units in the building first.");
            }

            GetAllBds_Click(sender, e);


        }
    


    private void UpdateBuilding_Click(object sender, EventArgs e)
        {

        }

        private void BckButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            Mai.Show();

        }



        private void UpdateBuilding_Click_1(object sender, EventArgs e)
        {
            int success = contobj.UpdateBuildingById(Convert.ToInt32(IDtxt.Text), Bname.Text, BStreet.Text, BCity.Text, BDistrict.Text, Convert.ToInt32(Bnum.Text), Convert.ToInt32(BnumOfUnits.Text), Convert.ToInt32(BOwnerId.Text));

            {
                if (success == 1)
                    MessageBox.Show("Updated.");
                else
                    MessageBox.Show("Update failed. ID you entered does not exist in the current database.");



            }

            GetAllBds_Click(sender, e);
        }
    }
}

   

