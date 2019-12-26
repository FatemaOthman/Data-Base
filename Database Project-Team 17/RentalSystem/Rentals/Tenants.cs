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
    public partial class Tenants : Form
    {
        MainPage Ma;
        Controller contobj;
     
 
            public Tenants(Controller contobje, MainPage M1)
            {
            InitializeComponent();
                contobj = contobje;
                Ma = M1;
           
            //------------to add tenant id to combobox---------------
            Select_t.DataSource = contobj.GetTenantsID();
            Select_t.DisplayMember= "Tenant_ID";
            //--------------------------------------------------------
            //------------to add all building tocombobox--------------
            Buildings.DataSource = contobj.GetBuildingsName();
            Buildings.DisplayMember = "Building_Name";
            //--------------------------------------------------------
            //------------to add contacts to combobox-----------------
         

        }

        private void addSSN_TextChanged(object sender, EventArgs e)
        {


        }

        private void Tenants_Load(object sender, EventArgs e)
        {

        }

        private void Select_t_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void View_Tenant_Click(object sender, EventArgs e)
        {
            DataTable dat = contobj.GetTenant(Convert.ToInt32(Select_t.Text));
            ShowTenants.DataSource = dat;
            ShowTenants.Refresh();
        }

        private void ViewALL_Click(object sender, EventArgs e)
        {
            DataTable dat = contobj.GetAllTenantsInfo();
            ShowTenants.DataSource = dat;


        }

        private void BackB_Click(object sender, EventArgs e)
        {

            this.Hide();
            Ma.Show();
        }

        private void AddTenant_Click(object sender, EventArgs e)
        {
            
            
            if (addSSN.Text == "" || Fname.Text == "" || Lname.Text == "" || PhoneNUM.Text == "" || Buildings.Text== "" || UNITS.Text == "")
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }
            int success = contobj.AddTenant(Convert.ToInt32(addSSN.Text), Fname.Text, Lname.Text, Convert.ToInt32(PhoneNUM.Text), Buildings.Text, Convert.ToInt32(UNITS.Text));
            if (success == 1)
            {
                MessageBox.Show("Added.");
            }
            else
                MessageBox.Show("Tenant not added.");

            
            AddTenant.Refresh();
        }

        private void ShowTenants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ShowTenants.SelectedCells.Count > 0)
            {

                int selectedrowindex = ShowTenants.SelectedCells[0].RowIndex;

                DataGridViewRow selectedrow = ShowTenants.Rows[selectedrowindex];
                IDtext.Text = selectedrow.Cells["Tenant_Id"].Value.ToString();
                addSSN.Text = selectedrow.Cells["Tenant_SSN"].Value.ToString();
                Fname.Text = selectedrow.Cells["Tenant_FirstName"].Value.ToString();
                Lname.Text = selectedrow.Cells["Tenant_LastName"].Value.ToString();
                PhoneNUM.Text = selectedrow.Cells["Tenant_PhoneNumber"].Value.ToString();
               
            }


        }

        private void Buildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            UNITS.DataSource=contobj.GetUnitsID(Buildings.Text);
            UNITS.DisplayMember = "Unit_Id";
        }

        private void UNITS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void UpdateTB_Click(object sender, EventArgs e)
        {
            int s = contobj.UpdateTenantById(Convert.ToInt32(IDtext.Text), Convert.ToInt32(addSSN.Text), Fname.Text, Lname.Text, Convert.ToInt32(PhoneNUM.Text));
            if (s == 1)
                MessageBox.Show("Updated.");
            else
                MessageBox.Show("Update failed. Id you entered does not exist in the current database.");
        }
       
private void DeleteT_Click(object sender, EventArgs e)
        {
            int c = contobj.SelectUR_TId(Convert.ToInt32(IDtext.Text));

            if (c == 0)
            {
                int s = contobj.DelTenant(Convert.ToInt32(IDtext.Text));

                if (s == 1)
                    MessageBox.Show("Tenant deleted.");
                else
                    MessageBox.Show("Tenant is not deleted.");
            }
            else
            {
                int R = contobj.deleteUR_TId(Convert.ToInt32(IDtext.Text));

                int s = contobj.DelTenant(Convert.ToInt32(IDtext.Text));
          
                    if (s == 1)
                        MessageBox.Show("Tenant deleted.");
                    else
                        MessageBox.Show("Tenant is not deleted.");

                    
                    

            }
        }
    }
}
