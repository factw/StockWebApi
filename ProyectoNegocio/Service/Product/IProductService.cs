using ProyectoNegocio.Infrastructure.Dtos;

namespace ProyectoNegocio.Service.Product
{
    public interface IProductService
    {
        Task CreateProductAsync(ProductsDTO productDto);
        Task<ProductsDTO> GetProductDtoByIdAsync(int productId);
        Task<List<ProductsDTO>> GetProductListAsync();

    }
}
