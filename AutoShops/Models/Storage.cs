using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisioForge.Libs.DirectShowLib;

namespace AutoShops.Models
{
    public class Storage
    {
        [Key]
        public int Id { get; set; }
        public int Count { get; set; }
        public int IDproduct { get; set; }
        [ForeignKey(nameof(IDproduct))]
        public Product product { get; set; }
    }
}
