
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Enum;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.Base;

namespace ONS.PMO.Integracao.Domain.Interfaces.Repository.PMO
{
    public interface IParametroRepository : IRepository<ParametroPMO>
    {
        Task<ParametroPMO> ObterPorTipoAsync(ParametroEnum parametro);
    }
}
