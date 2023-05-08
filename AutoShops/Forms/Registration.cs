using AutoShops.DBL;
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
        FormLoad form = new FormLoad ();
        AccountRepositories accountrep = new AccountRepositories();
        Account oldAccount;
        private void button1_Click (object sender, EventArgs e) {
           
            Account account = new Account
            {
                Administration = Admin.Checked,
                Name = FIO.Text,
                Login=Login.Text,
                Password=Password.Text
            };
            try
            {
                accountrep.Add(account);
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show($"Пользователь {account.Name} успешно добавлен");
            form.SelectedAccount(dataGridView1);
        }

        private void Registration_Load (object sender, EventArgs e) {
            form.SelectedAccount(dataGridView1);
        }

        private void dataGridView1_SelectionChanged (object sender, EventArgs e) {

            int selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if(selectedRowCount > 0)
            {
                oldAccount = null;
                oldAccount = accountrep.GetAccount(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                if(oldAccount != null)
                {
                    FIO.Text = oldAccount.Name;
                    Login.Text = oldAccount.Login;
                    Password.Text = oldAccount.Password;
                    Admin.Checked = oldAccount.Administration;
                }
            }
        }

        private void EditAccount_Click (object sender, EventArgs e) {
            int selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if(selectedRowCount > 0)
            {
                var newAc = new Account
                {
                    Name = FIO.Text,
                    Login = Login.Text,
                    Password = Password.Text,
                    Administration = Admin.Checked
                };
                accountrep.Update(oldAccount, newAc);
                form.SelectedAccount(dataGridView1);
            }
        }
    }
}
