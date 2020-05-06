namespace JFood
{
    partial class frmSales
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpPreviousOrders = new System.Windows.Forms.TabPage();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.lblOrderSerial = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblReceiptSerial = new System.Windows.Forms.Label();
            this.lblReceiptID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblReceiptTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOldOrdersPrevious = new System.Windows.Forms.Button();
            this.btnOrderCancel = new System.Windows.Forms.Button();
            this.btnOldOrdersNext = new System.Windows.Forms.Button();
            this.dgvPreviousOrders = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnVoucher = new System.Windows.Forms.Button();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.flpItems = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.lblPlaceName = new System.Windows.Forms.Label();
            this.btnPrevItems = new System.Windows.Forms.Button();
            this.btnItemsNext = new System.Windows.Forms.Button();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.flpCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCategoriesPrevious = new System.Windows.Forms.Button();
            this.btnNextCategories = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpPreviousOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviousOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1246, 489);
            this.splitContainer1.SplitterDistance = 377;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tpPreviousOrders);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(377, 489);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer6);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(369, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "الحالي";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(3, 3);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer6.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.lblTotal);
            this.splitContainer6.Panel2.Controls.Add(this.label1);
            this.splitContainer6.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer6.Size = new System.Drawing.Size(363, 452);
            this.splitContainer6.SplitterDistance = 233;
            this.splitContainer6.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemName,
            this.QTY,
            this.Price,
            this.Total,
            this.DepartmentID});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(363, 233);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "الرقم";
            this.ItemID.Name = "ItemID";
            this.ItemID.Visible = false;
            // 
            // ItemName
            // 
            this.ItemName.FillWeight = 203.0457F;
            this.ItemName.HeaderText = "العنصر";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // QTY
            // 
            this.QTY.FillWeight = 65.65144F;
            this.QTY.HeaderText = "الكمية";
            this.QTY.Name = "QTY";
            // 
            // Price
            // 
            this.Price.FillWeight = 65.65144F;
            this.Price.HeaderText = "السعر";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.FillWeight = 65.65144F;
            this.Total.HeaderText = "الجملة";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // DepartmentID
            // 
            this.DepartmentID.HeaderText = "القسم";
            this.DepartmentID.Name = "DepartmentID";
            this.DepartmentID.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Black;
            this.lblTotal.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(15, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 54);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(216, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "الجمـــــلـــــــة";
            // 
            // tpPreviousOrders
            // 
            this.tpPreviousOrders.Controls.Add(this.splitContainer7);
            this.tpPreviousOrders.Location = new System.Drawing.Point(4, 22);
            this.tpPreviousOrders.Name = "tpPreviousOrders";
            this.tpPreviousOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tpPreviousOrders.Size = new System.Drawing.Size(369, 463);
            this.tpPreviousOrders.TabIndex = 1;
            this.tpPreviousOrders.Text = "السابق";
            this.tpPreviousOrders.UseVisualStyleBackColor = true;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(3, 3);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.lblOrderSerial);
            this.splitContainer7.Panel1.Controls.Add(this.label6);
            this.splitContainer7.Panel1.Controls.Add(this.lblOrderID);
            this.splitContainer7.Panel1.Controls.Add(this.label5);
            this.splitContainer7.Panel1.Controls.Add(this.lblReceiptSerial);
            this.splitContainer7.Panel1.Controls.Add(this.lblReceiptID);
            this.splitContainer7.Panel1.Controls.Add(this.label4);
            this.splitContainer7.Panel1.Controls.Add(this.lblReceiptTotal);
            this.splitContainer7.Panel1.Controls.Add(this.label2);
            this.splitContainer7.Panel1.Controls.Add(this.lblOrderTotal);
            this.splitContainer7.Panel1.Controls.Add(this.label7);
            this.splitContainer7.Panel1.Controls.Add(this.label3);
            this.splitContainer7.Panel1.Controls.Add(this.btnOldOrdersPrevious);
            this.splitContainer7.Panel1.Controls.Add(this.btnOrderCancel);
            this.splitContainer7.Panel1.Controls.Add(this.btnOldOrdersNext);
            this.splitContainer7.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.dgvPreviousOrders);
            this.splitContainer7.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer7.Size = new System.Drawing.Size(363, 457);
            this.splitContainer7.SplitterDistance = 232;
            this.splitContainer7.TabIndex = 0;
            // 
            // lblOrderSerial
            // 
            this.lblOrderSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderSerial.AutoSize = true;
            this.lblOrderSerial.Font = new System.Drawing.Font("Arial", 14F);
            this.lblOrderSerial.Location = new System.Drawing.Point(119, 118);
            this.lblOrderSerial.Name = "lblOrderSerial";
            this.lblOrderSerial.Size = new System.Drawing.Size(0, 22);
            this.lblOrderSerial.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F);
            this.label6.Location = new System.Drawing.Point(236, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "متسلسل الطلب:";
            // 
            // lblOrderID
            // 
            this.lblOrderID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Arial", 14F);
            this.lblOrderID.Location = new System.Drawing.Point(119, 96);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(0, 22);
            this.lblOrderID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.Location = new System.Drawing.Point(236, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "رقم الطلب:";
            // 
            // lblReceiptSerial
            // 
            this.lblReceiptSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReceiptSerial.AutoSize = true;
            this.lblReceiptSerial.Font = new System.Drawing.Font("Arial", 14F);
            this.lblReceiptSerial.Location = new System.Drawing.Point(119, 42);
            this.lblReceiptSerial.Name = "lblReceiptSerial";
            this.lblReceiptSerial.Size = new System.Drawing.Size(0, 22);
            this.lblReceiptSerial.TabIndex = 7;
            // 
            // lblReceiptID
            // 
            this.lblReceiptID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReceiptID.AutoSize = true;
            this.lblReceiptID.Font = new System.Drawing.Font("Arial", 14F);
            this.lblReceiptID.Location = new System.Drawing.Point(119, 20);
            this.lblReceiptID.Name = "lblReceiptID";
            this.lblReceiptID.Size = new System.Drawing.Size(0, 22);
            this.lblReceiptID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(236, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "متسلسل الوصل:";
            // 
            // lblReceiptTotal
            // 
            this.lblReceiptTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReceiptTotal.AutoSize = true;
            this.lblReceiptTotal.Font = new System.Drawing.Font("Arial", 14F);
            this.lblReceiptTotal.Location = new System.Drawing.Point(119, 64);
            this.lblReceiptTotal.Name = "lblReceiptTotal";
            this.lblReceiptTotal.Size = new System.Drawing.Size(0, 22);
            this.lblReceiptTotal.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(236, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "رقم الوصل:";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Font = new System.Drawing.Font("Arial", 14F);
            this.lblOrderTotal.Location = new System.Drawing.Point(119, 149);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(0, 22);
            this.lblOrderTotal.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F);
            this.label7.Location = new System.Drawing.Point(236, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "جملة مبلغ الوصل:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(236, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "جملة مبلغ الطلب:";
            // 
            // btnOldOrdersPrevious
            // 
            this.btnOldOrdersPrevious.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOldOrdersPrevious.Location = new System.Drawing.Point(3, 181);
            this.btnOldOrdersPrevious.Name = "btnOldOrdersPrevious";
            this.btnOldOrdersPrevious.Size = new System.Drawing.Size(91, 48);
            this.btnOldOrdersPrevious.TabIndex = 6;
            this.btnOldOrdersPrevious.Text = "السابق";
            this.btnOldOrdersPrevious.UseVisualStyleBackColor = false;
            this.btnOldOrdersPrevious.Click += new System.EventHandler(this.btnOldOrdersPrevious_Click);
            // 
            // btnOrderCancel
            // 
            this.btnOrderCancel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOrderCancel.Location = new System.Drawing.Point(135, 181);
            this.btnOrderCancel.Name = "btnOrderCancel";
            this.btnOrderCancel.Size = new System.Drawing.Size(91, 48);
            this.btnOrderCancel.TabIndex = 5;
            this.btnOrderCancel.Text = "حذف الطلب";
            this.btnOrderCancel.UseVisualStyleBackColor = false;
            this.btnOrderCancel.Visible = false;
            this.btnOrderCancel.Click += new System.EventHandler(this.btnOrderCancel_Click);
            // 
            // btnOldOrdersNext
            // 
            this.btnOldOrdersNext.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOldOrdersNext.Location = new System.Drawing.Point(269, 181);
            this.btnOldOrdersNext.Name = "btnOldOrdersNext";
            this.btnOldOrdersNext.Size = new System.Drawing.Size(91, 48);
            this.btnOldOrdersNext.TabIndex = 5;
            this.btnOldOrdersNext.Text = "التالي";
            this.btnOldOrdersNext.UseVisualStyleBackColor = false;
            this.btnOldOrdersNext.Click += new System.EventHandler(this.btnOldOrdersNext_Click);
            // 
            // dgvPreviousOrders
            // 
            this.dgvPreviousOrders.AllowUserToAddRows = false;
            this.dgvPreviousOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPreviousOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreviousOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.OrderID,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvPreviousOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPreviousOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvPreviousOrders.Name = "dgvPreviousOrders";
            this.dgvPreviousOrders.Size = new System.Drawing.Size(363, 221);
            this.dgvPreviousOrders.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OrderItemID";
            this.dataGridViewTextBoxColumn6.HeaderText = "الرقم";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "OrderID";
            this.OrderID.HeaderText = "رقم الطلب";
            this.OrderID.Name = "OrderID";
            this.OrderID.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn1.HeaderText = "رقم العنصر";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ItemText";
            this.dataGridViewTextBoxColumn2.FillWeight = 203.0457F;
            this.dataGridViewTextBoxColumn2.HeaderText = "العنصر";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ItemQTY";
            this.dataGridViewTextBoxColumn3.FillWeight = 65.65144F;
            this.dataGridViewTextBoxColumn3.HeaderText = "الكمية";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ItemPrice";
            this.dataGridViewTextBoxColumn4.FillWeight = 65.65144F;
            this.dataGridViewTextBoxColumn4.HeaderText = "السعر";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TotalPrice";
            this.dataGridViewTextBoxColumn5.FillWeight = 65.65144F;
            this.dataGridViewTextBoxColumn5.HeaderText = "الجملة";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer2.Size = new System.Drawing.Size(865, 489);
            this.splitContainer2.SplitterDistance = 644;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btnVoucher);
            this.splitContainer3.Panel1.Controls.Add(this.btnCredit);
            this.splitContainer3.Panel1.Controls.Add(this.btnCash);
            this.splitContainer3.Panel1.Controls.Add(this.btnClose);
            this.splitContainer3.Panel1.Controls.Add(this.btnPrint);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(644, 489);
            this.splitContainer3.SplitterDistance = 51;
            this.splitContainer3.TabIndex = 0;
            // 
            // btnVoucher
            // 
            this.btnVoucher.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVoucher.Location = new System.Drawing.Point(22, 3);
            this.btnVoucher.Name = "btnVoucher";
            this.btnVoucher.Size = new System.Drawing.Size(91, 48);
            this.btnVoucher.TabIndex = 6;
            this.btnVoucher.Text = "كبون";
            this.btnVoucher.UseVisualStyleBackColor = false;
            this.btnVoucher.Visible = false;
            this.btnVoucher.Click += new System.EventHandler(this.btnVoucher_Click);
            // 
            // btnCredit
            // 
            this.btnCredit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCredit.Location = new System.Drawing.Point(154, 3);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(91, 48);
            this.btnCredit.TabIndex = 6;
            this.btnCredit.Text = "دفع آجل";
            this.btnCredit.UseVisualStyleBackColor = false;
            this.btnCredit.Visible = false;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCash.Location = new System.Drawing.Point(292, 3);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(91, 48);
            this.btnCash.TabIndex = 6;
            this.btnCash.Text = "دفع نقدي";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Visible = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClose.Location = new System.Drawing.Point(424, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 48);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "اغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPrint.Location = new System.Drawing.Point(537, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(91, 48);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.flpItems);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.lblLocationName);
            this.splitContainer4.Panel2.Controls.Add(this.lblPlaceName);
            this.splitContainer4.Panel2.Controls.Add(this.btnPrevItems);
            this.splitContainer4.Panel2.Controls.Add(this.btnItemsNext);
            this.splitContainer4.Size = new System.Drawing.Size(644, 434);
            this.splitContainer4.SplitterDistance = 367;
            this.splitContainer4.TabIndex = 0;
            // 
            // flpItems
            // 
            this.flpItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpItems.Location = new System.Drawing.Point(0, 0);
            this.flpItems.Name = "flpItems";
            this.flpItems.Size = new System.Drawing.Size(644, 367);
            this.flpItems.TabIndex = 1;
            // 
            // lblLocationName
            // 
            this.lblLocationName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Font = new System.Drawing.Font("Arial", 14F);
            this.lblLocationName.Location = new System.Drawing.Point(189, 20);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(0, 22);
            this.lblLocationName.TabIndex = 8;
            // 
            // lblPlaceName
            // 
            this.lblPlaceName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlaceName.AutoSize = true;
            this.lblPlaceName.Font = new System.Drawing.Font("Arial", 14F);
            this.lblPlaceName.Location = new System.Drawing.Point(371, 20);
            this.lblPlaceName.Name = "lblPlaceName";
            this.lblPlaceName.Size = new System.Drawing.Size(0, 22);
            this.lblPlaceName.TabIndex = 8;
            // 
            // btnPrevItems
            // 
            this.btnPrevItems.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPrevItems.Location = new System.Drawing.Point(3, 3);
            this.btnPrevItems.Name = "btnPrevItems";
            this.btnPrevItems.Size = new System.Drawing.Size(91, 48);
            this.btnPrevItems.TabIndex = 4;
            this.btnPrevItems.Text = "السابق";
            this.btnPrevItems.UseVisualStyleBackColor = false;
            this.btnPrevItems.Click += new System.EventHandler(this.btnPrevItems_Click);
            // 
            // btnItemsNext
            // 
            this.btnItemsNext.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnItemsNext.Location = new System.Drawing.Point(550, 8);
            this.btnItemsNext.Name = "btnItemsNext";
            this.btnItemsNext.Size = new System.Drawing.Size(91, 48);
            this.btnItemsNext.TabIndex = 3;
            this.btnItemsNext.Text = "التالي";
            this.btnItemsNext.UseVisualStyleBackColor = false;
            this.btnItemsNext.Click += new System.EventHandler(this.btnItemsNext_Click);
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.flpCategories);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.btnCategoriesPrevious);
            this.splitContainer5.Panel2.Controls.Add(this.btnNextCategories);
            this.splitContainer5.Size = new System.Drawing.Size(217, 489);
            this.splitContainer5.SplitterDistance = 419;
            this.splitContainer5.TabIndex = 0;
            // 
            // flpCategories
            // 
            this.flpCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCategories.Location = new System.Drawing.Point(0, 0);
            this.flpCategories.Name = "flpCategories";
            this.flpCategories.Size = new System.Drawing.Size(217, 419);
            this.flpCategories.TabIndex = 1;
            // 
            // btnCategoriesPrevious
            // 
            this.btnCategoriesPrevious.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCategoriesPrevious.Location = new System.Drawing.Point(2, 8);
            this.btnCategoriesPrevious.Name = "btnCategoriesPrevious";
            this.btnCategoriesPrevious.Size = new System.Drawing.Size(91, 48);
            this.btnCategoriesPrevious.TabIndex = 4;
            this.btnCategoriesPrevious.Text = "السابق";
            this.btnCategoriesPrevious.UseVisualStyleBackColor = false;
            this.btnCategoriesPrevious.Visible = false;
            this.btnCategoriesPrevious.Click += new System.EventHandler(this.btnCategoriesPrevious_Click);
            // 
            // btnNextCategories
            // 
            this.btnNextCategories.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNextCategories.Location = new System.Drawing.Point(126, 8);
            this.btnNextCategories.Name = "btnNextCategories";
            this.btnNextCategories.Size = new System.Drawing.Size(91, 48);
            this.btnNextCategories.TabIndex = 3;
            this.btnNextCategories.Text = "التالي";
            this.btnNextCategories.UseVisualStyleBackColor = false;
            this.btnNextCategories.Visible = false;
            this.btnNextCategories.Click += new System.EventHandler(this.btnNextCategories_Click);
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1246, 489);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSales";
            this.ShowIcon = false;
            this.Text = "المبيعات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpPreviousOrders.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel1.PerformLayout();
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviousOrders)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpPreviousOrders;
        private System.Windows.Forms.Button btnPrevItems;
        private System.Windows.Forms.Button btnItemsNext;
        private System.Windows.Forms.Button btnCategoriesPrevious;
        private System.Windows.Forms.Button btnNextCategories;
        private System.Windows.Forms.FlowLayoutPanel flpItems;
        private System.Windows.Forms.FlowLayoutPanel flpCategories;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentID;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.DataGridView dgvPreviousOrders;
        private System.Windows.Forms.Button btnOldOrdersPrevious;
        private System.Windows.Forms.Button btnOldOrdersNext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOrderSerial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblReceiptSerial;
        private System.Windows.Forms.Label lblReceiptID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblReceiptTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOrderCancel;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.Label lblPlaceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnVoucher;
    }
}