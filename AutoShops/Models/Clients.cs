using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShops.Models
{
    public class Clients
    {
        /// <summary>
        /// Ид клиента
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Имя клиента
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Фамилия клиента
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string MiddleName { get; set; }
        /// <summary>
        /// Адресс
        /// </summary>
        public string Addres { get; set; }
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Почта
        /// </summary>
        public string Email { get; set; }

        public List<Order> Order { get; set; }

    }
}
