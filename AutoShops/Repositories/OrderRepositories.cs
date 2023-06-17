using AutoShops.DBL;
using AutoShops.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutoShops.Repositories
{
    public class OrderRepositories
    {
        public OrderRepositories () {
            _context = ContextRun.Context();
        }
        Context _context;
        ClientRepositories _clientRepositories = new ClientRepositories();
        CartRepositories _cartRepositories = new CartRepositories();
        StateRepositories _stateRepositories = new StateRepositories();
        /// <summary>
        /// Добавление заказа
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public Order Add (Clients client) {
            
            var clinets = _clientRepositories.Search(client);
            if(clinets != null)
            {
                return AddOrder(clinets);
            }
            else
            {
                var clients = _clientRepositories.AddClient(client);
                return AddOrder(_clientRepositories.Search(client));
            }

        }
        /// <summary>
        /// Вывод заказа
        /// </summary>
        /// <returns></returns>
        public List<Order> ViewOrder () {
            return _context.Order.Include(x=>x.StateOrder).ToList();
        }
        /// <summary>
        /// вывод состояния заказа
        /// </summary>
        /// <returns></returns>
        public List<StateOrder> ViewState () {
            return _context.StateOrder.ToList();
        }
        /// <summary>
        ///  вывод шд состояния
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int ViewStateID (string name) {
            return _context.StateOrder.Where(x=>x.Name==name).FirstOrDefault().IdState;
        }
        /// <summary>
        /// Редактирования состояния заказа
        /// </summary>
        /// <param name="name"></param>
        /// <param name="idState"></param>
        public void EditStateOrder (string name,int idState) {
            var c= _context.Order.Where(x => x.NumberOrder == name).FirstOrDefault();
            c.StateOrderId = idState;
            _context.SaveChangesAsync();
        }
        /// <summary>
        /// Добавление заказа
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        private  Order AddOrder (Clients client) {

            Random random = new Random();
            var states = _stateRepositories.viewState("Создан");

            var orders = new Order
            {
                OrderDate = DateTime.Now,
                CostOrder = 0,
                NumberOrder = "A" + random.Next(00001, 10000),
                ClientsId = client.Id,
                StateOrderId = states.IdState
            };
            decimal sum = 0;
            bool state = false;
            _context.Order.Add(orders);
            var cart = _cartRepositories.ShowCart();
            List<ProductOrder> productOrders = new List<ProductOrder>();
             _context.SaveChanges();
            for(int i = 0; i < cart.Count; i++)
            {
                var productOrder = new ProductOrder
                {
                    Count = cart[i].Count,
                    Sum = cart[i].CostOrder,
                    OrderId = orders.IdOrder,
                    productId = cart[i].ProductIdProduct,
                   
                };
                sum += cart[i].CostOrder;
                productOrders.Add(productOrder);
                _context.SaveChanges();
                if(cart[i].IsNotCountShop)
                    state = true;
            }
            if(state)
                orders.DateDeliveri = DateTime.Now.AddDays(3);
            else
                orders.DateDeliveri = DateTime.Now;
            _context.ProductOrder.AddRange(productOrders);
            orders.CostOrder = sum;
            _context.SaveChanges();

            _cartRepositories.FullRemoveCart();

            return orders;
        }
        public List<Order> FilteredOrders(DateTime dateTimeFrom, DateTime dateTimeTo) {
 
               return _context.Order.Include(x => x.StateOrder).Where(x => x.OrderDate >= dateTimeFrom && x.OrderDate <= dateTimeTo).ToList();

        }
    }
}
