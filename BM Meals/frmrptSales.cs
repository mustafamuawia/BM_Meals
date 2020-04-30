using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace BM_Meals
{
    public partial class frmrptSales : Form
    {
        
        BMMealsDBContext JFoodDC;
        public frmrptSales()
        {
            InitializeComponent();
        }

        private void chPeriod_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateTo.Enabled = chPeriod.Checked;
           
        }

        private void btnOpenReport_Click(object sender, EventArgs e)
        {
            string strFromTime = dateTimePicker1.Value.Date.ToShortDateString() + " " + cbFromHrs.Text + ":" + nudFromMins.Value.ToString() + " " + cbFromtt.Text;
            string strToTime = dtpDateTo.Value.Date.ToShortDateString() + " " + cbToHrs.Text + ":" + nudToMins.Value.ToString() + " " + cbTott.Text;
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Header", "فول وتميس افغاني"));
            string ReportType = "Cash";
            if (cbStatus.SelectedIndex == 1)
                ReportType = "Credit";
            else if (cbStatus.SelectedIndex == 2)
                ReportType = "Voucher";
            if (chPeriod.Checked)
            {

                if (Convert.ToDateTime(strFromTime) > Convert.ToDateTime(strToTime))
                {
                    MessageBox.Show("تاريخ نهاية الفترة لا بد أن يكون أكبر من تاريخ البداية");
                    dtpDateTo.Focus();
                }
                else
                {
                    
                    rptSalesResultBindingSource.DataSource = JFoodDC.rptSales(Convert.ToDateTime(strFromTime), Convert.ToDateTime(strToTime).AddMinutes(1),ReportType).ToList();
                    rptSalesServiceResultBindingSource.DataSource = JFoodDC.rptSalesService(Convert.ToDateTime(strFromTime), Convert.ToDateTime(strToTime).AddMinutes(1), ReportType).ToList();
                    reportViewer1.RefreshReport();

                    reportViewer1.LocalReport.SetParameters(new ReportParameter("FromDate", strFromTime));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("ToDate", strToTime));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("boolDay", false.ToString()));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportType", ReportType));
                    reportViewer1.RefreshReport();
                }
            }
            else
            {
                rptSalesResultBindingSource.DataSource = JFoodDC.rptSales(Convert.ToDateTime(strFromTime), Convert.ToDateTime(strToTime), ReportType).ToList();
                rptSalesServiceResultBindingSource.DataSource = JFoodDC.rptSalesService(Convert.ToDateTime(strFromTime), Convert.ToDateTime(strToTime), ReportType).ToList();
                reportViewer1.LocalReport.SetParameters(new ReportParameter("FromDate", Convert.ToDateTime(strFromTime).ToShortDateString()));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("ToDate", Convert.ToDateTime(strFromTime).ToLongDateString()));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("boolDay", true.ToString()));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportType", ReportType));
                reportViewer1.RefreshReport();
            }
        }

        private void frmrptSales_Load(object sender, EventArgs e)
        {
            JFoodDC = new BMMealsDBContext();
            
            

            //rptSalesResultBindingSource.DataSource = JFoodDC.rptSales(dateTimePicker1;
            //reportViewer1.RefreshReport();
        }

        private void cbFromHrs_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void cbFromHrs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbFromHrs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
