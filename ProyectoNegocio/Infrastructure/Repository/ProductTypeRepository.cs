using ProyectoNegocio.Infrastructure.Data;
using ProyectoNegocio.Infrastructure.Interfaces;
using ProyectoNegocio.Infrastructure.Model;

namespace ProyectoNegocio.Infrastructure.Repository
{
    public class ProductTypeRepository : RepositoryBase<ProductType>, IProductTypeRepository
    {
        public ProductTypeRepository(AppDbContext context) : base(context)
        {
        }
    }
}
