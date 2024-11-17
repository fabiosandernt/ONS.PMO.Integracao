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
    public class GabaritoRepository : Repository<Gabarito>, IGabaritoRepository
    {
        public GabaritoRepository(WebPmoContext context) : base(context)
        {
        }

        public IList<Gabarito> ConsultarGabaritoParticipaBloco(int idSemanaOperativa)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gabarito> ConsultarParaRemover(IList<int> ids)
        {
            throw new NotImplementedException();
        }

        public IList<Gabarito> ConsultarPorGabaritoFilter(GabaritoConfiguracaoFilter filter)
        {
            throw new NotImplementedException();
        }

        public void DeletarPorIdSemanaOperativa(int idSemanaOperativa)
        {
            throw new NotImplementedException();
        }

        public Gabarito ObterPorColetaInumoOrigemColeta(int idColetaInsumo, string idOrigemColeta)
        {
            throw new NotImplementedException();
        }
    }
}
