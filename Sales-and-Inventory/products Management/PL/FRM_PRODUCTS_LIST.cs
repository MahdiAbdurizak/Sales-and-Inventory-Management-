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
    public partial class FRM_PRODUCTS_LIST : Form
    {
        BL.CLS_PRODUCTS prd = new BL.CLS_PRODUCTS();
        public FRM_PRODUCTS_LIST()
        {
            InitializeComponent();
            this.dvgProducts.DataSource = prd.GET_ALL_PRODUCTS();
        }

        private void FRM_PRODUCTS_LIST_Load(object sender, EventArgs e)
        {

        }

        private void dvgProducts_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = prd.SearchProduct(txtsearch.Text);
            this.dvgProducts.DataSource = Dt;
        }
    }
}
