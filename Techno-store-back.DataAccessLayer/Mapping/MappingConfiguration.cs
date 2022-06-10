using AutoMapper;
using Techno_store_back.DataAccessLayer.Entities;
using Techno_store_back.DataAccessLayer.Models.DTOs;

namespace Techno_store_back.DataAccessLayer.Mapping
{
    public class MappingDALConfiguration : Profile
    {
        public MappingDALConfiguration()
        {
            CreateMap<Laptop, LaptopDAL>().ReverseMap();
        }
    }
}
