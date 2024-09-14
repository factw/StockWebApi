using ProyectoNegocio.Infrastructure.Data;
using ProyectoNegocio.Infrastructure.Interfaces;
using ProyectoNegocio.Infrastructure.Model;

namespace ProyectoNegocio.Infrastructure.Repository
{
    public class FragrancyRepository : RepositoryBase<Fragrancy>, IFragrancyRepository
    {
        public FragrancyRepository(AppDbContext context) : base(context)
        {
        }
    }
}
