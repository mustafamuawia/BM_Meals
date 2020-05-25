namespace BM_Meals
{
    partial class frmOldReceiptSearch
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
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chPeriod = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchOldReceiptsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbPlaces = new System.Windows.Forms.ComboBox();
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbLocations = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchOldReceiptsResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateTo.Enabled = false;
            this.dtpDateTo.Font = new System.Drawing.Font("Arial", 12.25F);
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(700, 83);
            this.dtpDateTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpDateTo.RightToLeftLayout = true;
            this.dtpDateTo.Size = new System.Drawing.Size(235, 26);
            this.dtpDateTo.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12.25F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(700, 18);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 26);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label2.Location = new System.Drawing.Point(962, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "إلى:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label1.Location = new System.Drawing.Point(962, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "يوم:";
            // 
            // chPeriod
            // 
            this.chPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chPeriod.AutoSize = true;
            this.chPeriod.Location = new System.Drawing.Point(1039, 91);
            this.chPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.chPeriod.Name = "chPeriod";
            this.chPeriod.Size = new System.Drawing.Size(15, 14);
            this.chPeriod.TabIndex = 21;
            this.chPeriod.UseVisualStyleBackColor = true;
            this.chPeriod.CheckedChanged += new System.EventHandler(this.chPeriod_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.searchOldReceiptsResultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(156, 161);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(900, 306);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSearch.Location = new System.Drawing.Point(300, 82);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 32);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbPlaces
            // 
            this.cbPlaces.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPlaces.DataSource = this.placeBindingSource;
            this.cbPlaces.DisplayMember = "PlaceName";
            this.cbPlaces.FormattingEnabled = true;
            this.cbPlaces.Location = new System.Drawing.Point(464, 21);
            this.cbPlaces.Name = "cbPlaces";
            this.cbPlaces.Size = new System.Drawing.Size(121, 26);
            this.cbPlaces.TabIndex = 24;
            this.cbPlaces.ValueMember = "PlaceID";
            this.cbPlaces.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // placeBindingSource
            // 
            this.placeBindingSource.DataSource = typeof(BM_Meals.Place);
            // 
            // cbLocations
            // 
            this.cbLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLocations.DataSource = this.locationBindingSource;
            this.cbLocations.DisplayMember = "LocationName";
            this.cbLocations.FormattingEnabled = true;
            this.cbLocations.Location = new System.Drawing.Point(464, 86);
            this.cbLocations.Name = "cbLocations";
            this.cbLocations.Size = new System.Drawing.Size(121, 26);
            this.cbLocations.TabIndex = 24;
            this.cbLocations.ValueMember = "LocationID";
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataSource = typeof(BM_Meals.Location);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label3.Location = new System.Drawing.Point(592, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "الأماكن:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label4.Location = new System.Drawing.Point(592, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "مكان الطلب:";
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPaymentMethod.DisplayMember = "PlaceName";
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "نقداً",
            "اجل"});
            this.cbPaymentMethod.Location = new System.Drawing.Point(300, 21);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbPaymentMethod.Size = new System.Drawing.Size(112, 26);
            this.cbPaymentMethod.TabIndex = 24;
            this.cbPaymentMethod.Text = "نقداً";
            this.cbPaymentMethod.ValueMember = "PlaceID";
            this.cbPaymentMethod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox3_KeyPress);
            // 
            // frmOldReceiptSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1102, 512);
            this.Controls.Add(this.cbLocations);
            this.Controls.Add(this.cbPaymentMethod);
            this.Controls.Add(this.cbPlaces);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chPeriod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOldReceiptSearch";
            this.Text = "الايصالات القديمة";
            this.Load += new System.EventHandler(this.frmOldReceiptSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchOldReceiptsResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chPeriod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn رقمالوصلDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn المتسلسلDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn تاريخالوصلDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn الجملةDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn مكانالطلبDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource searchOldReceiptsResultBindingSource;
        private System.Windows.Forms.ComboBox cbPlaces;
        private System.Windows.Forms.BindingSource placeBindingSource;
        private System.Windows.Forms.ComboBox cbLocations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
    }
}