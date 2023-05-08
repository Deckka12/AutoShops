using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using VisioForge.Libs.DirectShowLib;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace AutoShops.Models {
    public class ProductOrder : IEntity
    {
        /// <summary>
        /// Ид товара из заказа
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Количество товара
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Сумма товара
        /// </summary>
        public decimal Sum { get; set; }
        /// <summary>
        /// Внешний ключ заказа
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// навигационное свойство заказа
        /// </summary>
        [ForeignKey(nameof(OrderId))]
        public Order? order { get; set; }
        /// <summary>
        /// Внешний ключ товар
        /// </summary>
        
        public int productId { get; set; }
        /// <summary>
        /// навигационное свойство заказа
        /// </summary>
        [ForeignKey(nameof(productId))]
        public Product? product { get; set; }


    }
}
