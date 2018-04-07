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
    public partial class FRM_LOGIN : Form
    {
        BL.CLS_LOGIN log = new BL.CLS_LOGIN();
        DataTable Dt = new DataTable();
        FRM_MAIN frm = new FRM_MAIN();
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Dt = log.LOGIN(txtID.Text, txtPWD.Text);
            if (Dt.Rows.Count > 0)
            {
                if (Dt.Rows[0][2].ToString() == "MAMULE")
                {

                    FRM_MAIN frm = new FRM_MAIN();
                    FRM_MAIN.getMainForm.shaqaalahaToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.macamiishaToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.agabyadaToolStripMenuItem.Enabled = true; ;
                    FRM_MAIN.getMainForm.backupssaame.Enabled = true;
                    FRM_MAIN.getMainForm.backupsooceli.Enabled = true;
                    FRM_MAIN.getMainForm.kabax.Enabled = true;
                    FRM_MAIN.getMainForm.shaqaalahaToolStripMenuItem.Visible =true;
                    FRM_MAIN.getMainForm.toolStrip1.Enabled = true;
                    FRM_MAIN.getMainForm.dIYAARINTASERVERKAToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.bAKHAARKAToolStripMenuItem.Enabled = true;
                    
                    Program.SalesMan = Dt.Rows[0]["FullName"].ToString();

                    this.Close();
                }
                else if (Dt.Rows[0][2].ToString() == "SHAQAALE")
                {
                    FRM_MAIN frm = new FRM_MAIN();
                    FRM_MAIN.getMainForm.shaqaalahaToolStripMenuItem.Visible = false;
                    FRM_MAIN.getMainForm.macamiishaToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.agabyadaToolStripMenuItem.Enabled = true; ;
                    FRM_MAIN.getMainForm.backupssaame.Enabled = true;
                    FRM_MAIN.getMainForm.backupsooceli.Enabled = true;
                    FRM_MAIN.getMainForm.kabax.Enabled = true;
                    FRM_MAIN.getMainForm.toolStrip1.Enabled = true;
                    FRM_MAIN.getMainForm.dIYAARINTASERVERKAToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.toolStripButton1.Visible =false;
                    FRM_MAIN.getMainForm.bAKHAARKAToolStripMenuItem.Enabled = true;
                    
                    Program.SalesMan = Dt.Rows[0]["FullName"].ToString();

                    this.Close();
                }
            
            }
            else
            {
                MessageBox.Show("WAA LAGU GUULDAREESTAY GALIDA");
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtID.Text != string.Empty)
            {
                txtPWD.Focus();
            }
        }

        private void txtPWD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPWD.Text != string.Empty)
            {
                btnlogin.Focus();
            }

        }

        private void btnlogin_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnlogin_KeyUp_1(object sender, KeyEventArgs e)
        {

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPWD_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
