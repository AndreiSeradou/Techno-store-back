using AutoMapper;
using Techno_store_back.BL.Models.DTOs;
using Techno_store_back.DAL.Models.DTOs;

namespace Techno_store_back.BL.Mapping
{
    public class MappingBLConfiguration : Profile
    {
        public MappingBLConfiguration()
        {
            CreateMap<LaptopBL, LaptopDAL>().ReverseMap();
            CreateMap<OrderBL, OrderDAL>().ReverseMap();
            CreateMap<CatalogBL, CatalogDAL>().ReverseMap();
        }
    }
}
