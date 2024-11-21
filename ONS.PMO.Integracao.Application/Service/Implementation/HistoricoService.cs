using ONS.PMO.Integracao.Application.Service.Interfaces;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.Resources;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.PMO;


namespace ONS.PMO.Integracao.Application.Service.Implementation
{
    public class HistoricoService : IHistoricoService
    {
        private readonly ISemanaOperativaRepository _semanaOperativaRepository;
        private readonly IColetaInsumoRepository _coletaInsumoRepository;
        private readonly IHistoricoSemanaOperativaRepository _historicoSemanaOperativaRepository;
        public HistoricoService(IHistoricoSemanaOperativaRepository historicoSemanaOperativaRepository, ISemanaOperativaRepository semanaOperativaRepository, IColetaInsumoRepository coletaInsumoRepository)
        {
            _semanaOperativaRepository = semanaOperativaRepository;
            _coletaInsumoRepository = coletaInsumoRepository;
            _historicoSemanaOperativaRepository = historicoSemanaOperativaRepository;

        }
        public void CriarSalvarHistoricoColetaInsumo(ColetaInsumo coletaInsumo)
        {
            throw new NotImplementedException();
        }

        public void CriarSalvarHistoricoSemanaOperativa(SemanaOperativa semanaOperativa)
        {
            throw new NotImplementedException();
        }

        public async Task ExcluirHistoricoColetaInsumo(ColetaInsumo coletaInsumo)
        {
            await _coletaInsumoRepository.DeleteAsync(coletaInsumo);
        }

        public async Task ExcluirHistoricoColetaInsumoViaSemanaOperativa(SemanaOperativa semanaOperativa)
        {
            foreach (var item in semanaOperativa.TbColetainsumos)
            {
                if (item.IdSemanaoperativa == semanaOperativa.IdSemanaoperativa)
                {
                    await _coletaInsumoRepository.DeleteAsync(item);
                }
            }
        }

        public async Task ExcluirHistoricoSemanaOperativa(int idSemanaOperativa)
        {
            var historicoSemana = await _historicoSemanaOperativaRepository.GetByIdAsync(idSemanaOperativa);
            //if (historicoSemana == null) throw new Exception("Historico Semana Operativa Nao econtrado");
            if (historicoSemana != null)
            {
                await _historicoSemanaOperativaRepository.DeleteAsync(historicoSemana);
            }
           
        }

        

        public async Task ExcluirHistoricosSemanaOperativa(ICollection<SemanaOperativa> semanasOperativas)
        {
            foreach (var semana in semanasOperativas)
            {
               await ExcluirHistoricoSemanaOperativa(semana.IdSemanaoperativa);
            }
        }
    }
}
