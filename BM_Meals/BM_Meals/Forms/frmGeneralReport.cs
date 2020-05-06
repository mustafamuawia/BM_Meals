using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace JFood
{
    public partial class frmGeneralReport : Form
    {
        JFoodDataContext JFoodDC;
        public frmGeneralReport()
        {
            InitializeComponent();
        }

        private void frmDeleteReceipt_Load(object sender, EventArgs e)
        {
            JFoodDC = new JFoodDataContext();
            //this.reportViewer1.RefreshReport();
        }

        private void btnOpenReciept_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Header", "فول وتميس افغاني"));

            if (chPeriod.Checked)
            {
                rptGeneralResultBindingSource.DataSource = JFoodDC.rptGeneral(dateTimePicker1.Value.Date, dtpDateTo.Value.AddDays(1).Date);
                rptSalesServiceResultBindingSource.DataSource = JFoodDC.rptGeneral(dateTimePicker1.Value.Date, dtpDateTo.Value.AddDays(1).Date);
                reportViewer1.LocalReport.SetParameters(new ReportParameter("FromDate", dateTimePicker1.Value.Date.ToShortDateString()));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("ToDate", dtpDateTo.Value.Date.ToShortDateString()));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("boolDay", false.ToString()));
            
            }
            else
            {
                rptGeneralResultBindingSource.DataSource = JFoodDC.rptGeneral(dateTimePicker1.Value.Date, dateTimePicker1.Value.Date.AddDays(1));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("FromDate", dateTimePicker1.Value.Date.ToShortDateString()));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("ToDate", dtpDateTo.Value.Date.ToShortDateString()));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("boolDay", true.ToString()));
            
            }
            reportViewer1.RefreshReport();
            
        }

        private void chPeriod_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateTo.Enabled = chPeriod.Checked;
        }

        
    }
}