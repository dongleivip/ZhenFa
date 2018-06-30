using System;
using System.Collections.Generic;

namespace ZhenFa.Models
{
    public class Order
    {
        public long Id { get; set; }

        public string Customer { get; set; }

        public DateTime OrderDate { get; set; }

        public ICollection<Item> Items { get; set; }

        public Order()
        {
            Items = new List<Item>();
        }
    }
}
