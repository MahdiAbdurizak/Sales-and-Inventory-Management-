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
    public partial class FRM_CONFIG : Form
    {
        public FRM_CONFIG()
        {
            InitializeComponent();
            txtServer.Text = Properties.Settings.Default.Server;
            txtDatabase.Text = Properties.Settings.Default.Database;
            if (Properties.Settings.Default.Mode == "SQL")
            {
                rbSQL.Checked = true;
                txtID.Text = Properties.Settings.Default.ID;
                TXTPWD.Text = Properties.Settings.Default.Password;
            }
            else
            {
                rbWindows.Checked = true;
                txtID.Clear();
                TXTPWD.Clear();
                txtID.ReadOnly = true;
                TXTPWD.ReadOnly = true;
            }
        }

        private void FRM_CONFIG_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = txtServer.Text;
            Properties.Settings.Default.Database = txtDatabase.Text;
            Properties.Settings.Default.Mode = rbSQL.Checked==true?"SQL" :"Windows";
            Properties.Settings.Default.ID = txtID.Text;
            Properties.Settings.Default.Password = TXTPWD.Text;
            Properties.Settings.Default.Save();
        }

        private void rbSQL_CheckedChanged(object sender, EventArgs e)
        {
            txtID.ReadOnly = false;
            TXTPWD.ReadOnly = false;
        }

        private void rbWindows_CheckedChanged(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;
            TXTPWD.ReadOnly = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
