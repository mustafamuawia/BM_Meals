using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
namespace JFood
{
    public partial class frmItems : Form
    {
        Item Items;
        Category Categories;
        Department Department;
        JFoodDataContext JFoodDC;
        public frmItems()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvItems.EndEdit();
            JFoodDC.SubmitChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

            Items = new Item();
            Categories = new Category();
            Department = new Department();
            JFoodDC = new JFoodDataContext();
            //int ReceiptSerial=int.Parse(JFoodDC.InsertReceipt(DateTime.Now, 0, 0, 0, 0, 0).ReturnValue.ToString());
            
            itemBindingSource.DataSource = JFoodDC.Items;
            categoryBindingSource.DataSource = JFoodDC.Categories;
            departmentBindingSource.DataSource = JFoodDC.Departments;
            dgvItems.DataSource = itemBindingSource;
            
        }
    }
}