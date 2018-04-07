using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Data.OleDb;
using System.Globalization;

namespace products_Management.PL
{
    public partial class FRM_ADD_PRODUCT : Form
    {
        BL.CLS_PRODUCTS prd = new BL.CLS_PRODUCTS();
        public string State = "add";
        public int fl = 0;
        void clearData()
        {
            txtCode.Clear();
            txtCost.Clear();
            txtDec.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtQte.Clear();
            txtCat.Clear();
            txtCode.Focus();
            

            
        }
        
        public FRM_ADD_PRODUCT()
        {
            InitializeComponent();
          /*  this.cmbsupp.DataSource = prd.GET_ALL_Suppliers();
            cmbsupp.DisplayMember = "Company";
            cmbsupp.ValueMember = "ID";*/
            
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "SAWIRADA |*.jpg;*.png;*.gif;*.bmp";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(OFD.FileName);
            }
        }
        */
        private void btnOk_Click(object sender, EventArgs e)
        {
            try{
            
            if (txtCost.Text == string.Empty || txtPrice.Text == string.Empty ||txtCode.Text==string.Empty)
            {
                MessageBox.Show("BUUXI XOGTA MUHIMKA AH", "ISKA JIR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (State == "add")
            {
                MemoryStream ms = new MemoryStream();
               // pbox.Image.Save(ms, pbox.Image.RawFormat);
               // byte[] byteImage = ms.ToArray();
               // prd.ADD_PRODUCT(Convert.ToInt32(cmbcategories.SelectedValue), txtDec.Text, txtID.Text, Convert.ToInt32(txtQte.Text), txtPrice.Text, byteImage);
                prd.ADD_PRODUCT(txtCode.Text, txtName.Text, txtDec.Text,txtCost.Text,txtPrice.Text, txtQte.Text, txtCat.Text);
                 
                    
                MessageBox.Show("WAA LAGU GUULEESTAY KU DARIDA", "KU DARID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {  /*
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] byteImage = ms.ToArray();*/
                prd.UPDATE_PRDUCT(txtCode.Text, txtName.Text, txtDec.Text, txtCost.Text, txtPrice.Text,txtQte.Text, txtCat.Text);
                 
                MessageBox.Show("WAA LAGU GUULEESTAY BADALIDA", "BADALID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (fl == 2)
            {

                FRM_PRODUCTS.getMainForm.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
            }
            clearData();

            }
            catch
            {
                return;
            }

            
           
        }
        /*
          private void txtRef_Validated(object sender, EventArgs e)
          {
              if (State == "add")
              {
                  DataTable Dt = new DataTable();
                 Dt = prd.VerifyProductID(txtID.Text);
                  if (Dt.Rows.Count > 0)
                  {
                      MessageBox.Show("calaamadaan waa ku jirtaa", "iskajir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      txtID.Focus();
                      txtID.SelectionStart = 0;
                      txtID.SelectionLength = txtID.TextLength; 

                  }
              }
        


          }
          */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCode_Validated(object sender, EventArgs e)
        {
            if (State == "add")
            {
                DataTable Dt = new DataTable();
                Dt = prd.VerifyProductID(txtCode.Text);
                if (Dt.Rows.Count > 0)
                {
                    MessageBox.Show("RAQAMKAAN WAA KU JIRAA", "ISKA JIR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCode.Focus();
                    txtCode.SelectionStart = 0;
                    txtCode.SelectionLength = txtCode.TextLength;

                }
            }

        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void txtReorderLevel_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTarget_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtReorderQte_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_ADD_PRODUCT_Load(object sender, EventArgs e)
        {

        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtName.Focus();
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCat.Focus();
            }
        }

        private void txtCat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQte.Focus();
            }
        }

        private void txtQte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCost.Focus();
            }
        }

        private void txtCost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCost.Text != string.Empty)
            {
                txtPrice.Focus();
            }
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPrice.Text != string.Empty)
            {
                txtDec.Focus();
            }
        }

        private void txtDec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOk.Focus();
            }
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCat_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtQte_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtDec_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        

        
    }
}
