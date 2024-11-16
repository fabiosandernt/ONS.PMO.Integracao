using AspNetCore.IQueryable.Extensions;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Interfaces.RespositoryBase;
using ONS.PMO.Integracao.Infraestructure.Context;
using System.Linq.Expressions;

namespace ONS.PMO.Integracao.Infraestructure.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbSet<T> Query { get; set; }
        protected DbContext Context { get; set; }

        public Repository(WebPmoContext context)
        {
            this.Context = context;
            this.Query = Context.Set<T>();
        }
    
        public async Task Delete(T entity)
        {
            this.Query.Remove(entity);
            await this.Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> FindAllByCriterio(Expression<Func<T, bool>> expression)
        {
            return await this.Query.Where(expression).ToListAsync();
        }

        public async Task<T> FindOneByCriterio(Expression<Func<T, bool>> expression)
        {
            return await this.Query.FirstOrDefaultAsync(expression);
        }

        public async Task<T> Get(object id)
        {
            return await this.Query.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await this.Query.ToListAsync();
        }

        public async Task Save(T entity)
        {
            await this.Query.AddAsync(entity);
            await this.Context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            this.Query.Update(entity);
            await this.Context.SaveChangesAsync();
        }

        public async ValueTask<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await Query.AnyAsync(expression);
        }

        public async ValueTask<T> GetbyExpressionAsync(Expression<Func<T, bool>> expression)
        {
            return await Query.FirstOrDefaultAsync(expression);
        }
        
        public IQueryable<T> GetByQueryable(ICustomQueryable filter)
        {
            return Query.AsQueryable().Apply(filter);
        }
        IQueryable<T> IRepository<T>.Query()
        {
            return Query;
        }
    }
}

