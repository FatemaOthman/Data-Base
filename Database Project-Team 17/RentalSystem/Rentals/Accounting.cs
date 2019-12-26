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
    public partial class Accounting : Form
    {
        Controller contobj;
        MainPage M1;
        public Accounting(Controller contobj1, MainPage MM)
        {
            InitializeComponent();
            contobj = contobj1;
            M1 = MM;
            Ownersbox.DataSource = contobj.GetAllOwners();
            Ownersbox.DisplayMember = "Owner_ID";
            Ownersbox.ValueMember = "Owner_ID";
        }

        private void Accounting_Load(object sender, EventArgs e)
        {

        }

        private void OneOwner_Click(object sender, EventArgs e)
        {
            double income = contobj.GetOwnerIncome(Convert.ToInt16(Ownersbox.Text));
            double expense = contobj.GetOwnerExpenses(Convert.ToInt16(Ownersbox.Text));
            double profit = income - expense;
            Income.Text = income.ToString();
            Expenses.Text = expense.ToString();
            Profit.Text = profit.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //all owner profit
            double income = contobj.GetSumIncome();
            double expense = contobj.GetSumExpenses();
            double profit = income - expense;
            Income.Text = income.ToString();
            Expenses.Text = expense.ToString();
            Profit.Text = profit.ToString();
        }

        private void Expenses_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //back button
            M1.Show();
            this.Hide();
        }
    }
}
