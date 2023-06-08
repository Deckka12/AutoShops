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
    public partial class InputUser : Form
    {
        public InputUser () {
            InitializeComponent();
        }
        AccountRepositories account = new AccountRepositories();
        public bool returnValue { get; set; }
        private void InputButton_Click (object sender, EventArgs e) {
            var input = account.InputAccaunt(textBox1.Text, textBox2.Text);
            if(input != null)
            {
                // Устанавливаем значение, которое мы хотим вернуть
                returnValue = input.Administration;
                // Устанавливаем свойство DialogResult
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void InputUser_Load (object sender, EventArgs e) {

        }
    }
}
