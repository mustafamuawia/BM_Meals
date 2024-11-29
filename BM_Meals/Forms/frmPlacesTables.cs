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
 
    public partial class frmPlacesTables : Form
    {
        List<Place> _Places;
        List<Location> _Locations;
        int intPlace = 0, intLocation = 0,ReceiptID = 0;
        BM_MealsDBContext BM_MealsDC;
        public frmPlacesTables()
        {
            InitializeComponent();
        }
        public void IntializePlaces()
        {
            flpPlaces.Controls.Clear();
            flpLocations.Controls.Clear();
            
            _Places = (from _Place in BM_MealsDC.Places
                       select _Place).ToList<Place>();

            _Locations = (from _Location in BM_MealsDC.Locations
                          where _Location.PlaceID == 1
                          select _Location).ToList<Location>();
            var OpenTables = from _Receipt in BM_MealsDC.Receipts
                             where _Receipt.ReceiptStatus == "Current"
                             select _Receipt.LocationID;

            var CurrentPlaces = from _Place in BM_MealsDC.Places
                                join _Location in BM_MealsDC.Locations on _Place.PlaceID equals _Location.PlaceID
                                join _Receipt in BM_MealsDC.Receipts on _Location.LocationID equals _Receipt.LocationID
                                where _Receipt.ReceiptStatus == "Current"
                                select _Location.PlaceID;

            foreach (Place _Place in _Places)
            {


                Button btnPlace = new Button();
                btnPlace.Name = _Place.PlaceID.ToString();
                btnPlace.Text = _Place.PlaceName;

                btnPlace.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                if (CurrentPlaces.Contains<int?>(_Place.PlaceID))
                {
                    btnPlace.BackColor = System.Drawing.Color.Orange;
                }
                else
                    btnPlace.UseVisualStyleBackColor = true;
                btnPlace.Size = new System.Drawing.Size(111, 96);
                btnPlace.Click += new EventHandler(PlacesEvent);
                //btnMenuItem.MouseUp += new MouseEventHandler(MenuItemsRighClickEvent);

                this.flpPlaces.Controls.Add(btnPlace);

            }

            if (_Locations.Count > 25)
            {
                this.btnLocationsNext.Visible = true;
                this.btnLocationsPrevious.Visible = true;
            }
            else
            {
                this.btnLocationsNext.Visible = false;
                this.btnLocationsPrevious.Visible = false;
            }
            intLocation = 0;
            for (int Index = 0; Index < 32; Index++)
            {

                if (Index >= _Locations.Count) break;

                Location row = _Locations[intLocation];
                Button btnMenuItem = new Button();
                btnMenuItem.Name = row.LocationID.ToString();

                if (OpenTables.Contains<int?>(row.LocationID))
                {

                    btnMenuItem.BackColor = System.Drawing.Color.Orange;
                }
                else
                    btnMenuItem.UseVisualStyleBackColor = true;

                btnMenuItem.Text = row.LocationName;
                btnMenuItem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //btnMenuItem.ForeColor = System.Drawing.Color.b;


                btnMenuItem.Size = new System.Drawing.Size(111, 96);
                btnMenuItem.Click += new EventHandler(LocationsEvent);

                this.flpLocations.Controls.Add(btnMenuItem);
                this.intLocation += 1;
            }

        }
        private void frmPlacesTables_Load(object sender, EventArgs e)
        {
            BM_MealsDC = new BM_MealsDBContext();
            IntializePlaces();
        }
        

        //Initial Places Buttons
        private void PlacesEvent(object sender, EventArgs e)
        {

            intPlace = Convert.ToInt32(((Button)sender).Name);

            this.flpLocations.Controls.Clear();
            _Locations=(from _Location in BM_MealsDC.Locations
                       where _Location.PlaceID == intPlace
                       select _Location).ToList<Location>();

            var OpenTables = from _Receipt in BM_MealsDC.Receipts
                             where _Receipt.ReceiptStatus == "Current"
                             select _Receipt.LocationID;
            if (_Locations.Count > 32)
            {
                this.btnLocationsNext.Visible = true;
                this.btnLocationsPrevious.Visible = true;
            }
            else
            {
                this.btnLocationsNext.Visible = false;
                this.btnLocationsPrevious.Visible = false;
            }
            intLocation = 0;
            for (int Index = 0; Index < 32; Index++)
            {

                if (Index >= _Locations.Count) break;

                Location row = _Locations[intLocation];
                Button btnLocation = new Button();
                btnLocation.Name = row.LocationID.ToString();

                if (OpenTables.Contains<int?>(row.LocationID))
                {

                    btnLocation.BackColor = System.Drawing.Color.Orange;
                }
                else
                    btnLocation.UseVisualStyleBackColor = true;

                btnLocation.Text = row.LocationName;
                btnLocation.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //btnMenuItem.ForeColor = System.Drawing.Color.b;


                btnLocation.Size = new System.Drawing.Size(111, 96);
                btnLocation.Click += new EventHandler(LocationsEvent);

                this.flpLocations.Controls.Add(btnLocation);
                this.intLocation += 1;
            }


        }

        private void LocationsEvent(object sender, EventArgs e)
        {
            BM_MealsDBContext BM_MealsDC =new BM_MealsDBContext();
            int LocationID = int.Parse(((Button)sender).Name);
             Location varLocation = (from _Location in BM_MealsDC.Locations
                           where _Location.LocationID == LocationID
                           select _Location).First<Location>();
             ReceiptID = (from _Location in BM_MealsDC.Locations
                          join _Receipt in BM_MealsDC.Receipts on _Location.LocationID equals _Receipt.LocationID
                          where _Location.LocationID == int.Parse(((Control)sender).Name) & _Receipt.ReceiptStatus == "Current"
                          select _Receipt.ReceiptID).FirstOrDefault();
             frmSales fSales = new frmSales(varLocation,ReceiptID);
            fSales.ShowDialog();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            new frmCancelOrder().ShowDialog();
        }

        private void btnDeleteReceipt_Click(object sender, EventArgs e)
        {
            new frmDeleteReceipt().ShowDialog();
        }

        private void btnNextPlaces_Click(object sender, EventArgs e)
        {
            if (this.intPlace < _Places.Count)
            {
                this.flpPlaces.Controls.Clear();

                for (int Index = 0; Index < 12; Index++)
                {
                    if (intPlace >= _Places.Count) break;

                    Place row = _Places[intPlace];
                    Button btnCategory = new Button();
                    btnCategory.Name = row.PlaceID.ToString();
                    btnCategory.Text = row.PlaceName;
                    //+"\n \n" + row["MenuItemID"].ToString();
                    //btnMenuItem.Tag = row["MenuItemText"].ToString();
                    btnCategory.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            

                    btnCategory.UseVisualStyleBackColor = true;
                    btnCategory.Size = new System.Drawing.Size(111, 96);
                    btnCategory.Click += new EventHandler(PlacesEvent);

                    this.flpPlaces.Controls.Add(btnCategory);
                    this.intPlace+= 1;

                }
            }

        }

        private void btnPlacesPrevious_Click(object sender, EventArgs e)
        {
            if (this.intPlace>= 0)
            {
                this.flpPlaces.Controls.Clear();

                if (intPlace> 12 && intPlace% 12 == 0)
                {
                intPlace-= 12;
                }
                else
                {
                    intPlace= intPlace- 12 - (intPlace% 12);
                }


                for (int Index = 0; Index < 12; Index++)
                {

                    if (intPlace>= _Places.Count) break;

                    Place row = _Places[intPlace];
                    Button btnCategory = new Button();
                    btnCategory.Name = row.PlaceID.ToString();
                    btnCategory.Text = row.PlaceName;
                    btnCategory.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            

                    btnCategory.UseVisualStyleBackColor = true;
                    btnCategory.Size = new System.Drawing.Size(111, 96);
                    btnCategory.Click += new EventHandler(PlacesEvent);

                    this.flpPlaces.Controls.Add(btnCategory);
                    this.intPlace+= 1;
                }

                                    
        }
        }

        private void btnLocationsNext_Click(object sender, EventArgs e)
        {
            if (this.intLocation< _Locations.Count)
            {
                this.flpLocations.Controls.Clear();

                for (int Index = 0; Index < 32; Index++)
                {
                    if (intLocation >= _Locations.Count) break;

                    Location row = _Locations[intLocation];
                    Button btnMenuItem = new Button();
                    btnMenuItem.Name = row.LocationID.ToString();
                    btnMenuItem.Text = row.LocationName;
                    //+"\n \n" + row["MenuItemID"].ToString();
                    //btnMenuItem.Tag = row["MenuItemText"].ToString();
                    btnMenuItem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    

                    btnMenuItem.UseVisualStyleBackColor = true;
                    btnMenuItem.Size = new System.Drawing.Size(111, 96);
                    btnMenuItem.Click += new EventHandler(LocationsEvent);

                    this.flpLocations.Controls.Add(btnMenuItem);
                    this.intLocation+= 1;

                }
            }
        }

        private void btnLocationsPrevious_Click(object sender, EventArgs e)
        {
                if (this.intLocation>= 0)
                {
                    this.flpLocations.Controls.Clear();

                    if (intLocation > 32 && intLocation % 32 == 0)
                    {
                        intLocation -= 32;
                    }
                    else
                    {
                        intLocation = intLocation - 30 - (intLocation % 30);
                    }


                    for (int Index = 0; Index < 32; Index++)
                    {

                        if (intLocation >= _Locations.Count) break;

                        Location row = _Locations[intLocation];
                        Button btnMenuItem = new Button();
                        btnMenuItem.Name = row.LocationID.ToString();
                        btnMenuItem.Text = row.LocationName;
                        //+"\n \n" + row["MenuItemID"].ToString();
                        //btnMenuItem.Tag = row["MenuItemText"].ToString();
                        btnMenuItem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                

                        btnMenuItem.UseVisualStyleBackColor = true;
                        btnMenuItem.Size = new System.Drawing.Size(111, 96);
                        btnMenuItem.Click += new EventHandler(LocationsEvent);

                        this.flpLocations.Controls.Add(btnMenuItem);
                        this.intLocation += 1;
                    }




                }
        }

        private void btnTakeaway_Click(object sender, EventArgs e)
        {
            new frmTakeaway().ShowDialog();
        }


        //private void MenuItemsRighClickEvent(object sender, MouseEventArgs e)
        //{
        //    if (e.Button.ToString().Equals("Right"))
        //    {
        //        adItem = new SqlDataAdapter("Select * from MenuItems where MenuItemID=" + "'" + ((Button)sender).Name + "'", SqlConn);
        //        dsItem = new DataSet();
        //        adItem.Fill(dsItem, "MenuItems");
        //        DataTable dtItem = new DataTable();
        //        dtItem = dsItem.Tables["MenuItems"];
        //        DataRow drItem = dtItem.Rows[0];
        //        drItem = dtItem.Rows[0];




        //        if (this.Qty < 0)
        //        {
        //            //MessageBox.Show("لا يمكن استخدام رقم سالب");
        //            this.Qty = 0;
        //        }

        //        int item1 = -1;
        //        for (int i = 0; i < dataGridView1.Rows.Count; i++)
        //        {
        //            if (dataGridView1.Rows[i].Cells[0].Value.ToString().Equals(((Button)sender).Name))
        //            {
        //                item1 = i;
        //                break;
        //            }
        //        }

        //        //  MessageBox.Show(lvItems.Items.IndexOfKey(((Button)sender).Text).ToString());
        //        if (this.Qty > 0)
        //        {


        //            DataRow[] dr = dtMenuItems.Select("MenuItemID = " + dataGridView1.Rows[item1].Cells[0].Value + "");

        //            dataGridView1.Rows[item1].Cells[2].Value =
        //                (Convert.ToDouble(dataGridView1.Rows[item1].Cells[3].Value)
        //               - this.Qty).ToString();
        //            dataGridView1.Rows[item1].Cells[4].Value =
        //                (Convert.ToDouble(drItem["UnitSellPrice"]) *
        //                Convert.ToDouble((dataGridView1.Rows[item1].Cells[2].Value))).ToString();
        //            dataGridView1.Rows[item1].Cells[5].Value = Convert.ToDouble(dr[0]["Quantity"].ToString()) + 1;
        //            this.lblTotal.Text = (Convert.ToDouble(this.lblTotal.Text) -
        //                (Convert.ToDouble(drItem["UnitSellPrice"]) * Convert.ToDouble(this.Qty))).ToString();
        //            this.Qty = 0;

        //        }
        //        else if (this.Qty == 0)
        //        {
        //            if (Convert.ToDouble(dataGridView1.Rows[item1].Cells[2].Value) != 1)
        //            {
        //                int index = item1;
        //                DataRow[] dr = dtMenuItems.Select("MenuItemID = " + dataGridView1.Rows[item1].Cells[0].Value + "");
        //                //strQtys[Cart.IndexOf(((Button)sender).Text)] = (Convert.ToDouble(strQtys[Cart.IndexOf(((Button)sender).Text)]) + 1).ToString();
        //                dataGridView1.Rows[item1].Cells[2].Value =
        //                      (Convert.ToDouble(dataGridView1.Rows[item1].Cells[2].Value) - 1).ToString();
        //                dataGridView1.Rows[item1].Cells[4].Value = (Convert.ToInt16(drItem["UnitSellPrice"]) *
        //                     Convert.ToDouble(dataGridView1.Rows[item1].Cells[2].Value)).ToString();
        //                //dataGridView1.Rows[item1].Cells[5].Value = Convert.ToDouble(dataGridView1.Rows[item1].Cells[5].Value) + 1;

        //                this.lblTotal.Text = (Convert.ToDouble(this.lblTotal.Text) -
        //                    (Convert.ToDouble(drItem["UnitSellPrice"]))).ToString();
        //                // frmOrder.Total.Text = (Convert.ToDouble(Total) + Convert.ToDouble(frmOrder.lblService.Text)).ToString();
        //                this.Qty = 0;
        //            }
        //        }
        //    }
        //    }

    }
}