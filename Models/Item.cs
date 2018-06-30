using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZhenFa.Models
{
    [Table("Items")]
    public class Item
    {
        public long Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public int Count { get; set; }

        [StringLength(255)]
        public string Specs { get; set; }

        public Order Order { get; set; }

        public long OrderId { get; set; }
    }
}
