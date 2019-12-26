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
    public partial class MainPage : Form
    {
        Controller contobj;//creating controller to get it from prev form
        SignIn SP;//creating the previous form
        int privi;
       
        public MainPage(Controller contobj1,SignIn Pointer,int priv)
        {
            InitializeComponent();
            contobj = contobj1;//taking the previous's form controller 
            this.SP = Pointer;//taking an object from the previous form
            privi = priv;
            if (priv != 1)
            {
                Owners.Enabled = false;
                Leases.Enabled = false;
                Units.Enabled = false;
                Buildings.Enabled = false;
               
            }
            if (priv != 2 && priv != 1)
            {
                Expenses.Enabled = false;
                Accounting.Enabled = false;
                Tenants.Enabled = false;
                Employee.Enabled = false;

            }


        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            //Extra
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            this.Hide();//hide the current form
            Settings OP = new Settings(contobj, this,privi);//creates a setting form
            OP.Show();//shows the created setting form
        }

        private void Rents_Click(object sender, EventArgs e)
        {
            Rents R = new Rents(contobj,this);//creates a rents form
            this.Hide();//hides the current form
            R.Show();//shows the created rents form
        }

        private void Leases_Click(object sender, EventArgs e)
        {
            Leases Leases1 = new Leases(contobj, this);
            this.Hide();
            Leases1.Show();
        }

        private void Owners_Click(object sender, EventArgs e)
        {
            Owners owners1 = new Owners(contobj, this);
            this.Hide();
            owners1.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            SignIn ns = new SignIn(contobj);
            this.Hide();
            ns.Show();
        }

        private void Contacts_Click(object sender, EventArgs e)
        {
            Contacts contacts1 = new Contacts(contobj, this);
            this.Hide();
            contacts1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Expenses_Click(object sender, EventArgs e)
        {
            Expenses expenses = new Expenses(contobj, this);
            this.Hide();
            expenses.Show();
        }

        private void Accounting_Click(object sender, EventArgs e)
        {
            Accounting accounting = new Accounting(contobj, this);
            this.Hide();
            accounting.Show();
        }

        private void Tenants_Click(object sender, EventArgs e)
        {
            Tenants t = new Tenants(contobj, this);
            this.Hide();
            t.Show();

        }

        private void Employee_Click(object sender, EventArgs e)
        {
            Employee E = new Employee(contobj, this, privi);
            this.Hide();
            E.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            form u = new form(contobj, this);
            this.Hide();
            u.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buildings b = new Buildings(contobj, this,privi);
            this.Hide();
            b.Show();
        }
    }
}
