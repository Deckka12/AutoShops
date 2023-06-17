using AutoShops.DBL;
using AutoShops.DBL.SMTP;
using AutoShops.Models;
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
    public partial class ExecuteOrderssss : Form
    {
        public ExecuteOrderssss () {
            InitializeComponent();
        }
        FormLoadCart cart = new FormLoadCart ();
        FormLoad load = new FormLoad();
        OrderRepositories OrderRepositories = new OrderRepositories ();
        private void dataGridView1_CellContentClick (object sender, DataGridViewCellEventArgs e) {

        }

        private void ExecuteOrders_Load (object sender, EventArgs e) {
            cart.FillCart(ItemsOrders);
            ItemsOrders.ReadOnly = true;
            load.DesignDataGridView(ItemsOrders);
        }

        private void button1_Click (object sender, EventArgs e) {
            try
            {
                CartRepositories cartRepositories = new CartRepositories();
                var cart = cartRepositories.ShowCart();
                Clients client = new Clients()
                {
                    Name = Name.Text,
                    FirstName = FirstName.Text,
                    MiddleName = MiddleName.Text,
                    Addres = Addres.Text,
                    Phone = Phone.Text,
                    Email = Email.Text
                };
                var order = OrderRepositories.Add(client);
                SendMail.Send(client.Email, order, cart);
                Thread.Sleep(300);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message +Environment.NewLine+ "Оформление заказа отменено!");
            }
            
        }

        private void InfoCLient_Enter (object sender, EventArgs e) {

        }
    }
}
