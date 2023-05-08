using AutoShops.DBL;
using AutoShops.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoShops.Forms
{
    public partial class CurrentOrder : Form
    {
        FormLoad formLoad = new FormLoad();
        public CurrentOrder () {
            InitializeComponent();
        }

        private void CurrentOrder_Load (object sender, EventArgs e) {
            formLoad.FillOrders(dataGridView1);
            formLoad.FillComboBoxState(StateOrder);
        }

        private void dataGridView1_CellContentClick (object sender, DataGridViewCellEventArgs e) {

        }

        private void EditStateOrder_Click (object sender, EventArgs e) {
            int selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if(selectedRowCount > 0)
            {
                formLoad.EditStateOrder(dataGridView1,StateOrder);
            }
            else
            {
                MessageBox.Show("Выберите запись для изменения");
            }
        }
    }
}
