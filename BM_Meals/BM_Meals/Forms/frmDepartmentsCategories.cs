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
    public partial class frmDepartmentsCategories : Form
    {
        IQueryable Waiters;
        IQueryable Categories;
        IQueryable Departments;
        BM_Meals.BM_MealsDBContext BM_MealsDC;
        public frmDepartmentsCategories()
        {
            InitializeComponent();
        }

        private void frmDepartmentsCategories_Load(object sender, EventArgs e)
        {
            BM_MealsDC = new BM_Meals.BM_MealsDBContext();
            Waiters = from _Waiter in BM_MealsDC.Waiters select _Waiter;
            Categories = from _Category in BM_MealsDC.Categories select _Category;
            Departments = from _Dpartment in BM_MealsDC.Departments select _Dpartment;
            
            
            waiterBindingSource.DataSource = BM_MealsDC.Waiters;
            categoryBindingSource.DataSource = BM_MealsDC.Categories;
            departmentBindingSource.DataSource = BM_MealsDC.Departments;
            dgvWaiters.DataSource = waiterBindingSource;
            dgvCategories.DataSource = categoryBindingSource;
            dgvDepartments.DataSource = departmentBindingSource;
        }

      
        private void btnSaveDepartment_Click(object sender, EventArgs e)
        {

            dgvCategories.EndEdit();
           // BM_MealsDC.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, Categories);
            //BM_MealsDC.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, Departments);

            //BM_MealsDC.SubmitChanges();

            frmDepartmentsCategories_Load(null, null);
            MessageBox.Show("تم الحفظ");
        }

        private void btnSaveCategories_Click(object sender, EventArgs e)
        {
            
            dgvCategories.EndEdit();

            //BM_MealsDC.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, Waiters);
            //BM_MealsDC.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, Departments);
            //BM_MealsDC.SubmitChanges();
            frmDepartmentsCategories_Load(null, null);
            MessageBox.Show("تم الحفظ");
        }

        private void btnSaveWaiters_Click(object sender, EventArgs e)
        {
            
            dgvWaiters.EndEdit();
            //BM_MealsDC.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, Categories);
            //BM_MealsDC.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, Departments);
            
            //BM_MealsDC.SubmitChanges();
            frmDepartmentsCategories_Load(null, null);
            MessageBox.Show("تم الحفظ");
        }
    }
}
