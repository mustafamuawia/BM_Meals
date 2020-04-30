namespace BM_Meals
{
    partial class frmrptSales
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.nudToMins = new System.Windows.Forms.NumericUpDown();
            this.nudFromMins = new System.Windows.Forms.NumericUpDown();
            this.cbToHrs = new System.Windows.Forms.ComboBox();
            this.cbTott = new System.Windows.Forms.ComboBox();
            this.cbFromHrs = new System.Windows.Forms.ComboBox();
            this.cbFromtt = new System.Windows.Forms.ComboBox();
            this.chPeriod = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnOpenReport = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rptSalesResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptSalesServiceResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToMins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromMins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptSalesResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptSalesServiceResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbStatus);
            this.splitContainer1.Panel1.Controls.Add(this.nudToMins);
            this.splitContainer1.Panel1.Controls.Add(this.nudFromMins);
            this.splitContainer1.Panel1.Controls.Add(this.cbToHrs);
            this.splitContainer1.Panel1.Controls.Add(this.cbTott);
            this.splitContainer1.Panel1.Controls.Add(this.cbFromHrs);
            this.splitContainer1.Panel1.Controls.Add(this.cbFromtt);
            this.splitContainer1.Panel1.Controls.Add(this.chPeriod);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.dtpDateTo);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.btnOpenReport);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(668, 655);
            this.splitContainer1.SplitterDistance = 101;
            this.splitContainer1.TabIndex = 3;
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "نقدي",
            "آجل",
            "كبون"});
            this.cbStatus.Location = new System.Drawing.Point(121, 8);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbStatus.Size = new System.Drawing.Size(84, 26);
            this.cbStatus.TabIndex = 21;
            this.cbStatus.Text = "نقدي";
            this.cbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbStatus_KeyPress);
            // 
            // nudToMins
            // 
            this.nudToMins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudToMins.Location = new System.Drawing.Point(276, 56);
            this.nudToMins.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudToMins.Name = "nudToMins";
            this.nudToMins.Size = new System.Drawing.Size(50, 26);
            this.nudToMins.TabIndex = 20;
            // 
            // nudFromMins
            // 
            this.nudFromMins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudFromMins.Location = new System.Drawing.Point(276, 9);
            this.nudFromMins.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudFromMins.Name = "nudFromMins";
            this.nudFromMins.Size = new System.Drawing.Size(50, 26);
            this.nudFromMins.TabIndex = 20;
            // 
            // cbToHrs
            // 
            this.cbToHrs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbToHrs.FormattingEnabled = true;
            this.cbToHrs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbToHrs.Location = new System.Drawing.Point(223, 56);
            this.cbToHrs.Name = "cbToHrs";
            this.cbToHrs.Size = new System.Drawing.Size(47, 26);
            this.cbToHrs.TabIndex = 19;
            this.cbToHrs.Text = "1";
            this.cbToHrs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbFromHrs_KeyPress);
            // 
            // cbTott
            // 
            this.cbTott.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTott.FormattingEnabled = true;
            this.cbTott.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbTott.Location = new System.Drawing.Point(342, 55);
            this.cbTott.Name = "cbTott";
            this.cbTott.Size = new System.Drawing.Size(47, 26);
            this.cbTott.TabIndex = 19;
            this.cbTott.Text = "AM";
            // 
            // cbFromHrs
            // 
            this.cbFromHrs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFromHrs.FormattingEnabled = true;
            this.cbFromHrs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbFromHrs.Location = new System.Drawing.Point(223, 9);
            this.cbFromHrs.Name = "cbFromHrs";
            this.cbFromHrs.Size = new System.Drawing.Size(47, 26);
            this.cbFromHrs.TabIndex = 19;
            this.cbFromHrs.Text = "1";
            this.cbFromHrs.SelectedIndexChanged += new System.EventHandler(this.cbFromHrs_SelectedIndexChanged);
            this.cbFromHrs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbFromHrs_KeyDown);
            this.cbFromHrs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbFromHrs_KeyPress);
            // 
            // cbFromtt
            // 
            this.cbFromtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFromtt.FormattingEnabled = true;
            this.cbFromtt.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbFromtt.Location = new System.Drawing.Point(342, 8);
            this.cbFromtt.Name = "cbFromtt";
            this.cbFromtt.Size = new System.Drawing.Size(47, 26);
            this.cbFromtt.TabIndex = 19;
            this.cbFromtt.Text = "AM";
            // 
            // chPeriod
            // 
            this.chPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chPeriod.AutoSize = true;
            this.chPeriod.Location = new System.Drawing.Point(624, 61);
            this.chPeriod.Name = "chPeriod";
            this.chPeriod.Size = new System.Drawing.Size(15, 14);
            this.chPeriod.TabIndex = 18;
            this.chPeriod.UseVisualStyleBackColor = true;
            this.chPeriod.CheckedChanged += new System.EventHandler(this.chPeriod_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label2.Location = new System.Drawing.Point(586, 59);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "إلى:";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateTo.Font = new System.Drawing.Font("Arial", 12.25F);
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(422, 53);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpDateTo.RightToLeftLayout = true;
            this.dtpDateTo.Size = new System.Drawing.Size(158, 26);
            this.dtpDateTo.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label1.Location = new System.Drawing.Point(586, 11);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "يوم:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12.25F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(422, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 26);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // btnOpenReport
            // 
            this.btnOpenReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenReport.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenReport.Font = new System.Drawing.Font("Arial", 12.25F);
            this.btnOpenReport.Location = new System.Drawing.Point(45, 56);
            this.btnOpenReport.Name = "btnOpenReport";
            this.btnOpenReport.Size = new System.Drawing.Size(84, 31);
            this.btnOpenReport.TabIndex = 13;
            this.btnOpenReport.Text = "فتح التقرير";
            this.btnOpenReport.UseVisualStyleBackColor = false;
            this.btnOpenReport.Click += new System.EventHandler(this.btnOpenReport_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsSales";
            reportDataSource1.Value = this.rptSalesResultBindingSource;
            reportDataSource2.Name = "dsServices";
            reportDataSource2.Value = this.rptSalesServiceResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "JFood.rptSales.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reportViewer1.Size = new System.Drawing.Size(668, 550);
            this.reportViewer1.TabIndex = 0;
            // 
            // rptSalesResultBindingSource
            // 
            this.rptSalesResultBindingSource.DataSource = typeof(BM_Meals.rptSalesResult);
            // 
            // rptSalesServiceResultBindingSource
            // 
            this.rptSalesServiceResultBindingSource.DataSource = typeof(BM_Meals.rptSalesServiceResult);
            // 
            // frmrptSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 655);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmrptSales";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير المبيعات";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmrptSales_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudToMins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromMins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptSalesResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptSalesServiceResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox chPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnOpenReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rptSalesResultBindingSource;
        private System.Windows.Forms.NumericUpDown nudToMins;
        private System.Windows.Forms.NumericUpDown nudFromMins;
        private System.Windows.Forms.ComboBox cbToHrs;
        private System.Windows.Forms.ComboBox cbTott;
        private System.Windows.Forms.ComboBox cbFromHrs;
        private System.Windows.Forms.ComboBox cbFromtt;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.BindingSource rptSalesServiceResultBindingSource;
    }
}