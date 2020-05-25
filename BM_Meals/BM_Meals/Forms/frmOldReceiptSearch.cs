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
    public partial class frmOldReceiptSearch : Form
    {


        BM_MealsDBContext BM_MealsDC;
        public frmOldReceiptSearch()
        {
            InitializeComponent();
        }

        private void chPeriod_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateTo.Enabled = chPeriod.Checked;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Status = "Cash";
            if (cbPaymentMethod.Text == "اجل")
            {
                Status = "Credit";
            }
            /*if (!chPeriod.Checked)
            {
            searchOldReceiptsResultBindingSource.DataSource = BM_MealsDC.(from  int.Parse(cbLocations.SelectedValue.ToString()),
                dateTimePicker1.Value.Date, null, Status).ToList();}
            else
                searchOldReceiptsResultBindingSource.DataSource = BM_MealsDC.SearchOldReceipts(int.Parse(cbLocations.SelectedValue.ToString()),
                dateTimePicker1.Value.Date, dtpDateTo.Value.AddDays(1).Date, Status).ToList();*/
            //dataGridView1.DataSource = searchOldReceiptsResultBindingSource;
        }

        private void frmOldReceiptSearch_Load(object sender, EventArgs e)
        {
            BM_MealsDC = new BM_MealsDBContext();
            cbPlaces.DataSource = (from _Place in BM_MealsDC.Places
                                                           select _Place).ToList();
            cbPlaces.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLocations.DataSource = (from _Location in BM_MealsDC.Locations
                                    where _Location.PlaceID == int.Parse(cbPlaces.SelectedValue.ToString())
                                    select _Location).ToList();
            if (cbLocations.Items.Count > 0)
                cbLocations.SelectedIndex = 0;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            new frmOldReceipt(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())).ShowDialog();
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
