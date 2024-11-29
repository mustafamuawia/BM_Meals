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
    public partial class frmWaiters : Form
    {
        public frmWaiters()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ((frmSales)Application.OpenForms["frmSales"]).WaiterID = int.Parse(((Control)sender).Name);
            
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void frmWaiters_Load(object sender, EventArgs e)
        {
            BM_MealsDBContext BM_MealsDC = new BM_MealsDBContext();
            
            var _Waiters = (from _Waiter in BM_MealsDC.Waiters
                           select _Waiter).ToList<Waiter>();


            foreach (Waiter _Waiter in _Waiters)
            {


                Button btnWaiter = new Button();
                btnWaiter.Name = _Waiter.WaiterID.ToString();
                btnWaiter.Text = _Waiter.WaiterName;
                btnWaiter.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnWaiter.ForeColor = System.Drawing.Color.Purple;

                btnWaiter.UseVisualStyleBackColor = true;
                btnWaiter.Size = new System.Drawing.Size(111, 96);
                btnWaiter.Click += new EventHandler(btn_Click);

                this.flpWaiters.Controls.Add(btnWaiter);

            }
        }
    }
}
