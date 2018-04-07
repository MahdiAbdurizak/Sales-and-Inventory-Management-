using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
using System.IO;

namespace products_Management.PL
{
    public partial class FRM_Inventory : Form
    {
        
        DataTable Dt = new DataTable();
        BL.CLS_PRODUCTS pro = new BL.CLS_PRODUCTS();
        
        
        public FRM_Inventory()
        {
            InitializeComponent();

            dgList.DataSource = pro.Inventory_TR();
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {

        }

        private void btnLast_Click(object sender, EventArgs e)
        {

        }

        private void btnPreviuos_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btncurrent_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {

        }

        private void exportTopdfAll_Click(object sender, EventArgs e)
        {

        }

        private void exportTopdfCurrent_Click(object sender, EventArgs e)
        {

        }

        private void FRM_CATEGORIES_Load(object sender, EventArgs e)
        {

        }

        

       
      
    }
}
