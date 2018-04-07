using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace products_Management.PL
{
    public partial class FRM_CUSTOMERS : Form
    {
        BL.CLS_CUSTOMERS cust = new BL.CLS_CUSTOMERS();
        int ID,Position;
        void cleardata()
        {

            txtFirstName.Clear();
            txtCampany.Clear();
            txtAdress.Clear();
            txtNote.Clear();
            txtLastName.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            // pbox.Image = null;
            txtCampany.Focus();
           
        }
        public FRM_CUSTOMERS()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMERS();
            dataGridView1.Columns[0].Visible = false;
           // dataGridView1.Columns[5].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                /*  
            
              byte[] picture;
                  if (pbox.Image == null)
                  {
                      picture = new byte[0];
                      cust.ADD_CUSTOMER(txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, picture, "without_image");
                      MessageBox.Show("waa lagu guuleestay ku darida", "kudarid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMERS();
                  }*/

                // MemoryStream ms = new MemoryStream();
                // pbox.Image.Save(ms, pbox.Image.RawFormat);
                // picture = ms.ToArray();
                if (txtCampany.Text == string.Empty && txtFirstName.Text == string.Empty && txtLastName.Text == string.Empty &&
                         txtTel.Text == string.Empty)
                {
                    MessageBox.Show("BUUXI XOGTA MUHIMKA AH", "ISKA JIR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (raMA.Checked == true)
                {
                    cust.ADD_CUSTOMER(txtCampany.Text, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtTel.Text, txtAdress.Text, txtNote.Text);
                    MessageBox.Show("WAA LAGU GUULEESTAY KU DARIDA", "KU DARID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMERS();
                }
                else
                {

                    cust.ADD_Suppliers(txtCampany.Text, txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, txtNote.Text);
                    MessageBox.Show("waa lagu guuleestay ku darida", "kudarid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.GET_ALL_Suppliers2();
                }
                btnAdd.Enabled = false;
                btnNew.Enabled = true;
                cleardata();
            }
            catch
            {
                return;
            }
                
           
          
        }

        /* private void pbox_Click(object sender, EventArgs e)
         {  
             finally
             {
                 btnAdd.Enabled = false;
                 btnNew.Enabled = true;
             }
             OpenFileDialog op = new OpenFileDialog();
             op.Filter = "SAWIRADA |*.jpg;*.png;*.gif;*.bmp";
             if (op.ShowDialog() == DialogResult.OK)
             {
                 pbox.Image = Image.FromFile(op.FileName);
             }
         }
         */
        private void btnNew_Click(object sender, EventArgs e)
        {
            cleardata();
            ID = 0;
            btnAdd.Enabled = true;
            btnNew.Enabled = false;
        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLastName.Focus();
            }
        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTel.Focus();
            }
        }

        private void txtTel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (raMA.Checked == true)
                {
                    txtAdress.Focus();
                }
                else
                {
                    txtNote.Focus();
                }
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
               // pbox.Image = null;
                ID = Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value);
                this.txtCampany.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.txtFirstName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.txtLastName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                this.txtEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                this.txtTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                this.txtAdress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                this.txtNote.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
               /* byte[] pictuer = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(pictuer);
                pbox.Image = Image.FromStream(ms);*/
            }
            catch
            {
                return;
            }
            

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (raMA.Checked == true)
                {
                    if (ID == 0)
                    {
                        MessageBox.Show("kuma jiro macaamilka add badali rabtid");
                        return;
                    }
                    /*
                    byte[] picture;
                    if (pbox.Image == null)
                    {
                        picture = new byte[0];
                        cust.EDIT_CUSTOMER(txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, picture, "without_image",ID);
                        MessageBox.Show("waa lagu guuleestay ka badalida", "kabadalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMERS();
                    }*/


                    // MemoryStream ms = new MemoryStream();
                    // pbox.Image.Save(ms, pbox.Image.RawFormat);
                    // picture = ms.ToArray();
                    cust.EDIT_CUSTOMER(ID, txtCampany.Text, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtTel.Text, txtAdress.Text, txtNote.Text);
                    MessageBox.Show("waa lagu guuleestay ka badalida", "kabadalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMERS();
                    btnNew.Enabled = true;
                }
                else
                {
                    if (ID == 0)
                    {
                        MessageBox.Show("kuma jiro shirkada add badali rabtid");
                        return;
                    }
                    /*
                    byte[] picture;
                    if (pbox.Image == null)
                    {
                        picture = new byte[0];
                        cust.EDIT_CUSTOMER(txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, picture, "without_image",ID);
                        MessageBox.Show("waa lagu guuleestay ka badalida", "kabadalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMERS();
                    }*/


                    // MemoryStream ms = new MemoryStream();
                    // pbox.Image.Save(ms, pbox.Image.RawFormat);
                    // picture = ms.ToArray();
                    cust.EDIT__Suppliers(ID, txtCampany.Text, txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, txtNote.Text);
                    MessageBox.Show("waa lagu guuleestay ka badalida", "kabadalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.GET_ALL_Suppliers2();
                    btnNew.Enabled = true;
                }
                
            }
            catch
            {
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (raMA.Checked == true)
            {
                if (ID == 0)
                {
                    MessageBox.Show("kuma jiro macaamilka add tirtiry rabtid");
                    return;
                }
                if (MessageBox.Show("mahubtaa rabitaankaaga inaa tirtirida macaamilkaan ?", "tirtirid", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cust.DELETE_CUSTOMER(ID);
                    MessageBox.Show("waa lagu guuleestay ka tirtirida", "tirtirid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMERS();
                }
            }
            else
            {
                if (ID == 0)
                {
                    MessageBox.Show("kuma jiro shirkada add tirtiry rabtid");
                    return;
                }
                if (MessageBox.Show("mahubtaa rabitaankaaga inaa tirtirida shirkadaan ?", "tirtirid", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cust.DELETE_Suppliers(ID);
                    MessageBox.Show("waa lagu guuleestay ka tirtirida", "tirtirid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.GET_ALL_Suppliers2();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cust.Search_Customer(txtSEARCH.Text);
        }

        private void txtSEARCH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        void Navigate(int Index)
        {
            try
            {
                if (raMA.Checked == true)
                {
                    // pbox.Image = null;
                    DataRowCollection DRC = cust.GET_ALL_CUSTOMERS().Rows;
                    ID = Convert.ToInt32(DRC[Index][0]);
                    txtCampany.Text = DRC[Index][1].ToString();
                    txtFirstName.Text = DRC[Index][2].ToString();
                    txtLastName.Text = DRC[Index][3].ToString();
                    txtEmail.Text = DRC[Index][4].ToString();
                    txtTel.Text = DRC[Index][5].ToString();
                    txtAdress.Text = DRC[Index][6].ToString();
                    txtNote.Text = DRC[Index][7].ToString();
                }
                else
                {
                    DataRowCollection DRC = cust.GET_ALL_Suppliers2().Rows;
                    ID = Convert.ToInt32(DRC[Index][0]);
                    txtCampany.Text = DRC[Index][1].ToString();
                    txtFirstName.Text = DRC[Index][2].ToString();
                    txtLastName.Text = DRC[Index][3].ToString();
                    txtEmail.Text = DRC[Index][4].ToString();
                    txtTel.Text = DRC[Index][5].ToString();
                   // txtAdress.Text = DRC[Index][6].ToString();
                    txtNote.Text = DRC[Index][6].ToString();
                }
                
                /*
                byte[] pictuer = (byte[])DRC[Index][5];
                MemoryStream ms = new MemoryStream(pictuer);
                pbox.Image = Image.FromStream(ms); */
            }
            catch
            {
                return;
            }

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            Navigate(0);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (raMA.Checked == true)
            {
                Position = cust.GET_ALL_CUSTOMERS().Rows.Count - 1;
            }
            else
            {
                Position = cust.GET_ALL_Suppliers2().Rows.Count - 1;
            }
            Navigate(Position);
        }

        private void btnPreviuos_Click(object sender, EventArgs e)
        {
             
                if (Position == 0)
                {
                    if (raMA.Checked == true)
                    {
                        MessageBox.Show("WAA MACAAMILKA KOWAAD");
                    }
                    else
                    {
                        MessageBox.Show("WAA SHIRKADA KOWAAD");
                    }
                    return;

                }
            
           
            Position -= 1;
            Navigate(Position);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (raMA.Checked == true)
            {
                if (Position == cust.GET_ALL_CUSTOMERS().Rows.Count - 1)
                {
                    MessageBox.Show("WAA MACAAMILKA UGU DAMBEEYO");
                    return;
                }
            }
            else
            {
                if (Position == cust.GET_ALL_Suppliers2().Rows.Count - 1)
                {
                    MessageBox.Show("WAA SHIRKADA UGU DAMBEEYO");
                    return;
                }
            }
            Position += 1;
            Navigate(Position);
        }

        private void raSH_CheckedChanged(object sender, EventArgs e)
        {
            cleardata();
            txtAdress.Visible = false;
            label8.Visible = false;
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            
            this.Text = "MAMULKA SHIRKADAHA";
           groupBox3.Text = "LISKA SHIRKADAHA";
            groupBox1.Text = "XOGTA SHIRKKADAHA";
            this.dataGridView1.DataSource = cust.GET_ALL_Suppliers2();
            
        }

        private void raMA_CheckedChanged(object sender, EventArgs e)
        {
            cleardata();
            txtAdress.Visible = true;
            label8.Visible =true;
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            
            FRM_CUSTOMERS frm = new FRM_CUSTOMERS();
            this.Text = "MAMULKA MACAAMISHA";
            groupBox3.Text = "LISKA MACAAMISHA";
            groupBox1.Text = "XOGTA MACAAMISHA";
            this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMERS();
        }

        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            if (raMA.Checked == true)
            {
                dataGridView1.DataSource = cust.Search_Customer(txtSEARCH.Text);
            }
            else
            {

                dataGridView1.DataSource = cust.Search_Suppliers(txtSEARCH.Text);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCampany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFirstName.Focus();
            }
        }

        private void txtAdress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNote.Focus();
            }
        }

        private void txtNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();
            }

        }

       
       



           

        

       
    }
}
