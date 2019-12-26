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
    public partial class Expenses : Form
    {
        Controller contobj;
        MainPage M11;
        public Expenses(Controller contobj1, MainPage M1)
        {
            InitializeComponent();
            contobj = contobj1;
            M11 = M1;
        }
        
        private void Expenses_Load(object sender, EventArgs e)
        {
            Owners.DataSource = contobj.GetAllOwners();
            Owners.ValueMember = "Owner_ID";
            Owners.DisplayMember = "Owner_ID";
            Leases.DataSource = contobj.GetAllLeasesID();
            Leases.ValueMember = "Lease_ID";
            Leases.DisplayMember = "Lease_ID";
            ExpenseID.DataSource = contobj.GetAllExpenses();
            ExpenseID.ValueMember = "Expense_TranID";
            ExpenseID.DisplayMember = "Expense_TranID";
        }

        private void Reason_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add Expense button
            if (Owners.Text == "" || Amount.Text == "" || Reason.Text == "")
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }
            string amount = Amount.Text;
            int result;
            Int32.TryParse(amount, out result);
            if(!(Int32.TryParse(amount, out result)))
            {
                MessageBox.Show("Please enter a numerical amount in the Amount field.");
                return;
            }
            if (Leases.Text != "")
            {
                int query_result = contobj.AddExpense(Convert.ToInt32(Owners.SelectedValue), Convert.ToInt32(amount), date.Value, Reason.Text, Convert.ToInt32(Leases.Text));
                if (query_result == 1)
                {
                    contobj.TakeExpenseFromDeposit(Convert.ToInt32(amount), int.Parse(Leases.Text.ToString()));
                    MessageBox.Show("Expense created successfully.");
                    
                }
                else
                {
                    MessageBox.Show("Expense not added.");
                }
            }
            else
            {
                int query_result = contobj.AddExpense1(Convert.ToInt32(Owners.Text), Convert.ToInt32(amount), date.Value, Reason.Text);
                if (query_result == 1)
                {
                    MessageBox.Show("Expense created successfully.");
                    contobj.TakeExpenseFromOwner(Convert.ToInt32(amount),int.Parse(Owners.SelectedValue.ToString()));
                }
                else
                {
                    MessageBox.Show("Expense not added.");

                }
            }
            ExpenseID.DataSource = contobj.GetAllExpenses();
            ExpenseID.ValueMember = "Expense_TranID";
            ExpenseID.DisplayMember = "Expense_TranID";
            ExpenseView.DataSource = contobj.ShowAllExpenses();
            ExpenseView.Columns[0].HeaderText = "ID";
            ExpenseView.Columns[1].HeaderText = "Amount";
            ExpenseView.Columns[2].HeaderText = "Date";
            ExpenseView.Columns[3].HeaderText = "Reason";
            ExpenseView.Columns[4].HeaderText = "LeaseID";
            ExpenseView.Columns[5].HeaderText = "OwnerID";
            ExpenseView.Refresh();

        }

        private void UpdateExpense_Click(object sender, EventArgs e)
        {
            if (Owners.Text == "" || Amount.Text == "" || Reason.Text == "")
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }
            string amount = Amount.Text;
            int result;
            Int32.TryParse(amount, out result);
            if (!(Int32.TryParse(amount, out result)))
            {
                MessageBox.Show("Please enter a numerical amount in the Amount field.");
                return;
            }
            if (Leases.Text != "")
            {
                int query_result = contobj.UpdateExpense(Convert.ToInt32(ExpenseID.SelectedValue),Convert.ToInt32(Owners.Text), Convert.ToInt32(amount), date.Value, Reason.Text, Convert.ToInt32(Leases.Text));
                if (query_result == 1)
                {
                    MessageBox.Show("Expense updated successfully.");

                }
                else
                {
                    MessageBox.Show("Expense not updated.");
                }
            }
            else
            {
                int query_result = contobj.UpdateExpense1(Convert.ToInt32(ExpenseID.SelectedValue), Convert.ToInt32(Owners.Text), Convert.ToInt32(amount), date.Value.Date, Reason.Text);
                if (query_result == 1)
                {
                    MessageBox.Show("Expense updated successfully.");

                }
                else
                {
                    MessageBox.Show("Expense not updated.");
                }
            }
            ExpenseView.DataSource = contobj.ShowAllExpenses();
            ExpenseView.Columns[0].HeaderText = "ID";
            ExpenseView.Columns[1].HeaderText = "Amount";
            ExpenseView.Columns[2].HeaderText = "Date";
            ExpenseView.Columns[3].HeaderText = "Reason";
            ExpenseView.Columns[4].HeaderText = "LeaseID";
            ExpenseView.Columns[5].HeaderText = "OwnerID";
            ExpenseView.Refresh();
        }

        private void DeleteExpense_Click(object sender, EventArgs e)
        {
            if(contobj.DeleteExpense(Convert.ToInt16(ExpenseID.Text)) == 1)
            {
                MessageBox.Show("Expense deleted");
            }
            else
            {
                MessageBox.Show("Expense not deleted.");
            }
            ExpenseID.DataSource = contobj.GetAllExpenses();
            ExpenseID.ValueMember = "Expense_TranID";
            ExpenseID.DisplayMember = "Expense_TranID";
            ExpenseView.DataSource = contobj.ShowAllExpenses();
            ExpenseView.Columns[0].HeaderText = "ID";
            ExpenseView.Columns[1].HeaderText = "Amount";
            ExpenseView.Columns[2].HeaderText = "Date";
            ExpenseView.Columns[3].HeaderText = "Reason";
            ExpenseView.Columns[4].HeaderText = "LeaseID";
            ExpenseView.Columns[5].HeaderText = "OwnerID";
            ExpenseView.Refresh();
        }

        private void ViewAllOwners_Click(object sender, EventArgs e)
        {
            ExpenseView.DataSource = contobj.ShowAllExpenses();
            ExpenseView.Columns[0].HeaderText = "ID";
            ExpenseView.Columns[1].HeaderText = "Amount";
            ExpenseView.Columns[2].HeaderText = "Date";
            ExpenseView.Columns[3].HeaderText = "Reason";
            ExpenseView.Columns[4].HeaderText = "LeaseID";
            ExpenseView.Columns[5].HeaderText = "OwnerID";
            ExpenseView.Refresh();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            M11.Show();
            this.Hide();
        }
    }
}
