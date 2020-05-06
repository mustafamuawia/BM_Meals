using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JFood
{
    public partial class frmOldReceiptSearch : Form
    {
        
        
        JFoodDataContext JFoodDC;
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
            if (comboBox3.Text == "اجل")
            {
                Status = "Credit";
            }
            if (!chPeriod.Checked)
            {
            searchOldReceiptsResultBindingSource.DataSource = JFoodDC.SearchOldReceipts(int.Parse(comboBox2.SelectedValue.ToString()),
                dateTimePicker1.Value.Date, null, Status).ToList();}
            else
                searchOldReceiptsResultBindingSource.DataSource = JFoodDC.SearchOldReceipts(int.Parse(comboBox2.SelectedValue.ToString()),
                dateTimePicker1.Value.Date, dtpDateTo.Value.AddDays(1).Date, Status).ToList();
            //dataGridView1.DataSource = searchOldReceiptsResultBindingSource;
        }

        private void frmOldReceiptSearch_Load(object sender, EventArgs e)
        {
            JFoodDC = new JFoodDataContext();
            comboBox1.DataSource = (from _Place in JFoodDC.Places
                                                           select _Place).ToList();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = (from _Location in JFoodDC.Locations
                                    where _Location.PlaceID == int.Parse(comboBox1.SelectedValue.ToString())
                                    select _Location).ToList();
            if (comboBox2.Items.Count > 0)
                comboBox2.SelectedIndex = 0;
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
