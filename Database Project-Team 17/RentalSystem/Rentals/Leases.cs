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
    public partial class Leases : Form
    {
        Controller contobj;
        MainPage MM;
        public Leases(Controller contobj1, MainPage m1)
        {
            InitializeComponent();
            contobj = contobj1;
            MM = m1;


            DataTable dt5 = contobj.GetAllBuildings();
            comboBox1.DataSource = dt5;
            comboBox1.DisplayMember = "Building_Name";
            comboBox1.ValueMember = "Building_Id";

            DataTable dt4 = contobj.GetAllTenants();
            TenantE.DataSource = dt4;
            TenantE.DisplayMember = "Tenant_FirstName";
            TenantE.ValueMember = "Tenant_Id";


            DataTable dt6 = contobj.GetUnitsByBuildingId(Convert.ToInt32(comboBox1.SelectedValue));
            comboBox2.DataSource = dt6;
            comboBox2.DisplayMember = "Unit_Id";
            comboBox2.ValueMember = "Unit_Id";

            DataTable dt7 = contobj.GetAllCollecters();
            CollectorID.DataSource = dt7;
            CollectorID.DisplayMember = "Employee_FirstName";
            CollectorID.ValueMember = "Employee_Id";




        }

        private void Leases_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            DataTable dt1 = contobj.GetAllLeases();

            dataGridView2.DataSource = dt1;
            if (dt1 != null)
            {
               // dataGridView2.Columns[1].Visible = false;
                //dataGridView2.Columns[2].Visible = false;
                dataGridView2.Columns[3].Visible = false;
                dataGridView2.Columns[5].Visible = false;
                dataGridView2.Columns[6].Visible = false;
                dataGridView2.Columns[8].Visible = false;
                dataGridView2.Columns[9].Visible = false;
                //dataGridView2.Columns[9].Visible = false;
                /*dataGridView2.Columns[11].Visible = false;
                dataGridView2.Columns[12].Visible = false;
                dataGridView2.Columns[13].Visible = false;
                dataGridView2.Columns[14].Visible = false;
                dataGridView2.Columns[15].Visible = false;
                dataGridView2.Columns[16].Visible = false;
                dataGridView2.Columns[17].Visible = false;*/
                dataGridView2.Columns[0].HeaderText = "Lease ID";
                dataGridView2.Columns[4].HeaderText = "Rent Amount";
                dataGridView2.Columns[1].HeaderText = "End Date";
                dataGridView2.Columns[2].HeaderText = "Start Date";
                //dataGridView2.Columns[4].HeaderText = "Collecter Id";
                //dataGridView2.Columns[5].HeaderText = "Lease Id";
                dataGridView2.Columns[7].HeaderText = "Deposit";
                // dataGridView2.Columns[7].HeaderText = "Unit";
                 //dataGridView2.Columns[17].HeaderText = "Building ID";
            }
            dataGridView2.Refresh();
            if (sender == button1)
                MessageBox.Show("Search Done!!");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {

                int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;

                DataGridViewRow selectedrow = dataGridView2.Rows[selectedrowindex];
                string a = selectedrow.Cells["Lease_Interest"].Value.ToString();
                IPE.Text = a;
                a = selectedrow.Cells["Lease_InterestInterval"].Value.ToString();
                IIE.Text = a;

                a = selectedrow.Cells["Lease_RentAmount"].Value.ToString();
                RAE.Text = a;

                a = selectedrow.Cells["Lease_Deposit"].Value.ToString();
                DE.Text = a;

                /*if (selectedrow.Cells["Rent_DueDate"].Value.ToString() != "")
                {
                    DateTime b = (DateTime)selectedrow.Cells["Rent_DueDate"].Value;
                    a = b.ToString("yyyy-MM-dd");
                    RDDT.Text = a;

                }


                a = selectedrow.Cells["Rent_Statues"].Value.ToString();

                if (a == "True")
                    a = "Paid";
                else
                    a = "Not-Paid";

                RST.Text = a;


                if (selectedrow.Cells["Rent_CollecterId"].Value.ToString() != "")
                {
                    a = selectedrow.Cells["Rent_CollecterId"].Value.ToString();
                    a = contobj.GetEmpById(a);

                    CIDT.Text = a;
                }

                if (selectedrow.Cells["Unit_Rents_TenantId"].Value.ToString() != "")
                {
                    a = selectedrow.Cells["Unit_Rents_TenantId"].Value.ToString();
                    a = contobj.GetTenantById(a);

                    Tenantname.Text = a;
                }
                if (selectedrow.Cells["Unit_Rents_UnitId"].Value.ToString() != "")
                {
                    a = selectedrow.Cells["Unit_Rents_UnitId"].Value.ToString();
                    a = contobj.GetUnitById(a);

                    Unitname.Text = a;
                }
                if (selectedrow.Cells["Unit_BuildingNo"].Value.ToString() != "")
                {
                    a = selectedrow.Cells["Unit_BuildingNo"].Value.ToString();
                    a = contobj.GetBuildingById(a);

                    Buildingname.Text = a;
                }
                a = selectedrow.Cells["Rent_LeasesId"].Value.ToString();
                if (a == "")
                    a = "NONE";
                LIDT.Text = a;*/
            }
        }

        private void DE_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            DataTable dt1 = contobj.GetLeasesById(ID.Text.ToString());

            dataGridView2.DataSource = dt1;
            if (dt1 != null)
            {
                // dataGridView2.Columns[1].Visible = false;
                //dataGridView2.Columns[2].Visible = false;
                dataGridView2.Columns[3].Visible = false;
                dataGridView2.Columns[5].Visible = false;
                dataGridView2.Columns[6].Visible = false;
                dataGridView2.Columns[8].Visible = false;
                dataGridView2.Columns[9].Visible = false;
                //dataGridView2.Columns[9].Visible = false;
                /*dataGridView2.Columns[11].Visible = false;
                dataGridView2.Columns[12].Visible = false;
                dataGridView2.Columns[13].Visible = false;
                dataGridView2.Columns[14].Visible = false;
                dataGridView2.Columns[15].Visible = false;
                dataGridView2.Columns[16].Visible = false;
                dataGridView2.Columns[17].Visible = false;*/
                dataGridView2.Columns[0].HeaderText = "Lease ID";
                dataGridView2.Columns[4].HeaderText = "Rent Amount";
                dataGridView2.Columns[1].HeaderText = "End Date";
                dataGridView2.Columns[2].HeaderText = "Start Date";
                //dataGridView2.Columns[4].HeaderText = "Collecter Id";
                //dataGridView2.Columns[5].HeaderText = "Lease Id";
                // dataGridView2.Columns[6].HeaderText = "Tenant";
                // dataGridView2.Columns[7].HeaderText = "Unit";
                //dataGridView2.Columns[17].HeaderText = "Building ID";
            }
            dataGridView2.Refresh();
            if (sender == button3)
                MessageBox.Show("Search Done!!");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MM.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                DataTable dt5 = contobj.GetUnitsByBuildingId(Convert.ToInt32(comboBox1.SelectedValue));
                comboBox2.DataSource = dt5;
                comboBox2.DisplayMember = "Unit_Id";
                comboBox2.ValueMember = "Unit_Id";

            }
            }

        private void button4_Click(object sender, EventArgs e)
        {
            //Add Leases
            if( contobj.AddLease(EDE.Value, SDE.Value,"1", RAE.Value,(int)IPE.Value,(int)IIE.Value, DE.Value, SDE.Value.AddDays(30), Int32.Parse(TenantE.SelectedValue.ToString())) != 1)
            {
                MessageBox.Show("Failed to create Lease.");
            }
            int leaseid = contobj.GetLeaseID();
            int result = contobj.AddRent((int)RAE.Value, SDE.Value, "1" , Convert.ToInt32(CollectorID.SelectedValue),leaseid);
            contobj.AddUnit_Rent((int)TenantE.SelectedValue, (int)comboBox2.SelectedValue, contobj.GetRentID());
            if (result == 1)
            {
                MessageBox.Show("Lease and Rent added successfully.");

            }
            else
            {
                MessageBox.Show("Failed to create rent.");
            }
        }

        private void IPE_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CollectorID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
