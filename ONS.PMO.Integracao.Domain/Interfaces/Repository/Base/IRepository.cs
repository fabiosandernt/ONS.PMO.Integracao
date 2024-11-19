using AspNetCore.IQueryable.Extensions;
using System.Linq.Expressions;

namespace ONS.PMO.Integracao.Domain.Interfaces.Repository.Base
{
    public interface IRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteAsync(ICollection<T> entity);
        Task UpdateAsync(T entity);
        Task<T> GetByIdAsync(object id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> FindAllByCriterioAsync(Expression<Func<T, bool>> expression);
        Task<T> FindOneByCriterioAsync(Expression<Func<T, bool>> expression);
        ValueTask<bool> AnyAsync(Expression<Func<T, bool>> expression);
        ValueTask<T> GetbyExpressionAsync(Expression<Func<T, bool>> expression);
        ValueTask<T> GetbyExpressionIncludeAsync(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IQueryable<T>>? includeExpression = null);
        IQueryable<T> GetByQueryable(ICustomQueryable filter);
        IQueryable<T> Query();

    }
}
