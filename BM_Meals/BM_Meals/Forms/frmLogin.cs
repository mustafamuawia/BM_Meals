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
    public partial class frmLogin : Form
    {
        public static int UserID;
        BM_MealsDBContext BM_MealsDC; 
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            BM_MealsDC= new BM_MealsDBContext();

            var UsersTable = (from Users in BM_MealsDC.Users
                              where Users.UserID != frmLogin.UserID
                              select Users).ToList();

            cbUsers.DataSource = UsersTable;
            cbUsers.DisplayMember = "Username";
            cbUsers.ValueMember = "UserID";
            if (cbUsers.Items.Count != 0)
                cbUsers.SelectedIndex = 0;


        }

        private void btn_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Control)sender).Text;
            textBox1.Focus();
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                char pw= (char)e.KeyChar;
                textBox1.Text += pw;
            }
            else if (e.KeyChar == (char)8 && textBox1.Text.Length != 0)
            {
                string PW = textBox1.Text;
                PW = PW.Substring(0, PW.Length - 1);
                textBox1.Text = PW;
            }
            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            
            User varUser = BM_MealsDC.Users.SingleOrDefault(User =>User.Username==cbUsers.Text && User.UserPassword==textBox1.Text && User.UserStatus == "مفعل");
            if (varUser != null)
            {
                errorProvider1.SetError(textBox1, "");
                UserID = varUser.UserID;
                frmMain fMain = new frmMain();
                fMain.Show();
                textBox1.Text = "";
                Hide();
            }
            else
            {
                errorProvider1.SetError(textBox1, "خطأ");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnEnter_Click(null,null);
        }

        private void cbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Focus();            
        }

        private void cbUsers_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }
    }
}
