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
    public partial class frmReceiptChangeLocation : Form
    {
        BMMealsDBContext JFoodDC;
        public frmReceiptChangeLocation()
        {
            InitializeComponent();
        }

        private void frmReceiptChangeLocation_Load(object sender, EventArgs e)
        {
            JFoodDC = new BMMealsDBContext();
            comboBox2.DataSource = (from _Location in JFoodDC.Locations
                                    where _Location.PlaceID == 1
                                    select _Location).ToList();
            if (comboBox2.Items.Count > 0)
                comboBox2.SelectedIndex = 0;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmSales.LocationID = int.Parse(comboBox2.SelectedValue.ToString());
            frmSales.LocationName = comboBox2.SelectedText;
        }
    }
}
