using AutoShops.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShops.Models {
    public class Product {

        /// <summary>
        /// Ид продукта
        /// </summary>
        [Key]
        public int IdProduct { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string? Comment { get; set; }
        /// <summary>
        /// Излбражение
        /// </summary>
        public byte[]? Image { get; set; }
        /// <summary>
        /// Ид категории
        /// </summary>
        public int IdCategory { get; set; }
        /// <summary>
        /// Количество товара в магазине
        /// </summary>
        public int Count { get; set; }
        [ForeignKey(nameof(IdCategory))]
        public Category CategoryID { get; set; }
        public List<Cart> Cart { get; set; } = new List<Cart>();

        public List<Storage> storages { get; set; } = new List<Storage>();
        public List<ProductOrder> productOrders { get; set; } = new List<ProductOrder>();

    }
}
