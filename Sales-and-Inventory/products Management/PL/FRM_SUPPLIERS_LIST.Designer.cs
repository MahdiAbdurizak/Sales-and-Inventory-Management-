namespace products_Management.PL
{
    partial class FRM_SUPPLIERS_LIST
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
            this.dvgSuppliers = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgSuppliers
            // 
            this.dvgSuppliers.AllowUserToAddRows = false;
            this.dvgSuppliers.AllowUserToDeleteRows = false;
            this.dvgSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgSuppliers.Location = new System.Drawing.Point(0, 57);
            this.dvgSuppliers.Margin = new System.Windows.Forms.Padding(4);
            this.dvgSuppliers.Name = "dvgSuppliers";
            this.dvgSuppliers.ReadOnly = true;
            this.dvgSuppliers.Size = new System.Drawing.Size(843, 449);
            this.dvgSuppliers.TabIndex = 1;
            this.dvgSuppliers.DoubleClick += new System.EventHandler(this.dvgSuppliers_DoubleClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(279, 24);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(450, 25);
            this.txtsearch.TabIndex = 3;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "GALI ERAYGA AAD RAADINEESID";
            // 
            // FRM_SUPPLIERS_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(843, 506);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgSuppliers);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_SUPPLIERS_LIST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIISKA SHARIKADAHA";
            ((System.ComponentModel.ISupportInitialize)(this.dvgSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dvgSuppliers;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
    }
}