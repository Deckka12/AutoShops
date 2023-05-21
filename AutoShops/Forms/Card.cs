using AutoShops.DBL;
using AutoShops.Models;
using AutoShops.Repositories;

namespace AutoShops.Forms
{
    public partial class Card : Form
    {
        FormLoadCart load = new FormLoadCart();
        FormLoad loads = new FormLoad();
        CartRepositories cartRepositories = new CartRepositories();
        Context _context ;
        ProductRepositories orders = new ProductRepositories();
        TextBox text = new TextBox();
        Form form1 = new Form();
        
        public Card () {
            InitializeComponent();
            _context = ContextRun.Context();
        }
        
        private void button1_Click (object sender, EventArgs e) {
            int selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if(selectedRowCount > 0)
            {
                if(orders.ShowOrdersNameCount( dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), 1) != null)
                {
                    cartRepositories.PlusCount( orders.ShowOrdersName( dataGridView1.SelectedRows[0].Cells[0].Value.ToString()).FirstOrDefault(), int.Parse(textBox1.Text), false);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Товара нет в наличие в магазине, хотите заказать со склада?", "Информация", MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes)
                        cartRepositories.PlusCount( orders.ShowOrdersName( dataGridView1.SelectedRows[0].Cells[0].Value.ToString()).FirstOrDefault(),int.Parse(textBox1.Text), true);
                }
            }
            else
            {
                MessageBox.Show("Выберите позицию в которой необходимо добавить количество");
                return;
            }
            load.FillCart(dataGridView1);

        }

        private void Card_Load (object sender, EventArgs e) {
            load.FillCart(dataGridView1);
            dataGridView1.ReadOnly = true;
            loads.DesignDataGridView(dataGridView1);
        }

        private void textBox1_TextChanged (object sender, EventArgs e) {

        }
        public void Removs(object sender,EventArgs e) {
            cartRepositories.RemoveCart( orders.ShowOrdersName( dataGridView1.SelectedRows[0].Cells[0].Value.ToString()).FirstOrDefault(), int.Parse(text.Text));
            this.Close();
            form1.Close();
        }

        public void Cancel (object sender, EventArgs e) {
            form1.Close();
        }

        private void Remove_Click (object sender, EventArgs e) {
            Client client = new Client();
            int selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if(selectedRowCount > 0)
            {
                for(int i = 0; i < selectedRowCount; i++)
                {
                    Label label = new Label();
                    Button button1 = new Button();
                    Button button2 = new Button();


                    button1.Text = "OK";
                    label.Location = new Point(10, 10);
                    label.Size = new Size(218, 86);
                    label.Text = $"Удалить товар полностью? Если нужно удалить только опредленное количество введите количество и нажмите ОК, если нужно удалить все, просто нажмите ОК, для отмены нажмите Отмена";
                    text.Location = new Point(label.Left, label.Height + label.Top + 10);
                    button1.Location = new Point(text.Left, text.Height + text.Top + 10);
                    button2.Text = "Отмена";
                    button2.Location
                       = new Point(button1.Left, button1.Height + button1.Top + 10);
                    form1.Text = "Удаление товара";
                    button1.Click += Removs;
                    button2.Click += Cancel;
                    button1.Click += client.ShowForm;

                    form1.Controls.Add(button1);
                    form1.Controls.Add(text);
                    form1.Controls.Add(label);
                    form1.Controls.Add(button2);
                    form1.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Выберите позицию которую необходимо удалить");
                return;
            }

        }
    }
}
