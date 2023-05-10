 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisioForge.Libs.DirectShowLib;

namespace AutoShops.Models {
    public class Order {
        /// <summary>
        /// ИД заказа
        /// </summary>
        [Key]
        public int IdOrder { get; set; }
        /// <summary>
        /// Дата заказа
        /// </summary>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// Дата доставки
        /// </summary>
        public DateTime DateDeliveri { get; set; }
        /// <summary>
        /// Сумма товара
        /// </summary>
        public decimal CostOrder { get; set; }
        /// <summary>
        /// Номер заказа
        /// </summary>
        public string NumberOrder { get; set; }
        /// <summary>
        /// Ид клиента
        /// </summary>
        [ ForeignKey("Clients")]
        [Column("ClientId", Order = 0)]
        public int ClientsId { get; set; }
        [ForeignKey(nameof(ClientsId))]
        public virtual Clients Clients { get; set; }
        
        /// <summary>
        /// Навигационное свойство товаров
        /// </summary>
        public virtual List<ProductOrder> ItemsOrder { get; set; } = new List<ProductOrder>();
        /// <summary>
        /// Ид состояния
        /// </summary>
        [ ForeignKey("StateOrder")]
        [Column(Order = 1)]
        public int StateOrderId { get; set; }
        [ForeignKey(nameof(StateOrderId))]
        public virtual StateOrder StateOrder { get; set; }

    }
}
