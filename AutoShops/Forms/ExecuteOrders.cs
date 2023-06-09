﻿using AutoShops.DBL;
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
    public partial class ExecuteOrders : Form
    {
        public ExecuteOrders () {
            InitializeComponent();
        }
        FormLoadCart cart = new FormLoadCart ();
        OrderRepositories OrderRepositories = new OrderRepositories ();
        private void dataGridView1_CellContentClick (object sender, DataGridViewCellEventArgs e) {

        }

        private void ExecuteOrders_Load (object sender, EventArgs e) {
            cart.FillCart(ItemsOrders);
            ItemsOrders.ReadOnly = true;
        }

        private void button1_Click (object sender, EventArgs e) {
            Clients client = new Clients()
            {
                Name = Name.Text,
                FirstName = FirstName.Text,
                MiddleName = MiddleName.Text,
                Addres = Addres.Text,
                Phone = Phone.Text,
                Email = Email.Text
            };
            var order =OrderRepositories.Add(client);
            //SendMail.Send(client.Email, order);
            //Thread.Sleep(300);
            this.Close();
        }

        private void InfoCLient_Enter (object sender, EventArgs e) {

        }
    }
}
