
using AutoMapper;
using ONS.PMO.Integracao.Application.Dto.PMO;
using ONS.PMO.Integracao.Application.Filter;
using ONS.PMO.Integracao.Application.Service.Interfaces;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.Resources;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.PMO;

namespace ONS.PMO.Integracao.Application.Service.Implementation
{
    public class SemanaOperativaService : ISemanaOperativaService
    {

        private readonly ISemanaOperativaRepository _semanaOperativaRepository;
        private readonly IParametroService _parametroService;
        private readonly ISituacaoSemanaOperativaRepository _situacaoSemanaOperativaRepository;
        private readonly ISituacaoColetaInsumoRepository _situacaoColetaInsumoRepository;
        private readonly IGabaritoRepository _gabaritoRepository;
        private readonly IColetaInsumoRepository _coletaInsumoRepository;
        private readonly IPMORepository _pmoRepository;
        private readonly INotificacaoService _notificacaoService;
        private readonly IDadoColetaNaoEstruturadoRepository _dadoColetaNaoEstruturadoRepository;
        private readonly IColetaInsumoService _coletaInsumoService;
        private readonly IArquivoRepository _arquivoRepository;
        private readonly ISharePointService _sharePointService;
        private readonly IHistoricoService _historicoService;
        private readonly IArquivoSemanaOperativaRepository _arquivoSemanaOperativaRepository;
        private readonly IMapper _mapper;

        public SemanaOperativaService(ISemanaOperativaRepository semanaOperativaRepository, IParametroService parametroService, ISituacaoSemanaOperativaRepository situacaoSemanaOperativaRepository, ISituacaoColetaInsumoRepository situacaoColetaInsumoRepository, IGabaritoRepository gabaritoRepository, IColetaInsumoRepository coletaInsumoRepository, IPMORepository pmoRepository, INotificacaoService notificacaoService, IDadoColetaNaoEstruturadoRepository dadoColetaNaoEstruturadoRepository, IColetaInsumoService coletaInsumoService, IArquivoRepository arquivoRepository, ISharePointService sharePointService, IHistoricoService historicoService, IArquivoSemanaOperativaRepository arquivoSemanaOperativaRepository, IMapper mapper)
        {
            _semanaOperativaRepository = semanaOperativaRepository;
            _parametroService = parametroService;
            _situacaoSemanaOperativaRepository = situacaoSemanaOperativaRepository;
            _situacaoColetaInsumoRepository = situacaoColetaInsumoRepository;
            _gabaritoRepository = gabaritoRepository;
            _coletaInsumoRepository = coletaInsumoRepository;
            _pmoRepository = pmoRepository;
            _notificacaoService = notificacaoService;
            _dadoColetaNaoEstruturadoRepository = dadoColetaNaoEstruturadoRepository;
            _coletaInsumoService = coletaInsumoService;
            _arquivoRepository = arquivoRepository;
            _sharePointService = sharePointService;
            _historicoService = historicoService;
            _arquivoSemanaOperativaRepository = arquivoSemanaOperativaRepository;
            _mapper = mapper;
        }

        public void AbrirEstudo(AberturaEstudoDTO dto)
        {
            throw new NotImplementedException();
        }

        public void AlterarSemanaOperativa(DadosAlteracaoSemanaOperativaDTO dadosAlteracao)
        {
            throw new NotImplementedException();
        }

        public void AtualizarSemanasOperativasInclusao(IEnumerable<SemanaOperativa> semanasOperativas, int ano, string nomeMes)
        {
            throw new NotImplementedException();
        }

        public ArquivosSemanaOperativaDTO ConsultarArquivosSemanaOperativaConvergenciaCcee(ArquivosSemanaOperativaFilter filtro)
        {
            throw new NotImplementedException();
        }

        public ArquivosSemanaOperativaConvergirPldDTO ConsultarArquivosSemanaOperativaConvergenciaPLD(ArquivosSemanaOperativaFilter filtro)
        {
            throw new NotImplementedException();
        }

        public ArquivosSemanaOperativaDTO ConsultarArquivosSemanaOperativaPublicacaoResultados(ArquivosSemanaOperativaFilter filtro)
        {
            throw new NotImplementedException();
        }

        public IList<SemanaOperativa> ConsultarEstudoConvergenciaPldPorNome(string nomeEstudo)
        {
            throw new NotImplementedException();
        }

        public IList<SemanaOperativa> ConsultarEstudoPorNome(string nomeEstudo)
        {
            throw new NotImplementedException();
        }

        public IList<SemanaOperativa> ConsultarSemanasOperativasComGabarito()
        {
            throw new NotImplementedException();
        }

        public void ConvergirPLD(ConvergirPLDDTO dto)
        {
            throw new NotImplementedException();
        }

        public void ExcluirSemana(SemanaOperativa semanaOperativa)
        {
            throw new NotImplementedException();
        }

        public SemanaOperativa GerarSemanaOperativa(int ano, string nomeMes, DateTime dataInicioSemana, DateTime dataFimPMO, int revisao)
        {
            throw new NotImplementedException();
        }

        public ISet<SemanaOperativa> GerarSugestaoSemanasOperativas(int ano, int mes)
        {
            throw new NotImplementedException();
        }

        public void IniciarConvergenciaCCEE(InicializacaoConvergenciaCceeDTO dto)
        {
            throw new NotImplementedException();
        }

        public SemanaOperativa ObterSemanaOperativaPorChave(int chave)
        {
            throw new NotImplementedException();
        }

        public SemanaOperativa ObterSemanaOperativaPorChaveParaInformarDados(int chave)
        {
            throw new NotImplementedException();
        }

        public async Task<TbSemanaoperativaDto> ObterSemanaOperativaValidaParaAbrirEstudo(DadosSemanaOperativaDTO dto)
        {
            SemanaOperativa semana = ObterSemanaOperativaPorChave(dto.IdSemanaOperativa);
            if (semana != null)
            {
                // Significa que a chamada deste método tem a intenção de verificar a versão do PMO
                if (dto.VersaoPMO != null)
                {
                    var pmo = await _pmoRepository.GetbyExpressionAsync(x => x.IdPmo == semana.IdPmo && x.VerControleconcorrencia == dto.VersaoPMO);
                }

                if (semana.IdTpsituacaosemanaoperNavigation != null)
                {
                    var message = BusinessMessage.Get("MS008");
                    throw new ArgumentException(message.Value);
                }
            }
            var semanaDto = _mapper.Map<TbSemanaoperativaDto>(semana);
            return semanaDto;
        }

        public SemanaOperativa ObterSemanaOperativaValidaParaResetarGabarito(int idSemanaOperativa)
        {
            throw new NotImplementedException();
        }

        public void PublicarResultados(PublicacaoResultadosDTO dto)
        {
            throw new NotImplementedException();
        }

        public void ReprocessarPMO(ReprocessamentoPMODTO dto)
        {
            throw new NotImplementedException();
        }

        public void ResetarGabarito(ResetGabaritoDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
