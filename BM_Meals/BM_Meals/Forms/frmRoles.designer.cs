namespace JFood
{
    partial class frmRoles
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbUserStatus = new System.Windows.Forms.ComboBox();
            this.gbEditUsers = new System.Windows.Forms.GroupBox();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.cbNewUserRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSaveAdd = new System.Windows.Forms.Button();
            this.rbEditUsers = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.rbAddUser = new System.Windows.Forms.RadioButton();
            this.cbUserUSERROLE = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.gbAddNewUser = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbEditUsers.SuspendLayout();
            this.gbAddNewUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(330, 39);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المستخدم:";
            // 
            // cbUserStatus
            // 
            this.cbUserStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserStatus.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbUserStatus.FormattingEnabled = true;
            this.cbUserStatus.Items.AddRange(new object[] {
            "مفعل",
            "معطل",
            "محذوف"});
            this.cbUserStatus.Location = new System.Drawing.Point(154, 111);
            this.cbUserStatus.Name = "cbUserStatus";
            this.cbUserStatus.Size = new System.Drawing.Size(224, 27);
            this.cbUserStatus.TabIndex = 1;
            // 
            // gbEditUsers
            // 
            this.gbEditUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEditUsers.Controls.Add(this.cbUsers);
            this.gbEditUsers.Controls.Add(this.cbUserStatus);
            this.gbEditUsers.Controls.Add(this.cbNewUserRole);
            this.gbEditUsers.Controls.Add(this.label4);
            this.gbEditUsers.Controls.Add(this.txtNewPasswordConfirmation);
            this.gbEditUsers.Controls.Add(this.txtNewUsername);
            this.gbEditUsers.Controls.Add(this.txtNewPassword);
            this.gbEditUsers.Controls.Add(this.btnSaveEdit);
            this.gbEditUsers.Controls.Add(this.label5);
            this.gbEditUsers.Controls.Add(this.btnCancelEdit);
            this.gbEditUsers.Controls.Add(this.label7);
            this.gbEditUsers.Controls.Add(this.label8);
            this.gbEditUsers.Controls.Add(this.label11);
            this.gbEditUsers.Controls.Add(this.label6);
            this.gbEditUsers.Enabled = false;
            this.gbEditUsers.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbEditUsers.Location = new System.Drawing.Point(29, 66);
            this.gbEditUsers.Name = "gbEditUsers";
            this.gbEditUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbEditUsers.Size = new System.Drawing.Size(525, 351);
            this.gbEditUsers.TabIndex = 23;
            this.gbEditUsers.TabStop = false;
            this.gbEditUsers.Text = "تعديل مستخدم";
            // 
            // cbUsers
            // 
            this.cbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsers.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Items.AddRange(new object[] {
            "مدير",
            "عادي"});
            this.cbUsers.Location = new System.Drawing.Point(154, 29);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(224, 27);
            this.cbUsers.TabIndex = 14;
            // 
            // cbNewUserRole
            // 
            this.cbNewUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNewUserRole.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbNewUserRole.FormattingEnabled = true;
            this.cbNewUserRole.Items.AddRange(new object[] {
            "مدير",
            "عادي"});
            this.cbNewUserRole.Location = new System.Drawing.Point(154, 71);
            this.cbNewUserRole.Name = "cbNewUserRole";
            this.cbNewUserRole.Size = new System.Drawing.Size(224, 27);
            this.cbNewUserRole.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(384, 253);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "تأكيد كلمة المرور:";
            // 
            // txtNewPasswordConfirmation
            // 
            this.txtNewPasswordConfirmation.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtNewPasswordConfirmation.Location = new System.Drawing.Point(154, 250);
            this.txtNewPasswordConfirmation.Name = "txtNewPasswordConfirmation";
            this.txtNewPasswordConfirmation.PasswordChar = '*';
            this.txtNewPasswordConfirmation.Size = new System.Drawing.Size(224, 27);
            this.txtNewPasswordConfirmation.TabIndex = 13;
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtNewUsername.Location = new System.Drawing.Point(154, 162);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(224, 27);
            this.txtNewUsername.TabIndex = 13;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtNewPassword.Location = new System.Drawing.Point(154, 207);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(224, 27);
            this.txtNewPassword.TabIndex = 13;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSaveEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSaveEdit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEdit.ForeColor = System.Drawing.Color.Black;
            this.btnSaveEdit.Location = new System.Drawing.Point(274, 293);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSaveEdit.Size = new System.Drawing.Size(104, 50);
            this.btnSaveEdit.TabIndex = 11;
            this.btnSaveEdit.Text = "حفظ";
            this.btnSaveEdit.UseVisualStyleBackColor = false;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(397, 29);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(122, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "اسم المستخدم:";
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCancelEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelEdit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEdit.ForeColor = System.Drawing.Color.Black;
            this.btnCancelEdit.Location = new System.Drawing.Point(154, 293);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancelEdit.Size = new System.Drawing.Size(104, 50);
            this.btnCancelEdit.TabIndex = 11;
            this.btnCancelEdit.Text = "الغاء";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(397, 114);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "الحالة:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(397, 74);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "الصلاحية:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label11.Location = new System.Drawing.Point(390, 165);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(122, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "اسم المستخدم:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(384, 210);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "كلمة المرور:";
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCancelAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelAdd.Enabled = false;
            this.btnCancelAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAdd.ForeColor = System.Drawing.Color.Black;
            this.btnCancelAdd.Location = new System.Drawing.Point(58, 234);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancelAdd.Size = new System.Drawing.Size(104, 56);
            this.btnCancelAdd.TabIndex = 11;
            this.btnCancelAdd.Text = "إلغاء";
            this.btnCancelAdd.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label10.Location = new System.Drawing.Point(1202, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "المستخدمين";
            // 
            // btnSaveAdd
            // 
            this.btnSaveAdd.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSaveAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSaveAdd.Enabled = false;
            this.btnSaveAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAdd.ForeColor = System.Drawing.Color.Black;
            this.btnSaveAdd.Location = new System.Drawing.Point(281, 234);
            this.btnSaveAdd.Name = "btnSaveAdd";
            this.btnSaveAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSaveAdd.Size = new System.Drawing.Size(104, 56);
            this.btnSaveAdd.TabIndex = 11;
            this.btnSaveAdd.Text = "حفظ";
            this.btnSaveAdd.UseVisualStyleBackColor = false;
            this.btnSaveAdd.Click += new System.EventHandler(this.btnSaveAdd_Click);
            // 
            // rbEditUsers
            // 
            this.rbEditUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbEditUsers.AutoSize = true;
            this.rbEditUsers.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rbEditUsers.Location = new System.Drawing.Point(425, 12);
            this.rbEditUsers.Name = "rbEditUsers";
            this.rbEditUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbEditUsers.Size = new System.Drawing.Size(129, 23);
            this.rbEditUsers.TabIndex = 21;
            this.rbEditUsers.Text = "تعديل مستخدم";
            this.rbEditUsers.UseVisualStyleBackColor = true;
            this.rbEditUsers.CheckedChanged += new System.EventHandler(this.rbEditUsers_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(330, 192);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "تأكيد كلمة المرور:";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPassword.Location = new System.Drawing.Point(82, 152);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(224, 27);
            this.txtPassword.TabIndex = 13;
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtUsername.Location = new System.Drawing.Point(82, 36);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(224, 27);
            this.txtUsername.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(330, 155);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "كلمة المرور:";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.SkyBlue;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(483, 466);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(104, 56);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddNewUser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddNewUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewUser.Location = new System.Drawing.Point(173, 234);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddNewUser.Size = new System.Drawing.Size(104, 56);
            this.btnAddNewUser.TabIndex = 11;
            this.btnAddNewUser.Text = "إضافة المستخدم";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // rbAddUser
            // 
            this.rbAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAddUser.AutoSize = true;
            this.rbAddUser.Checked = true;
            this.rbAddUser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rbAddUser.Location = new System.Drawing.Point(850, 12);
            this.rbAddUser.Name = "rbAddUser";
            this.rbAddUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbAddUser.Size = new System.Drawing.Size(167, 23);
            this.rbAddUser.TabIndex = 20;
            this.rbAddUser.TabStop = true;
            this.rbAddUser.Text = "إضافة مستخدم جديد";
            this.rbAddUser.UseVisualStyleBackColor = true;
            this.rbAddUser.CheckedChanged += new System.EventHandler(this.rbAddUser_CheckedChanged);
            // 
            // cbUserUSERROLE
            // 
            this.cbUserUSERROLE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserUSERROLE.Enabled = false;
            this.cbUserUSERROLE.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbUserUSERROLE.FormattingEnabled = true;
            this.cbUserUSERROLE.Items.AddRange(new object[] {
            "عادي",
            "مدير"});
            this.cbUserUSERROLE.Location = new System.Drawing.Point(82, 114);
            this.cbUserUSERROLE.Name = "cbUserUSERROLE";
            this.cbUserUSERROLE.Size = new System.Drawing.Size(224, 27);
            this.cbUserUSERROLE.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.Location = new System.Drawing.Point(330, 117);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "الصلاحية:";
            // 
            // txtPasswordConfirmation
            // 
            this.txtPasswordConfirmation.Enabled = false;
            this.txtPasswordConfirmation.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPasswordConfirmation.Location = new System.Drawing.Point(82, 189);
            this.txtPasswordConfirmation.Name = "txtPasswordConfirmation";
            this.txtPasswordConfirmation.PasswordChar = '*';
            this.txtPasswordConfirmation.Size = new System.Drawing.Size(224, 27);
            this.txtPasswordConfirmation.TabIndex = 13;
            // 
            // gbAddNewUser
            // 
            this.gbAddNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAddNewUser.Controls.Add(this.label12);
            this.gbAddNewUser.Controls.Add(this.txtName);
            this.gbAddNewUser.Controls.Add(this.cbUserUSERROLE);
            this.gbAddNewUser.Controls.Add(this.label3);
            this.gbAddNewUser.Controls.Add(this.label9);
            this.gbAddNewUser.Controls.Add(this.label1);
            this.gbAddNewUser.Controls.Add(this.txtPasswordConfirmation);
            this.gbAddNewUser.Controls.Add(this.txtPassword);
            this.gbAddNewUser.Controls.Add(this.txtUsername);
            this.gbAddNewUser.Controls.Add(this.btnSaveAdd);
            this.gbAddNewUser.Controls.Add(this.btnCancelAdd);
            this.gbAddNewUser.Controls.Add(this.label2);
            this.gbAddNewUser.Controls.Add(this.btnAddNewUser);
            this.gbAddNewUser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbAddNewUser.Location = new System.Drawing.Point(569, 66);
            this.gbAddNewUser.Name = "gbAddNewUser";
            this.gbAddNewUser.Size = new System.Drawing.Size(475, 331);
            this.gbAddNewUser.TabIndex = 22;
            this.gbAddNewUser.TabStop = false;
            this.gbAddNewUser.Text = "إضافة مستخدم جديد";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1055, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(258, 559);
            this.dataGridView1.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label12.Location = new System.Drawing.Point(330, 77);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(56, 19);
            this.label12.TabIndex = 14;
            this.label12.Text = "الاسم:";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtName.Location = new System.Drawing.Point(82, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 27);
            this.txtName.TabIndex = 15;
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 706);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbEditUsers);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rbEditUsers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rbAddUser);
            this.Controls.Add(this.gbAddNewUser);
            this.Font = new System.Drawing.Font("Arial", 8F);
            this.Name = "frmRoles";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "المستخدمين والصلاحيات";
            this.Load += new System.EventHandler(this.frmRoles_Load);
            this.gbEditUsers.ResumeLayout(false);
            this.gbEditUsers.PerformLayout();
            this.gbAddNewUser.ResumeLayout(false);
            this.gbAddNewUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUserStatus;
        private System.Windows.Forms.GroupBox gbEditUsers;
        private System.Windows.Forms.ComboBox cbNewUserRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewPasswordConfirmation;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSaveAdd;
        private System.Windows.Forms.RadioButton rbEditUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.RadioButton rbAddUser;
        private System.Windows.Forms.ComboBox cbUserUSERROLE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPasswordConfirmation;
        private System.Windows.Forms.GroupBox gbAddNewUser;
        
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtName;
    }
}