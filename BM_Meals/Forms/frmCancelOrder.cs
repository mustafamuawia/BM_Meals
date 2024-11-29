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
    public partial class frmCancelOrder : Form
    {
        BM_Meals.BM_MealsDBContext BM_MealsDC;
        public frmCancelOrder()
        {
            InitializeComponent();
        }
        
        private void frmDeleteReceipt_Load(object sender, EventArgs e)
        {
            BM_MealsDC = new BM_Meals.BM_MealsDBContext();
            //this.reportViewer1.RefreshReport();
        }

        private void btnOpenReciept_Click(object sender, EventArgs e)
        {


            if (rbOrderID.Checked)
            {
                if (txtOrderID.Text != "")
                {
                    txtOrderID.Enabled = false;
                    var _Order = BM_MealsDC.Orders.Where(o=>o.OrderID==int.Parse(txtOrderID.Text)).FirstOrDefault();
                    if (_Order.OrderID !=null)
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
                    var _Order = BM_MealsDC.Orders.Where(o=>o.OrderSerial==int.Parse(txtOrderSerial.Text) && o.OrderDate.Value.Date == dtpReceiptDate.Value.Date).ToList();
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
                if (rbOrderID.Checked)
                {
                    var OrderPlaceID = (from _place in BM_MealsDC.Places join
                                        _location in BM_MealsDC.Locations on _place.PlaceID equals _location.PlaceID join
                                        _order in BM_MealsDC.Orders on _location.LocationID equals _order.LocationID
                                        where _order.OrderID == int.Parse(txtOrderID.Text)
                                        select _location.PlaceID).FirstOrDefault();
                    decimal? OrderTotal = BM_MealsDC.Orders.Where(o => o.OrderID == int.Parse(txtOrderID.Text)).FirstOrDefault().OrderTotal;

                    var varOrder = BM_MealsDC.Orders.Where(o => o.OrderID == int.Parse(txtOrderID.Text)).FirstOrDefault();
                    varOrder.OrderStatus = "Canceled";
                    BM_MealsDC.SaveChanges();

                    ReceiptID = varOrder.ReceiptID;
                    var varReceipt = (from __Receipt in BM_MealsDC.Receipts
                                      where __Receipt.ReceiptID == ReceiptID
                                      select __Receipt).FirstOrDefault();
                    decimal ServiceFees = (decimal)(from _Place in BM_MealsDC.Places
                                                    where _Place.PlaceID == OrderPlaceID.Value
                                                    select _Place.ServiceFees).First();

                    varReceipt.ReceiptTotal -= OrderTotal;
                    varReceipt.ServiceFees -= Convert.ToInt32(OrderTotal * ServiceFees / 100);
                    BM_MealsDC.SaveChanges();
                    ReceiptOrders = (from _Order in BM_MealsDC.Orders
                                     where _Order.ReceiptID == ReceiptID && _Order.OrderStatus != "Canceled"
                                     select _Order).ToList().Count;

                }
                else
                {
                    //var OrderPlaceID = BM_MealsDC.Orders.Where(_order=>_order.OrderSerial==int.Parse(txtOrderSerial.Text)).FirstOrDefault().p;

                    var _Order = BM_MealsDC.Orders.Where(_order => _order.OrderSerial == int.Parse(txtOrderSerial.Text)
                    && _order.OrderDate.Value.Date == dtpReceiptDate.Value.Date).FirstOrDefault();
                    if (_Order != null)
                    {
                        _Order.OrderStatus = "Canceled";
                        BM_MealsDC.SaveChanges();

                        decimal ServiceFees = 1;
                            /*(decimal)(from _Place in BM_MealsDC.Places
                                                        where _Place.PlaceID == OrderPlaceID
                                                        select _Place.ServiceFees).First();*/
                        var varReceipt = (from __Receipt in BM_MealsDC.Receipts
                                          where __Receipt.ReceiptID == _Order.ReceiptID
                                          select __Receipt).FirstOrDefault();

                        varReceipt.ReceiptTotal -= _Order.OrderTotal;
                        varReceipt.ServiceFees -= Convert.ToInt32(_Order.OrderTotal* ServiceFees / 100);
                        BM_MealsDC.SaveChanges();

                        ReceiptOrders = BM_MealsDC.Orders.Where(_order=>_order.ReceiptID == ReceiptID && _Order.OrderStatus != "Canceled").ToList().Count; 
                }
                    if (ReceiptOrders == 0)
                    {
                        
                    }
                ((frmPlacesTables)Application.OpenForms["frmPlacesTables"]).IntializePlaces();
                    Close();
                }
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtOrderID.Enabled = rbOrderID.Checked;
            txtOrderSerial.Enabled = rbOrderSerial.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtOrderID.Enabled = rbOrderID.Checked;
            txtOrderSerial.Enabled = rbOrderSerial.Checked;

        }
    }
}
