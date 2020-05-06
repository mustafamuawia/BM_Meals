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
    public partial class frmCancelOrder : Form
    {
        JFoodDataContext JFoodDC;
        public frmCancelOrder()
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
                if (txtOrderID.Text != "")
                {
                    txtOrderID.Enabled = false;
                    var _Order = JFoodDC.GetOrderByID(int.Parse(txtOrderID.Text)).ToList();
                    if (_Order.Count > 0)
                    {
                        GetOrderByIDResultBindingSource.DataSource = _Order;
                        btnDeleteReciept.Enabled = true;
                    }
                }
            }
            else
            {
                if (txtOrderSerial.Text != "")
                {
                    txtOrderSerial.Enabled = false;
                    dtpReceiptDate.Enabled = false;
                    var _Order = JFoodDC.GetOrderBySerial(int.Parse(txtOrderSerial.Text), dtpReceiptDate.Value.Date).ToList();
                    if (_Order.Count > 0)
                    {
                        GetOrderByIDResultBindingSource.DataSource = _Order;
                        btnDeleteReciept.Enabled = true;
                    }
                }
            }
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Header", "فول وتميس افغاني"));

            reportViewer1.RefreshReport();
            
        }

        private void btnCancelReciept_Click(object sender, EventArgs e)
        {
            int ReceiptOrders = 0;
            int? ReceiptID = 0;
            if (MessageBox.Show(this, "هل تود الغاء الطلب", "تنبيه", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (radioButton1.Checked)
                {
                    var OrderPlaceID =JFoodDC.GetOrderByID(int.Parse(txtOrderID.Text)).FirstOrDefault().PlaceID;
                    decimal? OrderTotal = JFoodDC.GetOrderByID(int.Parse(txtOrderID.Text)).FirstOrDefault().TotalPrice;
                    JFoodDC.CancelOrderByID(int.Parse(txtOrderID.Text));

                     ReceiptID= JFoodDC.GetOrderByID(int.Parse(txtOrderID.Text)).ToList<GetOrderByIDResult>().FirstOrDefault().ReceiptID;
                     var varReceipt = (from __Receipt in JFoodDC.Receipts
                                       where __Receipt.ReceiptID == ReceiptID
                                       select __Receipt).FirstOrDefault();
                     decimal ServiceFees = (decimal)(from _Place in JFoodDC.Places
                                                     where _Place.PlaceID == OrderPlaceID
                                                     select _Place.ServiceFees).First();
            
                     varReceipt.ReceiptTotal -= OrderTotal;
                     varReceipt.ServiceFees -= Convert.ToInt32( OrderTotal * ServiceFees / 100);
                     JFoodDC.SubmitChanges();
                    ReceiptOrders = (from _Order in JFoodDC.Orders
                                         where _Order.ReceiptID == ReceiptID && _Order.OrderStatus !="Canceled"
                                         select _Order).ToList().Count;
                }
                else
                {
                    var OrderPlaceID = JFoodDC.GetOrderByID(int.Parse(txtOrderSerial.Text)).FirstOrDefault().PlaceID;
                    
                    decimal? OrderTotal = JFoodDC.GetOrderBySerial(int.Parse(txtOrderSerial.Text), dtpReceiptDate.Value.Date).FirstOrDefault().TotalPrice;
                    JFoodDC.CancelOrderBySerial(int.Parse(txtOrderSerial.Text), dtpReceiptDate.Value.Date);
                    ReceiptID= JFoodDC.GetOrderBySerial(int.Parse(txtOrderSerial.Text), dtpReceiptDate.Value.Date).ToList<GetOrderBySerialResult>().FirstOrDefault().ReceiptID;
                    decimal ServiceFees = (decimal)(from _Place in JFoodDC.Places
                                                    where _Place.PlaceID == OrderPlaceID
                                                    select _Place.ServiceFees).First();
                    var varReceipt = (from __Receipt in JFoodDC.Receipts
                                      where __Receipt.ReceiptID == ReceiptID
                                      select __Receipt).FirstOrDefault();

                    varReceipt.ReceiptTotal -= OrderTotal;
                    varReceipt.ServiceFees -= Convert.ToInt32(OrderTotal * ServiceFees / 100);
                    JFoodDC.SubmitChanges();

                    ReceiptOrders = (from _Order in JFoodDC.Orders
                                     where _Order.ReceiptID == ReceiptID && _Order.OrderStatus != "Canceled"
                                     select _Order).ToList().Count;
                }
                if (ReceiptOrders == 0)
                {
                    JFoodDC.CancelReceiptByID(ReceiptID);
                }
                ((frmPlacesTables)Application.OpenForms["frmPlacesTables"]).IntializePlaces();
                Close();
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtOrderID.Enabled = radioButton1.Checked;
            txtOrderSerial.Enabled = radioButton2.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtOrderID.Enabled = radioButton1.Checked;
            txtOrderSerial.Enabled = radioButton2.Checked;

        }
    }
}
