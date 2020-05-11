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
    public partial class frmUserInfo : Form
    {
        public frmUserInfo()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BM_MealsDBContext BM_MealsDC = new BM_MealsDBContext();
           int OldPassword =   (from _User in BM_MealsDC.Users
                                      where _User.UserPassword == txtOldPassword.Text
                                      select _User).Count();
            if (OldPassword == 0)
                errorProvider1.SetError(txtOldPassword, "كلمة المرور القديمة خطأ");
            else if (txtNewPassword.Text =="")
                errorProvider1.SetError(txtNewPassword, "حقل مطلوب");
            else if (txtNewPassword.Text != txtPasswordConfirm.Text)
                errorProvider1.SetError(txtPasswordConfirm, "لا بد ان يكون مطابق لكلمة المرور الجديدة");
            else
            {
                User _User = (from _user in BM_MealsDC.Users
                              where _user.UserID == frmLogin.UserID
                              select _user).FirstOrDefault();

                _User.UserPassword = txtNewPassword.Text;

                //BM_MealsDC.SubmitChanges();

                txtOldPassword.Text = txtPasswordConfirm.Text = txtNewPassword.Text = "";
                MessageBox.Show("تم تعديل كلمة السر");
            }
        }
    }
}
