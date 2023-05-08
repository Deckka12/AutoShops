using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AutoShops.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AutoShops.DBL.SMTP
{
    public static class SendMail
    {
        public static void Send (string Email, Order order) {
            SendEmailAsync(Email,order).GetAwaiter();
        }
        private static async Task SendEmailAsync (string Email, Order order) {
            MailAddress from = new MailAddress("andrianov.2024@list.ru", "AutoShops");
            MailAddress to = new MailAddress(Email);
            MailMessage m = new MailMessage(from, to);
            m.Subject = $"Заказ №{order.NumberOrder}";
            m.Body = $"<h2>Заказ №{order.NumberOrder} успешно создан. </h2>";
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.list.ru", 25);
            smtp.Credentials = new NetworkCredential("andrianov.2024@list.ru", "XWtbT6Yy4ik86fevxK0s");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
    }
}
