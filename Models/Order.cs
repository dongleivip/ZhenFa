using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZhenFa.Models
{
    public class Order
    {
        public long Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Customer { get; set; }

        [Column(TypeName = "Date")]
        public DateTime OrderDate { get; set; }

        public ICollection<Item> Items { get; set; }

        public Order()
        {
            Items = new List<Item>();
        }
    }
}
