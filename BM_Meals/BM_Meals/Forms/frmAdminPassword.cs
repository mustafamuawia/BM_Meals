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
    public partial class frmAdminPassword : Form
    {
        BM_MealsDBContext BM_MealsDC;
        int UserID;
        string txtFocused = "Password";
        public frmAdminPassword()
        {
            BM_MealsDC = new BM_MealsDBContext();
            InitializeComponent();
            
                
        }
        private void frmAdminPassword_Load(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            
            if (txtFocused == "PasswordConfirm")
            {
                txtPasswordConfirm.Text += ((Control)sender).Text;
                txtPasswordConfirm.Focus();
                this.ActiveControl = txtPasswordConfirm;
            }
            else
            {
                txtPassword.Text += ((Control)sender).Text;
                txtPassword.Focus();
                this.ActiveControl = txtPassword;
            }

    }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                char pw = (char)e.KeyChar;
                if (txtPasswordConfirm.Focused)
                    txtPasswordConfirm.Text += pw;
                else 
                txtPassword.Text += pw;
            }
            else if (e.KeyChar == (char)8 && txtPassword.Text.Length != 0 && txtPassword.Focused)
            {
                string PW = txtPassword.Text;
                PW = PW.Substring(0, PW.Length - 1);
                txtPassword.Text = PW;
            }
            else if (e.KeyChar == (char)8 && txtPasswordConfirm.Text.Length != 0 && txtPasswordConfirm.Focused)
            {
                string PW = txtPasswordConfirm.Text;
                PW = PW.Substring(0, PW.Length - 1);
                txtPasswordConfirm.Text = PW;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {


            if (txtPasswordConfirm.Text == "")
                errorProvider1.SetError(txtPasswordConfirm, "كلمة المرور لا يمكن ان تكون فارغة");
            else if (txtPasswordConfirm.Text != txtPassword.Text)
                errorProvider1.SetError(txtPasswordConfirm, "لا بد من مطابقة كلمة المرور مع التأكيد");
            else
            {
                User _user = new User();
                _user.Username = "Admin";
                _user.UserPassword = txtPasswordConfirm.Text;
                _user.UserRole = "Admin";
                _user.UserStatus = "Active";
                BM_MealsDC.Users.Add(_user);
                BM_MealsDC.SaveChanges();
                Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnEnter_Click(null, null);
        }

      
        private void cbUsers_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtFocused = "Password";
        }

        private void txtPasswordConfirm_Click(object sender, EventArgs e)
        {
            txtFocused = "PasswordConfirm";
        }
    }
}   