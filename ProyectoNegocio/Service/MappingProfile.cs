using AutoMapper;
using ProyectoNegocio.Infrastructure.Dtos;
using ProyectoNegocio.Infrastructure.Model;

namespace ProyectoNegocio.Service
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Products, ProductsDTO>()
                .ForMember(dest => dest.Fragrancy, opt => opt.MapFrom(src => src.Fragrancy))
                .ForMember(dest => dest.ProductType, opt => opt.MapFrom(src => src.ProductType));

            CreateMap<ProductType, ProductTypeDTO>();
            CreateMap<Fragrancy, FragrancyDTO>().ReverseMap();

        }
    }
}
