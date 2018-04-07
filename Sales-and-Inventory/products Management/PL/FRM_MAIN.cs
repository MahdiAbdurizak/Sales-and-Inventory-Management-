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
    public partial class FRM_MAIN : Form
    {
        private static FRM_MAIN frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FRM_MAIN getMainForm
        {
            get
            {
                if(frm==null)
                { 
                    frm=new FRM_MAIN();
                    frm.FormClosed +=new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
  
        public FRM_MAIN()
        {
            
        
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.shaqaalahaToolStripMenuItem.Enabled = false;
            this.macamiishaToolStripMenuItem.Enabled = false;
            this.agabyadaToolStripMenuItem.Enabled = false;
            this.backupssaame.Enabled = false;
            this.backupsooceli.Enabled = false;
            this.kabax.Enabled = false;
            this.bAKHAARKAToolStripMenuItem.Enabled = false;
            this.toolStrip1.Enabled = false;
            this.dIYAARINTASERVERKAToolStripMenuItem.Enabled = true;
            

        }

        private void galida_Click(object sender, EventArgs e)
        {
            FRM_LOGIN frm = new FRM_LOGIN();
            frm.ShowDialog();
        }

        private void kuDarAgabCusubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.ShowDialog();
        }

        private void mamulkaMacamiishaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMERS frm = new FRM_CUSTOMERS();
            frm.ShowDialog();
        }

        private void mamulkaBeecmuushtarkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDERS_LIST frm = new FRM_ORDERS_LIST();
            frm.ShowDialog();
        }

        private void beecCusubToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            FRM_PRODUCTS frm = new FRM_PRODUCTS();
            frm.ShowDialog();
        }

        private void shaqaalaCusubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER frm = new FRM_ADD_USER();
            frm.ShowDialog();
        }

        private void mamulkaShaqaalahaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_USERS_LIST frm = new FRM_USERS_LIST();
            frm.ShowDialog();

        }

        private void backupssaame_Click(object sender, EventArgs e)
        {
            FRM_BACKUP frm = new FRM_BACKUP();
            frm.ShowDialog();
        }

        private void backupsooceli_Click(object sender, EventArgs e)
        {
            FRM__RESTORE frm = new FRM__RESTORE();
            frm.ShowDialog();

        }

        private void dIYAARINTASERVERKAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CONFIG frm = new FRM_CONFIG();
            frm.ShowDialog();
        }

        private void rASIIDYADAToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            FRM_USERS_LIST frm = new FRM_USERS_LIST();
            frm.ShowDialog();
        }

        private void xISAABTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORRDER_TOTAL frm = new FRM_ORRDER_TOTAL();
            frm.ShowDialog();
        }

        private void dALABCUSUBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDERS frm = new FRM_ORDERS();
            frm.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAKHAARKAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs eh)
        {
            FRM_Inventory frm = new FRM_Inventory();
            frm.ShowDialog();

        }

        private void bARNAAMIJKAANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PREVIEW frm = new FRM_PREVIEW();
            frm.ShowDialog();
        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {

        }


       
        
    }
}
