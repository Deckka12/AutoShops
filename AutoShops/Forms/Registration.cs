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
    public partial class Registration : Form
    {
        public Registration () {
            InitializeComponent();
        }

        private void button1_Click (object sender, EventArgs e) {
            AccountRepositories accountrep = new AccountRepositories();
            Account account = new Account
            {
                Administration = Admin.Checked,
                Name = FIO.Text,
                Login=Login.Text,
                Password=Password.Text
            };
            accountrep.Add(account);
            MessageBox.Show($"Пользователь {account.Name} успешно добавлен");
            ;
        }
    }
}
