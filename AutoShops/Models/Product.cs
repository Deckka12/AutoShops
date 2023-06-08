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
        public int CategoryID { get; set; }
        public string Articl { get; set; }
        /// <summary>
        /// Количество товара в магазине
        /// </summary>
        public int Count { get; set; }
        [ForeignKey(nameof(CategoryID))]
        public virtual Category Category { get; set; }
        public virtual List<Cart> Cart { get; set; } = new List<Cart>();

        public virtual List<Storage> Storage { get; set; } = new List<Storage>();
        public virtual List<ProductOrder> ProductOrder { get; set; } = new List<ProductOrder>();

    }
}
