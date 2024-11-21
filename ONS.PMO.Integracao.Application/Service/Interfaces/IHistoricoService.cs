using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Application.Service.Interfaces
{
    public interface IHistoricoService
    {
        void CriarSalvarHistoricoColetaInsumo(ColetaInsumo coletaInsumo);

        void CriarSalvarHistoricoSemanaOperativa(SemanaOperativa semanaOperativa);

        Task ExcluirHistoricoColetaInsumo(ColetaInsumo coletaInsumo);

        Task ExcluirHistoricoColetaInsumoViaSemanaOperativa(SemanaOperativa semanaOperativa);

        Task ExcluirHistoricoSemanaOperativa(int idSemanaOperativa);

        Task ExcluirHistoricosSemanaOperativa(ICollection<SemanaOperativa> semanasOperativas);

      
    }
}
