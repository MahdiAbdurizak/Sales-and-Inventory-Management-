using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace products_Management.PL
{
    public partial class FRM_BACKUP : Form
    {
        SqlConnection con = new SqlConnection(@"Server=.\SQLEXPRESS;Database=NorthwindSQL; Integrated Security=true");
        SqlCommand cmd;
        public FRM_BACKUP()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {

                string fileName = txtFileName.Text + "\\NorthwindSQL" + DateTime.Now.ToShortDateString().Replace('/', '-')
                    + " - " + DateTime.Now.ToLongTimeString().Replace(':', '-');
                string strQuery = "Backup Database NorthwindSQL to Disk= '" + fileName + ".bak'";
                cmd = new SqlCommand(strQuery, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("WAA LAHU GUULEESTAY SAMEENTA BACK UPKA", "BACK UP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
