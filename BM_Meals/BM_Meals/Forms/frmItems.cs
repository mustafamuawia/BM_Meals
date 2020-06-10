using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;

namespace BM_Meals
{
    public partial class frmItems : Form
    {
        Item Items;
        Category Categories;
        Department Department;
        BM_MealsDBContext BM_MealsDC;
        public frmItems()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvItems.EndEdit();
            BM_MealsDC.SaveChanges();
            MessageBox.Show("تم الحفظ بنجاح");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BM_MealsDC = new BM_MealsDBContext();
            BM_MealsDC.Departments.Load();
            BM_MealsDC.Items.Load();
            BM_MealsDC.Categories.Load();
            itemBindingSource.DataSource = BM_MealsDC.Items.Local.ToBindingList<Item>();
            categoryBindingSource.DataSource = BM_MealsDC.Categories.Local.ToBindingList<Category>();
            departmentBindingSource.DataSource = BM_MealsDC.Departments.Local.ToBindingList<Department>();
            dgvItems.DataSource = itemBindingSource;
            
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 7)// 10th column the button
            {
                dgvItems.EndEdit();
                BM_MealsDC.SaveChanges();
                MessageBox.Show("تم الحفظ بنجاح");
            }
            if (e.ColumnIndex == 8)// 10th column the button
            {

                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "رسالة تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    //dgvItems.Rows.Remove(dgvItems.Rows[e.RowIndex]);
                    dgvItems.Rows.Remove(dgvItems.Rows[e.RowIndex]);
                    BM_MealsDC.SaveChanges();
                    dgvItems.Refresh();
                }
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}