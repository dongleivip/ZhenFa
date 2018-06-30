using Microsoft.EntityFrameworkCore;
using ZhenFa.Models;

namespace ZhenFa.Persistence
{
    public class ZhenFaDbContext: DbContext
    {
        public ZhenFaDbContext(DbContextOptions options): base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
    }
}
