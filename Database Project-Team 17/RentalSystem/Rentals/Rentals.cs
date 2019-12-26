using System;
using System.Data;
using System.Windows.Forms;

namespace Rentals
{
    public partial class Rentals : Form
    {
        Controller nc = new Controller();
        SignIn si ;
        public Rentals()
        {
            InitializeComponent();
            si = new SignIn(nc);
        }

        internal class Rents_ManagementDataSet
        {
            public string DataSetName { get; internal set; }
            public SchemaSerializationMode SchemaSerializationMode { get; internal set; }
        }

        internal class Rents_ManagementDataSetTableAdapters
        {
            internal class UsersTableAdapter : global::Rentals.Rents_ManagementDataSetTableAdapters.UsersTableAdapter
            {
            }
        }

        private void Rentals_Load(object sender, EventArgs e)
        {
            si.Show();
        }

       
        
    }

    internal class Rents_ManagementDataSetTableAdapters
    {
        internal class UsersTableAdapter
        {
        }
    }
}
