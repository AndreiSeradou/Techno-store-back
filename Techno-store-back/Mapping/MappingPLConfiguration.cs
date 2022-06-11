using AutoMapper;
using Techno_store_back.BL.Models.DTOs;
using Techno_store_back.Web.Models.DTOs;

namespace Techno_store_back.Web.Mapping
{
    public class MappingPLConfiguration : Profile
    {
        public MappingPLConfiguration()
        {
            CreateMap<LaptopPL, LaptopBL>().ReverseMap();
        }
    }
}
