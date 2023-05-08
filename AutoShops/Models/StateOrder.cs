using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShops.Models
{
    public class StateOrder
    {
        [Key]
        public int IdState { get; set; }
        public string Name { get; set; }
        public List<Order> Order { get; set; }
    }
}
