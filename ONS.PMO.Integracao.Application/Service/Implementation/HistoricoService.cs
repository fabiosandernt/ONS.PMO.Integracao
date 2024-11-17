using ONS.PMO.Integracao.Application.Service.Interfaces;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;


namespace ONS.PMO.Integracao.Application.Service.Implementation
{
    public class HistoricoService : IHistoricoService
    {
        public void CriarSalvarHistoricoColetaInsumo(ColetaInsumo coletaInsumo)
        {
            throw new NotImplementedException();
        }

        public void CriarSalvarHistoricoSemanaOperativa(SemanaOperativa semanaOperativa)
        {
            throw new NotImplementedException();
        }

        public void ExcluirHistoricoColetaInsumo(int idColetaInsumo)
        {
            throw new NotImplementedException();
        }

        public void ExcluirHistoricoColetaInsumoViaSemanaOperativa(int idSemanaOperativa)
        {
            throw new NotImplementedException();
        }

        public void ExcluirHistoricoSemanaOperativa(int idSemanaOperativa)
        {
            throw new NotImplementedException();
        }

        public void ExcluirHistoricosSemanaOperativa(ISet<SemanaOperativa> idsSemanaOperativa)
        {
            throw new NotImplementedException();
        }
    }
}
