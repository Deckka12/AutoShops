using AutoShops.DBL;
using AutoShops.DBL.Excel;
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
        OrderRepositories repositories = new OrderRepositories();
        private void CurrentOrder_Load (object sender, EventArgs e) {
            formLoad.FillOrders(dataGridView1);
            formLoad.FillComboBoxState(StateOrder);
            formLoad.DesignDataGridView(dataGridView1);
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

        private void ImportExcel_Click (object sender, EventArgs e) {
            if(dataGridView1.Rows.Count > 0)
                InputExcel.Input(dataGridView1);
            else
                MessageBox.Show("Нет данных для вывода");
        }

        private void Filtered_Click (object sender, EventArgs e) {
            formLoad.FillOrdersFiltered(dataGridView1, repositories.FilteredOrders(dateTimePicker1.Value.Date,dateTimePicker2.Value.Date));
        }
    }
}
