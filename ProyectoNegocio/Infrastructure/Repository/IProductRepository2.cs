using ProyectoNegocio.Infrastructure.Model;

namespace ProyectoNegocio.Infrastructure.Repository
{
    public interface IProductRepository2 : IDisposable
    {
        Task<IEnumerable<Products>> GetProductsAsync();
        Task<Products?> GetByIdAsync(int id);
        Task InsertAsync(Products product);
        Task DeleteProductsAsync(int productID);
        Task UpdateProductAsync(Products product);
        Task Save();
    }
}
