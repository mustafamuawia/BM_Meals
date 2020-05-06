namespace JFood
{
    partial class frmDeleteReceipt
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.prntReceiptReceiptIDResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnOpenReciept = new System.Windows.Forms.Button();
            this.btnDeleteReciept = new System.Windows.Forms.Button();
            this.dtpReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.txtReceiptSerial = new System.Windows.Forms.TextBox();
            this.txtReceiptID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.prntReceiptReceiptIDResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prntReceiptReceiptIDResultBindingSource
            // 
            this.prntReceiptReceiptIDResultBindingSource.DataSource = typeof(JFood.prntReceiptReceiptIDResult);
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
            this.splitContainer1.Panel1.Controls.Add(this.txtReceiptSerial);
            this.splitContainer1.Panel1.Controls.Add(this.txtReceiptID);
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
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(564, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 78);
            this.panel1.TabIndex = 3;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 58);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            this.btnDeleteReciept.Click += new System.EventHandler(this.btnDeleteReciept_Click);
            // 
            // dtpReceiptDate
            // 
            this.dtpReceiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReceiptDate.Location = new System.Drawing.Point(152, 14);
            this.dtpReceiptDate.Name = "dtpReceiptDate";
            this.dtpReceiptDate.Size = new System.Drawing.Size(124, 26);
            this.dtpReceiptDate.TabIndex = 2;
            // 
            // txtReceiptSerial
            // 
            this.txtReceiptSerial.Location = new System.Drawing.Point(383, 64);
            this.txtReceiptSerial.Name = "txtReceiptSerial";
            this.txtReceiptSerial.Size = new System.Drawing.Size(100, 26);
            this.txtReceiptSerial.TabIndex = 1;
            // 
            // txtReceiptID
            // 
            this.txtReceiptID.Location = new System.Drawing.Point(383, 12);
            this.txtReceiptID.Name = "txtReceiptID";
            this.txtReceiptID.Size = new System.Drawing.Size(100, 26);
            this.txtReceiptID.TabIndex = 1;
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
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الإيصال:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "dsPrintReceipt";
            reportDataSource3.Value = this.prntReceiptReceiptIDResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "JFood.Receipt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(668, 541);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmDeleteReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 655);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDeleteReceipt";
            this.ShowIcon = false;
            this.Text = "حذف ايصال";
            this.Load += new System.EventHandler(this.frmDeleteReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prntReceiptReceiptIDResultBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txtReceiptSerial;
        private System.Windows.Forms.TextBox txtReceiptID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnDeleteReciept;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnOpenReciept;
        private System.Windows.Forms.BindingSource prntReceiptReceiptIDResultBindingSource;
    }
}