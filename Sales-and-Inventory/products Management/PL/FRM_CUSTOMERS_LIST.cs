using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace products_Management.PL
{
    public partial class FRM_CUSTOMERS_LIST : Form
    {
        BL.CLS_CUSTOMERS cust = new BL.CLS_CUSTOMERS();
        public FRM_CUSTOMERS_LIST()
        {
            InitializeComponent();
            this.dvgCustomers.DataSource = cust.GET_ALL_CUSTOMERS();
            this.dvgCustomers.Columns[0].Visible = false;
            //this.dvgCustomers.Columns[5].Visible = false;
        }

        private void FRM_CUSTOMERS_LIST_Load(object sender, EventArgs e)
        {

        }

        private void dvgCustomers_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = cust.Search_Customer(txtsearch.Text);
            this.dvgCustomers.DataSource = Dt;
        }
    }
}
