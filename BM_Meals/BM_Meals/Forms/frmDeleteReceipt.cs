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
    public partial class frmDeleteReceipt : Form
    {
        JFoodDataContext JFoodDC;
        public frmDeleteReceipt()
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
            
            if (radioButton1.Checked)
            {
                if (txtReceiptID.Text != "")
                {
                    txtReceiptID.Enabled = false;
                    var _Receipt = JFoodDC.prntReceiptReceiptID(int.Parse(txtReceiptID.Text)).ToList();
                    if (_Receipt.Count > 0)
                    {
                        prntReceiptReceiptIDResultBindingSource.DataSource = _Receipt;
                        btnDeleteReciept.Enabled = true;
                    }
                }
            }
            else
            {
                if (txtReceiptSerial.Text != "")
                {
                    txtReceiptSerial.Enabled = false;
                    dtpReceiptDate.Enabled = false;
                    var _Receipt = JFoodDC.prntReceiptSerial(int.Parse(txtReceiptSerial.Text), dtpReceiptDate.Value.Date).ToList();
                    if (_Receipt.Count > 0)
                    {
                        prntReceiptReceiptIDResultBindingSource.DataSource = _Receipt;
                        btnDeleteReciept.Enabled = true;
                    }
                }
            }
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Header", "فول وتميس افغاني"));

            reportViewer1.RefreshReport();
            
        }

        private void btnDeleteReciept_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "هل تود الغاء الوصل", "تنبيه", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (radioButton1.Checked)
                {
                    JFoodDC.CancelReceiptByID(int.Parse(txtReceiptID.Text));

                }
                else
                {
                    JFoodDC.CancelReceiptBySerial(int.Parse(txtReceiptSerial.Text), dtpReceiptDate.Value.Date);
                }
                ((frmPlacesTables)Application.OpenForms["frmPlacesTables"]).IntializePlaces();
                Close();
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtReceiptID.Enabled = radioButton1.Checked;
            txtReceiptSerial.Enabled = radioButton2.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtReceiptID.Enabled = radioButton1.Checked;
            txtReceiptSerial.Enabled = radioButton2.Checked;

        }
    }
}
