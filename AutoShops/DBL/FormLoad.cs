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
    public class FormLoad
    {
        Context _context;

        CategoryRepositories categoryRepositories = new CategoryRepositories();
        InformationAccounts informationAccounts = new InformationAccounts();
        ProductRepositories orderRepositories = new ProductRepositories();
        ClientRepositories clientRepositories = new ClientRepositories();

        public FormLoad () {
            _context = ContextRun.Context();


        }

        /// <summary>
        /// заблокировать редактирование
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="groupBox"></param>
        /// <param name="Addcart"></param>
        /// <param name="visible"></param>
        public void viewPartsVisible (DataGridView dataGridView, GroupBox groupBox, Button Addcart, bool visible) {
            dataGridView.Visible = visible;
            groupBox.Visible = visible;
            Addcart.Visible = visible;
        }

        /// <summary>
        /// скрытие контрола
        /// </summary>
        /// <param name="RemoveAddEmpl"></param>
        /// <param name="ThisOrder"></param>
        /// <param name="editProduct"></param>
        /// <param name="comboBox"></param>
        /// <param name="add"></param>
        /// <param name="excel"></param>
        /// <param name="remove"></param>
        /// <param name="Edit"></param>
        /// <param name="addCat"></param>
        public void FillControls (Button RemoveAddEmpl, Button ThisOrder, Button editProduct, GroupBox comboBox, Button add, Button excel, Button remove, Button Edit, Button addCat, Button controlClient, bool isFlag) {
                RemoveAddEmpl.Visible = isFlag;
                ThisOrder.Visible = isFlag;
                editProduct.Visible = isFlag;
                comboBox.Enabled = isFlag;
                add.Visible = isFlag;
                excel.Visible = isFlag;
                remove.Visible = isFlag;
                Edit.Visible = isFlag;
                addCat.Visible = isFlag;
                controlClient.Visible = isFlag;
        }

        /// <summary>
        /// Заполнение комбобокс категории
        /// </summary>
        /// <param name="comboBox1"></param>
        public void FillComboBoxCategory (ComboBox comboBox1) {
            if(comboBox1.Items.Count > 0)
                comboBox1.Items.Clear();
            var c = categoryRepositories.ShowCategories();
            foreach(var category in c)
            {
                comboBox1.Items.Add(category.NameCategory);
            }
        }

        
        /// <summary>
        /// заполненеие грида продуктов
        /// </summary>
        /// <param name="dataGridView1"></param>
        /// <param name="orders"></param>
        public void FillDataGrid (DataGridView dataGridView1, List<Product> orders) {
            if(dataGridView1.Rows.Count > 0)
                dataGridView1.Rows.Clear();
            for(int i = 0; i < orders.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = orders[i].Name;
                dataGridView1.Rows[i].Cells[1].Value = orders[i].Category?.NameCategory;//categoryRepositories.ShowCategoriesKey( orders[i].CategoryID);
                dataGridView1.Rows[i].Cells[2].Value = orders[i].Price;
                dataGridView1.Rows[i].Cells[3].Value = orders[i].Articl;
            }
        }
        /// <summary>
        /// выюор продукта со категории
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dataGridView"></param>
        public void SelectComboAndFillDaraGrid (string name, DataGridView dataGridView) {
            dataGridView.Rows.Clear();
            var c = orderRepositories.ShowOrdersCategory(name);
            FillDataGrid(dataGridView, c);
        }
        /// <summary>
        /// Вывод продуктов по имени
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dataGridView"></param>
        public void SelectTextAndFillDaraGrid (string name, DataGridView dataGridView) {
            dataGridView.Rows.Clear();
            var c = orderRepositories.ShowOrdersContainsNameOrArticle(name);
            FillDataGrid(dataGridView, c);
        }

        /// <summary>
        /// вывод заказа
        /// </summary>
        /// <param name="dataGridView1"></param>
        public void FillOrders (DataGridView dataGridView1) {
            OrderRepositories repositories = new OrderRepositories();
            if(dataGridView1.Rows.Count > 0)
                dataGridView1.Rows.Clear();

            ProductRepositories productRepositories = new ProductRepositories();
            var orders = repositories.ViewOrder();
            int count = orders[0].ItemsOrder.Count;
            int i = 0;
            int dtCount = 0;
            for(; i < orders.Count; i++)

            {
                for(int j = 0; j < orders[i].ItemsOrder.Count; j++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[dtCount].Cells[0].Value = orders[i].NumberOrder;
                    dataGridView1.Rows[dtCount].Cells[1].Value = orders[i].OrderDate;
                    dataGridView1.Rows[dtCount].Cells[2].Value = orders[i].ItemsOrder[j].Sum;//items[j].Sum;
                    dataGridView1.Rows[dtCount].Cells[3].Value = orders[i].DateDeliveri;
                    dataGridView1.Rows[dtCount].Cells[4].Value = orders[i].StateOrder.Name;
                    dataGridView1.Rows[dtCount].Cells[5].Value = orders[i].ItemsOrder[j].product.Name;
                    dataGridView1.Rows[dtCount].Cells[6].Value = orders[i].ItemsOrder[j].Count;
                    dtCount++;
                }
            }
        }
        public void DesignDataGridView (DataGridView dataGridView1) {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(153, 180, 209);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        /// <summary>
        /// вывод заказа по фильтрам
        /// </summary>
        /// <param name="dataGridView1"></param>
        public void FillOrdersFiltered (DataGridView dataGridView1,List<Order> orders) {
            OrderRepositories repositories = new OrderRepositories();
            if(dataGridView1.Rows.Count > 0)
                dataGridView1.Rows.Clear();

            int i = 0;
            int dtCount = 0;
            for(; i < orders.Count; i++)
            {
                for(int j = 0; j < orders[i].ItemsOrder.Count; j++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[dtCount].Cells[0].Value = orders[i].NumberOrder;
                    dataGridView1.Rows[dtCount].Cells[1].Value = orders[i].OrderDate;
                    dataGridView1.Rows[dtCount].Cells[2].Value = orders[i].ItemsOrder[j].Sum;//items[j].Sum;
                    dataGridView1.Rows[dtCount].Cells[3].Value = orders[i].DateDeliveri;
                    dataGridView1.Rows[dtCount].Cells[4].Value = orders[i].StateOrder.Name;
                    dataGridView1.Rows[dtCount].Cells[5].Value = orders[i].ItemsOrder[j].product.Name;
                    dataGridView1.Rows[dtCount].Cells[6].Value = orders[i].ItemsOrder[j].Count;
                    dtCount++;
                }
            }
        }

        /// <summary>
        /// Заполнение состояний
        /// </summary>
        /// <param name="comboBox1"></param>
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
        /// <summary>
        /// Изменение состояния заказа
        /// </summary>
        /// <param name="dataGridView1"></param>
        /// <param name="comboBox"></param>
        public void EditStateOrder (DataGridView dataGridView1, ComboBox comboBox) {
            OrderRepositories repositories = new OrderRepositories();
            repositories.EditStateOrder(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),
                                        repositories.ViewStateID(comboBox.Text));
            FillOrders(dataGridView1);
        }
        /// <summary>
        /// Выбор аккаунта
        /// </summary>
        /// <param name="dataGridView"></param>
        public void SelectedAccount (DataGridView dataGridView) {
            AccountRepositories repositories = new AccountRepositories();
            FillDataGridAccount(dataGridView, repositories.GetAccounts());
        }

        /// <summary>
        /// Заполнение таблицы аккаунт
        /// </summary>
        /// <param name="dataGridView1">Форма заполненеия грид</param>
        /// <param name="account">Модель Аккаунта</param>
        public void FillDataGridAccount (DataGridView dataGridView1, List<Account> account) {
            if(dataGridView1.Rows.Count > 0)
                dataGridView1.Rows.Clear();
            for(int i = 0; i < account.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = account[i].Name;
                dataGridView1.Rows[i].Cells[1].Value = account[i].Login;
                dataGridView1.Rows[i].Cells[2].Value = account[i].Administration;
            }
        }

        public void ShowCLient(DataGridView dataGridView) {
            FillDataGridClient(dataGridView, clientRepositories.ShowClient());
        }
        /// <summary>
        /// Заполнение таблицы клиентов
        /// </summary>
        /// <param name="dataGridView1">Форма заполненеия грид</param>
        /// <param name="account">Модель Аккаунта</param>
        public void FillDataGridClient (DataGridView dataGridView1, List<Clients> clients) {
            if(dataGridView1.Rows.Count > 0)
                dataGridView1.Rows.Clear();
            for(int i = 0; i < clients.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = clients[i].FirstName + " "+ clients[i].Name + " " + clients[i].MiddleName;
                dataGridView1.Rows[i].Cells[1].Value = clients[i].Addres;
                dataGridView1.Rows[i].Cells[2].Value = clients[i].Phone;
                dataGridView1.Rows[i].Cells[3].Value = clients[i].Email;
            }
        }
    }
}
