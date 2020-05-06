using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JFood
{
    public partial class frmDepartmentsCategories : Form
    {
        IQueryable Waiters;
        IQueryable Categories;
        IQueryable Departments;
        JFoodDataContext JFoodDC;
        public frmDepartmentsCategories()
        {
            InitializeComponent();
        }

        private void frmDepartmentsCategories_Load(object sender, EventArgs e)
        {
            JFoodDC = new JFoodDataContext();
            Waiters = from _Waiter in JFoodDC.Waiters select _Waiter;
            Categories = from _Category in JFoodDC.Categories select _Category;
            Departments = from _Dpartment in JFoodDC.Departments select _Dpartment;
            
            
            waiterBindingSource.DataSource = JFoodDC.Waiters;
            categoryBindingSource.DataSource = JFoodDC.Categories;
            departmentBindingSource.DataSource = JFoodDC.Departments;
            dgvWaiters.DataSource = waiterBindingSource;
            dgvCategories.DataSource = categoryBindingSource;
            dgvDepartments.DataSource = departmentBindingSource;
        }

      
        private void btnSaveDepartment_Click(object sender, EventArgs e)
        {

            dgvCategories.EndEdit();
            JFoodDC.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, Categories);
            JFoodDC.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, Departments);

            JFoodDC.SubmitChanges();

            frmDepartmentsCategories_Load(null, null);
            MessageBox.Show("تم الحفظ");
        }

        private void btnSaveCategories_Click(object sender, EventArgs e)
        {
            
            dgvCategories.EndEdit();

            JFoodDC.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, Waiters);
            JFoodDC.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, Departments);
            JFoodDC.SubmitChanges();
            frmDepartmentsCategories_Load(null, null);
            MessageBox.Show("تم الحفظ");
        }

        private void btnSaveWaiters_Click(object sender, EventArgs e)
        {
            
            dgvWaiters.EndEdit();
            JFoodDC.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, Categories);
            JFoodDC.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, Departments);
            
            JFoodDC.SubmitChanges();
            frmDepartmentsCategories_Load(null, null);
            MessageBox.Show("تم الحفظ");
        }
    }
}
