using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace products_Management.PL
{
    public partial class FRM_ORDERS : Form
    {
        BL.CLS_ORDERS order = new BL.CLS_ORDERS();
        DataTable Dt = new DataTable();
       public DataTable Dt1 = new DataTable();
       public DataTable Dt2 = new DataTable();
        public string state="add";
       // int ORDE;
        
        void CalculateAmount()
        {
            if (txtPrice.Text != string.Empty && txtQty.Text != string.Empty)
           

                txtAmount.Text = (Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQty.Text)).ToString();
           
        }
        void CalculateTotalAmount()
        {
            if (txtDescount.Text != string.Empty && txtSumTotals.Text != string.Empty)
            {
                double Descount = Convert.ToDouble(txtDescount.Text);
                double Amount = Convert.ToDouble(txtSumTotals.Text);
                double TotalAmount = Amount - (Amount * (Descount / 100));
                txtTotalAmount.Text = TotalAmount.ToString();
            }
        }

        void CalculateAmountDue()
        {
            if (txtAmounKash.Text == string.Empty)
            {
                double e = 0;
                txtAmounKash.Text = e.ToString();
            }
            if (txtAmounKash.Text != string.Empty && txtTotalAmount.Text != string.Empty)
            {
                double sum = 0;
                double kash = 0;
                       sum = Convert.ToDouble(txtTotalAmount.Text);
                       kash = Convert.ToDouble(txtAmounKash.Text);
                double due = sum - kash;
                txtAmounDue.Text = due.ToString();
            }
        }
        void CalculateAmountDue1()
        {
            if (txtAmounKash.Text == string.Empty)
            {
                double e = 0;
                txtAmounKash.Text = e.ToString();
            }
            if (txtAmounKash.Text != string.Empty && txtSumTotals.Text != string.Empty)
            {
                double sum = 0;
                double kash = 0;
                sum = Convert.ToDouble(txtSumTotals.Text);
                kash = Convert.ToDouble(txtAmounKash.Text);
                double due = sum - kash;
                txtAmounDue.Text = due.ToString();
            }
        }

        void CalculateTotalAmount1()
        {
            if (raOR.Checked == true)
            {
                txtSumTotals.Text = (from DataGridViewRow row in dataGridView1.Rows
                                     where row.Cells[4].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            }
            else
            {
                txtSumTotals.Text = (from DataGridViewRow row in dataGridView1.Rows
                                     where row.Cells[4].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            }
                
            
        }
        void ClearBoxes()
        {
                 txtIDproduct.Clear();
                 txtNameProduct.Clear();
                 txtPrice.Clear();
                 txtQty.Clear();
                 txtAmount.Clear();
                 txtDescount.Clear();
                 txtTotalAmount.Clear();
                 btnBrowse.Focus();

        }

        void clearData()
        { txtCustomerID.Clear();
            txtCompany.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtTel.Clear();
           
            txtAmounKash.Clear();
           // pbox.Image = null;
            ClearBoxes();
            dtOrder.ResetText();
           // txtSalesMan.Clear();
            txtSumTotals.Clear();
            txtAmounDue.Clear();
            Dt.Clear();
            txtDesOrder.Clear();
            txtOrderID.Clear();
            dataGridView1.DataSource = null;
            btnAdd.Enabled = false;
            btnNEW.Enabled = true;
            btnPrint.Enabled = true;

        }
        void CreateDataTable()
        {
            Dt.Columns.Add("RAQAMKA AGABKA");
            Dt.Columns.Add("MAGACA AGABKA");
            Dt.Columns.Add("QIIMAHA XABADA");
            Dt.Columns.Add("CADADKA");
            Dt.Columns.Add("QIIMAHA OO DHAN");
            Dt.Columns.Add("cost");
            //Dt.Columns.Add("QIIMAHA UGU DAMBEEYO");
            dataGridView1.DataSource = Dt;
            

            /*
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "doorashada agab";
            btn.Text = "radin";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(0,btn);*/


        }
       public void CreateDataTable1()
        {  /*
            Dt1.Columns.Add("RAQAMKA AGABKA");
            Dt1.Columns.Add("MAGACA AGABKA");
            Dt1.Columns.Add("QIIMAHA XABADA");
            Dt1.Columns.Add("CADADKA");
            Dt1.Columns.Add("QIIMAHA OO DHAN");
            Dt1.Columns.Add("KA DHIMID %");
            Dt1.Columns.Add("QIIMAHA UGU DAMBEEYO");*/
            Dt1.Columns.Add("RAQAMKA AGABKA");
            Dt1.Columns.Add("MAGACA AGABKA");
            Dt1.Columns.Add("QIIMAHA XABADA");
            Dt1.Columns.Add("CADADKA");
            Dt1.Columns.Add("QIIMAHA OO DHAN");
            Dt1.Columns.Add("cost");
            
            dataGridView1.DataSource = Dt1;
           
           
           // ORDE =Convert.ToInt32(dataGridView1.Rows[0].Cells[8].Value.ToString());

        }
       public void CreateDataTable2()
       {
           Dt2.Columns.Add("RAQAMKA AGABKA");
           Dt2.Columns.Add("MAGACA AGABKA");
           Dt2.Columns.Add("QIIMAHA XABADA");
           Dt2.Columns.Add("CADADKA");
           Dt2.Columns.Add("QIIMAHA OO DHAN");
           dataGridView1.DataSource = Dt2;
       }
       public void Create2()
       {
           dataGridView1.DataSource = Dt2;
       }
       public void Create()
       {
           dataGridView1.DataSource = Dt1;
       }
      

        void ResizeDVG()
        {
            this.dataGridView1.RowHeadersWidth = 79;
            this.dataGridView1.Columns[0].Width = 110;
            this.dataGridView1.Columns[1].Width = 162;
            this.dataGridView1.Columns[2].Width = 114;
            this.dataGridView1.Columns[3].Width = 112;
            this.dataGridView1.Columns[4].Width = 110;
           // this.dataGridView1.Columns[5].Width = 105;
           // this.dataGridView1.Columns[6].Width = 162;
            //this.dataGridView1.Columns[7].Width = 162;

        }
        void ResizeDVG1()
        {
            this.dataGridView1.RowHeadersWidth = 79;
            this.dataGridView1.Columns[0].Width = 110;
            this.dataGridView1.Columns[1].Width = 162;
            this.dataGridView1.Columns[2].Width = 114;
            this.dataGridView1.Columns[3].Width = 112;
            this.dataGridView1.Columns[4].Width = 110;
           
        }
        public FRM_ORDERS()
        {
            InitializeComponent();
            CreateDataTable();
            CreateDataTable2();
                ResizeDVG();
                btnNEW.Enabled = true;
                btnAdd.Enabled = false;
            txtSalesMan.Text = Program.SalesMan;
            
            
           
           
            
        }

        private void btnNEW_Click(object sender, EventArgs e)
        {
            clearData();
            
            if (raOR.Checked == true)
            {
                this.txtOrderID.Text = order.GET_LAST_ORDER_ID().Rows[0][0].ToString();
                this.lbTrID.Text = order.GET_LAST_Transaction_ID().Rows[0][0].ToString();
                btnNEW.Enabled = false;
                btnAdd.Enabled = true;
                txtCustomerID.Text = "1";
                
            }
            else
            {
                this.txtOrderID.Text = order.GET_LAST_PurchaseORDER_ID().Rows[0][0].ToString();
                this.lbTrID.Text = order.GET_LAST_Transaction_ID().Rows[0][0].ToString();
                btnNEW.Enabled = false;
                btnAdd.Enabled = true;
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            /*
            
            if (frm.dvgCustomers.CurrentRow.Cells[5].Value is DBNull)
            {
                MessageBox.Show("macaamilkaan sawir malahan");
                txtCustomerID.Text = frm.dvgCustomers.CurrentRow.Cells[0].Value.ToString();
                txtFirstName.Text = frm.dvgCustomers.CurrentRow.Cells[1].Value.ToString();
                txtLastName.Text = frm.dvgCustomers.CurrentRow.Cells[2].Value.ToString();
                txtTel.Text = frm.dvgCustomers.CurrentRow.Cells[3].Value.ToString();
                txtEmail.Text = frm.dvgCustomers.CurrentRow.Cells[4].Value.ToString();
                pbox.Image = null;
                return;
            }*/

            if (raOR.Checked == true)
            {
                FRM_CUSTOMERS_LIST frm = new FRM_CUSTOMERS_LIST();
                frm.ShowDialog();
                txtCustomerID.Text = frm.dvgCustomers.CurrentRow.Cells[0].Value.ToString();
                txtCompany.Text = frm.dvgCustomers.CurrentRow.Cells[1].Value.ToString();
                txtFirstName.Text = frm.dvgCustomers.CurrentRow.Cells[2].Value.ToString();
                txtLastName.Text = frm.dvgCustomers.CurrentRow.Cells[3].Value.ToString();
                txtTel.Text = frm.dvgCustomers.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {


                FRM_SUPPLIERS_LIST frm = new FRM_SUPPLIERS_LIST();
                frm.ShowDialog();


                txtCustomerID.Text = frm.dvgSuppliers.CurrentRow.Cells[0].Value.ToString();
                txtCompany.Text = frm.dvgSuppliers.CurrentRow.Cells[1].Value.ToString();
                txtFirstName.Text = frm.dvgSuppliers.CurrentRow.Cells[2].Value.ToString();
                txtLastName.Text = frm.dvgSuppliers.CurrentRow.Cells[3].Value.ToString();
                txtTel.Text = frm.dvgSuppliers.CurrentRow.Cells[4].Value.ToString();
            }



           

           /* byte[] custPictuer = (byte[])frm.dvgCustomers.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(custPictuer);
            pbox.Image = Image.FromStream(ms);*/

        }

        private void button2_Click(object sender, EventArgs e)
        {   
            ClearBoxes();
            FRM_PRODUCTS_LIST frm = new FRM_PRODUCTS_LIST();
            if (raOR.Checked == true)
            {
                frm.ShowDialog();
                txtIDproduct.Text = frm.dvgProducts.CurrentRow.Cells[0].Value.ToString();
                txtNameProduct.Text = frm.dvgProducts.CurrentRow.Cells[1].Value.ToString();
                txtPrice.Text = frm.dvgProducts.CurrentRow.Cells[4].Value.ToString();
                lbcost.Text = frm.dvgProducts.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                frm.ShowDialog();
                txtIDproduct.Text = frm.dvgProducts.CurrentRow.Cells[0].Value.ToString();
                txtNameProduct.Text = frm.dvgProducts.CurrentRow.Cells[1].Value.ToString();
                txtPrice.Text = frm.dvgProducts.CurrentRow.Cells[3].Value.ToString();
            }
            txtQty.Focus();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {     
            char DecimalSeparator=Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }

        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPrice.Text != string.Empty)
            {
                txtQty.Focus();
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
           /* if (raOR.Checked == true)
            {
                if (e.KeyCode == Keys.Enter && txtQty.Text != string.Empty)
                {
                    txtDescount.Focus();
                }
            }
            */
           
            
                if (e.KeyCode == Keys.Enter)
                {
                    if (raOR.Checked == true)
                    {
                        if (order.VarifyQty(txtIDproduct.Text, Convert.ToInt32(txtQty.Text)).Rows.Count < 1)
                        {
                            MessageBox.Show("cadadkaan kuma jiro baqaarka", "baqaarka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;

                        }
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txtIDproduct.Text)
                        {
                            MessageBox.Show("agabkaan waa ku jiraa liiska", "iska jir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                    }
                    if (raOR.Checked==true && state == "add")
                    {
                        DataRow r = Dt.NewRow();

                        r[0] = txtIDproduct.Text;
                        r[1] = txtNameProduct.Text;
                        r[2] = txtPrice.Text;
                        r[3] = txtQty.Text;
                        r[4] = txtAmount.Text;
                        r[5] = lbcost.Text;
                        //r[6] = txtTotalAmount.Text;
                        Dt.Rows.Add(r);
                        dataGridView1.DataSource = Dt;
                    }
                    else if (raOR.Checked == true && state == "update")
                    {

                        DataRow r1 = Dt1.NewRow();

                        r1[0] = txtIDproduct.Text;
                        r1[1] = txtNameProduct.Text;
                        r1[2] = txtPrice.Text;
                        r1[3] = txtQty.Text;
                        r1[4] = txtAmount.Text;
                        r1[5] = lbcost.Text;
                        // r1[6] = txtTotalAmount.Text;
                        Dt1.Rows.Add(r1);

                        dataGridView1.DataSource = Dt1;
                    }
                    else
                    {
                        DataRow r2 = Dt2.NewRow();

                        r2[0] = txtIDproduct.Text;
                        r2[1] = txtNameProduct.Text;
                        r2[2] = txtPrice.Text;
                        r2[3] = txtQty.Text;
                        r2[4] = txtAmount.Text;
                       // r1[5] = lbcost.Text;
                        // r1[6] = txtTotalAmount.Text;
                        Dt2.Rows.Add(r2);

                        dataGridView1.DataSource = Dt2;
                    }

                    ClearBoxes();
                    txtSumTotals.Text = (from DataGridViewRow row in dataGridView1.Rows
                                         where row.Cells[4].FormattedValue.ToString() != string.Empty
                                         select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();

                }
            
        }

        private void txtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
            
        }

        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
           
        }

        private void txtDescount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void txtDescount_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateTotalAmount();

            if (raPOR.Checked == true)
            {
                CalculateAmountDue1();

            }
            else
            {
                CalculateAmountDue();
            }
        }

        private void txtDescount_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && txtDescount.Text != string.Empty)
            {
                txtAmounKash.Focus();
            }
            
            
            
            /*if (e.KeyCode == Keys.Enter )
            {
                if (raOR.Checked == true)
                {
                    if (order.VarifyQty(txtIDproduct.Text, Convert.ToInt32(txtQty.Text)).Rows.Count < 1)
                    {
                        MessageBox.Show("cadadkaan kuma jiro baqaarka", "baqaarka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;

                    }
                }
                for (int i = 0; i < dataGridView1.Rows.Count - 1 ;i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txtIDproduct.Text)
                    {
                        MessageBox.Show("agabkaan waa ku jiraa liiska", "iska jir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                   
                }
                if (state == "add")
                {
                    DataRow r = Dt.NewRow();

                    r[0] = txtIDproduct.Text;
                    r[1] = txtNameProduct.Text;
                    r[2] = txtPrice.Text;
                    r[3] = txtQty.Text;
                    r[4] = txtAmount.Text;
                    r[5] = txtDescount.Text;
                    r[6] = txtTotalAmount.Text;
                    Dt.Rows.Add(r);
                    dataGridView1.DataSource = Dt;
                }
                else
                {
                    DataRow r1 = Dt1.NewRow();

                    r1[0] = txtIDproduct.Text;
                    r1[1] = txtNameProduct.Text;
                    r1[2] = txtPrice.Text;
                    r1[3] = txtQty.Text;
                    r1[4] = txtAmount.Text;
                    r1[5] = txtDescount.Text;
                    r1[6] = txtTotalAmount.Text;
                    Dt1.Rows.Add(r1);

                    dataGridView1.DataSource = Dt1;
                }
                ClearBoxes();
                txtSumTotals.Text = (from DataGridViewRow row in dataGridView1.Rows
                                     where row.Cells[6].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();

               
                
               
                
                    
                  
                
                
               
               
                

            }*/

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                /* if (raOR.Checked == true)
                 {
                     txtIDproduct.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                     txtNameProduct.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                     txtPrice.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                     txtQty.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                     txtAmount.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                     txtDescount.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                     txtTotalAmount.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                     dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                     txtQty.Focus();
                 }*/
                if (raOR.Checked == true)
                {
                    txtIDproduct.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txtNameProduct.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtPrice.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txtQty.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    txtAmount.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    lbcost.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    // txtDescount.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    // txtTotalAmount.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    txtQty.Focus();
                }
                else
                {
                    txtIDproduct.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txtNameProduct.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtPrice.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txtQty.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    txtAmount.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    //lbcost.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    // txtDescount.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    // txtTotalAmount.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    txtQty.Focus();
                }
                
            }
            catch{
                return;

                 }

        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            /*if (raOR.Checked == true)
            {
                txtSumTotals.Text = (from DataGridViewRow row in dataGridView1.Rows
                                     where row.Cells[6].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            }
            else
            {*/
                txtSumTotals.Text = (from DataGridViewRow row in dataGridView1.Rows
                                     where row.Cells[4].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            
        }

        private void kabadalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1_DoubleClick(sender,e);

        }

        private void tirtirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void tirtirKuliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dt.Clear();
            dataGridView1.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          try
            {
                if (raOR.Checked == true)
                {
                    if (txtOrderID.Text == string.Empty || txtCustomerID.Text == string.Empty || dataGridView1.Rows.Count < 1 ||
                         txtAmounKash.Text == string.Empty || txtAmounDue.Text == string.Empty || txtDescount.Text == string.Empty)
                    {
                        MessageBox.Show("BUUXI XOGTA MUHIMKA AH", "ISKA JIR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    if (txtOrderID.Text == string.Empty || txtCustomerID.Text == string.Empty || dataGridView1.Rows.Count < 1 ||
                     txtAmounKash.Text == string.Empty || txtAmounDue.Text == string.Empty)
                    {
                        MessageBox.Show("BUUXI XOGTA MUHIMKA AH", "ISKA JIR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                int IN_ID = Convert.ToInt32(lbTrID.Text);
                string AMD = txtAmounDue.Text;
                string AMP = txtAmounKash.Text;
                

                if (raOR.Checked == true)
                {


                    if (state == "add")
                    {
                        order.ADD_ORDER(Convert.ToInt32(txtOrderID.Text), Convert.ToInt32(txtCustomerID.Text), Convert.ToDateTime(dtOrder.Value.ToShortDateString()), Convert.ToInt32(txtDescount.Text),
                                        txtTotalAmount.Text, AMP, AMD, txtSalesMan.Text, txtDesOrder.Text);
                    }
                    else
                    {
                        order.EDIT_ORDER(Convert.ToInt32(txtOrderID.Text), Convert.ToInt32(txtCustomerID.Text), Convert.ToDateTime(dtOrder.Value.ToShortDateString()), Convert.ToInt32(txtDescount.Text),
                           txtTotalAmount.Text, AMP, AMD, txtSalesMan.Text, txtDesOrder.Text);
                        FRM_ORDERS_LIST.getMainForm.dgvOrders.DataSource = order.SearchOrders2("");
                    }

                    /*
                else
                { 
                   // order.ADD_ORDER2(Convert.ToInt32(txtOrderID.Text), dtOrder.Value, txtSalesMan.Text, txtDesOrder.Text);
                    order.ADD_ORDER(Convert.ToInt32(txtOrderID.Text), 33, dtOrder.Value, AMP, AMD, txtSalesMan.Text, txtDesOrder.Text);
                }*/
                }
                else
                {
                    if (state == "add")
                    {
                        order.ADD_Purchase_Orders(Convert.ToInt32(txtOrderID.Text), Convert.ToInt32(txtCustomerID.Text), Convert.ToDateTime(dtOrder.Value.ToShortDateString()), AMP, AMD, txtSalesMan.Text, txtDesOrder.Text);
                    }
                    else
                    {
                        order.EDIT_Purchase_Orders(Convert.ToInt32(txtOrderID.Text), Convert.ToInt32(txtCustomerID.Text), Convert.ToDateTime(dtOrder.Value.ToShortDateString()), AMP, AMD, txtSalesMan.Text, txtDesOrder.Text);
                        FRM_ORDERS_LIST.getMainForm.dgvOrders.DataSource = order.Search_Purchase_Orders("");
                    }
                }




                if (raOR.Checked == true)
                {
                    if (state == "add")
                    {

                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            string ID_PR = dataGridView1.Rows[i].Cells[0].Value.ToString();
                            int ID_OR = Convert.ToInt32(txtOrderID.Text);
                            int QTE = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                            string PRC = dataGridView1.Rows[i].Cells[2].Value.ToString();
                            // float DIS = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                            string AM = dataGridView1.Rows[i].Cells[4].Value.ToString();
                            string COS = dataGridView1.Rows[i].Cells[5].Value.ToString();

                            order.ADD_ORDER_DETAILS(ID_OR, ID_PR, QTE, PRC, AM, IN_ID,COS);
                            int TR = 2;
                            int POR = 2;
                            string CR = "OR";
                            int Qty = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                            order.Inventory_Transactions(IN_ID, TR, dtOrder.Value, ID_PR, Qty, POR, ID_OR, CR);
                        }
                    }
                    else{
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            string ID_PR = dataGridView1.Rows[i].Cells[0].Value.ToString();
                            int ID_OR = Convert.ToInt32(txtOrderID.Text);
                            int QTE = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                            string PRC = dataGridView1.Rows[i].Cells[2].Value.ToString();
                            // float DIS = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                            string AM = dataGridView1.Rows[i].Cells[4].Value.ToString();
                            string COS = dataGridView1.Rows[i].Cells[5].Value.ToString();

                            order.EDIT_ORDER_DETAILS(ID_OR, ID_PR, QTE, PRC, AM, IN_ID, COS);
                            int TR = 2;
                            int POR = 2;
                            string CR = "OR";
                            int Qty = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                            order.EDIT_Inventory_Transactions(IN_ID, TR, dtOrder.Value, ID_PR, Qty, POR, ID_OR, CR);
                        }
                         }
                    }
               
                else
                {
                    if (state == "add")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            string ID_PR = dataGridView1.Rows[i].Cells[0].Value.ToString();
                            int ID_OR = Convert.ToInt32(txtOrderID.Text);
                            int QTE = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                            string PRC = dataGridView1.Rows[i].Cells[2].Value.ToString();
                            // float DIS = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                            string AM = dataGridView1.Rows[i].Cells[4].Value.ToString();
                            // double TAM = Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);


                            order.ADD_Purchase_Order_Details(ID_OR, ID_PR, QTE, PRC, AM, dtOrder.Value, IN_ID);
                            int TR = 1;
                            int POR = 2;
                            string CR = "POR";
                            int Qty = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                            order.Inventory_Transactions(IN_ID, TR, dtOrder.Value, ID_PR, Qty, ID_OR, POR, CR);
                        }




                    }
                    else
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            string ID_PR = dataGridView1.Rows[i].Cells[0].Value.ToString();
                            int ID_OR = Convert.ToInt32(txtOrderID.Text);
                            int QTE = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                            string PRC = dataGridView1.Rows[i].Cells[2].Value.ToString();
                            // float DIS = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                            string AM = dataGridView1.Rows[i].Cells[4].Value.ToString();
                            // double TAM = Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);


                            order.EDIT_Purchase_DETAILS(ID_OR, ID_PR, QTE, PRC, AM, IN_ID);
                            int TR = 1;
                            int POR = 2;
                            string CR = "POR";
                            int Qty = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                            order.EDIT_Inventory_Transactions(IN_ID, TR, dtOrder.Value, ID_PR, Qty, ID_OR, POR, CR);
                        }
                    }

                }


                MessageBox.Show("waa lagu guuleestay kaydiska", "kaydis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNEW.Enabled = true;

            }
            catch
            {
                return;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
                frm.txtOrderID.Text = this.txtOrderID.Text;
                frm.txtFirstName.Text = this.txtFirstName.Text;
                frm.txtLastName.Text = this.txtLastName.Text;
                frm.txtTel.Text = this.txtTel.Text;
                frm.txtSumTotals.Text = this.txtSumTotals.Text;
                frm.txtDescount.Text = this.txtDescount.Text;
                frm.txtTotalAmount.Text = this.txtTotalAmount.Text;
                frm.txtAmounKash.Text = this.txtAmounKash.Text;
                frm.txtAmounDue.Text = this.txtAmounDue.Text;
                /*
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        frm.dataGridView1.Rows[i].Cells[0].Value =this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                        frm.dataGridView1.Rows[i].Cells[1].Value = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                        frm.dataGridView1.Rows[i].Cells[2].Value = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
                        frm.dataGridView1.Rows[i].Cells[3].Value=this.dataGridView1.Rows[i].Cells[3].Value.ToString();
                        frm.dataGridView1.Rows[i].Cells[4].Value = this.dataGridView1.Rows[i].Cells[4].Value.ToString();
                  
                    
                    }
                 */
                if (state == "add" && raOR.Checked==true)
                {
                    frm.dataGridView1.DataSource = Dt;
                }
                else if (state == "update" && raOR.Checked == true)
                {
                    frm.dataGridView1.DataSource = Dt1;
                }
                else
                {
                    frm.dataGridView1.DataSource = Dt2;
                }


                /*
                    int order_ID = Convert.ToInt32(order.GET_LAST_ORDER_FOR_PRINT().Rows[0][0]);
                    RPT.rpt_orders report = new RPT.rpt_orders();
                    RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
                    report.SetDataSource(order.GetOrderDetails(order_ID));
                    frm.crystalReportViewer1.ReportSource = report; 
                */
                btnNEW.Enabled = true;
                btnAdd.Enabled = false;
                frm.ShowDialog();
                this.Cursor = Cursors.Default;

                /* else
                 {
                     this.Cursor = Cursors.WaitCursor;
                     int order_ID = Convert.ToInt32(order.GET_LAST_ORDER_FOR_PRINT().Rows[0][0]);
                     RPT.rpt_orders report = new RPT.rpt_orders();
                     RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
                     report.SetDataSource(order.GetOrderDetailsCADI(order_ID));
                     frm.crystalReportViewer1.ReportSource = report;
                     frm.ShowDialog();
                     this.Cursor = Cursors.Default;
                 }*/
            }
            catch
            {
                return;
            }

        }

        private void raOR_CheckedChanged(object sender, EventArgs e)
        {
           

            
           // ResizeDVG();
            txtDescount.Visible = true;
            txtTotalAmount.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            groupBox2.Text = "MACAAMILKA";
            
           
            if (state == "add")
            {
                btnNEW.Enabled = true;
                btnAdd.Enabled = false;
            }
            else
            {
                btnNEW.Visible = false;
                btnAdd.Enabled = true;
            }
        }

        private void raPOR_CheckedChanged(object sender, EventArgs e)
        {
            
           

           // ResizeDVG1();
            txtDescount.Visible = false;
            txtTotalAmount.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            groupBox2.Text = "SHARIKADA";
          
           
            if (state == "add")
            {
                btnNEW.Enabled = true;
                btnAdd.Enabled = false;
            }
            else
            {
                btnNEW.Visible = false;
                btnAdd.Enabled = true;
                txtDescount.Visible = false;
                txtTotalAmount.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
            }
            
        }

        private void txtAmounKash_TextChanged(object sender, EventArgs e)
        {
            if (raPOR.Checked == true)
            {
                CalculateAmountDue1();

            }
            else
            {
                CalculateAmountDue();
            }
        }

      /*  private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dataGridView1_DataMemberChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowValidated_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MarginChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }*/

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {  
            if (state == "update")
            {

                CalculateTotalAmount1();
            }
        }

        private void txtSumTotals_TextChanged(object sender, EventArgs e)
        {  if(raPOR.Checked==true)
            CalculateAmountDue1();
        }

        private void txtAmounKash_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void txtAmounKash_KeyUp(object sender, KeyEventArgs e)
        {

            if (raPOR.Checked == true)
            {
                CalculateAmountDue1();

            }
            else
            {
                CalculateAmountDue();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_ORDERS_Load(object sender, EventArgs e)
        {

        }

       
       

       

       

        
    }
}
