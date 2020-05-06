namespace JFood
{
    partial class frmDepartmentsCategories
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
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dgvWaiters = new System.Windows.Forms.DataGridView();
            this.waiterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveCategories = new System.Windows.Forms.Button();
            this.btnSaveWaiters = new System.Windows.Forms.Button();
            this.btnSaveDepartment = new System.Windows.Forms.Button();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.waiterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waiterNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waiterStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaiters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waiterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategories.AutoGenerateColumns = false;
            this.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryIDDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.categoryStatusDataGridViewTextBoxColumn});
            this.dgvCategories.DataSource = this.categoryBindingSource;
            this.dgvCategories.Location = new System.Drawing.Point(727, 94);
            this.dgvCategories.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCategories.Size = new System.Drawing.Size(487, 208);
            this.dgvCategories.TabIndex = 0;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(JFood.Category);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(956, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "المجموعات";
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.AllowUserToDeleteRows = false;
            this.dgvDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartments.AutoGenerateColumns = false;
            this.dgvDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentIDDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvDepartments.DataSource = this.departmentBindingSource;
            this.dgvDepartments.Location = new System.Drawing.Point(727, 343);
            this.dgvDepartments.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvDepartments.Size = new System.Drawing.Size(487, 208);
            this.dgvDepartments.TabIndex = 0;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(JFood.Department);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(978, 321);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاقسام";
            // 
            // dgvWaiters
            // 
            this.dgvWaiters.AllowUserToDeleteRows = false;
            this.dgvWaiters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWaiters.AutoGenerateColumns = false;
            this.dgvWaiters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWaiters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWaiters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.waiterIDDataGridViewTextBoxColumn,
            this.waiterNameDataGridViewTextBoxColumn,
            this.waiterStatusDataGridViewTextBoxColumn});
            this.dgvWaiters.DataSource = this.waiterBindingSource;
            this.dgvWaiters.Location = new System.Drawing.Point(117, 94);
            this.dgvWaiters.Margin = new System.Windows.Forms.Padding(4);
            this.dgvWaiters.Name = "dgvWaiters";
            this.dgvWaiters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvWaiters.Size = new System.Drawing.Size(487, 208);
            this.dgvWaiters.TabIndex = 0;
            // 
            // waiterBindingSource
            // 
            this.waiterBindingSource.DataSource = typeof(JFood.Waiter);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(332, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "الويترس";
            // 
            // btnSaveCategories
            // 
            this.btnSaveCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveCategories.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSaveCategories.Location = new System.Drawing.Point(629, 172);
            this.btnSaveCategories.Name = "btnSaveCategories";
            this.btnSaveCategories.Size = new System.Drawing.Size(91, 48);
            this.btnSaveCategories.TabIndex = 6;
            this.btnSaveCategories.Text = "حفظ";
            this.btnSaveCategories.UseVisualStyleBackColor = false;
            this.btnSaveCategories.Click += new System.EventHandler(this.btnSaveCategories_Click);
            // 
            // btnSaveWaiters
            // 
            this.btnSaveWaiters.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSaveWaiters.Location = new System.Drawing.Point(19, 172);
            this.btnSaveWaiters.Name = "btnSaveWaiters";
            this.btnSaveWaiters.Size = new System.Drawing.Size(91, 48);
            this.btnSaveWaiters.TabIndex = 6;
            this.btnSaveWaiters.Text = "حفظ";
            this.btnSaveWaiters.UseVisualStyleBackColor = false;
            this.btnSaveWaiters.Click += new System.EventHandler(this.btnSaveWaiters_Click);
            // 
            // btnSaveDepartment
            // 
            this.btnSaveDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDepartment.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSaveDepartment.Location = new System.Drawing.Point(629, 390);
            this.btnSaveDepartment.Name = "btnSaveDepartment";
            this.btnSaveDepartment.Size = new System.Drawing.Size(91, 48);
            this.btnSaveDepartment.TabIndex = 6;
            this.btnSaveDepartment.Text = "حفظ";
            this.btnSaveDepartment.UseVisualStyleBackColor = false;
            this.btnSaveDepartment.Click += new System.EventHandler(this.btnSaveDepartment_Click);
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "الرقم";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "اسم المجموعة";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // categoryStatusDataGridViewTextBoxColumn
            // 
            this.categoryStatusDataGridViewTextBoxColumn.DataPropertyName = "CategoryStatus";
            this.categoryStatusDataGridViewTextBoxColumn.HeaderText = "الحالة";
            this.categoryStatusDataGridViewTextBoxColumn.Name = "categoryStatusDataGridViewTextBoxColumn";
            this.categoryStatusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryStatusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "الرقم";
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            this.departmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "القسم";
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "الحالة";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // waiterIDDataGridViewTextBoxColumn
            // 
            this.waiterIDDataGridViewTextBoxColumn.DataPropertyName = "WaiterID";
            this.waiterIDDataGridViewTextBoxColumn.HeaderText = "الرقم";
            this.waiterIDDataGridViewTextBoxColumn.Name = "waiterIDDataGridViewTextBoxColumn";
            // 
            // waiterNameDataGridViewTextBoxColumn
            // 
            this.waiterNameDataGridViewTextBoxColumn.DataPropertyName = "WaiterName";
            this.waiterNameDataGridViewTextBoxColumn.HeaderText = "الاسم";
            this.waiterNameDataGridViewTextBoxColumn.Name = "waiterNameDataGridViewTextBoxColumn";
            // 
            // waiterStatusDataGridViewTextBoxColumn
            // 
            this.waiterStatusDataGridViewTextBoxColumn.DataPropertyName = "WaiterStatus";
            this.waiterStatusDataGridViewTextBoxColumn.HeaderText = "الحالة";
            this.waiterStatusDataGridViewTextBoxColumn.Name = "waiterStatusDataGridViewTextBoxColumn";
            this.waiterStatusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.waiterStatusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmDepartmentsCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1245, 581);
            this.Controls.Add(this.btnSaveWaiters);
            this.Controls.Add(this.btnSaveDepartment);
            this.Controls.Add(this.btnSaveCategories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDepartments);
            this.Controls.Add(this.dgvWaiters);
            this.Controls.Add(this.dgvCategories);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Name = "frmDepartmentsCategories";
            this.Text = "الاقسام والمجموعات";
            this.Load += new System.EventHandler(this.frmDepartmentsCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaiters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waiterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvWaiters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.BindingSource waiterBindingSource;
        private System.Windows.Forms.Button btnSaveCategories;
        private System.Windows.Forms.Button btnSaveWaiters;
        private System.Windows.Forms.Button btnSaveDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn categoryStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waiterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waiterNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn waiterStatusDataGridViewTextBoxColumn;
    }
}