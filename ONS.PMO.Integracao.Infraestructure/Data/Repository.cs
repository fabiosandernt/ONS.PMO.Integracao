using AspNetCore.IQueryable.Extensions;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.Base;
using ONS.PMO.Integracao.Infraestructure.Context;
using System.Linq.Expressions;

namespace ONS.PMO.Integracao.Infraestructure.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbSet<T> _query { get; set; }
        protected DbContext _context { get; set; }
        public Repository(WebPmoContext context)
        {
            _context = context;
            _query = _context.Set<T>();
        }

        public async Task Delete(T entity)
        {
            _query.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> FindAllByCriterio(Expression<Func<T, bool>> expression)
        {
            return await _query.Where(expression).ToListAsync();
        }

        public async Task<T> FindOneByCriterio(Expression<Func<T, bool>> expression)
        {
           return await _query.FirstOrDefaultAsync(expression);
        }

        public async Task<T> Get(object id)
        {
            return await _query.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _query.ToListAsync();
        }

        public async Task Save(T entity)
        {
            await _query.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _query.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async ValueTask<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _query.AnyAsync(expression);
        }

        public async ValueTask<T> GetbyExpressionAsync(Expression<Func<T, bool>> expression)
        {
            return await _query.FirstOrDefaultAsync(expression);
        }

        public IQueryable<T> GetByQueryable(ICustomQueryable filter)
        {
            var query = _query.AsQueryable().Apply(filter);
            return query;
        }
        IQueryable<T> IRepository<T>.Query()
        {
            return _query;
        }

        public interface IAquivoRepository
        {
        }
    }
}

