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
    }
}