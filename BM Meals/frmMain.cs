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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void الطلباتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmPlacesTables"] != null)
                Application.OpenForms["frmPlacesTables"].Focus();
            else if (Application.OpenForms["frmPlacesTables"] == null)
            {
                frmPlacesTables fPlacesTables = new frmPlacesTables();
                fPlacesTables.Show();
                fPlacesTables.MdiParent = this;
                fPlacesTables.WindowState = FormWindowState.Maximized;
            }
        }

        private void تعريفالاصنفاToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frmItems"] != null)
                Application.OpenForms["frmItems"].Focus();
            else if (Application.OpenForms["frmItems"] == null)
            {
                frmItems fItems = new frmItems();
                fItems.Show();
                fItems.MdiParent = this;
                fItems.WindowState = FormWindowState.Maximized;

            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["frmLogin"].Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmPlacesTables"] != null)
                Application.OpenForms["frmPlacesTables"].Focus();
            else if (Application.OpenForms["frmPlacesTables"] == null)
            {
                frmPlacesTables fPlacesTables = new frmPlacesTables();
                fPlacesTables.Show();
                fPlacesTables.MdiParent = this;
                fPlacesTables.WindowState = FormWindowState.Maximized;

            }

        }

        private void المجموعاتوالاقساموالويترسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmDepartmentsCategories"] != null)
                Application.OpenForms["frmDepartmentsCategories"].Focus();
            else if (Application.OpenForms["frmDepartmentsCategories"] == null)
            {
                frmDepartmentsCategories fDepartmentsCategories = new frmDepartmentsCategories();
                fDepartmentsCategories.Show();
                fDepartmentsCategories.MdiParent = this;
                fDepartmentsCategories.WindowState = FormWindowState.Maximized;
            }
        }

        private void تقريرالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frmrptSales"] != null)
                Application.OpenForms["frmrptSales"].Focus();
            else if (Application.OpenForms["frmrptSales"] == null)
            {
                frmrptSales frptSales = new frmrptSales();
                frptSales.Show();
                frptSales.MdiParent = this;
                frptSales.WindowState = FormWindowState.Maximized;
            }
        }

        private void الايصالاتالقديمةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmOldReceiptSearch"] != null)
                Application.OpenForms["frmOldReceiptSearch"].Focus();
            else if (Application.OpenForms["frmOldReceiptSearch"] == null)
            {
                frmOldReceiptSearch fOldReceiptSearch = new frmOldReceiptSearch();
                fOldReceiptSearch.Show();
                fOldReceiptSearch.MdiParent = this;
                fOldReceiptSearch.WindowState = FormWindowState.Maximized;
            }
        }

        private void التقريرالعامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmGeneralReport"] != null)
                Application.OpenForms["frmGeneralReport"].Focus();
            else if (Application.OpenForms["frmGeneralReport"] == null)
            {
                frmGeneralReport fGeneralReport = new frmGeneralReport();
                fGeneralReport.Show();
                fGeneralReport.MdiParent = this;
                fGeneralReport.WindowState = FormWindowState.Maximized;
            }
        }

        private void تغييركلمةالسرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmUserInfo"] != null)
                Application.OpenForms["frmUserInfo"].Focus();
            else if (Application.OpenForms["frmUserInfo"] == null)
            {
                frmUserInfo fUserInfo = new frmUserInfo();
                fUserInfo.Show();
                fUserInfo.MdiParent = this;
                fUserInfo.WindowState = FormWindowState.Maximized;
            }
        }

        private void ادارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["fRoles"] != null)
                Application.OpenForms["fRoles"].Focus();
            else if (Application.OpenForms["fRoles"] == null)
            {
                frmRoles fRoles = new frmRoles();
                fRoles.Show();
                fRoles.MdiParent = this;
                fRoles.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
