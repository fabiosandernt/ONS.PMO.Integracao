using ONS.PMO.Integracao.Domain.Entidades.BDT;
using ONS.PMO.Integracao.Domain.Entidades.SAGER.DisponibilidadeCVU;
using ONS.PMO.Integracao.Domain.Interfaces.RespositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Domain.Interfaces
{
    public interface IDadosResultadoPmoRepository : IRepository<DadoResultPMO>
    {
        Task<List<DadoResultPMO>> GetDadoResultPmosAsync(DisponibilidadeFilter filter);
    }
}
