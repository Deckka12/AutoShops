using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoShops.DBL;
using AutoShops.Models;
using AutoShops.Repositories;

namespace AutoShops.Forms
{
    public partial class ControlCLient : Form
    {
        public ControlCLient () {
            InitializeComponent();
        }
        FormLoad load = new FormLoad();
        ClientRepositories clientRepositories = new ClientRepositories();
        private void ControlCLient_Load (object sender, EventArgs e) {
            load.DesignDataGridView(dataGridView1);
            load.ShowCLient(dataGridView1);
        }
        Clients OldClients;
        private void dataGridView1_SelectionChanged (object sender, EventArgs e) {
            try
            {
                int selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if(selectedRowCount > 0)
                {
                    OldClients = null;
                    OldClients = clientRepositories.SearchEmailAndPhone(dataGridView1.SelectedRows[0].Cells[3].Value.ToString(), dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                    if(OldClients != null)
                    {
                        Name.Text = OldClients.Name;
                        FirstName.Text = OldClients.FirstName;
                        MiddleName.Text = OldClients.MiddleName;
                        Adress.Text = OldClients.Addres;
                        Phone.Text = OldClients.Phone;
                        Email.Text = OldClients.Email;
                    }
                }

            }
            catch
            {
                MessageBox.Show("Нет данных для выбора");
            }
        }

        private void groupBox1_Enter (object sender, EventArgs e) {
            
            
        }

        private void AddClient_Click (object sender, EventArgs e) {
            Clients client = new Clients
            {
                Addres = Adress.Text,
                Phone = Phone.Text,
                Email = Email.Text,
                Name = Name.Text,
                FirstName = FirstName.Text,
                MiddleName = MiddleName.Text
            };
            clientRepositories.AddClient(client);
            load.ShowCLient(dataGridView1);
        }

        private void button2_Click (object sender, EventArgs e) {
            Clients client = new Clients
            {
                Addres = Adress.Text,
                Phone = Phone.Text,
                Email = Email.Text,
                Name = Name.Text,
                FirstName = FirstName.Text,
                MiddleName = MiddleName.Text
            };
            clientRepositories.EditClient(OldClients, client);
            load.ShowCLient(dataGridView1);
        }

        private void button3_Click (object sender, EventArgs e) {
            Clients client = new Clients
            {
                Addres = Adress.Text,
                Phone = Phone.Text,
                Email = Email.Text,
                Name = Name.Text,
                FirstName = FirstName.Text,
                MiddleName = MiddleName.Text
            };
            clientRepositories.RemoveClient(client);
            load.ShowCLient(dataGridView1);
        }
    }
}
