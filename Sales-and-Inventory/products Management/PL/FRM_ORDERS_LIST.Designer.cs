namespace products_Management.PL
{
    partial class FRM_ORDERS_LIST
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.raCA = new System.Windows.Forms.RadioButton();
            this.raMA = new System.Windows.Forms.RadioButton();
            this.raKU = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.raPOR = new System.Windows.Forms.RadioButton();
            this.raOR = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOrders);
            this.groupBox1.Location = new System.Drawing.Point(20, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1108, 404);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LIISKA RASIIDYADA";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(0, 25);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(1100, 371);
            this.dgvOrders.TabIndex = 0;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(325, 33);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(493, 25);
            this.txtsearch.TabIndex = 4;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "GALI ERAYGA AAD RAADINEESID";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(650, 502);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "KABAX";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // raCA
            // 
            this.raCA.AutoSize = true;
            this.raCA.Location = new System.Drawing.Point(8, 30);
            this.raCA.Margin = new System.Windows.Forms.Padding(4);
            this.raCA.Name = "raCA";
            this.raCA.Size = new System.Drawing.Size(66, 21);
            this.raCA.TabIndex = 19;
            this.raCA.Text = "CAADI";
            this.raCA.UseVisualStyleBackColor = true;
            this.raCA.CheckedChanged += new System.EventHandler(this.raCA_CheckedChanged);
            // 
            // raMA
            // 
            this.raMA.AutoSize = true;
            this.raMA.Location = new System.Drawing.Point(8, 55);
            this.raMA.Margin = new System.Windows.Forms.Padding(4);
            this.raMA.Name = "raMA";
            this.raMA.Size = new System.Drawing.Size(96, 21);
            this.raMA.TabIndex = 18;
            this.raMA.Text = "MACAAMIL";
            this.raMA.UseVisualStyleBackColor = true;
            this.raMA.CheckedChanged += new System.EventHandler(this.raMA_CheckedChanged);
            // 
            // raKU
            // 
            this.raKU.AutoSize = true;
            this.raKU.Checked = true;
            this.raKU.Location = new System.Drawing.Point(8, 0);
            this.raKU.Margin = new System.Windows.Forms.Padding(4);
            this.raKU.Name = "raKU";
            this.raKU.Size = new System.Drawing.Size(54, 21);
            this.raKU.TabIndex = 20;
            this.raKU.TabStop = true;
            this.raKU.Text = "KULI";
            this.raKU.UseVisualStyleBackColor = true;
            this.raKU.CheckedChanged += new System.EventHandler(this.raKU_CheckedChanged);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(398, 502);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 30);
            this.button3.TabIndex = 21;
            this.button3.Text = "BADAL RASIIDKA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(178, 502);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 30);
            this.button4.TabIndex = 22;
            this.button4.Text = "TIRTIR RASIDKA";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.raKU);
            this.groupBox2.Controls.Add(this.raMA);
            this.groupBox2.Controls.Add(this.raCA);
            this.groupBox2.Location = new System.Drawing.Point(843, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(124, 77);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.raPOR);
            this.groupBox3.Controls.Add(this.raOR);
            this.groupBox3.Location = new System.Drawing.Point(995, 7);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(133, 77);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // raPOR
            // 
            this.raPOR.AutoSize = true;
            this.raPOR.Location = new System.Drawing.Point(8, 47);
            this.raPOR.Margin = new System.Windows.Forms.Padding(4);
            this.raPOR.Name = "raPOR";
            this.raPOR.Size = new System.Drawing.Size(99, 21);
            this.raPOR.TabIndex = 1;
            this.raPOR.Text = "SOO GADID";
            this.raPOR.UseVisualStyleBackColor = true;
            this.raPOR.CheckedChanged += new System.EventHandler(this.raPOR_CheckedChanged);
            // 
            // raOR
            // 
            this.raOR.AutoSize = true;
            this.raOR.Checked = true;
            this.raOR.Location = new System.Drawing.Point(8, 21);
            this.raOR.Margin = new System.Windows.Forms.Padding(4);
            this.raOR.Name = "raOR";
            this.raOR.Size = new System.Drawing.Size(68, 21);
            this.raOR.TabIndex = 0;
            this.raOR.TabStop = true;
            this.raOR.Text = "GADID";
            this.raOR.UseVisualStyleBackColor = true;
            this.raOR.CheckedChanged += new System.EventHandler(this.raOR_CheckedChanged);
            // 
            // FRM_ORDERS_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1183, 545);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_ORDERS_LIST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MAMULKA RASIIDYADA";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton raCA;
        private System.Windows.Forms.RadioButton raMA;
        private System.Windows.Forms.RadioButton raKU;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton raPOR;
        private System.Windows.Forms.RadioButton raOR;


    }
}