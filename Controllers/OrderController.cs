using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZhenFa.Controllers.Resources;
using ZhenFa.Models;
using ZhenFa.Persistence;

namespace ZhenFa.Controllers
{
    public class OrderController : Controller
    {
        private readonly ZhenFaDbContext _context;

        private readonly IMapper _mapper;

        public OrderController(ZhenFaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("api/orders")]
        public async Task<IEnumerable<OrderResource>> GetOrders()
        {
            var orders = await _context.Orders.Include(o => o.Items).ToListAsync();

            return _mapper.Map<List<Order>, List<OrderResource>>(orders);
        }
    }
}