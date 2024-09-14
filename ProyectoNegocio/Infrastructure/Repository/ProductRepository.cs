using ProyectoNegocio.Infrastructure.Data;
using ProyectoNegocio.Infrastructure.Interfaces;
using ProyectoNegocio.Infrastructure.Model;

namespace ProyectoNegocio.Infrastructure.Repository
{
    //public class ProductRepository : IProductRepository, IDisposable
    public class ProductRepository : RepositoryBase<Products>, IProductRepository
    {
        //private readonly AppDbContext _context;

        //public ProductRepository(AppDbContext dbStoreContext)
        //{
        //    _context = dbStoreContext;
        //}

        //public async Task<IEnumerable<Products>> GetProductsAsync()
        //{
        //    return await _context.products
        //                         .Include(p => p.Fragrancy)
        //                         .Include(p => p.ProductType)
        //                         .ToListAsync();
        //}

        //public async Task<Products?> GetByIdAsync(int id)
        //{
        //    return await _context.products
        //                         .Include(p=> p.Fragrancy)
        //                         .Include(p=> p.ProductType)
        //                         .FirstOrDefaultAsync(p=> p.Id.Equals(id));
        //}

        //public async Task InsertAsync(Products product)
        //{
        //    if (product == null)
        //        throw new ArgumentNullException(nameof(product));
        //    await _context.products.AddAsync(product);
        //}

        //public async Task UpdateProductAsync(Products product)
        //{
        //    _context.Entry(product).State = EntityState.Modified; 
        //}

        //public async Task DeleteProductsAsync(int productID)
        //{
        //    Products product = await _context.products.FindAsync(productID);
        //    if (product != null)
        //    {
        //        _context.products.Remove(product);
        //    }
        //}

        //public async Task Save()
        //{
        //    await _context.SaveChangesAsync();
        //}

        //private bool disposed = false;

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!this.disposed)
        //    {
        //        if (disposing)
        //        {
        //            _context.Dispose();
        //        }
        //    }
        //    this.disposed = true;
        //}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
