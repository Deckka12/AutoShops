using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoShops.Models;
using AutoShops.Repositories;


namespace AutoShops.DBL
{
    public  class FormLoad
    {
        Context _context;

        CategoryRepositories categoryRepositories = new CategoryRepositories();
        InformationAccounts informationAccounts = new InformationAccounts();
        ProductRepositories orderRepositories = new ProductRepositories();
        
        public FormLoad () {
            _context = ContextRun.Context();

            
        }
        public void viewPartsVisible (DataGridView dataGridView,GroupBox groupBox,Button Addcart,bool visible ) {
            dataGridView.Visible = visible;
            groupBox.Visible = visible;
            Addcart.Visible = visible;
        }
        public void FillControls (Button RemoveAddEmpl,Button ThisOrder) {
            if(!informationAccounts.IsAvailable)
            {
                RemoveAddEmpl.Visible = false;
                ThisOrder.Visible = false;
            }
        }

        public void FillComboBoxCategory (ComboBox comboBox1) {
            if(comboBox1.Items.Count>0)
                comboBox1.Items.Clear();
            var c = categoryRepositories.ShowCategories();
            foreach(var category in c)
            {
                comboBox1.Items.Add(category.NameCategory);
            }
        }
        public void FillComboBoxAdmin (ComboBox comboBox1) {
            if(comboBox1.Items.Count > 0)
                comboBox1.Items.Clear();
            comboBox1.Items.Add(true);
            comboBox1.Items.Add(false);
        }
        public void FillDataGrid (DataGridView dataGridView1, List<Product> orders) {
            if(dataGridView1.Rows.Count > 0)
                dataGridView1.Rows.Clear();
            for(int i = 0; i < orders.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = orders[i].Name;
                dataGridView1.Rows[i].Cells[1].Value = categoryRepositories.ShowCategoriesKey( orders[i].IdCategory);
                dataGridView1.Rows[i].Cells[2].Value = orders[i].Price;
            }
        }

        public void SelectComboAndFillDaraGrid (string name, DataGridView dataGridView) {
            dataGridView.Rows.Clear();
            var c = orderRepositories.ShowOrdersCategory( name);
            FillDataGrid(dataGridView, c);
        }

        public void SelectTextAndFillDaraGrid (string name, DataGridView dataGridView) {
            dataGridView.Rows.Clear();
            var c = orderRepositories.ShowOrdersName( name);
            FillDataGrid(dataGridView, c);
        }
        public void FillOrders (DataGridView dataGridView1) {
            OrderRepositories repositories = new OrderRepositories();
            if(dataGridView1.Rows.Count > 0)
                dataGridView1.Rows.Clear();
            
            ProductRepositories productRepositories = new ProductRepositories();
            var orders = repositories.ViewOrder();
            for(int i = 0; i < orders.Count; i++)
            {
                var items = repositories.viewProduct(orders[i]);
                for(int j = 0; j < items.Count; j++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[j].Cells[0].Value = orders[i].NumberOrder;
                    dataGridView1.Rows[j].Cells[1].Value = orders[i].OrderDate;
                    dataGridView1.Rows[j].Cells[2].Value = items[j].Sum;
                    dataGridView1.Rows[j].Cells[3].Value = orders[i].DateDeliveri;
                    dataGridView1.Rows[j].Cells[4].Value = repositories.ViewNameState(orders[i]);
                    dataGridView1.Rows[j].Cells[5].Value = productRepositories.ShowOrdersId(items[j].productId).Name;
                    dataGridView1.Rows[j].Cells[6].Value = items[j].Count;
                }
            }
        }

        public void FillComboBoxState (ComboBox comboBox1) {
            OrderRepositories repositories = new OrderRepositories();
            if(comboBox1.Items.Count > 0)
                comboBox1.Items.Clear();
            var c = repositories.ViewState();
            foreach(var category in c)
            {
                comboBox1.Items.Add(category.Name);
            }
        }

        public void EditStateOrder (DataGridView dataGridView1,ComboBox comboBox) {
            OrderRepositories repositories = new OrderRepositories();
            repositories.EditStateOrder(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),
                                        repositories.ViewStateID(comboBox.Text));
            FillOrders(dataGridView1);
        }


    }
}
