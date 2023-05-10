using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShops.Models
{
    public class Category : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string NameCategory { get; set; }

        // Навигационное свойство
        public virtual ICollection<Product> Product { get; set; }
        public Category () {
            Product = new List<Product> ();
        }
    }
}
