using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BM_Meals
{
    public partial class frmRoles : Form
    {
        //dsPosTableAdapters.UsersTableAdapter uta;
        //dsPos.UsersDataTable udt;
        string UserName;
        BMMealsDBContext JFoodDC;
        User varUsers;
        public frmRoles()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //if (e.CloseReason == CloseReason.WindowsShutDown) return;

            //// Confirm user wants to close
            //switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            //{
            //    case DialogResult.No:
            //        e.Cancel = true;
            //        break;
            //    default:
            //        {
            //frmSettings f = (frmSettings)Application.OpenForms["frmSettings"];
            //f.Show();
            //this.Dispose();
            //        }
            //        break;
            //}
        }

        private void InitialUsersListBox()
        {
            //lvUsers.Items.Clear();

            //if (udt.Rows.Count != 0)
            //{
            //    foreach (DataRow UserRow in udt.Rows)
            //    {
            //        if (UserRow["USERROLE"].ToString() != "Admin"
            //             && UserRow["USERROLE"].ToString() != this.UserName)
            //        {
            //            ListViewItem lvi = new ListViewItem(UserRow["username"].ToString());
            //            lvi.SubItems.Add(UserRow["USERROLE"].ToString());
            //            lvUsers.Items.Add(lvi);
            //        }
            //    }
            //}
        }

        private void InitialUsersComboBox()
        {
            //try
            //{
            //    cbUsers.SelectedIndexChanged -= new EventHandler(cbUsers_SelectedIndexChanged);
            //    cbUsers.DataSource = udt.Select("Username <> '" + frmMain.strUsername + "'").CopyToDataTable();

            //    cbUsers.DisplayMember = "Username";
            //    cbUsers.ValueMember = "UserID";
            //    cbUsers.SelectedIndexChanged += new EventHandler(cbUsers_SelectedIndexChanged);

            //    if (cbUsers.Items.Count != 0)
            //        //cbUsers.SelectedIndex = 0;
            //        cbUsers_SelectedIndexChanged(null, null);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}
        }

        private void frmUsersManagement_Load(object sender, EventArgs e)
        {
            
            //InitialUsersComboBox();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            this.btnAddNewUser.Enabled = false;
            this.btnCancelAdd.Enabled = true;
            this.btnSaveAdd.Enabled = true;
            this.txtUsername.Enabled = true;
            this.txtName.Enabled = true;
            this.cbUserUSERROLE.Enabled = true;
            this.txtPassword.Enabled = true;
            this.txtPasswordConfirmation.Enabled = true;
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            this.btnAddNewUser.Enabled = true;
            this.btnCancelAdd.Enabled = false;
            this.btnSaveAdd.Enabled = false;
            this.cbUserUSERROLE.Enabled = false;
            this.txtUsername.Clear();
            this.txtUsername.Enabled = false;
            this.txtPassword.Clear();
            this.txtPassword.Enabled = false;
            this.txtPasswordConfirmation.Clear();
            this.txtPassword.Enabled = false;

        }

        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            if (this.txtUsername.Text == ""
                || this.txtPassword.Text == "")
            {
                MessageBox.Show("تأكد من اسم المستخدم وكلمة المرور");
            }
            else if (this.txtPassword.Text != this.txtPasswordConfirmation.Text)
                MessageBox.Show("كلمة المرور والتأكيد غير متطابقين");
            else
            {
                try
                {

                    int UsersCount = (from _User in JFoodDC.Users
                                      where _User.Username == txtUsername.Text
                                      select _User).Count();
                    if (UsersCount != 0)
                        MessageBox.Show("عفواً هذا المستخدم موجود مسبقا");
                    else
                    {
                        User _user = new User();
                        _user.Username = txtUsername.Text;
                        _user.FullName = txtName.Text;
                        _user.UserPassword = txtPassword.Text;
                        _user.UserRole = cbUserUSERROLE.Text;
                        _user.UserStatus = "مفعل";
                        JFoodDC.Users.InsertOnSubmit(_user);
                        JFoodDC.SubmitChanges();

                        this.btnAddNewUser.Enabled = true;
                        this.btnCancelAdd.Enabled = false;
                        this.btnSaveAdd.Enabled = false;
                        this.txtUsername.Enabled = false;
                        this.txtUsername.Clear();
                        this.txtName.Enabled = false;
                        this.txtName.Clear();
                        this.cbUserUSERROLE.Enabled = false;
                        this.txtPassword.Enabled = false;
                        this.txtPassword.Clear();
                        this.txtPasswordConfirmation.Enabled = false;
                        this.txtPasswordConfirmation.Clear();
                        InitialUsersListBox();
                        InitialUsersComboBox();
                        frmUsersManagement_Load(null, null);
                    }
                }
                catch (Exception sqlex)
                {
                    MessageBox.Show(sqlex.Message.ToString());
                }
                finally
                {

                }
            }
        }


        private void cbUsers_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbAddUser_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbAddUser.Checked == true)
            {
                this.gbAddNewUser.Enabled = true;
                this.gbEditUsers.Enabled = false;
                txtNewUsername.Clear();
                txtNewPassword.Clear();
                txtNewPasswordConfirmation.Clear();
            }
        }

        private void rbEditUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbEditUsers.Checked == true)
            {
                InitialUsersComboBox();
                this.gbAddNewUser.Enabled = false;
                this.gbEditUsers.Enabled = true;

            }
            else
            {
                this.gbAddNewUser.Enabled = false;
                this.gbEditUsers.Enabled = true;
            }

        }

        private void cbUsers_DropDown(object sender, EventArgs e)
        {

        }

        private void cbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbNewUserRole.Text = varUsers.UserRole;
                txtNewUsername.Text = varUsers.Username;
                
            }
            catch (Exception sqlex)
            {
                MessageBox.Show(sqlex.Message.ToString());
            }
        }

        private void btnChangeUSERROLE_Click(object sender, EventArgs e)
        {
            this.cbNewUserRole.Enabled = true;
            this.btnSaveEdit.Enabled = true;
            this.btnCancelEdit.Enabled = true;

        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            int UsersCount = (from _User in JFoodDC.Users
                              where _User.Username == txtNewUsername.Text
                              select _User).Count();
            
            User varUser = (from _User in JFoodDC.Users
                        where _User.UserID == int.Parse(cbUsers.SelectedValue.ToString())
                        select _User).FirstOrDefault();

            if (this.txtNewPassword.Text != this.txtNewPasswordConfirmation.Text)
                MessageBox.Show("كلمة المرور والتأكيد غير متطابقين");

            else if ( UsersCount!= 0)
                MessageBox.Show("عفواً هذا المستخدم موجود مسبقا");

                
            else
            {
                try
                {

                    if (this.txtNewPassword.Text == "")
                    {
                        varUsers.Username = txtNewUsername.Text;
                        varUsers.UserStatus = cbUserStatus.Text;
                        varUser.UserRole = cbNewUserRole.Text;

                    }
                    else
                    {
                        varUsers.Username = txtNewUsername.Text;
                        varUsers.UserStatus = cbUserStatus.Text;
                        varUser.UserRole = cbNewUserRole.Text;
                        varUser.UserPassword = txtNewPasswordConfirmation.Text;
                    }   

                    JFoodDC.SubmitChanges();
                    MessageBox.Show("تم الحفظ بنجاح");
                    frmUsersManagement_Load(null, null);

                }
                catch (Exception ex)
                {

                }
            }
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.cbUsers.Enabled = false;
            this.txtNewPassword.Enabled = true;
            this.txtNewPasswordConfirmation.Enabled = true;
            this.btnCancelEdit.Enabled = true;
            this.btnSaveEdit.Enabled = true;
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            if (this.cbNewUserRole.Enabled == true)
            {
                this.cbNewUserRole.Enabled = false;
                this.cbUsers.Enabled = true;
                this.btnCancelEdit.Enabled = false;
                this.btnSaveEdit.Enabled = false; ;
            }
            else if (this.txtNewUsername.Enabled == true)
            {
                this.cbUsers.Enabled = true;
                this.txtNewUsername.Enabled = false;
                this.txtNewUsername.Clear();
                this.btnCancelEdit.Enabled = false;
                this.btnSaveEdit.Enabled = false; ;
            }
            else if (this.txtNewPassword.Enabled == true)
            {
                this.cbUsers.Enabled = false;
                this.cbUsers.Enabled = true;
                this.txtNewPassword.Enabled = false;
                this.txtNewPassword.Clear();
                this.txtNewPasswordConfirmation.Enabled = false;
                this.txtNewPasswordConfirmation.Clear();
                this.btnCancelEdit.Enabled = false;
                this.btnSaveEdit.Enabled = false; ;
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                InitialUsersListBox();
                InitialUsersComboBox();
                this.cbUsers.Enabled = true;
                this.txtNewPassword.Enabled = false;
                this.txtNewPasswordConfirmation.Enabled = false;
                this.btnCancelEdit.Enabled = false;
                this.btnSaveEdit.Enabled = false;
            }
            catch (Exception sqlex)
            {
                MessageBox.Show(sqlex.Message.ToString());
            }
            finally
            {
                
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ((frmLogin)Application.OpenForms["frmLogin"]).Show();
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "frmLogin")
                    f.Close();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void gbEditUsers_Enter(object sender, EventArgs e)
        {

        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            JFoodDC = new BMMealsDBContext();
            var UsersTable = (from Users in JFoodDC.Users
                             where Users.UserID != frmLogin.UserID
                             select Users).ToList();

            cbUsers.DataSource = UsersTable;
            cbUsers.DisplayMember = "Username";
            cbUsers.ValueMember = "UserID";

            

            //uta = new dsPosTableAdapters.UsersTableAdapter();
            //udt = new dsPos.UsersDataTable();
            //uta.Fill(udt);
            InitialUsersListBox();
            
            // TODO: This line of code loads data into the 'fitnessDataSet.Fitness_Users' table. You can move, or remove it, as needed.
            
            

            cbUserUSERROLE.SelectedIndex = 0;
            
            if (cbUsers.Items.Count!=0)
            cbUsers.SelectedIndex = 0;

        }
    }
}
    

