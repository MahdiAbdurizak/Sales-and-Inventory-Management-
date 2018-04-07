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
    public partial class FRM_ADD_USER : Form
    {
        public FRM_ADD_USER()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == string.Empty || txtFullName.Text == string.Empty || txtPWD.Text == string.Empty ||
                    txtPWDConfirm.Text == string.Empty)
                {
                    MessageBox.Show("FADHLAN BUUXI XOGTA OO DHAN", "QALAD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                if (txtPWD.Text != txtPWDConfirm.Text)
                {
                    MessageBox.Show("FADHLAN LABADA ERAY ISMALAHAN", "ISKA JIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (btnSave.Text == "KAYDI")
                {
                    BL.CLS_LOGIN user = new BL.CLS_LOGIN();
                    user.ADD_USER(txtID.Text, txtFullName.Text, txtPWD.Text, cmbType.Text);
                    MessageBox.Show("WAA LAGU GUULEESTAY KU DARIDA ADEEGSADAHAAN", "KU DARIDA ADEEGSADE CUSUB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (btnSave.Text == "BADAL")
                {
                    BL.CLS_LOGIN user = new BL.CLS_LOGIN();
                    user.EDIT_USER(txtID.Text, txtFullName.Text, txtPWD.Text, cmbType.Text);
                    MessageBox.Show("WAA LAGU GUULEESTAY BADALIDA ADEEGSADAHAAN", "BADALID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtID.Clear();
                txtFullName.Clear();
                txtPWD.Clear();
                txtPWDConfirm.Clear();


                txtID.Focus();
            }
            catch
            {
                return;
            }
            
        }

        private void txtPWDConfirm_Validated(object sender, EventArgs e)
        {
            if (txtPWD.Text != txtPWDConfirm.Text)
            {
                MessageBox.Show("FADHLAN LABADA ERAY ISMALAHAN", "ISKA JIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtID.Text != string.Empty)
            {
                txtFullName.Focus();
            }
        }

        private void txtFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtFullName.Text != string.Empty)
            {
                txtPWD.Focus();
            }
        }

        private void txtPWD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPWD.Text != string.Empty)
            {
                txtPWDConfirm.Focus();
            }
        }

        private void txtPWDConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPWDConfirm.Text != string.Empty)
            {
                cmbType.Focus();
            }
        }

        private void cmbType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }
    }
}
