using AutoMapper;
using stockportfolio.Controllers.Resources;
using stockportfolio.Models;

namespace stockportfolio.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserResource>();
            CreateMap<UserStock, UserStockResource>();
            CreateMap<StockExchange, StockExchangeResource>();
            CreateMap<Stock, StockResource>();
        }
    }
}