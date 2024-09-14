using Microsoft.EntityFrameworkCore;
using ProyectoNegocio.Infrastructure.Model;

namespace ProyectoNegocio.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> employees { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<ProductType> productTypes { get; set; }
        public DbSet<Fragrancy> fragrancys { get; set;}
    }
}
