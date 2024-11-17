using AspNetCore.IQueryable.Extensions;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.Base;

namespace ONS.PMO.Integracao.Domain.Interfaces.Repository.PMO
{
    public interface IInsumoRepostitory : IRepository<InsumoPMO>
    {
        IEnumerable<InsumoPMO> GetAllInsumosCustom(ICustomQueryable filter);
    }
}
