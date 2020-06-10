using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using Microsoft.Reporting.WinForms;

namespace BM_Meals
{
    public partial class frmTakeaway : Form
    {
        public frmTakeaway()
        {
            InitializeComponent();
            
        }
        public static int LocationID=-1;
        public static string LocationName = "";
        List<Category> _Categories;
        List<Item> _Items;
        int intCategory = 0, intItem = 0, ReceiptID=0, OrderIndex = 0;
        Location varLocation;
        private int m_currentPageIndex;
        private IList<Stream> m_streams;
        public int WaiterID = 0;
        BM_MealsDBContext BM_MealsDC;
        List<KeyValuePair<int, int>> lstDepartmentsItems;

        List<KeyValuePair<Order, List<OrderItem>>> lstOrder_OrderItems;



        private Stream CreateStream(string name,
     string fileNameExtension, Encoding encoding,
     string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }
        //<PageHeight>11in</PageHeight>
        //        <MarginTop>0.25in</MarginTop>
        //        <MarginLeft>0.25in</MarginLeft>
        //        <MarginRight>0.25in</MarginRight>
        //        <MarginBottom>0.25in</MarginBottom>
        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new
               Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }
        private void Export(LocalReport report)
        {
            string deviceInfo =
              @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>8cm</PageWidth>
                <DpiX>300</DpiX>
                <DpiY>300</DpiY>
            </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream,
               out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            BM_MealsDC = new BM_MealsDBContext();
            lstDepartmentsItems = new List<KeyValuePair<int, int>>();
            _Categories = (from _Category in BM_MealsDC.Categories
                           // where _Place.PlaceID == 1
                           select _Category).ToList<Category>();

            _Items = (from _Location in BM_MealsDC.Items
                      where _Location.CategoryID == 1
                      select _Location).ToList<Item>();
            //lblPlaceName.Text = (from _Place in BM_MealsDC.Places
            //                     where _Place.PlaceID == varLocation.PlaceID
            //                     select _Place.PlaceName).First();

           // lblLocationName.Text = varLocation.LocationName;
          
            
            //comment by Basem for test------------------------------------------------

            //if (_Categories.Count > 12)
            //{
            //    this.btnNextCategories.Visible = true;
            //    this.btnCategoriesPrevious.Visible = true;
            //}
            //else
            //{
            //    this.btnNextCategories.Visible = false;
            //    this.btnCategoriesPrevious.Visible = false;
            //}

            foreach (Category _Category in _Categories)
            {
                if (intCategory > 11) break;
                Button btnCategory = new Button();
                btnCategory.Name = _Category.CategoryID.ToString();
                btnCategory.Text = _Category.CategoryName;
                btnCategory.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnCategory.ForeColor = System.Drawing.Color.Lime;
                btnCategory.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                btnCategory.UseVisualStyleBackColor = false;
                btnCategory.Size = new System.Drawing.Size(111, 96);
                btnCategory.Click += new EventHandler(CategoriesEvent);

                this.flpCategories.Controls.Add(btnCategory);
                intCategory += 1;
            }


            //comment by Basem for test------------------------------------------------

            //if (_Items.Count > 30)
            //{
            //    //this.btnItemsNext.Visible = true;
            //    this.btnPrevItems.Visible = true;
            //}
            //else
            //{
            //   // this.btnItemsNext.Visible = false;
            //    this.btnPrevItems.Visible = false;
            //}
            intItem = 0;
            for (int Index = 0; Index < 30; Index++)
            {

                if (Index >= _Items.Count) break;

                Item row = _Items[intItem];
                Button btnMenuItem = new Button();
                btnMenuItem.Name = row.ItemsID.ToString();
                btnMenuItem.Text = row.ItemName;
                //+"\n \n" + row["MenuItemID"].ToString();
                //btnMenuItem.Tag = row["MenuItemText"].ToString();
                btnMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnMenuItem.ForeColor = System.Drawing.Color.Gold;
                btnMenuItem.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                btnMenuItem.UseVisualStyleBackColor = false;
                btnMenuItem.Size = new System.Drawing.Size(111, 96);
                btnMenuItem.Click += new EventHandler(MenuItemsEvent);

                this.flpItems.Controls.Add(btnMenuItem);
                this.intItem += 1;
            }

            if (ReceiptID == 0)
                tabControl1.TabPages.RemoveAt(1);
            else
            {
                btnCash.Visible = true;
                btnCredit.Visible = true;
                btnVoucher.Visible = true;
                lblReceiptID.Text = ReceiptID.ToString();
                var varReceipt = from _Receipt in BM_MealsDC.Receipts
                                 where _Receipt.ReceiptID == ReceiptID
                                 select _Receipt;
                lblReceiptSerial.Text = varReceipt.First().ReceiptSerial.ToString();
                lblReceiptTotal.Text = varReceipt.First().ReceiptTotal.ToString();

                lstOrder_OrderItems = new List<KeyValuePair<Order, List<OrderItem>>>();

                List<Order> Orders = (from _Order in BM_MealsDC.Orders
                                      where _Order.ReceiptID == ReceiptID && _Order.OrderStatus =="Available"
                                      select _Order).ToList<Order>();

                for (int i = 0; i < Orders.Count; i++)
                {
                    List<OrderItem> lstOrderItems = (from _OrderItems in BM_MealsDC.OrderItems
                                                     where _OrderItems.OrderID == Orders[i].OrderID
                                                     select _OrderItems).ToList<OrderItem>();

                    lstOrder_OrderItems.Add(new KeyValuePair<Order, List<OrderItem>>(Orders[i], lstOrderItems));
                }

                if (Orders.Count < 2)
                {
                    btnOldOrdersNext.Visible = false;
                    btnOldOrdersPrevious.Visible = false;
                }
                else
                {
                    btnOldOrdersNext.Visible = true;
                    btnOldOrdersPrevious.Visible = true;
                }

                lblOrderID.Text = Orders[OrderIndex].OrderID.ToString();
                lblOrderSerial.Text = Orders[OrderIndex].OrderSerial.ToString();

                lblOrderTotal.Text = Orders[OrderIndex].OrderTotal.ToString();

                dgvPreviousOrders.DataSource = lstOrder_OrderItems[OrderIndex].Value;
            }
        }
        private void CategoriesEvent(object sender, EventArgs e)
        {

            intCategory = Convert.ToInt32(((Button)sender).Name);

            _Items = (from _Location in BM_MealsDC.Items
                      where _Location.CategoryID == intCategory
                      select _Location).ToList<Item>();


            this.flpItems.Controls.Clear();


            if (_Items.Count > 30)
            {
                //this.btnItemsNext.Visible = true;
                this.btnPrevItems.Visible = true;
            }
            else
            {
                //this.btnItemsNext.Visible = false;
                this.btnPrevItems.Visible = false;
            }

            intItem = 0;
            for (int Index = 0; Index < 30; Index++)
            {

                if (Index >= _Items.Count) break;

                Item row = _Items[intItem];
                Button btnMenuItem = new Button();
                btnMenuItem.Name = row.ItemsID.ToString();
                btnMenuItem.Text = row.ItemName;
                //+"\n \n" + row["MenuItemID"].ToString();
                //btnMenuItem.Tag = row["MenuItemText"].ToString();
                btnMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnMenuItem.ForeColor = System.Drawing.Color.Gold;
                btnMenuItem.BackColor = System.Drawing.Color.FromArgb(64,64,64);
                btnMenuItem.UseVisualStyleBackColor = false;
                btnMenuItem.Size = new System.Drawing.Size(111, 96);
                btnMenuItem.Click += new EventHandler(MenuItemsEvent);

                this.flpItems.Controls.Add(btnMenuItem);
                this.intItem += 1;
            }


        }
        private void MenuItemsEvent(object sender, EventArgs e)
        {
            int ItemID = int.Parse(((Button)sender).Name);
            Item varItem = (from _Item in new BM_MealsDBContext().Items
                            where _Item.ItemsID == ItemID
                            select _Item).First<Item>();

            int item1 = -1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["ItemID"].Value.ToString().Equals(((Button)sender).Name))
                {
                    item1 = i;
                    break;
                }
            }
            double qtnfull;
            if (item1 == -1)
            {
                if (txtfullqnt.Text == string.Empty)
                {
                    qtnfull = 1;
                }
                else
                {
                    qtnfull = Convert.ToInt32(txtfullqnt.Text);
                }
                dataGridView1.Rows.Add(((Button)sender).Name, varItem.ItemName, qtnfull, varItem.ItemSellPrice, Convert.ToDouble(varItem.ItemSellPrice)* qtnfull, varItem.DepartmentID);
                lblTotal.Text = dataGridView1.Rows.Cast<DataGridViewRow>()
               .Sum(t => Convert.ToInt32(t.Cells[4].Value)).ToString();
                txtfullqnt.Text = null;
            }
            else if (item1 > -1)
            {
                dataGridView1.Rows[item1].Cells["QTY"].Value = (Convert.ToDouble(dataGridView1.Rows[item1].Cells["QTY"].Value) + 1).ToString();
                dataGridView1.Rows[item1].Cells["Total"].Value = (varItem.ItemSellPrice * decimal.Parse(dataGridView1.Rows[item1].Cells["QTY"].Value.ToString())).ToString();
                lblTotal.Text = dataGridView1.Rows.Cast<DataGridViewRow>()
                               .Sum(t => Convert.ToInt32(t.Cells[4].Value)).ToString();
            }
        }

        void PrintDepartment(int OrderID)
        {
            LocalReport report = new LocalReport();
            report.ReportPath = @"Order.rdlc";

            BindingSource bsOrder = new BindingSource();

            //bsOrder.DataSource = BM_MealsDC.GetTakeawayOrderByID(OrderID).ToList();
            report.SetParameters(new ReportParameter("Header", "فول وتميس افغاني"));
            report.DataSources.Add(new ReportDataSource("dsOrder", bsOrder));
            
            Export(report);
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }


        void PrintReciept(dynamic dtOrder)
        {
            LocalReport report = new LocalReport();
            report.ReportPath = @"Receipt.rdlc";

            BindingSource bsprntReceipt = new BindingSource();

            bsprntReceipt.DataSource = dtOrder;

            report.SetParameters(new ReportParameter("Header", "فول وتميس افغاني"));

            report.DataSources.Add(new ReportDataSource("dsPrintReceipt", bsprntReceipt));

            Export(report);

            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");

            PrintDocument printDoc = new PrintDocument();

            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count != 0)
            {
                //if (new frmWaiters().ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //{

                    BM_MealsDBContext BM_MealsDC = new BM_MealsDBContext();

                    //decimal ServiceFees = (decimal)(from _Place in BM_MealsDC.Places
                    //                                where _Place.PlaceID == varLocation.PlaceID
                    //                                select _Place.ServiceFees).First();
            
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DataGridViewRow Row = dataGridView1.Rows[i];
                        lstDepartmentsItems.Add(new KeyValuePair<int, int>(int.Parse(Row.Cells["DepartmentID"].Value.ToString()), i));

                    }
                    int OrderID;

                    if (ReceiptID == 0)
                    {
                    decimal ReceiptTotal = decimal.Parse(dataGridView1.Rows.Cast<DataGridViewRow>().Sum(Row => decimal.Parse(Row.Cells["Total"].Value.ToString())).ToString());
                    var _Receipt = new Receipt();
                    _Receipt.ReceiptDate = DateTime.Now;
                    _Receipt.ReceiptTotal = ReceiptTotal;
                    _Receipt.UserID = frmLogin.UserID;
                    BM_MealsDC.Receipts.Add(_Receipt);
                    BM_MealsDC.SaveChanges();
                    ReceiptID = _Receipt.ReceiptID;



                    }
                    else
                    {
                        var varReceipt = (from _Receipt in BM_MealsDC.Receipts
                                          where _Receipt.ReceiptID == ReceiptID
                                          select _Receipt).FirstOrDefault();

                       varReceipt.ReceiptTotal = varReceipt.ReceiptTotal + decimal.Parse(lblTotal.Text);
                       // varReceipt.ServiceFees = varReceipt.ServiceFees + Convert.ToInt32(decimal.Parse(lblTotal.Text) * ServiceFees / 100);
                       BM_MealsDC.SaveChanges();

                    }


                    List<OrderItem> lstOrder;
                    var Departments = lstDepartmentsItems.GroupBy(DeptItem => DeptItem.Key, DeptItem => DeptItem.Value).ToDictionary(DeptItem => DeptItem.Key).Keys;

                    foreach (var DepartmentID in Departments)
                    {
                        lstOrder = new List<OrderItem>();
                        decimal OrderTotal = Convert.ToDecimal(dataGridView1.Rows.Cast<DataGridViewRow>().Where(_Row => _Row.Cells["DepartmentID"].Value.ToString()==DepartmentID.ToString())
                            .Sum(Row => decimal.Parse(Row.Cells["Total"].Value.ToString())).ToString());
                    Order _Order = new Order();
                    _Order.ReceiptID = ReceiptID;
                    _Order.OrderStatus = "Available";
                    _Order.UserID = frmLogin.UserID;
                    _Order.WaiterID= 0;
                    _Order.OrderTotal = OrderTotal;
                    _Order.OrderDate = DateTime.Now;
                    _Order.OrderStatus = "TakeAway";
                    BM_MealsDC.Orders.Add(_Order);
                    BM_MealsDC.SaveChanges();
                    OrderID = _Order.OrderID;
                  //0, "سفري"
                  //OrderID = BM_MealsDC.InsertOrder(ReceiptID, "Available", frmLogin.UserID, 0, OrderTotal, DateTime.Now,
                  //0, "سفري").First().orderid;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            OrderItem _OrderItem = new OrderItem();

                            if (DepartmentID == int.Parse(dataGridView1.Rows[i].Cells["DepartmentID"].Value.ToString()))
                            {
                                _OrderItem.ItemID = int.Parse(dataGridView1.Rows[i].Cells["ItemID"].Value.ToString());
                                _OrderItem.ItemText = dataGridView1.Rows[i].Cells["ItemName"].Value.ToString();
                                _OrderItem.ItemPrice = decimal.Parse((dataGridView1.Rows[i].Cells["Price"].Value.ToString()));
                                _OrderItem.ItemQTY = int.Parse(dataGridView1.Rows[i].Cells["QTY"].Value.ToString());
                                _OrderItem.OrderID = OrderID;
                                _OrderItem.TotalPrice = _OrderItem.ItemPrice * _OrderItem.ItemQTY;
                                BM_MealsDC.OrderItems.Add(_OrderItem);
                                
                                lstOrder.Add(_OrderItem);
                            BM_MealsDC.SaveChanges();
                        }
                    }
                        string Department = (from _Dept in BM_MealsDC.Departments
                                             where _Dept.DepartmentID == DepartmentID
                                             select _Dept.DepartmentName).First().ToString();

                    
                      PrintDepartment(OrderID);
                      btnCash_Click(null, null);    
                  //  }
                    ((frmPlacesTables)Application.OpenForms["frmPlacesTables"]).IntializePlaces();
                  //  Close();
                } 
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOrderCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "هل تود الغاء الطلب", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                BM_MealsDBContext BM_MealsDC = new BM_MealsDBContext();
                var varOrder = (from _Order in BM_MealsDC.Orders
                                where _Order.OrderID == int.Parse(lblOrderID.Text)
                                select _Order).FirstOrDefault();
                varOrder.OrderStatus = "Deleted";
                BM_MealsDC.SaveChanges();


            }
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (ReceiptID != 0)
            {
                BM_MealsDBContext BM_MealsDC = new BM_MealsDBContext();
                
                var varReceipt = (from _Receipt in BM_MealsDC.Receipts
                                  where _Receipt.ReceiptID == ReceiptID
                                  select _Receipt).FirstOrDefault();
                varReceipt.ReceiptStatus = "Cash";
                varReceipt.UserID = frmLogin.UserID;
                varReceipt.ReceiptDate = DateTime.Now;

                //BM_MealsDC.SubmitChanges();
                //var __Receipt = BM_MealsDC.prntTakeawayReceiptReceiptID(ReceiptID).ToList();
                //PrintReciept(__Receipt);
                //PrintReciept(__Receipt);
                ((frmPlacesTables)Application.OpenForms["frmPlacesTables"]).IntializePlaces();
                Close();
            }
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            if (new frmReceiptChangeLocation().ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                if (ReceiptID != 0)
                {
                    BM_MealsDBContext BM_MealsDC = new BM_MealsDBContext();

                    var varReceipt = (from _Receipt in BM_MealsDC.Receipts
                                      where _Receipt.ReceiptID == ReceiptID
                                      select _Receipt).FirstOrDefault();
                    varReceipt.LocationID = frmSales.LocationID;
                    varReceipt.UserID = frmLogin.UserID;
                    varReceipt.ReceiptDate = DateTime.Now;
                    varReceipt.ReceiptStatus = "Credit";


                    BM_MealsDC.SaveChanges();
                    //var __Receipt = BM_MealsDC.prntReceiptReceiptID(ReceiptID).ToList();
                    //PrintReciept(__Receipt);
                    //PrintReciept(__Receipt);
                    ((frmPlacesTables)Application.OpenForms["frmPlacesTables"]).IntializePlaces();
                    Close();
                }
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTotal.Text = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(Row => decimal.Parse(Row.Cells["Total"].Value.ToString())).ToString();
        }

        private void btnItemsNext_Click(object sender, EventArgs e)
        {
            if (this.intItem < _Items.Count)
            {
                this.flpItems.Controls.Clear();

                for (int Index = 0; Index < 30; Index++)
                {
                    if (intItem >= _Items.Count) break;

                    Item row = _Items[intItem];
                    Button btnMenuItem = new Button();
                    btnMenuItem.Name = row.ItemsID.ToString();
                    btnMenuItem.Text = row.ItemName;
                    //+"\n \n" + row["MenuItemID"].ToString();
                    //btnMenuItem.Tag = row["MenuItemText"].ToString();
                    btnMenuItem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnMenuItem.ForeColor = System.Drawing.Color.Purple;

                    btnMenuItem.UseVisualStyleBackColor = true;
                    btnMenuItem.Size = new System.Drawing.Size(111, 96);
                    btnMenuItem.Click += new EventHandler(MenuItemsEvent);

                    this.flpItems.Controls.Add(btnMenuItem);
                    this.intItem += 1;

                }
            }
        }

        private void btnPrevItems_Click(object sender, EventArgs e)
        {
            if (this.intItem >= 0)
            {
                this.flpItems.Controls.Clear();
                
                if (intItem > 30 && intItem % 30 == 0)
                {
                    intItem -= 30;
                }
                else
                {
                    intItem = intItem - 30 - (intItem % 30);
                }


                for (int Index = 0; Index < 30; Index++)
                {

                    if (intItem >= _Items.Count) break;

                    Item row = _Items[intItem];
                    Button btnMenuItem = new Button();
                    btnMenuItem.Name = row.ItemsID.ToString();
                    btnMenuItem.Text = row.ItemName;
                    //+"\n \n" + row["MenuItemID"].ToString();
                    //btnMenuItem.Tag = row["MenuItemText"].ToString();
                    btnMenuItem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnMenuItem.ForeColor = System.Drawing.Color.Purple;

                    btnMenuItem.UseVisualStyleBackColor = true;
                    btnMenuItem.Size = new System.Drawing.Size(111, 96);
                    btnMenuItem.Click += new EventHandler(MenuItemsEvent);

                    this.flpItems.Controls.Add(btnMenuItem);
                    this.intItem += 1;
                }

            }
        }

        private void btnNextCategories_Click(object sender, EventArgs e)
        {
            if (this.intCategory< _Categories.Count)
            {
                this.flpCategories.Controls.Clear();

                for (int Index = 0; Index < 12; Index++)
                {
                    if (intCategory >= _Categories.Count) break;

                    Category row = _Categories[intCategory];
                    Button btnCategory = new Button();
                    btnCategory.Name = row.CategoryID.ToString();
                    btnCategory.Text = row.CategoryName;
                    //+"\n \n" + row["MenuItemID"].ToString();
                    //btnMenuItem.Tag = row["MenuItemText"].ToString();
                    btnCategory.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnCategory.ForeColor = System.Drawing.Color.Purple;

                    btnCategory.UseVisualStyleBackColor = true;
                    btnCategory.Size = new System.Drawing.Size(111, 96);
                    btnCategory.Click += new EventHandler(CategoriesEvent);

                    this.flpCategories.Controls.Add(btnCategory);
                    this.intCategory += 1;

                }
            }
        }

        private void btnCategoriesPrevious_Click(object sender, EventArgs e)
        {
            if (this.intCategory >= 0)
            {
                this.flpCategories.Controls.Clear();

                if (intCategory > 12 && intItem % 12 == 0)
                {
                    intCategory -= 12;
                }
                else
                {
                    intCategory= intCategory- 12 - (intCategory% 12);
                }


                for (int Index = 0; Index < 12; Index++)
                {

                    if (intCategory >= _Categories.Count) break;

                    Category row = _Categories[intCategory];
                    Button btnCategory = new Button();
                    btnCategory.Name = row.CategoryID.ToString();
                    btnCategory.Text = row.CategoryName;
                    btnCategory.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnCategory.ForeColor = System.Drawing.Color.Purple;

                    btnCategory.UseVisualStyleBackColor = true;
                    btnCategory.Size = new System.Drawing.Size(111, 96);
                    btnCategory.Click += new EventHandler(CategoriesEvent);

                    this.flpCategories.Controls.Add(btnCategory);
                    this.intCategory += 1;
                }

            }
        }

        private void btnOldOrdersNext_Click(object sender, EventArgs e)
        {
            if (ReceiptID != 0)
            {

                lstOrder_OrderItems = new List<KeyValuePair<Order, List<OrderItem>>>();

                List<Order> Orders = (from _Order in BM_MealsDC.Orders
                                      where _Order.ReceiptID == ReceiptID && _Order.OrderStatus == "Available"
                                      select _Order).ToList<Order>();

                for (int i = 0; i < Orders.Count; i++)
                {
                    List<OrderItem> lstOrderItems = (from _OrderItems in BM_MealsDC.OrderItems
                                                     where _OrderItems.OrderID == Orders[i].OrderID
                                                     select _OrderItems).ToList<OrderItem>();

                    lstOrder_OrderItems.Add(new KeyValuePair<Order, List<OrderItem>>(Orders[i], lstOrderItems));
                }
                if (OrderIndex < Orders.Count)
                {
                    OrderIndex += 1;

                    if (Orders.Count < 2)
                    {
                        btnOldOrdersNext.Visible = false;
                        btnOldOrdersPrevious.Visible = false;
                    }
                    else
                    {
                        btnOldOrdersNext.Visible = true;
                        btnOldOrdersPrevious.Visible = true;
                    }

                    lblOrderID.Text = Orders[OrderIndex].OrderID.ToString();
                    lblOrderSerial.Text = Orders[OrderIndex].OrderSerial.ToString();

                    lblOrderTotal.Text = Orders[OrderIndex].OrderTotal.ToString();

                    dgvPreviousOrders.DataSource = lstOrder_OrderItems[OrderIndex].Value;
                }
            }
        }

        private void btnNextCategories_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCategoriesPrevious_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPrevItems_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCredit_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVoucher_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
                if (e.ColumnIndex == 6)// 10th column the button
                {

                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "رسالة تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                }
                lblTotal.Text = dataGridView1.Rows.Cast<DataGridViewRow>()
                     .Sum(t => Convert.ToInt32(t.Cells[4].Value)).ToString();
            }
        }

        private void txtfullqnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Control Activecon;
        private void BTN1_Click(object sender, EventArgs e)
        {
            try
            {
   Button btn = (Button)sender;
  txtfullqnt.Focus();
            Activecon.Focus();
              
            SendKeys.Send(btn.Text);
            }
            catch(Exception )
            {
                txtfullqnt.Focus();
                return ;
            }
        }

        private void txtfullqnt_Enter(object sender, EventArgs e)
        {
            Activecon = (Control)sender;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtfullqnt.Text = null;
        }

        private void btnOldOrdersPrevious_Click(object sender, EventArgs e)
        {
            if (ReceiptID != 0)
            {


                lstOrder_OrderItems = new List<KeyValuePair<Order, List<OrderItem>>>();

                List<Order> Orders = (from _Order in BM_MealsDC.Orders
                                      where _Order.ReceiptID == ReceiptID && _Order.OrderStatus == "Available"
                                      select _Order).ToList<Order>();

                for (int i = 0; i < Orders.Count; i++)
                {
                    List<OrderItem> lstOrderItems = (from _OrderItems in BM_MealsDC.OrderItems
                                                     where _OrderItems.OrderID == Orders[i].OrderID
                                                     select _OrderItems).ToList<OrderItem>();

                    lstOrder_OrderItems.Add(new KeyValuePair<Order, List<OrderItem>>(Orders[i], lstOrderItems));
                }
                if (OrderIndex >= 0)
                {
                    OrderIndex -= 1;

                    if (Orders.Count < 2)
                    {
                        btnOldOrdersNext.Visible = false;
                        btnOldOrdersPrevious.Visible = false;
                    }
                    else
                    {
                        btnOldOrdersNext.Visible = true;
                        btnOldOrdersPrevious.Visible = true;
                    }

                    lblOrderID.Text = Orders[OrderIndex].OrderID.ToString();
                    lblOrderSerial.Text = Orders[OrderIndex].OrderSerial.ToString();

                    lblOrderTotal.Text = Orders[OrderIndex].OrderTotal.ToString();

                    dgvPreviousOrders.DataSource = lstOrder_OrderItems[OrderIndex].Value;
                }
            }

        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            if (ReceiptID != 0)
            {
                BM_MealsDBContext BM_MealsDC = new BM_MealsDBContext();

                var varReceipt = (from _Receipt in BM_MealsDC.Receipts
                                  where _Receipt.ReceiptID == ReceiptID
                                  select _Receipt).FirstOrDefault();
                varReceipt.UserID = frmLogin.UserID;
                varReceipt.ReceiptDate = DateTime.Now;
                varReceipt.ReceiptStatus = "Voucher";
                BM_MealsDC.SaveChanges();
                //var __Receipt = BM_MealsDC.prntReceiptReceiptID(ReceiptID).ToList();
                //PrintReciept(__Receipt);
              //  PrintReciept(__Receipt);
                ((frmPlacesTables)Application.OpenForms["frmPlacesTables"]).IntializePlaces();
                Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}       

    

