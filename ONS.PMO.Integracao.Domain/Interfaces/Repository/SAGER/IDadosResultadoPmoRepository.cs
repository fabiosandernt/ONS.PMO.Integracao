using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.SAGER.DisponibilidadeCVU;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.Base;

namespace ONS.PMO.Integracao.Domain.Interfaces.Repository.SAGER
{
    public interface IDadosResultadoPmoRepository : IRepository<DadoResultadoPMO>
    {
        Task<List<DadoResultadoPMO>> GetDadoResultPmosAsync(DisponibilidadeFilter filter);
    }
}
