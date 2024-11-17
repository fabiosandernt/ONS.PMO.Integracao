using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Filter;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Domain.Interfaces.Repository.PMO
{
    public interface IDadoColetaNaoEstruturadoRepository : IRepository<DadoColetaNaoEstruturado>
    {
        DadoColetaNaoEstruturado ObterDadoColetaNaoEstruturado(DadoColetaInsumoNaoEstruturadoFilter filtros);
        void DeletarPorIdGabarito(IList<int> idsGabarito);
        IList<DadoColetaNaoEstruturado> ObterDadosColetaNaoEstruturado(ArquivosSemanaOperativaFilter filtro);
    }
}
