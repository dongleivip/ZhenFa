using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ZhenFa.Controllers.Resources
{
    public class OrderResource
    {
        public long Id { get; set; }

        public string Customer { get; set; }

        public DateTime OrderDate { get; set; }

        public ICollection<ItemResource> Items { get; set; }

        public OrderResource()
        {
            Items = new Collection<ItemResource>();
        }
    }
}
