using AspNetCore.IQueryable.Extensions;
using System.Linq.Expressions;

namespace ONS.PMO.Integracao.Domain.Interfaces.Repository.Base
{
    public interface IRepository<T> where T : class
    {
        Task Save(T entity);
        Task Delete(T entity);
        Task Update(T entity);
        Task<T> Get(object id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> FindAllByCriterio(Expression<Func<T, bool>> expression);
        Task<T> FindOneByCriterio(Expression<Func<T, bool>> expression);
        ValueTask<bool> AnyAsync(Expression<Func<T, bool>> expression);
        ValueTask<T> GetbyExpressionAsync(Expression<Func<T, bool>> expression);
        IQueryable<T> GetByQueryable(ICustomQueryable filter);
        IQueryable<T> Query();

    }
}
