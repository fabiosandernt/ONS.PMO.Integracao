using ONS.PMO.Integracao.Domain.Entidades.PMO;
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
    public class SemanaOperativaRepository : Repository<SemanaOperativa>, ISemanaOperativaRepository
    {
        public SemanaOperativaRepository(WebPmoContext context) : base(context)
        {
        }

        public IList<SemanaOperativa> ConsultarEstudoPorNome(string nomeEstudo, int quantidadeMaxima)
        {
            throw new NotImplementedException();
        }

        public IList<SemanaOperativa> ConsultarEstudoPorNomeEStatus(string nomeEstudo, int? idStatus, int quantidadeMaxima)
        {
            throw new NotImplementedException();
        }

        public IList<SemanaOperativa> ConsultarSemanasOperativasComGabarito()
        {
            throw new NotImplementedException();
        }
    }
}
