using AutoMapper;
using Techno_store_back.DAL.Entities;
using Techno_store_back.DAL.Models.DTOs;

namespace Techno_store_back.DAL.Mapping
{
    public class MappingDALConfiguration : Profile
    {
        public MappingDALConfiguration()
        {
            CreateMap<Laptop, LaptopDAL>().ReverseMap();
            CreateMap<Order, OrderDAL>().ReverseMap();
            CreateMap<Catalog, CatalogDAL>().ReverseMap();
        }
    }
}
