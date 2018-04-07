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
    public partial class FRM_ORDERS_LIST : Form
    {
        private static FRM_ORDERS_LIST frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FRM_ORDERS_LIST getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_ORDERS_LIST();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        BL.CLS_ORDERS order = new BL.CLS_ORDERS();
        public FRM_ORDERS_LIST()
        {
            
            InitializeComponent();
            if (frm == null)
                frm = this;
            if (raCA.Checked == true)
            {
                this.dgvOrders.DataSource = order.SearchOrders("");
            }
            else if (raMA.Checked == true)
            {

                this.dgvOrders.DataSource = order.SearchOrders3("");
            }
            else
            {
                this.dgvOrders.DataSource = order.SearchOrders2("");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (raOR.Checked == true)
            {
                if (raMA.Checked == true)
                {
                    DataTable Dt = new DataTable();
                    Dt = order.SearchOrders3(txtsearch.Text);
                    this.dgvOrders.DataSource = Dt;
                }
                else if (raCA.Checked == true)
                {
                    DataTable Dt = new DataTable();
                    Dt = order.SearchOrders(txtsearch.Text);
                    this.dgvOrders.DataSource = Dt;
                }
                else
                {

                    DataTable Dt = new DataTable();
                    Dt = order.SearchOrders2(txtsearch.Text);
                    this.dgvOrders.DataSource = Dt;
                }
            }
            else
            {
                this.dgvOrders.DataSource = order.Search_Purchase_Orders(txtsearch.Text);
            }

        }

        private void raCA_CheckedChanged(object sender, EventArgs e)
        {
            dgvOrders.DataSource = null;
            this.dgvOrders.DataSource = order.SearchOrders("");
        }

        private void raMA_CheckedChanged(object sender, EventArgs e)
        {
            dgvOrders.DataSource = null;
            this.dgvOrders.DataSource = order.SearchOrders3("");
        }

        private void raKU_CheckedChanged(object sender, EventArgs e)
        {
            dgvOrders.DataSource = null;
            this.dgvOrders.DataSource = order.SearchOrders2("");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           try{

                FRM_ORDERS frm = new FRM_ORDERS();
                
                

                if (this.raOR.Checked == true)
                {

                    frm.txtOrderID.Text = this.dgvOrders.CurrentRow.Cells[0].Value.ToString();
                    frm.dtOrder.Value = Convert.ToDateTime(this.dgvOrders.CurrentRow.Cells[1].Value.ToString());
                    frm.txtSalesMan.Text = this.dgvOrders.CurrentRow.Cells[8].Value.ToString();
                    frm.txtDesOrder.Text = this.dgvOrders.CurrentRow.Cells[9].Value.ToString();
                    frm.txtCustomerID.Text = this.dgvOrders.CurrentRow.Cells[2].Value.ToString();
                    frm.txtFirstName.Text = this.dgvOrders.CurrentRow.Cells[3].Value.ToString();
                    frm.txtAmounKash.Text = this.dgvOrders.CurrentRow.Cells[6].Value.ToString();
                    frm.txtAmounDue.Text = this.dgvOrders.CurrentRow.Cells[7].Value.ToString();
                    frm.txtDescount.Text = this.dgvOrders.CurrentRow.Cells[4].Value.ToString();
                    frm.txtTotalAmount.Text = this.dgvOrders.CurrentRow.Cells[5].Value.ToString();

                    // frm.dataGridView1.DataSource=order.GetOrderDetailsForUpdate(Convert.ToInt32(this.dgvOrders.CurrentRow.Cells[0].Value.ToString()));

                    frm.CreateDataTable1();
                    frm.Dt1 = order.GetOrderDetailsForUpdate(Convert.ToInt32(this.dgvOrders.CurrentRow.Cells[0].Value.ToString()));
                    frm.Create();
                    
                    
                    frm.btnAdd.Text = "BADAL";
                    frm.btnAdd.Enabled = true;
                    frm.btnNEW.Visible = false;
                    frm.Text = "RASID BADALID";

                    frm.raOR.Checked = true;
                    frm.raPOR.Visible = false;

                    frm.dataGridView1.Columns[5].Visible = false;
                    //frm.dataGridView1.Columns[6].Visible = false;
                    frm.lbTrID.Text = order.GET_Transaction_ID(Convert.ToInt32(this.dgvOrders.CurrentRow.Cells[0].Value.ToString())).Rows[0][0].ToString();

                }
                else
                {
                    frm.state = "update";
                    frm.txtOrderID.Text = this.dgvOrders.CurrentRow.Cells[0].Value.ToString();
                    frm.dtOrder.Value = Convert.ToDateTime(this.dgvOrders.CurrentRow.Cells[1].Value.ToString());
                    frm.txtSalesMan.Text = this.dgvOrders.CurrentRow.Cells[6].Value.ToString();
                    frm.txtDesOrder.Text = this.dgvOrders.CurrentRow.Cells[7].Value.ToString();
                    frm.txtCustomerID.Text = this.dgvOrders.CurrentRow.Cells[2].Value.ToString();
                    frm.txtFirstName.Text = this.dgvOrders.CurrentRow.Cells[3].Value.ToString();
                    frm.txtAmounKash.Text = this.dgvOrders.CurrentRow.Cells[4].Value.ToString();
                    frm.txtAmounDue.Text = this.dgvOrders.CurrentRow.Cells[5].Value.ToString();


                    // frm.dataGridView1.DataSource=order.GetOrderDetailsForUpdate(Convert.ToInt32(this.dgvOrders.CurrentRow.Cells[0].Value.ToString()));
                   // frm.CreateDataTable2();
                    frm.Dt2 = order.GetPurchaseOrderDetailsForUpdate(Convert.ToInt32(this.dgvOrders.CurrentRow.Cells[0].Value.ToString()));
                    frm.Create2();
                   
                    frm.btnAdd.Text = "BADAL";
                    frm.btnAdd.Enabled = true;
                    frm.btnNEW.Visible = false;
                    frm.Text = "RASID BADALID";


                    frm.raPOR.Checked = true;
                    frm.raOR.Visible = false;

                   // frm.dataGridView1.Columns[5].Visible = false;
                   // frm.dataGridView1.Columns[6].Visible = false;

                    frm.lbTrID.Text = order.GET_Transaction_ID2(Convert.ToInt32(this.dgvOrders.CurrentRow.Cells[0].Value.ToString())).Rows[0][0].ToString();                   // frm.chInv.Checked = Convert.ToBoolean(frm.dataGridView1.Rows[0].Cells[6].Value.ToString());


                }

                frm.state = "update";
                //frm.dataGridView1.Enabled = false;
               
               // frm.btnBrowse.Enabled = false;
                //frm.txtQty.Enabled = false;
               // frm.txtPrice.Enabled = false;
                frm.ShowDialog();

                //frm.CalculateTotalAmount1();
           }
            catch
            {
                return;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (raOR.Checked == true)
            {
                if (MessageBox.Show("MAHUBTAA RABITAANKAAGA TIRTIRIDA RASIIDKAAN ?", "TIRTIRID", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    order.DELETE_Order(Convert.ToInt32(this.dgvOrders.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("WAA LA TIRTIRAY RASIIDKA", "TIRTIRID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgvOrders.DataSource = order.SearchOrders2("");
                }
                else
                {
                    MessageBox.Show("WAA LAGA NOQDAY TIRTIRIDA", "TIRTIRID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (MessageBox.Show("MAHUBTAA RABITAANKAAGA TIRTIRIDA RASIIDKAAN ?", "TIRTIRID", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    order.DELETE_Purchase_Order(Convert.ToInt32(this.dgvOrders.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("WAA LA TIRTIRAY RASIIDKA", "TIRTIRID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgvOrders.DataSource = order.Search_Purchase_Orders("");
                }
                else
                {
                    MessageBox.Show("WAA LAGA NOQDAY TIRTIRIDA", "TIRTIRID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void raPOR_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            this.dgvOrders.DataSource = order.Search_Purchase_Orders("");

        }

        private void raOR_CheckedChanged(object sender, EventArgs e)
        {
            dgvOrders.DataSource = null;
            this.dgvOrders.DataSource = order.SearchOrders2("");
            groupBox2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
