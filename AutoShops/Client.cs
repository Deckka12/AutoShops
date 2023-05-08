using AutoShops.Models;
using AutoShops.Repositories;
using AutoShops.DBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using AutoShops.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace AutoShops
{
    public partial class Client : Form
    {
        Context _context;
        public Client () {
            InitializeComponent();
            _context = ContextRun.Context();
        }
        Color defaultBackColor;
        ProductRepositories orders = new ProductRepositories();
        FormLoad form = new FormLoad();
        
        CartRepositories cartRepositories = new CartRepositories();
        private void Client_Load (object sender, EventArgs e) {
            ViewParts_Click(sender, e);
            ViewParts.BackColor = Color.YellowGreen;
            defaultBackColor = OrdersParts.BackColor;
            form.FillControls(RemoveAddEmpl, ThisOrder);
        }
        private void ButtonColor (object sender, EventArgs e) {
            ViewParts.GotFocus += (sender, e) => { ViewParts.BackColor = Color.YellowGreen; };
            ViewParts.LostFocus += (sender, e) => { ViewParts.BackColor = defaultBackColor; };
            OrdersParts.GotFocus += (sender, e) => { OrdersParts.BackColor = Color.YellowGreen; };
            OrdersParts.LostFocus += (sender, e) => { OrdersParts.BackColor = defaultBackColor; };
            RemoveAddEmpl.GotFocus += (sender, e) => { RemoveAddEmpl.BackColor = Color.YellowGreen; };
            RemoveAddEmpl.LostFocus += (sender, e) => { RemoveAddEmpl.BackColor = defaultBackColor; };
            ThisOrder.GotFocus += (sender, e) => { ThisOrder.BackColor = Color.YellowGreen; };
            ThisOrder.LostFocus += (sender, e) => { ThisOrder.BackColor = defaultBackColor; };
        }
        private void ViewParts_Click (object sender, EventArgs e) {
            ViewParts.Click += ButtonColor;
            form.viewPartsVisible(ViewProduct, Filtered, Addcart, true);
            form.FillComboBoxCategory(Categories);
            form.FillDataGrid(ViewProduct, orders.ShowOrders());
        }

        private void OrdersParts_Click (object sender, EventArgs e) {
            OrdersParts.Click += ButtonColor;
            form.viewPartsVisible(ViewProduct, Filtered, Addcart, false);
            ExecuteOrders executeOrders = new ExecuteOrders();
            executeOrders.Show();
        }

        private void comboBox1_SelectedIndexChanged (object sender, EventArgs e) {
            form.SelectComboAndFillDaraGrid(Categories.Text, ViewProduct);
        }

        private void textBox1_TextChanged (object sender, EventArgs e) {
            form.SelectTextAndFillDaraGrid(NamesProduct.Text, ViewProduct);
        }
        public void ShowForm (object sender, EventArgs e) {
            Card card = new Card();
            card.Show();
        }

        private void Cart_Click (object sender, EventArgs e) {
            ShowForm(sender, e);
        }

        private void Addcart_Click (object sender, EventArgs e) {
            int selectedRowCount = ViewProduct.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if(selectedRowCount > 0)
            {
                if(orders.ShowOrdersNameCount( ViewProduct.SelectedRows[0].Cells[0].Value.ToString(),1)!=null)
                {
                    cartRepositories.AddCart( orders.ShowOrdersName( ViewProduct.SelectedRows[0].Cells[0].Value.ToString()).FirstOrDefault(),false);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Товара нет в наличие в магазине, хотите заказать со склада?", "Информация", MessageBoxButtons.YesNo);
                    if(result==DialogResult.Yes)
                        cartRepositories.AddCart( orders.ShowOrdersName( ViewProduct.SelectedRows[0].Cells[0].Value.ToString()).FirstOrDefault(), true);
                }

                    
            }
        }

        private void dataGridView1_CellClick (object sender, DataGridViewCellEventArgs e) {
            InfoProduct product = new InfoProduct(orders.ShowOrdersName( ViewProduct.Rows[e.RowIndex].Cells[0].Value.ToString()).FirstOrDefault());
            product.Show();
        }

        private void RemoveAddEmpl_Click (object sender, EventArgs e) {
            Registration registration = new Registration();
            registration.Show();
        }

        private void ThisOrder_Click (object sender, EventArgs e) {
            CurrentOrder currentOrder = new CurrentOrder();
            currentOrder.Show();
        }
    }
}
