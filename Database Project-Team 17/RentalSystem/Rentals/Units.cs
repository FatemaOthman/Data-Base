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
    public partial class form : Form
    {
        MainPage Mi;
        Controller contobj;
        public form(Controller contobje, MainPage M1)
        {
            InitializeComponent();
            contobj = contobje;
            Mi = M1;

            //to add unit id to comboBox to select certian unit

            UnitIDtext.DataSource = contobj.GetUnitbyID();
            UnitIDtext.DisplayMember = "Unit_Id";
            //--------------------------------------------------



        }



        private void Units_Load(object sender, EventArgs e)
        {

        }

        private void UArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void UnitIDtext_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = contobj.ShowCertianUnit(Convert.ToInt32(UnitIDtext.Text));
            displayUnits.DataSource = dt;

            displayUnits.Refresh();


        }

        private void ShowAllUnits_Click(object sender, EventArgs e)
        {

            DataTable dat = contobj.GetALLUnits();
            displayUnits.DataSource = dat;
            displayUnits.Refresh();


        }

        private void displayUnits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (displayUnits.SelectedCells.Count > 0)
            {

                int selectedrowindex = displayUnits.SelectedCells[0].RowIndex;

                DataGridViewRow selectedrow = displayUnits.Rows[selectedrowindex];
                uID.Text = selectedrow.Cells["Unit_Id"].Value.ToString();
                UType.Text = selectedrow.Cells["Unit_Type"].Value.ToString();
                UReqRent.Text = selectedrow.Cells["Unit_RequiredRent"].Value.ToString();
                UArea.Text = selectedrow.Cells["Unit_Area"].Value.ToString();
                UnoOfBathrooms.Text = selectedrow.Cells["Unit_NumberOfBathrooms"].Value.ToString();
                UnoOfRooms.Text = selectedrow.Cells["Unit_NumberOfRooms"].Value.ToString();
                UCondition.Text = selectedrow.Cells["Unit_Condition"].Value.ToString();
                UBuildingNum.Text = selectedrow.Cells["Unit_BuildingNo"].Value.ToString();

                string un = selectedrow.Cells["Unit_State"].Value.ToString();

                if (un == "True")
                    un = "Rented";
                else
                    un = "Empty";

                UState.Text = un;

            }

            ShowAllUnits_Click(sender, e);
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mi.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void DELUnit_Click(object sender, EventArgs e)
        {

            int c = contobj.SelectUR_UId(Convert.ToInt32(uID.Text));
            if (c == 0)
            {
                int s = contobj.deleteUNIT(Convert.ToInt32(uID.Text));

                if (s == 1)
                    MessageBox.Show(" Unit deleted.");
                else
                    MessageBox.Show(" Unit is not deleted.");
            }
            else
            {
                int R = contobj.deleteUR_UId(Convert.ToInt32(uID.Text));

                int s = contobj.deleteUNIT(Convert.ToInt32(uID.Text));

                    if (s == 1)
                        MessageBox.Show(" Unit deleted.");
                    else
                        MessageBox.Show(" Unit is not deleted.");




            }
        }


 
        private void AddUNIT_Click(object sender, EventArgs e)
        {

            if (UType.Text == "" || UReqRent.Text == "" ||UState.Text == "" || UArea.Text == "" || UnoOfBathrooms.Text == "" ||UnoOfRooms.Text == "" || UCondition.Text=="" || UBuildingNum.Text=="")
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }
            
            int success = contobj.AddUnits(UType.Text, Convert.ToInt32(UReqRent.Text), Convert.ToInt32(UState.Text), Convert.ToInt32(UArea.Text), Convert.ToInt32(UnoOfBathrooms.Text), Convert.ToInt32(UnoOfRooms.Text), UCondition.Text,Convert.ToInt32(UBuildingNum.Text));
            if (success == 1)
            {
                MessageBox.Show("Added.");
            }
            else
                MessageBox.Show("Building not added.");

            ShowAllUnits_Click(sender, e);

        }

        private void UPDATEunit_Click(object sender, EventArgs e)
        {
            int success = contobj.UpdateUnit(Convert.ToInt32(uID.Text), UType.Text, Convert.ToInt32(UReqRent.Text), Convert.ToInt32(UState.Text), Convert.ToInt32(UArea.Text), Convert.ToInt32(UnoOfBathrooms.Text), Convert.ToInt32(UnoOfRooms.Text), UCondition.Text, Convert.ToInt32(UBuildingNum.Text));
            if (success == 1)
                    MessageBox.Show("Updated.");
                else
                    MessageBox.Show("Update failed. ID you entered does not exist in the current database.");


                ShowAllUnits_Click(sender, e);

        }


    }
}


