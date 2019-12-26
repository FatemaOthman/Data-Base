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
    public partial class Contacts : Form
    {
        Controller contobj;
        MainPage MM;
        string[] statarr = new string[7] { "Waiting", "Interested", "Tenant", "Owner", "Cash Collector", "Employee", "Other" };

        public Contacts(Controller contobj1, MainPage m1)
        {
            InitializeComponent();
            contobj = contobj1;
            MM = m1;
            Status.DataSource = statarr;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string Fname, Lname;
            Fname = FirstName.Text;
            Lname = LastName.Text;

            if (Fname == "" || Lname == "" || PhoneNumber.Text == "" || Email.Text == "" || Address.Text == "" || identifier.Text == "")
            {
                MessageBox.Show("Please enter all fields");
                return;
            }


            if(Fname.Any(char.IsDigit))
            {
                MessageBox.Show("First name can't contain any digits.");
                return;
            }
            if (Lname.Any(char.IsDigit))
            {
                MessageBox.Show("Last name can't contain any digits.");
                return;
                
            }
            int result;
            if(!(Int32.TryParse(PhoneNumber.Text, out result)))
            {
                MessageBox.Show("Phone Number must contain only digits.");
                return;
            }
            int queryresult = contobj.UpdateContactByID(Convert.ToInt32(identifier.Text), FirstName.Text, LastName.Text, Convert.ToInt32(PhoneNumber.Text), Email.Text, Address.Text, Status.Text);
            if( queryresult == 1)
            {
                MessageBox.Show("Contact updated.");
            }
            else
            {
                MessageBox.Show("Contact Not Updated.");
            }
            Contactsgrid.DataSource = contobj.GetAllContacts();

            Contactsgrid.Columns[0].HeaderText = "ID";
            Contactsgrid.Columns[1].HeaderText = "First Name";
            Contactsgrid.Columns[2].HeaderText = "Last Name";
            Contactsgrid.Columns[3].HeaderText = "Phone Number";
            Contactsgrid.Columns[4].HeaderText = "Email";
            Contactsgrid.Columns[5].HeaderText = "Address";
            Contactsgrid.Columns[6].HeaderText = "Status";
            Contactsgrid.Refresh();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string Fname, Lname;
            Fname = FirstName.Text;
            Lname = LastName.Text;

            if (Fname == "" || Lname == "" || PhoneNumber.Text == "" || Email.Text == "" || Address.Text == "")
            {
                MessageBox.Show("Please enter all fields");
                return;
            }


            if (Fname.Any(char.IsDigit))
            {
                MessageBox.Show("First name can't contain any digits.");
                return;
            }
            if (Lname.Any(char.IsDigit))
            {
                MessageBox.Show("Last name can't contain any digits.");
                return;

            }
            int result;
            if (!(Int32.TryParse(PhoneNumber.Text, out result)))
            {
                MessageBox.Show("Phone Number must contain only digits.");
                return;
            }
            int queryresult = contobj.AddContact(FirstName.Text, LastName.Text, Convert.ToInt32(PhoneNumber.Text), Email.Text, Address.Text, Status.Text);
            if (queryresult == 1)
            {
                MessageBox.Show("Contact Added.");
            }
            else
            {
                MessageBox.Show("Contact Not Added.");
            }
            Contactsgrid.DataSource = contobj.GetAllContacts();

            Contactsgrid.Columns[0].HeaderText = "ID";
            Contactsgrid.Columns[1].HeaderText = "First Name";
            Contactsgrid.Columns[2].HeaderText = "Last Name";
            Contactsgrid.Columns[3].HeaderText = "Phone Number";
            Contactsgrid.Columns[4].HeaderText = "Email";
            Contactsgrid.Columns[5].HeaderText = "Address";
            Contactsgrid.Columns[6].HeaderText = "Status";
            Contactsgrid.Refresh();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if(identifier.Text == "")
            {
                MessageBox.Show("The ID field is empty.");
                return;
            }
            int result = contobj.DeleteContactbyID(Convert.ToInt32(identifier.Text));
            if ( result ==1)
            {
                MessageBox.Show("Contact deleted successfully.");

                
            }
            else
            {
                MessageBox.Show("This ID has not been found in the contacts list.");
                
            }
            Contactsgrid.DataSource = contobj.GetAllContacts();

            Contactsgrid.Columns[0].HeaderText = "ID";
            Contactsgrid.Columns[1].HeaderText = "First Name";
            Contactsgrid.Columns[2].HeaderText = "Last Name";
            Contactsgrid.Columns[3].HeaderText = "Phone Number";
            Contactsgrid.Columns[4].HeaderText = "Email";
            Contactsgrid.Columns[5].HeaderText = "Address";
            Contactsgrid.Columns[6].HeaderText = "Status";
            Contactsgrid.Refresh();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //shows all the contacts
            Contactsgrid.DataSource = contobj.GetAllContacts();

            Contactsgrid.Columns[0].HeaderText = "ID";
            Contactsgrid.Columns[1].HeaderText = "First Name";
            Contactsgrid.Columns[2].HeaderText = "Last Name";
            Contactsgrid.Columns[3].HeaderText = "Phone Number";
            Contactsgrid.Columns[4].HeaderText = "Email";
            Contactsgrid.Columns[5].HeaderText = "Address";
            Contactsgrid.Columns[6].HeaderText = "Status";
            Contactsgrid.Refresh();
        }

        private void Get_Click(object sender, EventArgs e)
        {
            Contactsgrid.DataSource = contobj.GetContactByID(Convert.ToInt32(identifier.Text));
            Contactsgrid.Columns[0].HeaderText = "ID";
            Contactsgrid.Columns[1].HeaderText = "First Name";
            Contactsgrid.Columns[2].HeaderText = "Last Name";
            Contactsgrid.Columns[3].HeaderText = "Phone Number";
            Contactsgrid.Columns[4].HeaderText = "Email";
            Contactsgrid.Columns[5].HeaderText = "Address";
            Contactsgrid.Columns[6].HeaderText = "Status";
            Contactsgrid.Refresh();

        }

        private void Contacts_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MM.Show();
            this.Hide();

        }

        private void Contactsgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
