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
    public partial class FRM_ORRDER_TOTAL : Form
    {
        BL.CLS_ORDERS order = new BL.CLS_ORDERS();
        void CalculateTotalAmount1()
        {
            txtAmount.Text = (from DataGridViewRow row in dataGridView1.Rows
                                 where row.Cells[4].FormattedValue.ToString() != string.Empty
                                 select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();

            txtPayment.Text = (from DataGridViewRow row in dataGridView1.Rows
                                 where row.Cells[5].FormattedValue.ToString() != string.Empty
                                 select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();

            txtPaymentdue.Text = (from DataGridViewRow row in dataGridView1.Rows
                                 where row.Cells[6].FormattedValue.ToString() != string.Empty
                                 select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
        }
        void CalculateTotalAmount2()
        {
            txtAmount.Text = (from DataGridViewRow row in dataGridView1.Rows
                              where row.Cells[2].FormattedValue.ToString() != string.Empty
                              select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();

            txtPayment.Text = (from DataGridViewRow row in dataGridView1.Rows
                               where row.Cells[3].FormattedValue.ToString() != string.Empty
                               select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();

            txtPaymentdue.Text = (from DataGridViewRow row in dataGridView1.Rows
                                  where row.Cells[4].FormattedValue.ToString() != string.Empty
                                  select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
        }
        public FRM_ORRDER_TOTAL()
        {
            InitializeComponent();
            if (raOR.Checked == true)
            {
                dataGridView1.DataSource = order.ORDER_TOTAL();
                CalculateTotalAmount1();
                this.cmb.DataSource = order.GET_CUSTOMER_ID();
                cmb.DisplayMember = "MAGACA";
                cmb.ValueMember = "ID";
            }
            else if(raPOR.Checked == true)
            {
                dataGridView1.DataSource = order.PURCHASE_TOTAL();
                CalculateTotalAmount1();
                this.cmb.DataSource = order.GET_SUPPLIER_ID();
                cmb.DisplayMember = "MAGACA";
                cmb.ValueMember = "ID";
            }
           
            

           
        }

        private void raToDay_CheckedChanged(object sender, EventArgs e)
        {
            if (raOR.Checked == true)
            {
                dataGridView1.DataSource = order.ORDER_TOTAL_TODAY(Convert.ToDateTime(dt3.Value.ToShortDateString()));
                CalculateTotalAmount1();
            }
            else if (raPOR.Checked == true)
            {
                dataGridView1.DataSource = order.PURCHASE_TOTAL_TODAY(Convert.ToDateTime(dt3.Value.ToShortDateString()));
                CalculateTotalAmount1();
            }
            else
            {
                dataGridView1.DataSource = order.ITEM_TOTAL_TODAY(Convert.ToDateTime(dt3.Value.ToShortDateString()));
                CalculateTotalAmount2();
            }

            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        private void raBETWEEN_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox4.Visible = false;
            if (raOR.Checked == true)
            {
                dataGridView1.DataSource = order.ORDER_TOTAL_BETWEEN(Convert.ToDateTime(dt.Value.ToShortDateString()), Convert.ToDateTime(dt1.Value.ToShortDateString()));
                CalculateTotalAmount1();
            }
            else if (raPOR.Checked == true)
            {
                dataGridView1.DataSource = order.PURCHASE_TOTAL_BETWEEN(Convert.ToDateTime(dt.Value.ToShortDateString()), Convert.ToDateTime(dt1.Value.ToShortDateString()));
                CalculateTotalAmount1();
            }
            else
            {
                dataGridView1.DataSource = order.ITEM_TOTAL_BETWEEN(Convert.ToDateTime(dt.Value.ToShortDateString()), Convert.ToDateTime(dt1.Value.ToShortDateString()));
                CalculateTotalAmount2();
            }
          

        }

        private void dt_ValueChanged(object sender, EventArgs e)
        {
            if (raOR.Checked == true)
            {
                dataGridView1.DataSource = order.ORDER_TOTAL_BETWEEN(Convert.ToDateTime(dt.Value.ToShortDateString()), Convert.ToDateTime(dt1.Value.ToShortDateString()));
                CalculateTotalAmount1();
            }
            else if (raPOR.Checked == true)
            {
                dataGridView1.DataSource = order.PURCHASE_TOTAL_BETWEEN(Convert.ToDateTime(dt.Value.ToShortDateString()), Convert.ToDateTime(dt1.Value.ToShortDateString()));
                CalculateTotalAmount1();
            }
            else
            {
                dataGridView1.DataSource = order.ITEM_TOTAL_BETWEEN(Convert.ToDateTime(dt.Value.ToShortDateString()), Convert.ToDateTime(dt1.Value.ToShortDateString()));
                CalculateTotalAmount2();
            }
        }

        private void dt1_ValueChanged(object sender, EventArgs e)
        {
            if (raOR.Checked == true)
            {
                dataGridView1.DataSource = order.ORDER_TOTAL_BETWEEN(Convert.ToDateTime(dt.Value.ToShortDateString()), Convert.ToDateTime(dt1.Value.ToShortDateString()));
                CalculateTotalAmount1();
            }
            else if (raPOR.Checked == true)
            {
                dataGridView1.DataSource = order.PURCHASE_TOTAL_BETWEEN(Convert.ToDateTime(dt.Value.ToShortDateString()), Convert.ToDateTime(dt1.Value.ToShortDateString()));
                CalculateTotalAmount1();
            }
             else
            {
                dataGridView1.DataSource = order.ITEM_TOTAL_BETWEEN(Convert.ToDateTime(dt.Value.ToShortDateString()), Convert.ToDateTime(dt1.Value.ToShortDateString()));
                CalculateTotalAmount2();
            }
        }

        private void FRM_ORRDER_TOTAL_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            groupBox3.Visible = false;
            
            dataGridView1.DataSource = null;
            CalculateTotalAmount1();
            if (raOR.Checked == true)
            {
                this.cmb.DataSource = order.GET_CUSTOMER_ID();
                cmb.DisplayMember = "MAGACA";
                cmb.ValueMember = "ID";

            }
            else
            {
                this.cmb.DataSource = order.GET_SUPPLIER_ID();
                cmb.DisplayMember = "MAGACA";
                cmb.ValueMember = "ID";
            
            }
            cmb.SelectedValue = 0;
          

        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("value", cmb.SelectedValue.ToString());
            if (raOR.Checked == true)
            {
                if (cmb.ValueMember == "ID")
                    dataGridView1.DataSource = order.ORDER_TOTAL_CUSTOMER(Convert.ToInt32(cmb.SelectedValue));
                CalculateTotalAmount1();
            }
            else
            {
                if (cmb.ValueMember == "ID")
                    dataGridView1.DataSource = order.PURCHASE_TOTAL_SUPPLIER(Convert.ToInt32(cmb.SelectedValue));
                CalculateTotalAmount1();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            if (raOR.Checked == true)
            {
                dataGridView1.DataSource = order.ORDER_TOTAL();
                CalculateTotalAmount1();
            }
            else if (raPOR.Checked == true)
            {
                dataGridView1.DataSource = order.PURCHASE_TOTAL();
                CalculateTotalAmount1();
            }
            else
            {
                dataGridView1.DataSource = order.ITEM_TOTAL();
                CalculateTotalAmount2();
            }
        }

        private void raOR_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            radioButton1.Visible = true;
            label1.Text = "ISKU DARKA";
            label2.Text = "KASH";
            label3.Text = "DEEN";
            radioButton1.Text = "MACAAMIL";
            groupBox4.Text = "MAGACA MACAAMILKA";
            radioButton2.Checked = true;
            
                dataGridView1.DataSource = order.ORDER_TOTAL();
                CalculateTotalAmount1();
               
           
        }

        private void raPOR_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            radioButton1.Visible = true;
            label1.Text = "ISKU DARKA";
            label2.Text = "KASH";
            label3.Text = "DEEN";
            radioButton1.Text = "GADAHA";
            groupBox4.Text = "MAGACA GADAHA";
            radioButton2.Checked = true;

                dataGridView1.DataSource = order.PURCHASE_TOTAL();
                CalculateTotalAmount1();
               
        }

        private void raPROF_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            label1.Text = "CADADKA";
            label2.Text = "ISKU DARKA";
            label3.Text = "FAIIDADA";
            radioButton1.Visible = false;
            radioButton2.Checked = true;
            
            dataGridView1.DataSource = order.ITEM_TOTAL();
            CalculateTotalAmount2();
        }
    }
}
