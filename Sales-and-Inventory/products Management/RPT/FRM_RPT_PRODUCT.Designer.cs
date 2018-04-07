namespace products_Management.RPT
{
    partial class FRM_RPT_PRODUCT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_RPT_PRODUCT));
            this.comboPaperSize = new System.Windows.Forms.ComboBox();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.MyButtonPrint = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAmounDue = new System.Windows.Forms.TextBox();
            this.txtAmounKash = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtDescount = new System.Windows.Forms.TextBox();
            this.txtSumTotals = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboPaperSize
            // 
            this.comboPaperSize.FormattingEnabled = true;
            this.comboPaperSize.Location = new System.Drawing.Point(6, 31);
            this.comboPaperSize.Name = "comboPaperSize";
            this.comboPaperSize.Size = new System.Drawing.Size(240, 25);
            this.comboPaperSize.TabIndex = 0;
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // MyButtonPrint
            // 
            this.MyButtonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyButtonPrint.Location = new System.Drawing.Point(6, 95);
            this.MyButtonPrint.Margin = new System.Windows.Forms.Padding(4);
            this.MyButtonPrint.Name = "MyButtonPrint";
            this.MyButtonPrint.Size = new System.Drawing.Size(179, 30);
            this.MyButtonPrint.TabIndex = 2;
            this.MyButtonPrint.Text = "fiiri";
            this.MyButtonPrint.UseVisualStyleBackColor = true;
            this.MyButtonPrint.Click += new System.EventHandler(this.MyButtonPrint_Click);
            // 
            // Print
            // 
            this.Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print.Location = new System.Drawing.Point(6, 151);
            this.Print.Margin = new System.Windows.Forms.Padding(4);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(179, 30);
            this.Print.TabIndex = 3;
            this.Print.Text = "SOO SAAR";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(453, 95);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(125, 17);
            this.label22.TabIndex = 54;
            this.label22.Text = "ISKU DARKA GUUD";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(453, 64);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 17);
            this.label21.TabIndex = 53;
            this.label21.Text = "KADHIMID(%)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(454, 170);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 17);
            this.label20.TabIndex = 52;
            this.label20.Text = "DAMBE";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(453, 124);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 17);
            this.label19.TabIndex = 51;
            this.label19.Text = "BIXIN";
            // 
            // txtAmounDue
            // 
            this.txtAmounDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmounDue.Location = new System.Drawing.Point(594, 162);
            this.txtAmounDue.Name = "txtAmounDue";
            this.txtAmounDue.ReadOnly = true;
            this.txtAmounDue.Size = new System.Drawing.Size(169, 25);
            this.txtAmounDue.TabIndex = 50;
            this.txtAmounDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAmounKash
            // 
            this.txtAmounKash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmounKash.Location = new System.Drawing.Point(594, 122);
            this.txtAmounKash.Name = "txtAmounKash";
            this.txtAmounKash.Size = new System.Drawing.Size(169, 25);
            this.txtAmounKash.TabIndex = 49;
            this.txtAmounKash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAmount.Location = new System.Drawing.Point(594, 87);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(169, 25);
            this.txtTotalAmount.TabIndex = 48;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescount
            // 
            this.txtDescount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescount.Location = new System.Drawing.Point(594, 56);
            this.txtDescount.MaxLength = 3;
            this.txtDescount.Name = "txtDescount";
            this.txtDescount.Size = new System.Drawing.Size(169, 25);
            this.txtDescount.TabIndex = 47;
            this.txtDescount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSumTotals
            // 
            this.txtSumTotals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSumTotals.Location = new System.Drawing.Point(594, 25);
            this.txtSumTotals.Name = "txtSumTotals";
            this.txtSumTotals.ReadOnly = true;
            this.txtSumTotals.Size = new System.Drawing.Size(169, 25);
            this.txtSumTotals.TabIndex = 46;
            this.txtSumTotals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(453, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 45;
            this.label10.Text = "ISKU DARKA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(788, 112);
            this.dataGridView1.TabIndex = 55;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Location = new System.Drawing.Point(157, 116);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(213, 25);
            this.txtLastName.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "RAQAMKA";
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.Location = new System.Drawing.Point(157, 150);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(213, 25);
            this.txtTel.TabIndex = 57;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Location = new System.Drawing.Point(157, 82);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(213, 25);
            this.txtFirstName.TabIndex = 62;
            // 
            // txtOrderID
            // 
            this.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderID.Location = new System.Drawing.Point(157, 42);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(213, 25);
            this.txtOrderID.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 61;
            this.label9.Text = "TELKA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "MAGACA AABAHA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 58;
            this.label7.Text = "MAGACA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtAmounDue);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.txtAmounKash);
            this.groupBox1.Controls.Add(this.txtOrderID);
            this.groupBox1.Controls.Add(this.txtTotalAmount);
            this.groupBox1.Controls.Add(this.txtDescount);
            this.groupBox1.Controls.Add(this.txtSumTotals);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 205);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(803, 139);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboPaperSize);
            this.groupBox3.Controls.Add(this.MyButtonPrint);
            this.groupBox3.Controls.Add(this.Print);
            this.groupBox3.Location = new System.Drawing.Point(812, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 213);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            // 
            // FRM_RPT_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1128, 425);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_RPT_PRODUCT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOO SARIDA RASIIDYADA";
            this.Load += new System.EventHandler(this.FRM_RPT_PRODUCT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboPaperSize;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button MyButtonPrint;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtAmounDue;
        public System.Windows.Forms.TextBox txtAmounKash;
        public System.Windows.Forms.TextBox txtTotalAmount;
        public System.Windows.Forms.TextBox txtDescount;
        public System.Windows.Forms.TextBox txtSumTotals;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txtLastName;
        public System.Windows.Forms.TextBox txtTel;
        public System.Windows.Forms.TextBox txtFirstName;


    }
}