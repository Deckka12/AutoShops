using AutoShops.Models;
using AutoShops.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShops.DBL
{
    class FormLoadCart
    {

        ProductRepositories orderRepositories = new ProductRepositories();
        CartRepositories cartRepositories = new CartRepositories();


        public void FillDataGrid (DataGridView dataGridView1, List<Cart> carts) {
            for(int i = 0; i < carts.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = orderRepositories.ShowOrders().FirstOrDefault(x => x.IdProduct == carts[i].Idproduct).Name;
                dataGridView1.Rows[i].Cells[1].Value = carts[i].CostOrder;
                dataGridView1.Rows[i].Cells[2].Value = carts[i].Count;
            }
        }
        public void FillCart (DataGridView dataGridView) {
            dataGridView.Rows.Clear();
            var c = cartRepositories.ShowCart();
            FillDataGrid(dataGridView, c);
        }
    }
}
