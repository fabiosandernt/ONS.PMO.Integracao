using AspNetCore.IQueryable.Extensions;
using AspNetCore.IQueryable.Extensions.Pagination;
using AspNetCore.IQueryable.Extensions.Sort;

namespace ONS.PMO.Integracao.Domain.Filter
{
    public interface IBaseFilter: ICustomQueryable, IQueryPaging, IQuerySort
    {
    }
}
