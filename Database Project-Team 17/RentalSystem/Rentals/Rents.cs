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
    public partial class Rents : Form
    {
        MainPage M ;
        Controller contobj;
        public Rents(Controller contobj1,MainPage M1)
        {
            InitializeComponent();
            contobj = contobj1;
            M = M1;

            string[] Status = new string[3] { "ALL","Paid", "Not-Paid" };
            RS.DataSource = Status;
            RS.Refresh();

          
            DataTable dt1 = contobj.GetAllCollecters();
            RC.DataSource = dt1;
            RC.DisplayMember = "Employee_FirstName";

            RC.ValueMember = "Employee_Id";
            RC.Refresh();

            DataTable dt2 = contobj.GetAllCollecters();
            Collecter.DataSource = dt2;
            Collecter.DisplayMember = "Employee_FirstName";
            Collecter.ValueMember = "Employee_Id";
            Collecter.Refresh();

            DataTable dt3 = contobj.GetAllUnits();
            Units.DataSource = dt3;
            Units.ValueMember = "Unit_Id";
            Units.Refresh();

            DataTable dt4 = contobj.GetAllTenants();
            tenants.DataSource = dt4;
            tenants.DisplayMember = "Tenant_FirstName";
            tenants.ValueMember = "Tenant_Id";
            tenants.Refresh();
            DataTable dt5 = contobj.GetAllBuildings();
            BCC.DataSource = dt5;
            BCC.DisplayMember = "Building_Name";
            BCC.ValueMember = "Building_Id";
            BCC.Refresh();

            DataTable dt6 = contobj.GetAllOwners();
            Owners.DataSource = dt6;
            Owners.DisplayMember = "Owner_Name";
            Owners.ValueMember = "Owner_Id";
            Owners.Refresh();
        }

        private void RS_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Pay_Click(object sender, EventArgs e)
        {

            if (RIDT.Text.ToString() !="")
            {
                contobj.PayRent(1, Int32.Parse(RIDT.Text.ToString()));
                MessageBox.Show("Paid!!");
                RS.Refresh();
                ALL_Click(sender, e);
                dataGridView1.Refresh();

                contobj.PayRentToOwner(Int32.Parse(RDD.Text), Int32.Parse(Owners.SelectedValue.ToString()));
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            RIDT.Text = "";
            RDD.Text = "";
            RDDT.Text = "";
            RST.Text = "";
            LIDT.Text = "";
            CIDT.Text = "";
            if (dataGridView1.SelectedCells.Count > 0)
            {

                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedrow = dataGridView1.Rows[selectedrowindex];
                string a = selectedrow.Cells["Rent_Id"].Value.ToString();
                RIDT.Text = a;
                a = selectedrow.Cells["Rent_Amount"].Value.ToString();
                RDD.Text = a;
                if (selectedrow.Cells["Rent_DueDate"].Value.ToString() != "")
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


                if (selectedrow.Cells["Rent_CollecterId"].Value.ToString() !="")
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
                LIDT.Text = a;
            }
                               
                    
                    
        }

        private void UNPAY_Click(object sender, EventArgs e)
        {
            if (RIDT.Text.ToString() != "")
            {
                contobj.PayRent(0, Int32.Parse(RIDT.Text.ToString()));
                MessageBox.Show("UN-Paid!!");
                RS.Refresh();
                dataGridView1.Refresh();
                ALL_Click(sender,e);
                contobj.UnPayRentToOwner(Int32.Parse(RDD.Text), Int32.Parse(Owners.SelectedValue.ToString()));
            }


        }

        private void RC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RIDT.Text.ToString() != "")
            {
                contobj.ChangeCollecter((int)RC.SelectedValue, Int32.Parse(RIDT.Text));
                MessageBox.Show("Changed!!");
                ALL_Click(sender, e);
            }

        }

        private void Search_Click(object sender, EventArgs e)
        {



            string a;
            RS.Refresh();
            
            
                if (RS.SelectedValue.ToString() == "Paid")
                { a = "1)"; }
                else if (RS.SelectedValue.ToString() == "Not-Paid")
                { a = "0)"; }
                else
                { a = "0 OR Rent_Statues = 1)"; }



                string b;

                b = " AND Rent_Amount >" + RAN.Value.ToString();
                a += b;


                if (Collecter.SelectedValue != null)
                {
                    b = " AND Rent_CollecterId = " + Collecter.SelectedValue.ToString();
                    a += b;
                }

                if (DueS.Value != null)
                {
                    b = " And Rent_DueDate <= '" + DueS.Value.ToString("yyyy-MM-dd") + "'";
                    a += b;
                }

                if (DDA.Value != null)
                {
                    b = " And Rent_DueDate >= '" + DDA.Value.ToString("yyyy-MM-dd") + "'";
                    a += b;
                }

                if (Units.SelectedValue != null)
                {
                    b = " And Unit_Rents_UnitId = " + Units.SelectedValue.ToString();
                    a += b;
                }

                if (tenants.SelectedValue != null)
                {
                    b = " And Unit_Rents_TenantId = " + tenants.SelectedValue.ToString();
                    a += b;
                }

                if (BCC.SelectedValue != null)
                {
                    b = " And Unit_BuildingNo = " + BCC.SelectedValue.ToString();
                    a += b;
                }

                DataTable dt1 = contobj.GetRentsByStat(a);
                dataGridView1.DataSource = dt1;
                if (dt1 != null)
                {
                    dataGridView1.Columns[4].Visible = false;
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[9].Visible = false;
                    dataGridView1.Columns[10].Visible = false;
                    dataGridView1.Columns[11].Visible = false;
                    dataGridView1.Columns[12].Visible = false;
                    dataGridView1.Columns[13].Visible = false;
                    dataGridView1.Columns[14].Visible = false;
                    dataGridView1.Columns[15].Visible = false;
                    dataGridView1.Columns[16].Visible = false;
                    dataGridView1.Columns[17].Visible = false;
                    dataGridView1.Columns[0].HeaderText = "Id";
                    dataGridView1.Columns[1].HeaderText = "Amount";
                    dataGridView1.Columns[2].HeaderText = "Due Date";
                    dataGridView1.Columns[3].HeaderText = "Payment Statues";
                    /* dataGridView1.Columns[4].HeaderText = "Collecter Id";
                     dataGridView1.Columns[5].HeaderText = "Lease Id";
                     dataGridView1.Columns[6].HeaderText = "Tenant";
                     dataGridView1.Columns[7].HeaderText = "Unit";
                     dataGridView1.Columns[17].HeaderText = "Building ID";*/
                }

                dataGridView1.Refresh();
                if (sender == Search)
                    MessageBox.Show("Search Done!!");

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            M.Show();
            this.Hide();
        }

        private void ALL_Click(object sender, EventArgs e)
        {
           
            string a = "0 OR Rent_Statues = 1)";
            DataTable dt1 = contobj.GetRentsByStat(a);
           
            dataGridView1.DataSource = dt1;
            if (dt1 != null)
            {
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = false;
                dataGridView1.Columns[13].Visible = false;
                dataGridView1.Columns[14].Visible = false;
                dataGridView1.Columns[15].Visible = false;
                dataGridView1.Columns[16].Visible = false;
                dataGridView1.Columns[17].Visible = false;
                dataGridView1.Columns[0].HeaderText = "Id";
                dataGridView1.Columns[1].HeaderText = "Amount";
                dataGridView1.Columns[2].HeaderText = "Due Date";
                dataGridView1.Columns[3].HeaderText = "Payment Statues";
                /* dataGridView1.Columns[4].HeaderText = "Collecter Id";
                 dataGridView1.Columns[5].HeaderText = "Lease Id";
                 dataGridView1.Columns[6].HeaderText = "Tenant";
                 dataGridView1.Columns[7].HeaderText = "Unit";
                 dataGridView1.Columns[17].HeaderText = "Building ID";*/
            }
            dataGridView1.Refresh();
            if (sender == ALL)
                MessageBox.Show("Search Done!!");
        }

        private void DDA_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rents_Load(object sender, EventArgs e)
        {

        }
    }
}
