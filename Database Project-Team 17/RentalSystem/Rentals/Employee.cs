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
    public partial class Employee : Form
    {
        Controller contobj;
        MainPage MM;

        public Employee(Controller contobj1, MainPage m1,int priv)
        {
           

            InitializeComponent();
            if (priv == 3)
            {
                Add.Hide();
                Update.Hide();
                Delete.Hide();
                UnPay.Hide();
               
            }
            if (priv != 3 && priv != 1)
            {
                Add.Hide();
                Update.Hide();
                Delete.Hide();
                PayManValue.Hide();
                Pay_Manual.Hide();
                UnPay.Hide();
            }
            contobj = contobj1;
            MM = m1;
            DataTable D1 = null;
            MgrID.DataSource = D1;
            D1 = contobj.GetEmployeeByType("Manager");
            if(D1!=null)
            
                for (int i = 0; i < D1.Rows.Count; i++)
                {
                    MgrID.Items.Add(D1.Rows[i][0]);
                }
                D1 = null;
                ContID.DataSource = D1;
                D1 = contobj.GetUnEmployedContactID();

            if (D1 != null) 
                for (int i = 0; i < D1.Rows.Count; i++)
                {
                    ContID.Items.Add(D1.Rows[i][0]);
                }
                D1 = null;
                OwnID.DataSource = D1;
                D1 = contobj.GetAllOwnerID();
            if (D1 != null)
                for (int i = 0; i < D1.Rows.Count; i++)
                {
                    OwnID.Items.Add(D1.Rows[i][0]);
                }



                Type.Items.Add("Manager");
                Type.Items.Add("Accountant");
                Type.Items.Add("Cash Collecter");

      

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SH_ALL_Click(object sender, EventArgs e)
        {
            string MGR = null, ACC = null, CASH = null;
            if (ManagerSearch.Checked==true)
                MGR = "Manager";
            if (AcountantSearch.Checked==true)
                ACC = "Accountant";
            if (CashSearch.Checked==true)
                CASH = "Cash Collecter";
           
           
            dataGridView1.DataSource = contobj.GetEmployee(MGR,CASH, ACC);
            if (dataGridView1.DataSource != null)
            {
                
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "First Name";
                dataGridView1.Columns[2].HeaderText = "Last Name";
                dataGridView1.Columns[3].HeaderText = "SSN";
                dataGridView1.Columns[4].HeaderText="Outstanding Salary";
                dataGridView1.Columns[5].HeaderText = "Salary";
                dataGridView1.Columns[6].HeaderText = "Hiring Date";
                dataGridView1.Columns[7].HeaderText = "Type";
                dataGridView1.Columns[10].HeaderText = "Manager ID";
                dataGridView1.Columns[11].HeaderText = "Owner ID";
                dataGridView1.Columns[12].HeaderText = "Contact ID";

            }
            dataGridView1.Refresh();
            if (sender == SH_ALL)
                MessageBox.Show("Search Done!!");
        }

        private void Add_Click(object sender, EventArgs e)
        {


            if (Fname.Text == "" || Lname.Text == "" || (string)Type.SelectedItem == "" || Type.SelectedItem == null || OwnID.SelectedItem == null|| (MgrID.SelectedItem==null&&HasMGR.Checked==true))
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }
            string FN, LN;
            FN = Fname.Text;
            LN = Lname.Text;
        
            if (FN.Any(char.IsDigit))
            {
                MessageBox.Show("No digits are allowed in first name field!");
                return;
            }
            if (LN.Any(char.IsDigit))
            {
                MessageBox.Show("No digits are allowed in last name field!");
                return;

            }

            int? MGR=null;
            if (HasMGR.Checked == true)
                MGR = (int)MgrID.SelectedItem;

    
            int r = contobj.AddEmployee(Fname.Text, Lname.Text, (int)SSN.Value, (float)OSSalary.Value, (float)Salary.Value, Hdate.Value, (string)Type.SelectedItem, (int?)MGR, (int)OwnID.SelectedItem, (int)ContID.SelectedItem);
            if (r > 0)
                MessageBox.Show("The Employee is Added successfully! :) ");
            else
                MessageBox.Show("Employee Not Added, Check your input again. ");
            dataGridView1.Refresh();
            SH_ALL_Click(sender, e);
            return;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (Search_SSN.Text == "")
            {
                MessageBox.Show("Please enter The SSN.");
                return;
            }
            int x;
            if (!(Int32.TryParse(Search_SSN.Text, out x)))
            {
                MessageBox.Show("Please enter a number in the SSN number field.");
                return;
            }
            dataGridView1.DataSource=contobj.GetEmpBySSN(Convert.ToInt32(Search_SSN.Text));
            if(dataGridView1.DataSource == null)
            {
                MessageBox.Show("Sorry, we don't have any employees with this SSN, Please recheck the SSN you entered.");
                return;
            }
            if (dataGridView1.DataSource != null)
            {

                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "First Name";
                dataGridView1.Columns[2].HeaderText = "Last Name";
                dataGridView1.Columns[3].HeaderText = "SSN";
                dataGridView1.Columns[4].HeaderText = "Outstanding Salary";
                dataGridView1.Columns[5].HeaderText = "Salary";
                dataGridView1.Columns[6].HeaderText = "Hiring Date";
                dataGridView1.Columns[7].HeaderText = "Type";
                dataGridView1.Columns[10].HeaderText = "Manager ID";
                dataGridView1.Columns[11].HeaderText = "Owner ID";
                dataGridView1.Columns[12].HeaderText = "Contact ID";

            }
            dataGridView1.Refresh();
            if (sender == SH_ALL)
                MessageBox.Show("Search Done!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (Fname.Text == "" || Lname.Text == "" ||ID.Text==""|| (string)Type.SelectedItem == "" || Type.SelectedItem == null || OwnID.SelectedItem == null || (MgrID.SelectedItem == null && HasMGR.Checked == true))
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }
          
            string FN, LN;
            FN = Fname.Text;
            LN = Lname.Text;

            if (FN.Any(char.IsDigit))
            {
                MessageBox.Show("No digits are allowed in first name field!");
                return;
            }
            if (LN.Any(char.IsDigit))
            {
                MessageBox.Show("No digits are allowed in last name field!");
                return;
            }
            int x;
            if (!(Int32.TryParse(ID.Text, out x)))
            {
                MessageBox.Show("Please enter a number in the ID number field.");
                return;
            }
            int? MGR = null;
            if (HasMGR.Checked == true)
                MGR = (int)MgrID.SelectedItem;
            int r = contobj.UpdateEmployee(Convert.ToInt32(ID.Text),Fname.Text, Lname.Text, (int)SSN.Value, (float)OSSalary.Value, (float)Salary.Value, Hdate.Value, (string)Type.SelectedItem, (int?)MGR, (int)OwnID.SelectedItem, (int)ContID.SelectedItem);
            if (r > 0)
                MessageBox.Show("The Employee is Updated successfully! :) ");
            else
                MessageBox.Show("Employee Not Updated, Check your input again. ");
            dataGridView1.Refresh();
            SH_ALL_Click(sender, e);
            return;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (ID.Text == "")
            {
                MessageBox.Show("Please enter the ID!");
                return;
            }
            int x;
            if (!(Int32.TryParse(ID.Text, out x)))
            {
                MessageBox.Show("Please enter a number in the ID number field.");
                return;
            }
            int r = contobj.DeleteEmployee(Convert.ToInt32(ID.Text));
            if (r > 0)
                MessageBox.Show("Deleted Sucssesfully!");
            else
                MessageBox.Show("Employee Not Deleted, Recheck The ID");
            dataGridView1.Refresh();
            SH_ALL_Click(sender, e);

            
           

        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            Fname.Text = (string)dataGridView1[1, row].Value;
           
            Lname.Text = (string)dataGridView1[2, row].Value;
         
            ID.Text = ((int)dataGridView1[0, row].Value).ToString();
          
            SSN.Value = (int)dataGridView1[3, row].Value;
        
            OSSalary.Value= Convert.ToInt32(dataGridView1[4, row].Value);
           
            Salary.Value= Convert.ToInt32(dataGridView1[5, row].Value);
            
            Hdate.Value = Convert.ToDateTime(dataGridView1[6, row].Value);

            Type.SelectedItem = (string)dataGridView1[7, row].Value;

            MgrID.SelectedItem= MgrID.SelectedItem==null?null:(string)dataGridView1[10, row].Value;

            OwnID.SelectedItem= (int)dataGridView1[11, row].Value;

            ContID.SelectedItem= (int)dataGridView1[12, row].Value;
          

        }

        private void Pay_Os_Salary_Click(object sender, EventArgs e)
        {
            if (ID.Text == "")
            {
                MessageBox.Show("Please enter the ID!");
                return;
            }
            int x;
            if (!(Int32.TryParse(ID.Text, out x)))
            {
                MessageBox.Show("Please enter a number in the ID number field.");
                return;
            }
            if((contobj.GetEmpById(ID.Text))==null)
            {
                MessageBox.Show("This ID is non existent, Please reEnter The ID.");
                return;
            }
            int OID = contobj.GetOwnerIDFromEmpID(Convert.ToInt32(ID.Text));
            int Sal = contobj.SalaryByID(Convert.ToInt32(ID.Text));
            int Os = contobj.OustandingSalaryByID(Convert.ToInt32(ID.Text));
            if(Os<=0)
            {
                MessageBox.Show("No Outstanding Salary, Salary Is already paid! ");
                return;
            }

            int r = contobj.AddExpense1(OID, Os, DateTime.Now, "Salary");
            if (r > 0)
                MessageBox.Show("Payment Done!");
            else
                MessageBox.Show("Payment Not Done");
            contobj.PayoutstandingSalary(Convert.ToInt32(ID.Text));

            SH_ALL_Click(sender, e);


        }

        private void Pay_Manual_Click(object sender, EventArgs e)
        {
            if (ID.Text == "")
            {
                MessageBox.Show("Please enter the ID!");
                return;
            }
            int x;
            if (!(Int32.TryParse(ID.Text, out x)))
            {
                MessageBox.Show("Please enter a number in the ID number field.");
                return;
            }
            if ((contobj.GetEmpById(ID.Text)) == null)
            {
                MessageBox.Show("This ID is non existent, Please reEnter The ID.");
                return;
            }
            int OID = contobj.GetOwnerIDFromEmpID(Convert.ToInt32(ID.Text));
            int Sal = Convert.ToInt32(PayManValue.Value);
            int Os = contobj.OustandingSalaryByID(Convert.ToInt32(ID.Text));

            int r = contobj.AddExpense1(OID, Sal, DateTime.Now, "Salary");
            if (r > 0)
                MessageBox.Show("Payment Done!");
            else
                MessageBox.Show("Payment Not Done");
            contobj.Un_Or_PayManualAmount(Convert.ToInt32(ID.Text), Sal, Os);

            SH_ALL_Click(sender, e);
        }

        private void UnPay_Click(object sender, EventArgs e)
        {
            if (ID.Text == "")
            {
                MessageBox.Show("Please enter the ID!");
                return;
            }
            int x;
            if (!(Int32.TryParse(ID.Text, out x)))
            {
                MessageBox.Show("Please enter a number in the ID number field.");
                return;
            }
            if ((contobj.GetEmpById(ID.Text)) == null)
            {
                MessageBox.Show("This ID is non existent, Please reEnter The ID.");
                return;
            }
            int OID = contobj.GetOwnerIDFromEmpID(Convert.ToInt32(ID.Text));
            int Sal = contobj.SalaryByID(Convert.ToInt32(ID.Text));
            int Os = contobj.OustandingSalaryByID(Convert.ToInt32(ID.Text));

            int r = contobj.AddExpense1(OID, -Sal, DateTime.Now, "Salary");
            if (r > 0)
                MessageBox.Show("Payment Done!");
            else
                MessageBox.Show("Payment Not Done");
            contobj.Un_Or_PayManualAmount(Convert.ToInt32(ID.Text), -1*Sal, Os);

            SH_ALL_Click(sender, e);
        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MM.Show();
        }
    }

}
