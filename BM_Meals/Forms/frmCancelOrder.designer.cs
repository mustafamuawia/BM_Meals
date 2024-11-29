namespace BM_Meals
{
    partial class frmCancelOrder
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GetOrderByIDResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbOrderSerial = new System.Windows.Forms.RadioButton();
            this.rbOrderID = new System.Windows.Forms.RadioButton();
            this.btnOpenReciept = new System.Windows.Forms.Button();
            this.btnDeleteReciept = new System.Windows.Forms.Button();
            this.dtpReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.txtOrderSerial = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.GetOrderByIDResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.btnOpenReciept);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteReciept);
            this.splitContainer1.Panel1.Controls.Add(this.dtpReceiptDate);
            this.splitContainer1.Panel1.Controls.Add(this.txtOrderSerial);
            this.splitContainer1.Panel1.Controls.Add(this.txtOrderID);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(668, 655);
            this.splitContainer1.SplitterDistance = 108;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbOrderSerial);
            this.panel1.Controls.Add(this.rbOrderID);
            this.panel1.Location = new System.Drawing.Point(564, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 78);
            this.panel1.TabIndex = 3;
            // 
            // rbOrderSerial
            // 
            this.rbOrderSerial.AutoSize = true;
            this.rbOrderSerial.Location = new System.Drawing.Point(8, 58);
            this.rbOrderSerial.Name = "rbOrderSerial";
            this.rbOrderSerial.Size = new System.Drawing.Size(14, 13);
            this.rbOrderSerial.TabIndex = 0;
            this.rbOrderSerial.UseVisualStyleBackColor = true;
            this.rbOrderSerial.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbOrderID
            // 
            this.rbOrderID.AutoSize = true;
            this.rbOrderID.Checked = true;
            this.rbOrderID.Location = new System.Drawing.Point(8, 11);
            this.rbOrderID.Name = "rbOrderID";
            this.rbOrderID.Size = new System.Drawing.Size(14, 13);
            this.rbOrderID.TabIndex = 0;
            this.rbOrderID.TabStop = true;
            this.rbOrderID.UseVisualStyleBackColor = true;
            this.rbOrderID.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnOpenReciept
            // 
            this.btnOpenReciept.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOpenReciept.Location = new System.Drawing.Point(268, 57);
            this.btnOpenReciept.Name = "btnOpenReciept";
            this.btnOpenReciept.Size = new System.Drawing.Size(58, 38);
            this.btnOpenReciept.TabIndex = 1;
            this.btnOpenReciept.Text = "عرض";
            this.btnOpenReciept.UseVisualStyleBackColor = false;
            this.btnOpenReciept.Click += new System.EventHandler(this.btnOpenReciept_Click);
            // 
            // btnDeleteReciept
            // 
            this.btnDeleteReciept.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeleteReciept.Enabled = false;
            this.btnDeleteReciept.Location = new System.Drawing.Point(152, 57);
            this.btnDeleteReciept.Name = "btnDeleteReciept";
            this.btnDeleteReciept.Size = new System.Drawing.Size(58, 38);
            this.btnDeleteReciept.TabIndex = 1;
            this.btnDeleteReciept.Text = "حذف";
            this.btnDeleteReciept.UseVisualStyleBackColor = false;
            this.btnDeleteReciept.Click += new System.EventHandler(this.btnCancelReciept_Click);
            // 
            // dtpReceiptDate
            // 
            this.dtpReceiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReceiptDate.Location = new System.Drawing.Point(152, 14);
            this.dtpReceiptDate.Name = "dtpReceiptDate";
            this.dtpReceiptDate.Size = new System.Drawing.Size(124, 26);
            this.dtpReceiptDate.TabIndex = 2;
            // 
            // txtOrderSerial
            // 
            this.txtOrderSerial.Location = new System.Drawing.Point(383, 64);
            this.txtOrderSerial.Name = "txtOrderSerial";
            this.txtOrderSerial.Size = new System.Drawing.Size(100, 26);
            this.txtOrderSerial.TabIndex = 1;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(383, 12);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 26);
            this.txtOrderID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "التسلسلي:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "التاريخ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الطلب:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsOrder";
            reportDataSource1.Value = this.GetOrderByIDResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BM_Meals.Order.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(668, 541);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmCancelOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 655);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCancelOrder";
            this.ShowIcon = false;
            this.Text = "حذف طلب";
            this.Load += new System.EventHandler(this.frmDeleteReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetOrderByIDResultBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpReceiptDate;
        private System.Windows.Forms.TextBox txtOrderSerial;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteReciept;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbOrderSerial;
        private System.Windows.Forms.RadioButton rbOrderID;
        private System.Windows.Forms.Button btnOpenReciept;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GetOrderByIDResultBindingSource;
    }
}