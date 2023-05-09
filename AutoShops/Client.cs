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
using AutoShops.DBL.Excel;

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
        CategoryRepositories CategoryRepositories = new CategoryRepositories();
        Product OldProduct;
        CartRepositories cartRepositories = new CartRepositories();
        private void Client_Load (object sender, EventArgs e) {
            ViewParts_Click(sender, e);
            ViewParts.BackColor = Color.DeepSkyBlue;
            defaultBackColor = OrdersParts.BackColor;
            form.FillControls(RemoveAddEmpl, ThisOrder, EditProduct, groupBox1,button1,ViewExcel);
            ViewProduct.ReadOnly=true;
        }
        private void ButtonColor (object sender, EventArgs e) {
            ViewParts.GotFocus += (sender, e) => { ViewParts.BackColor = Color.DeepSkyBlue; };
            ViewParts.LostFocus += (sender, e) => { ViewParts.BackColor = defaultBackColor; };
            OrdersParts.GotFocus += (sender, e) => { OrdersParts.BackColor = Color.DeepSkyBlue; };
            OrdersParts.LostFocus += (sender, e) => { OrdersParts.BackColor = defaultBackColor; };
            RemoveAddEmpl.GotFocus += (sender, e) => { RemoveAddEmpl.BackColor = Color.DeepSkyBlue; };
            RemoveAddEmpl.LostFocus += (sender, e) => { RemoveAddEmpl.BackColor = defaultBackColor; };
            ThisOrder.GotFocus += (sender, e) => { ThisOrder.BackColor = Color.DeepSkyBlue; };
            ThisOrder.LostFocus += (sender, e) => { ThisOrder.BackColor = defaultBackColor; };
        }
        private void ViewParts_Click (object sender, EventArgs e) {
            ViewParts.Click += ButtonColor;
            form.viewPartsVisible(ViewProduct, Filtered, Addcart, true);
            form.FillComboBoxCategory(Categories);
            form.FillComboBoxCategory(CategoryProduct);
            form.FillDataGrid(ViewProduct, orders.ShowOrders());
        }

        private void OrdersParts_Click (object sender, EventArgs e) {
            OrdersParts.Click += ButtonColor;
            //form.viewPartsVisible(ViewProduct, Filtered, Addcart, false);
            ExecuteOrderssss executeOrders = new ExecuteOrderssss();
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
                if(orders.ShowOrdersNameCount(ViewProduct.SelectedRows[0].Cells[0].Value.ToString(), 1) != null)
                {
                    cartRepositories.AddCart(orders.ShowOrdersName(ViewProduct.SelectedRows[0].Cells[0].Value.ToString()).FirstOrDefault(), false);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Товара нет в наличие в магазине, хотите заказать со склада?", "Информация", MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes)
                        cartRepositories.AddCart(orders.ShowOrdersName(ViewProduct.SelectedRows[0].Cells[0].Value.ToString()).FirstOrDefault(), true);
                }


            }
        }

        private void dataGridView1_CellClick (object sender, DataGridViewCellEventArgs e) {
            InfoProduct product = new InfoProduct(orders.ShowOrdersName(ViewProduct.Rows[e.RowIndex].Cells[0].Value.ToString()).FirstOrDefault());
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

        private void label5_Click (object sender, EventArgs e) {

        }

        private void ViewProduct_SelectionChanged (object sender, EventArgs e) {
            ProductRepositories productRepositories = new ProductRepositories();

            int selectedRowCount = ViewProduct.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if(selectedRowCount > 0)
            {
                OldProduct = null;
                OldProduct = productRepositories.ShowOrdersName(ViewProduct.SelectedRows[0].Cells[0].Value.ToString()).FirstOrDefault();
                if(OldProduct != null)
                {
                    NameProduct.Text = OldProduct.Name;
                    PriceProduct.Text = OldProduct.Price.ToString();
                    CommentProduct.Text = OldProduct.Comment;
                    CategoryProduct.SelectedItem = CategoryRepositories.ShowCategorName(OldProduct.IdCategory);
                }
            }
        }

        private void EditProduct_Click (object sender, EventArgs e) {
            int selectedRowCount = ViewProduct.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if(selectedRowCount > 0)
            {
                var productNew = new Product()
                {
                    Name = NameProduct.Text,
                    Price = decimal.Parse(PriceProduct.Text),
                    Comment = CommentProduct.Text,
                    IdCategory = CategoryRepositories.ShowCategorID(CategoryProduct.Text)
                };
                orders.EditProduct(OldProduct, productNew);
                form.FillDataGrid(ViewProduct, orders.ShowOrders());
            }
        }

        private void button1_Click (object sender, EventArgs e) {
            OpenFileDialog saveFileDialog = new OpenFileDialog();
            saveFileDialog.Filter = "Text files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {

            }
            byte[] imageData;
            using(System.IO.FileStream fs = new System.IO.FileStream(saveFileDialog.FileName, FileMode.Open))
            {
                imageData = new byte[fs.Length];
                fs.Read(imageData, 0, imageData.Length);
            }

            var productNew = new Product()
            {
                Name = NameProduct.Text,
                Price = decimal.Parse(PriceProduct.Text),
                Comment = CommentProduct.Text,
                IdCategory = CategoryRepositories.ShowCategorID(CategoryProduct.Text),
                Image = imageData
            };
            try
            {
                orders.AddProduct(productNew);
                form.FillDataGrid(ViewProduct, orders.ShowOrders());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ViewExcel_Click (object sender, EventArgs e) {
            InputExcel.Input(ViewProduct);
        }
    }
}
