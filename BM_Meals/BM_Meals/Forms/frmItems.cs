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
            //BM_MealsDC.SubmitChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

            Items = new Item();
            Categories = new Category();
            Department = new Department();
            BM_MealsDC = new BM_MealsDBContext();
            //int ReceiptSerial=int.Parse(BM_MealsDC.InsertReceipt(DateTime.Now, 0, 0, 0, 0, 0).ReturnValue.ToString());
            
            itemBindingSource.DataSource = BM_MealsDC.Items;
            categoryBindingSource.DataSource = BM_MealsDC.Categories;
            departmentBindingSource.DataSource = BM_MealsDC.Departments;
            dgvItems.DataSource = itemBindingSource;
            
        }
    }
}