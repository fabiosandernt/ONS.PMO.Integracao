using AspNetCore.IQueryable.Extensions.Pagination;
using AspNetCore.IQueryable.Extensions.Sort;
using AspNetCore.IQueryable.Extensions;

namespace ONS.PMO.Integracao.Domain.Entidades.Base
{
    public interface IBaseFilter : ICustomQueryable, IQueryPaging, IQuerySort
    {
    }
}
