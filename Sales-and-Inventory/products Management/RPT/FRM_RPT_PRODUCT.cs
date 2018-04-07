using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace products_Management.RPT
{
    public partial class FRM_RPT_PRODUCT : Form
    {
        public int d, m;

        public FRM_RPT_PRODUCT()
        {
            InitializeComponent();
          
            
            comboPaperSize.DisplayMember = "PaperName";
            PaperSize pkSize;
            for (int i = 0; i < printDoc.PrinterSettings.PaperSizes.Count; i++)
            {
                pkSize = printDoc.PrinterSettings.PaperSizes[i];
                comboPaperSize.Items.Add(pkSize);
            }
            comboPaperSize.SelectedIndex = 1;
            
        }

        private void FRM_RPT_PRODUCT_Load(object sender, EventArgs e)
        {

        }

        private void MyButtonPrint_Click(object sender, EventArgs e)
        {
            if (comboPaperSize.SelectedIndex != -1)
            {
                printDoc.DefaultPageSettings.PaperSize =
                printDoc.PrinterSettings.PaperSizes[comboPaperSize.SelectedIndex];
                printPreviewDialog1.Document = printDoc;
                printPreviewDialog1.ShowDialog();

            }
        }

        private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {

            //Courier New- MessageBox.Show("WIDTH = " +  printDocument1.DefaultPageSettings.PaperSize.Width.ToString());
            //  MessageBox.Show("Height = " + printDocument1.DefaultPageSettings.PaperSize.Height.ToString());
            string s = "BAHATI STORE & GENERAL COSMETICS";
            Font f = new System.Drawing.Font("arial", 9, FontStyle.Bold);
            Font fo = new System.Drawing.Font("arial", 7, FontStyle.Bold);
            Font fc = new System.Drawing.Font("arial", 18, FontStyle.Bold);
            // e.Graphics.DrawString(s,f, Brushes.Black,10,10);
            // e.Graphics.DrawRectangle(Pens.Black, 5, 5, 273, 1159);
            e.Graphics.DrawString(s, f, Brushes.Black, 15, 20);
            e.Graphics.DrawString("Tel:624354-0618458305-0615381268-", f, Brushes.Black, 15, 40);
            e.Graphics.DrawString("     0615544795-0699881085", f, Brushes.Black, 15, 60);
            e.Graphics.DrawString("address  : Mogadisho Somalia", f, Brushes.Black, 30, 80);
            e.Graphics.DrawString("Telka Macaamilka: "+txtTel.Text, fo, Brushes.Black, 30, 110);
            //e.Graphics.DrawString(txtTel.Text, fo, Brushes.Black, 130, 100);
            e.Graphics.DrawString("Taarikhda Soo saarka :  " + System.DateTime.Now.ToString(), fo, Brushes.Black, 30, 125);
            e.Graphics.DrawString("Rasiid", fc, Brushes.Black, 80, 150);
            e.Graphics.DrawString("No:_________", f, Brushes.Black, 180, 150);
            e.Graphics.DrawString(txtOrderID.Text, fo, Brushes.Black, 205, 149);
            e.Graphics.DrawString("Magaca: ____________________________", f, Brushes.Black, 15, 180);
            e.Graphics.DrawString(txtFirstName.Text+"   "+txtLastName.Text, fo, Brushes.Black, 80, 180);
           // e.Graphics.DrawRectangle(Pens.Black, 15, 210, 255, 500);
            //rows
            m = (dataGridView1.Rows.Count - 1)*30;
            
            for (int i = 210; i <= m+240; i += 30)
            {
                e.Graphics.DrawLine(Pens.Black, 15, i, 270, i);
                d = m+240;
            }
            // clumuns
           // e.Graphics.DrawLine(Pens.Black, 45, 210, 45, 710);
            // e.Graphics.DrawString("1", f, Brushes.Black,18,430);
           /* e.Graphics.DrawLine(Pens.Black, 130, 210, 130, 860);
            e.Graphics.DrawLine(Pens.Black, 170, 210, 170, 710);
            e.Graphics.DrawLine(Pens.Black, 220, 210, 220, 860);
            e.Graphics.DrawLine(Pens.Black, 15, 860, 270, 860);
            e.Graphics.DrawLine(Pens.Black, 270, 710, 270, 860);
            e.Graphics.DrawLine(Pens.Black, 15, 710, 15, 860);
            e.Graphics.DrawLine(Pens.Black, 130, 740, 270, 740);
            e.Graphics.DrawLine(Pens.Black, 130, 770, 270, 770);
            e.Graphics.DrawLine(Pens.Black, 130, 800, 270, 800);
            e.Graphics.DrawLine(Pens.Black, 130, 830, 270, 830);*/
            e.Graphics.DrawString("No", fo, Brushes.Black, 15, 220);
            e.Graphics.DrawString("Description", fo, Brushes.Black, 47, 220);
            e.Graphics.DrawString("Qty", fo, Brushes.Black, 135, 220);
            e.Graphics.DrawString("U.price", fo, Brushes.Black, 175, 220);
            e.Graphics.DrawString("Amount", fo, Brushes.Black, 225, 220);
            e.Graphics.DrawString("Isku dar", fo, Brushes.Black, 135, d+10);
            e.Graphics.DrawString("Kdhimid(%)", fo, Brushes.Black, 135, d+40);
            e.Graphics.DrawString("Isku dar Guud", fo, Brushes.Black, 135, d+70);
            e.Graphics.DrawString("Bixin", fo, Brushes.Black, 135, d+100);
            e.Graphics.DrawString("Dambe", fo, Brushes.Black, 135, d+130);

            e.Graphics.DrawString("$" +txtSumTotals.Text, fo, Brushes.Black, 220, d+10);
            e.Graphics.DrawString(txtDescount.Text, fo, Brushes.Black, 220, d+40);
            e.Graphics.DrawString("$" + txtTotalAmount.Text, fo, Brushes.Black, 220, d+70);
            e.Graphics.DrawString("$" + txtAmounKash.Text, fo, Brushes.Black, 220, d+100);
            e.Graphics.DrawString("$" + txtAmounDue.Text, fo, Brushes.Black, 220, d+130);
            //fill
            int r =0;
            int v = 1;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
               // e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), fo, Brushes.Black, 15, 250+r);
                e.Graphics.DrawString(v.ToString(), fo, Brushes.Black, 18, 250 + r);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), fo, Brushes.Black, 47, 250+r);
                e.Graphics.DrawString("$"+dataGridView1.Rows[i].Cells[2].Value.ToString(), fo, Brushes.Black, 175, 250+r);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), fo, Brushes.Black, 135, 250+r);
                e.Graphics.DrawString("$"+dataGridView1.Rows[i].Cells[4].Value.ToString(), fo, Brushes.Black, 220, 250+r);
                r = r + 30;
                v++;

            }

                 
               
                  
                  
                  
                  
                    
                
            
        }

        private void Print_Click(object sender, EventArgs e)
        {
            if (comboPaperSize.SelectedIndex != -1)
            {
                printDoc.DefaultPageSettings.PaperSize =
                printDoc.PrinterSettings.PaperSizes[comboPaperSize.SelectedIndex];
                printDoc.Print();

            }
        }
    }
}
