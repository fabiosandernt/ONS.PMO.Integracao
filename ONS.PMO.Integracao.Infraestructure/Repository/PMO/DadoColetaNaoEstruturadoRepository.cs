using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Filter;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.PMO;
using ONS.PMO.Integracao.Infraestructure.Context;
using ONS.PMO.Integracao.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Infraestructure.Repository.PMO
{
    public class DadoColetaNaoEstruturadoRepository : Repository<DadoColetaNaoEstruturado>, IDadoColetaNaoEstruturadoRepository
    {
        public DadoColetaNaoEstruturadoRepository(WebPmoContext context) : base(context)
        {
        }

        public void DeletarPorIdGabarito(IList<int> idsGabarito)
        {
            throw new NotImplementedException();
        }

        public DadoColetaNaoEstruturado ObterDadoColetaNaoEstruturado(IBaseFilter filtros)
        {
            throw new NotImplementedException();
        }

        public IList<DadoColetaNaoEstruturado> ObterDadosColetaNaoEstruturado(IBaseFilter filtro)
        {
            throw new NotImplementedException();
        }
    }
}
