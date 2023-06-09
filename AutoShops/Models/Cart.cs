﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisioForge.Libs.DirectShowLib;

namespace AutoShops.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Сумма товара
        /// </summary>
        public decimal CostOrder { get; set; }
        /// <summary>
        /// Количество товара
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Есть ли товар в магазине
        /// </summary>
        public bool IsNotCountShop { get; set; }
        /// <summary>
        /// Ид товара
        /// </summary>
        public int Idproduct { get; set; }
        [ForeignKey(nameof(Idproduct))]
        public Product product { get; set; }
    }
}
