using Microsoft.EntityFrameworkCore;
using ProyectoNegocio.Infrastructure.Data;
using System.Linq.Expressions;

namespace ProyectoNegocio.Infrastructure.Repository
{
    public class RepositoryBase<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly AppDbContext _context;
        public RepositoryBase(AppDbContext context)
        {
            _context = context;
        }
        public void Add(TEntity objModel)
        {
            _context.Set<TEntity>().Add(objModel);
            _context.SaveChanges();
        }

        public void AddRange(IEnumerable<TEntity> objModel)
        {
            _context.Set<TEntity>().AddRange(objModel);
            _context.SaveChanges();
        }

        public int Count()
        {
            return _context.Set<TEntity>().Count();
        }

        public async Task<int> CountAsync()
        {
            return await _context.Set<TEntity>().CountAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public TEntity? Get(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().FirstOrDefault(predicate);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().FirstOrDefaultAsync(predicate);
        }

        public TEntity? GetId(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public async Task<TEntity?> GetIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).ToList();
        }

        public async Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().Where(predicate).ToArrayAsync();
        }

        public void Remove(TEntity objModel)
        {
            _context.Set<TEntity>().Remove(objModel);
            _context.SaveChanges();
        }

        public void Update(TEntity objModel)
        {
            _context.Entry(objModel).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
