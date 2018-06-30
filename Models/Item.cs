namespace ZhenFa.Models
{
    public class Item
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public int Count { get; set; }

        public string Specs { get; set; }

        public Order Order { get; set; }

        public long OrderId { get; set; }
    }
}
