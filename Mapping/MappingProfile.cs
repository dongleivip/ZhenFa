using AutoMapper;
using ZhenFa.Controllers.Resources;
using ZhenFa.Models;

namespace ZhenFa.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrderResource>();
            CreateMap<Item, ItemResource>();
        }
    }
}
