using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;

namespace products_Management.PL
{
    public partial class FRM_PRODUCTS : Form
    {
        private static FRM_PRODUCTS frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FRM_PRODUCTS getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_PRODUCTS();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        BL.CLS_PRODUCTS prd = new BL.CLS_PRODUCTS();
        public FRM_PRODUCTS()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = prd.SearchProduct(txtsearch.Text);
            this.dataGridView1.DataSource = Dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.fl = 2;
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("MAHUBTAA RABITAANKAAGA TIRTIRIDA AGABKAAN ?", "TIRTIRID", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    prd.DeleteProduct(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("WAA LA TIRTIRAY AGABKA", "TIRTIRID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
                }
                else
                {
                    MessageBox.Show("WAA LAGA NOQDAY TIRTIRIDA", "TIRTIRID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                return;
            }
                
              

               
           
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
                // frm.txtID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtCode.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.txtDec.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.txtCost.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.txtPrice.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                // frm.txtReorderLevel.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                // frm.txtTarget.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                frm.txtQte.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                // frm.CheckDescount.Checked = Convert.ToBoolean(this.dataGridView1.CurrentRow.Cells[9].Value.ToString());
                // frm.txtReorderQte.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
                frm.txtCat.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                // frm.cmbsupp.SelectedValue = Convert.ToInt32( this.dataGridView1.CurrentRow.Cells[7].Value.ToString());
                frm.txtCode.ReadOnly = true;

                frm.Text = "BADALKA : " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.btnOk.Text = "CUSBOONEESIIN";
                frm.State = "update";
                //frm.txtID.ReadOnly = true;
                /*
                byte[] image = (byte[])prd.GET_IMAGE_PRDUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
                MemoryStream ms = new MemoryStream(image);
                frm.pbox.Image = Image.FromStream(ms);*/
                frm.fl = 2;
                frm.ShowDialog();
            }
            catch
            {
                return;
            }


        }

       /* private void button5_Click(object sender, EventArgs e)
        {
            FRM_PREVIEW frm = new FRM_PREVIEW();
             byte[] image = (byte[])prd.GET_IMAGE_PRDUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pictureBox1.Image = Image.FromStream(ms);
            frm.ShowDialog();

        }
        */
        private void button4_Click(object sender, EventArgs e)
        {
          
            
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
             
           

           

        }

        private void button8_Click(object sender, EventArgs e)
        {
            




            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

       
    }
}
