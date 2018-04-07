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
    public partial class FRM_SUPPLIERS_LIST : Form
    {
        BL.CLS_CUSTOMERS cust = new BL.CLS_CUSTOMERS();
        public FRM_SUPPLIERS_LIST()
        {
            InitializeComponent();
            this.dvgSuppliers.DataSource = cust.GET_ALL_Suppliers2();
            this.dvgSuppliers.Columns[0].Visible = false;
        }

        private void dvgSuppliers_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = cust.Search_Suppliers(txtsearch.Text);
            this.dvgSuppliers.DataSource = Dt;
        }
    }
}
