using ProyectoNegocio.Infrastructure.Dtos;

namespace ProyectoNegocio.Service.Product
{
    public interface IProductTypeService
    {
        Task<ProductTypeDTO> CreateProductTypeAsync(ProductTypeDTO productTypeDto);
    }
}
