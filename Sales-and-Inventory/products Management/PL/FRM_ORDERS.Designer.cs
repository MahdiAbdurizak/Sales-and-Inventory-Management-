namespace products_Management.PL
{
    partial class FRM_ORDERS
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.raPOR = new System.Windows.Forms.RadioButton();
            this.raOR = new System.Windows.Forms.RadioButton();
            this.lbTrID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalesMan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesOrder = new System.Windows.Forms.TextBox();
            this.dtOrder = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAmounDue = new System.Windows.Forms.TextBox();
            this.txtAmounKash = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtDescount = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIDproduct = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnNEW = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kabadalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tirtirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tirtirKuliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSumTotals = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lbcost = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.raPOR);
            this.groupBox1.Controls.Add(this.raOR);
            this.groupBox1.Controls.Add(this.lbTrID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSalesMan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDesOrder);
            this.groupBox1.Controls.Add(this.dtOrder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOrderID);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RASIIDKA";
            // 
            // raPOR
            // 
            this.raPOR.AutoSize = true;
            this.raPOR.Location = new System.Drawing.Point(411, 58);
            this.raPOR.Name = "raPOR";
            this.raPOR.Size = new System.Drawing.Size(99, 21);
            this.raPOR.TabIndex = 40;
            this.raPOR.Text = "SOO GADID";
            this.raPOR.UseVisualStyleBackColor = true;
            this.raPOR.CheckedChanged += new System.EventHandler(this.raPOR_CheckedChanged);
            // 
            // raOR
            // 
            this.raOR.AutoSize = true;
            this.raOR.Checked = true;
            this.raOR.Location = new System.Drawing.Point(411, 24);
            this.raOR.Name = "raOR";
            this.raOR.Size = new System.Drawing.Size(68, 21);
            this.raOR.TabIndex = 39;
            this.raOR.TabStop = true;
            this.raOR.Text = "GADID";
            this.raOR.UseVisualStyleBackColor = true;
            this.raOR.CheckedChanged += new System.EventHandler(this.raOR_CheckedChanged);
            // 
            // lbTrID
            // 
            this.lbTrID.AutoSize = true;
            this.lbTrID.Location = new System.Drawing.Point(437, 164);
            this.lbTrID.Name = "lbTrID";
            this.lbTrID.Size = new System.Drawing.Size(0, 17);
            this.lbTrID.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "GADAHA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "TAARIIQDA";
            // 
            // txtSalesMan
            // 
            this.txtSalesMan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalesMan.Location = new System.Drawing.Point(116, 109);
            this.txtSalesMan.Name = "txtSalesMan";
            this.txtSalesMan.ReadOnly = true;
            this.txtSalesMan.Size = new System.Drawing.Size(228, 25);
            this.txtSalesMan.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOTE";
            // 
            // txtDesOrder
            // 
            this.txtDesOrder.Location = new System.Drawing.Point(116, 155);
            this.txtDesOrder.Multiline = true;
            this.txtDesOrder.Name = "txtDesOrder";
            this.txtDesOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesOrder.Size = new System.Drawing.Size(228, 45);
            this.txtDesOrder.TabIndex = 0;
            // 
            // dtOrder
            // 
            this.dtOrder.Checked = false;
            this.dtOrder.Location = new System.Drawing.Point(116, 58);
            this.dtOrder.Name = "dtOrder";
            this.dtOrder.Size = new System.Drawing.Size(228, 25);
            this.dtOrder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "RAQAMKA";
            // 
            // txtOrderID
            // 
            this.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderID.Location = new System.Drawing.Point(116, 17);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(228, 25);
            this.txtOrderID.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtLastName);
            this.groupBox2.Controls.Add(this.txtTel);
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Controls.Add(this.txtCompany);
            this.groupBox2.Controls.Add(this.txtCustomerID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(562, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 206);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MACAAMILKA";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(298, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "....";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Location = new System.Drawing.Point(157, 130);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(213, 25);
            this.txtLastName.TabIndex = 15;
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.Location = new System.Drawing.Point(157, 164);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(213, 25);
            this.txtTel.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Location = new System.Drawing.Point(157, 96);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(213, 25);
            this.txtFirstName.TabIndex = 14;
            // 
            // txtCompany
            // 
            this.txtCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompany.Location = new System.Drawing.Point(157, 62);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.ReadOnly = true;
            this.txtCompany.Size = new System.Drawing.Size(213, 25);
            this.txtCompany.TabIndex = 13;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerID.Location = new System.Drawing.Point(157, 23);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(132, 25);
            this.txtCustomerID.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "TELKA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "MAGACA AABAHA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "MAGACA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "SHIRKADA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "RAQAMKA";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbcost);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtAmounDue);
            this.groupBox3.Controls.Add(this.txtAmounKash);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtTotalAmount);
            this.groupBox3.Controls.Add(this.txtDescount);
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtQty);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtPrice);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtNameProduct);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtIDproduct);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnNEW);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.txtSumTotals);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnBrowse);
            this.groupBox3.Location = new System.Drawing.Point(16, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1120, 338);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "AGABYADA";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(803, 210);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(125, 17);
            this.label22.TabIndex = 44;
            this.label22.Text = "ISKU DARKA GUUD";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(803, 179);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 17);
            this.label21.TabIndex = 43;
            this.label21.Text = "KADHIMID(%)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(804, 285);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 17);
            this.label20.TabIndex = 41;
            this.label20.Text = "DAMBE";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(803, 239);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 17);
            this.label19.TabIndex = 40;
            this.label19.Text = "BIXIN";
            // 
            // txtAmounDue
            // 
            this.txtAmounDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmounDue.Location = new System.Drawing.Point(944, 277);
            this.txtAmounDue.Name = "txtAmounDue";
            this.txtAmounDue.ReadOnly = true;
            this.txtAmounDue.Size = new System.Drawing.Size(169, 25);
            this.txtAmounDue.TabIndex = 39;
            this.txtAmounDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAmounKash
            // 
            this.txtAmounKash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmounKash.Location = new System.Drawing.Point(944, 237);
            this.txtAmounKash.Name = "txtAmounKash";
            this.txtAmounKash.Size = new System.Drawing.Size(169, 25);
            this.txtAmounKash.TabIndex = 37;
            this.txtAmounKash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmounKash.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAmounKash_KeyUp);
            this.txtAmounKash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmounKash_KeyPress);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(1, 24);
            this.label18.Margin = new System.Windows.Forms.Padding(3);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(6);
            this.label18.Size = new System.Drawing.Size(90, 37);
            this.label18.TabIndex = 35;
            this.label18.Text = "dooro";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAmount.Location = new System.Drawing.Point(944, 202);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(169, 25);
            this.txtTotalAmount.TabIndex = 34;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescount
            // 
            this.txtDescount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescount.Location = new System.Drawing.Point(944, 171);
            this.txtDescount.MaxLength = 10;
            this.txtDescount.Name = "txtDescount";
            this.txtDescount.Size = new System.Drawing.Size(169, 25);
            this.txtDescount.TabIndex = 32;
            this.txtDescount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescount_KeyDown);
            this.txtDescount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDescount_KeyUp);
            this.txtDescount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescount_KeyPress);
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Location = new System.Drawing.Point(659, 68);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(130, 25);
            this.txtAmount.TabIndex = 30;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(659, 24);
            this.label15.Margin = new System.Windows.Forms.Padding(3);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(6);
            this.label15.Size = new System.Drawing.Size(130, 37);
            this.label15.TabIndex = 29;
            this.label15.Text = "qiimaha oo dhan";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Location = new System.Drawing.Point(530, 68);
            this.txtQty.MaxLength = 12;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(130, 25);
            this.txtQty.TabIndex = 28;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            this.txtQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyUp);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(530, 24);
            this.label14.Margin = new System.Windows.Forms.Padding(3);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(6);
            this.label14.Size = new System.Drawing.Size(130, 37);
            this.label14.TabIndex = 27;
            this.label14.Text = "cadadka";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Location = new System.Drawing.Point(401, 68);
            this.txtPrice.MaxLength = 12;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(130, 25);
            this.txtPrice.TabIndex = 26;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrice_KeyDown);
            this.txtPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrice_KeyUp);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(401, 24);
            this.label13.Margin = new System.Windows.Forms.Padding(3);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(6);
            this.label13.Size = new System.Drawing.Size(130, 37);
            this.label13.TabIndex = 25;
            this.label13.Text = "qiimaha xabada";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameProduct.Location = new System.Drawing.Point(216, 68);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.ReadOnly = true;
            this.txtNameProduct.Size = new System.Drawing.Size(187, 25);
            this.txtNameProduct.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(216, 24);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(6);
            this.label12.Size = new System.Drawing.Size(187, 37);
            this.label12.TabIndex = 23;
            this.label12.Text = "magaca agabka";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIDproduct
            // 
            this.txtIDproduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDproduct.Location = new System.Drawing.Point(90, 68);
            this.txtIDproduct.Name = "txtIDproduct";
            this.txtIDproduct.ReadOnly = true;
            this.txtIDproduct.Size = new System.Drawing.Size(130, 25);
            this.txtIDproduct.TabIndex = 22;
            this.txtIDproduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(90, 24);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(6);
            this.label11.Size = new System.Drawing.Size(130, 37);
            this.label11.TabIndex = 21;
            this.label11.Text = "raqamka agabka";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNEW
            // 
            this.btnNEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNEW.Location = new System.Drawing.Point(78, 290);
            this.btnNEW.Name = "btnNEW";
            this.btnNEW.Size = new System.Drawing.Size(142, 31);
            this.btnNEW.TabIndex = 17;
            this.btnNEW.Text = "RASIID CUSUB";
            this.btnNEW.UseVisualStyleBackColor = true;
            this.btnNEW.Click += new System.EventHandler(this.btnNEW_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(239, 290);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 31);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "KAYDI ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(409, 290);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(142, 31);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Text = "SOO SAAR";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(574, 290);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 31);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "BIXID";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 112);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(788, 112);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kabadalToolStripMenuItem,
            this.toolStripSeparator1,
            this.tirtirToolStripMenuItem,
            this.tirtirKuliToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 76);
            // 
            // kabadalToolStripMenuItem
            // 
            this.kabadalToolStripMenuItem.Name = "kabadalToolStripMenuItem";
            this.kabadalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kabadalToolStripMenuItem.Text = "kabadal";
            this.kabadalToolStripMenuItem.Click += new System.EventHandler(this.kabadalToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // tirtirToolStripMenuItem
            // 
            this.tirtirToolStripMenuItem.Name = "tirtirToolStripMenuItem";
            this.tirtirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tirtirToolStripMenuItem.Text = "tirtir sadarkaan";
            this.tirtirToolStripMenuItem.Click += new System.EventHandler(this.tirtirToolStripMenuItem_Click);
            // 
            // tirtirKuliToolStripMenuItem
            // 
            this.tirtirKuliToolStripMenuItem.Name = "tirtirKuliToolStripMenuItem";
            this.tirtirKuliToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tirtirKuliToolStripMenuItem.Text = "tirtir kuli";
            this.tirtirKuliToolStripMenuItem.Click += new System.EventHandler(this.tirtirKuliToolStripMenuItem_Click);
            // 
            // txtSumTotals
            // 
            this.txtSumTotals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSumTotals.Location = new System.Drawing.Point(944, 140);
            this.txtSumTotals.Name = "txtSumTotals";
            this.txtSumTotals.ReadOnly = true;
            this.txtSumTotals.Size = new System.Drawing.Size(169, 25);
            this.txtSumTotals.TabIndex = 16;
            this.txtSumTotals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSumTotals.TextChanged += new System.EventHandler(this.txtSumTotals_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(803, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "ISKU DARKA";
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Location = new System.Drawing.Point(1, 66);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(90, 27);
            this.btnBrowse.TabIndex = 36;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbcost
            // 
            this.lbcost.AutoSize = true;
            this.lbcost.Location = new System.Drawing.Point(860, 25);
            this.lbcost.Name = "lbcost";
            this.lbcost.Size = new System.Drawing.Size(52, 17);
            this.lbcost.TabIndex = 45;
            this.lbcost.Text = "label16";
            this.lbcost.Visible = false;
            // 
            // FRM_ORDERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1168, 581);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ORDERS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DALABAADKA";
            this.Load += new System.EventHandler(this.FRM_ORDERS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIDproduct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kabadalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tirtirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tirtirKuliToolStripMenuItem;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox txtSalesMan;
        public System.Windows.Forms.TextBox txtDesOrder;
        public System.Windows.Forms.DateTimePicker dtOrder;
        public System.Windows.Forms.TextBox txtOrderID;
        public System.Windows.Forms.TextBox txtCustomerID;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox txtAmounKash;
        public System.Windows.Forms.RadioButton raOR;
        public System.Windows.Forms.TextBox txtAmounDue;
        public System.Windows.Forms.Button btnNEW;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnPrint;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label lbTrID;
        public System.Windows.Forms.TextBox txtSumTotals;
        public System.Windows.Forms.RadioButton raPOR;
        public System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox txtTotalAmount;
        public System.Windows.Forms.TextBox txtDescount;
        public System.Windows.Forms.TextBox txtQty;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lbcost;
    }
}