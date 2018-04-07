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
    public partial class FRM__RESTORE : Form
    {

        SqlConnection con = new SqlConnection(@"Server=.\SQLEXPRESS;Database=master; Integrated Security=true");
        SqlCommand cmd;
        public FRM__RESTORE()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string strQuery = "ALTER Database NorthwindSQL SET OFFLINE WITH ROLLBACK IMMEDIATE ;Restore Database NorthwindSQL From Disk='" + txtFileName.Text + "'";
                cmd = new SqlCommand(strQuery, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("WAA LAHU GUULEESTAY SOO CILINTA BACK UPKA", "BACK UP", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog1.FileName;
            }
        }
    }
}
