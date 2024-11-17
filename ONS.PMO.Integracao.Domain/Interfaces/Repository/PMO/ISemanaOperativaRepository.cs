using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Domain.Interfaces.Repository.PMO
{
    public interface ISemanaOperativaRepository : IRepository<SemanaOperativa>    
    {
        IList<SemanaOperativa> ConsultarSemanasOperativasComGabarito();
        IList<SemanaOperativa> ConsultarEstudoPorNome(string nomeEstudo, int quantidadeMaxima);
        IList<SemanaOperativa> ConsultarEstudoPorNomeEStatus(string nomeEstudo, int? idStatus, int quantidadeMaxima);
    }

}

