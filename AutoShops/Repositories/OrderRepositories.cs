using AutoShops.Models;
using Gst.WebRTC;
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
        public Order Add (Clients client) {
            
            var clinets = _clientRepositories.Search(client);
            if(clinets != null)
            {
                return AddOrder(clinets);
            }
            else
            {
                return AddOrder(_clientRepositories.Search(_clientRepositories.AddClient(client)));
            }

        }
        public List<Order> ViewOrder () {
            return _context.Order.ToList();
        }
        public Order ViewOrderByName(string Name) {
            return _context.Order.Where(x => x.NumberOrder == Name).FirstOrDefault();
        }
        public List<ProductOrder> viewProduct (Order order) {
            return _context.ProductOrder.Where(x => x.OrderId == order.IdOrder).ToList();
        }
        public string ViewNameState(Order order) {
            return _context.StateOrder.Where(x => x.IdState == order.StateOrderId).FirstOrDefault().Name;
        }
        public List<StateOrder> ViewState () {
            return _context.StateOrder.ToList();
        }
        public int ViewStateID (string name) {
            return _context.StateOrder.Where(x=>x.Name==name).FirstOrDefault().IdState;
        }

        public void EditStateOrder (string name,int idState) {
            var c= _context.Order.Where(x => x.NumberOrder == name).FirstOrDefault();
            c.StateOrderId = idState;
            _context.SaveChangesAsync();
        }
        public  Order AddOrder (Clients client) {

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
                    productId = cart[i].Idproduct,
                   
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

            //_cartRepositories.FullRemoveCart();

            return orders;
        }
    }
}
