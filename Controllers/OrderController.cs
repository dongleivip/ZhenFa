using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZhenFa.Models;
using ZhenFa.Persistence;

namespace ZhenFa.Controllers
{
    public class OrderController : Controller
    {
        private readonly ZhenFaDbContext _context;

        public OrderController(ZhenFaDbContext context)
        {
            this._context = context;
        }

        [HttpGet("api/orders")]
        public async Task<IEnumerable<Order>> Index()
        {
            return await _context.Orders.Include(o => o.Items).ToListAsync();
        }
    }
}