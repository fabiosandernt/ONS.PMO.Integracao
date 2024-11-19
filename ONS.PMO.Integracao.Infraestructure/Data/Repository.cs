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

        public async ValueTask<T> GetbyExpressionIncludeAsync(Expression<Func<T, bool>> expression,
                     Func<IQueryable<T>, IQueryable<T>>? includeExpression = null)
        {
            IQueryable<T> query = _query;

            if (includeExpression != null)
            {
                query = includeExpression(query);
            }

            return await query.FirstOrDefaultAsync(expression);
        }

        public async Task DeleteAsync(T entity)
        {
            _query.Remove(entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteRangeAsync(ICollection<T> entity)
        {
            _query.RemoveRange(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> FindAllByCriterioAsync(Expression<Func<T, bool>> expression)
        {
            return await _query.Where(expression).ToListAsync();
        }

        public async Task<T> FindOneByCriterioAsync(Expression<Func<T, bool>> expression)
        {
           return await _query.FirstOrDefaultAsync(expression);
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await _query.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _query.ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await _query.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
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

    }
}

