using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AutoShops.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using AutoShops.Repositories;
using VisioForge.MediaFramework.Helpers;

namespace AutoShops.DBL.SMTP
{
    public static class SendMail
    {
        
        public static void Send (string Email, Order order, List<Cart> cart) {
            SendEmailAsync(Email,order, cart).GetAwaiter();
        }
        private static async Task SendEmailAsync (string Email, Order order,List<Cart> cart) {
            ProductRepositories orderRepositories = new ProductRepositories();
            MailAddress from = new MailAddress("andrianov.2024@list.ru", "AutoShops");
            MailAddress to = new MailAddress(Email);
            MailMessage m = new MailMessage(from, to);
            decimal total = 0;
            m.Subject = $"Заказ №{order.NumberOrder} сформирован";
            //m.Body = "<style>\r\n   #total {\r\n      text-align:right;\r\n   }\r\n\r\n   #table {\r\n      border:1px solid red;\r\n      border-collapse:separate;\r\n   }\r\n\r\n   #table th, #table td {\r\n      border:1px solid #000;\r\n   }\r\n</style>";
            m.Body = $"<h2>Заказ №{order.NumberOrder} успешно создан. </h2>\r\n<h4> Товары заказа:</h4>\r\n<table border=1px >\r\n<tr><th>Название</th><th>Цена</th><th>Количество</th></tr>";
            foreach(Cart cartItem in cart)
            {
                m.Body += $"<tr><td>{orderRepositories.ShowOrders().FirstOrDefault(x => x.IdProduct == cartItem.Idproduct).Name}</td><td>{cartItem.CostOrder}</td><td>{cartItem.Count}</td></tr>";
                total += cartItem.CostOrder;
            }
            m.Body += $"\r\n    <tr>\r\n      <th  colspan=\"1\" border=0px text-align=right>Итого :</th>\r\n      <td>{total}</td>\r\n    </tr>\r\n   \r\n</table>";
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.list.ru", 25);
            smtp.Credentials = new NetworkCredential("andrianov.2024@list.ru", "XWtbT6Yy4ik86fevxK0s");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
    }
}
