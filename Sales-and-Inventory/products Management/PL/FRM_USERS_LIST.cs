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
    public partial class FRM_USERS_LIST : Form
    {
        BL.CLS_LOGIN login = new BL.CLS_LOGIN();
        public FRM_USERS_LIST()
        {
            InitializeComponent();
            this.dgvUsers.DataSource = login.SearchUsers2("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER frm = new FRM_ADD_USER();
            frm.btnSave.Text = "KAYDI";
            frm.ShowDialog();
            this.dgvUsers.DataSource = login.SearchUsers2("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER frm = new FRM_ADD_USER();
            frm.txtID.Text = dgvUsers.CurrentRow.Cells[0].Value.ToString();
            frm.txtFullName.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
            frm.txtPWD.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
            frm.txtPWDConfirm.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
            frm.cmbType.Text = dgvUsers.CurrentRow.Cells[3].Value.ToString();
            frm.txtID.ReadOnly = true;
            
            frm.btnSave.Text = "BADAL";
            frm.ShowDialog();
            this.dgvUsers.DataSource = login.SearchUsers2("");
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            this.dgvUsers.DataSource = login.SearchUsers2(txtsearch.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("MAHUBTAA RABITAANKAGA TIRTIRIDA ADEEGSADAHAAN?", "TIRTIRID", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            { 
                login.DELETE_USER(dgvUsers.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("WAA LAGU GUULEESTAY TIRTIRIDA", "TIRTIRID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvUsers.DataSource = login.SearchUsers2("");
            }
        }
    }
}
