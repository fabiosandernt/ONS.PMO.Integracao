
using AutoMapper;
using ONS.PMO.Integracao.Application.Dto.PMO;
using ONS.PMO.Integracao.Application.Filter;
using ONS.PMO.Integracao.Application.Service.Interfaces;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.Resources;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;
using ONS.PMO.Integracao.Domain.Enum;
using ONS.PMO.Integracao.Domain.Filter;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.PMO;
using System;
using System.Globalization;

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

        public async Task AlterarSemanaOperativa(DadosAlteracaoSemanaOperativaDTO dadosAlteracao)
        {
            ValidarDataAlteracao(dadosAlteracao);

            SemanaOperativa semanaOperativa = await _semanaOperativaRepository.GetbyExpressionAsync(x => x.IdSemanaoperativa == dadosAlteracao.Id);

            if (semanaOperativa != null)
            {
                semanaOperativa.DatReuniao = dadosAlteracao.DataReuniao;
                semanaOperativa.DatIniciomanutencao = dadosAlteracao.DataInicioManutencao;
                semanaOperativa.DatFimmanutencao = dadosAlteracao.DataFimManutencao;
                semanaOperativa.DinUltimaalteracao = DateTime.Now;
                await _semanaOperativaRepository.UpdateAsync(semanaOperativa);
            }
        }

        private void ValidarDataAlteracao(DadosAlteracaoSemanaOperativaDTO dadosAlteracao)
        {
            const string dataReuniao = "Data da Reunião";
            const string dataInicioManutencao = "Data Início da Manutenção";
            const string dataFimManutencao = "Data Termino da Manutenção";

            DateTime dataAtual = DateTime.Now.Date;
            var message = BusinessMessage.Get("MS006");

            IList<string> mensagens = new List<string>();

            if (dadosAlteracao.DataReuniao.CompareTo(dataAtual) < 0)
            {
                mensagens.Add(string.Format(message.Value, dataReuniao));
            }

            if (dadosAlteracao.DataInicioManutencao.CompareTo(dataAtual) < 0)
            {
                mensagens.Add(string.Format(message.Value, dataInicioManutencao));
            }

            if (dadosAlteracao.DataFimManutencao.CompareTo(dataAtual) < 0)
            {
                mensagens.Add(string.Format(message.Value, dataFimManutencao));
            }

            if (mensagens.Any())
            {
                throw new BusinessValidationException(mensagens);
            }
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

            ISet<SemanaOperativa> semanasOperativas = new SortedSet<SemanaOperativa>();

            var cultura = CultureInfo.CurrentCulture;
            string nomeMes = cultura.TextInfo.ToTitleCase(cultura.DateTimeFormat.GetMonthName(mes));

            DateTime dataInicioSemana = new DateTime(ano, mes, 1);
            DateTime ultimoDiaMes = dataInicioSemana.AddMonths(1).AddDays(-1);
            DateTime dataFimPMO = ultimoDiaMes;

            if (dataInicioSemana.DayOfWeek != DayOfWeek.Saturday)
            {
                // A semana operativa desve ser sempre de Sábado a Sexta
                // Se o primeiro dia do mês não for um Sábado é preciso obter a quantidade de dias 
                // que se deve retroceder para chegar ao Sábado
                int qtdDiasParaSabado = -(int)dataInicioSemana.DayOfWeek - 1;
                dataInicioSemana = dataInicioSemana.AddDays(qtdDiasParaSabado);
            }

            if (ultimoDiaMes.DayOfWeek != DayOfWeek.Friday)
            {
                // A semana operativa desve ser sempre de Sábado a Sexta
                // Se último dia do mês não for uma Sexta é preciso obter a quantidade de dias 
                // para chegar à Sexta
                int qtdDiasParaSexta = ultimoDiaMes.DayOfWeek == DayOfWeek.Saturday ?
                    6 : (int)DayOfWeek.Friday - (int)ultimoDiaMes.DayOfWeek;
                dataFimPMO = ultimoDiaMes.AddDays(qtdDiasParaSexta);
            }

            int revisao = 0;
            while (dataInicioSemana <= ultimoDiaMes)
            {
                SemanaOperativa semanaOperativa = GerarSemanaOperativa(ano, nomeMes, dataInicioSemana, dataFimPMO, revisao);
                if (semanaOperativa != null)
                {
                    semanasOperativas.Add(semanaOperativa);
                    revisao++;
                }
                dataInicioSemana = dataInicioSemana.AddDays(7);
            }
            return semanasOperativas;

        }

        public void IniciarConvergenciaCCEE(InicializacaoConvergenciaCceeDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task<SemanaOperativa> ObterSemanaOperativaPorChave(int chave)
        {
            return await _semanaOperativaRepository.GetbyExpressionAsync(x => x.IdSemanaoperativa == chave);
        }
        public async Task<SemanaOperativa> ObterSemanaOperativaPorChave(int chave, byte[] versao)
        {
            return await _semanaOperativaRepository.GetbyExpressionAsync(x => x.IdSemanaoperativa == chave && x.VerControleconcorrencia == versao);
        }

        public SemanaOperativa ObterSemanaOperativaPorChaveParaInformarDados(int chave)
        {
            throw new NotImplementedException();
        }

        public async Task<TbSemanaoperativaDto> ObterSemanaOperativaValidaParaAbrirEstudo(DadosSemanaOperativaDTO dto)
        {
            SemanaOperativa semana = await ObterSemanaOperativaPorChave(dto.IdSemanaOperativa);
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

        public async Task ResetarGabarito(ResetGabaritoDTO dto)
        {
            await AssociarGabarito(dto.IdSemanaOperativa, dto.IdEstudo, dto.IsPadrao, dto.VersaoPMO, dto.VersaoSemanaOperativa);
        }

        private async Task AssociarGabarito(int idSemanaOperativa, int? idSemanaEstudoGabarito, bool isPadrao, byte[] versaoPMO, byte[] versaoSemanaOperativa)
        {
            SemanaOperativa semanaOperativa = versaoSemanaOperativa == null
                ? await ObterSemanaOperativaPorChave(idSemanaOperativa)
                : await ObterSemanaOperativaPorChave(idSemanaOperativa, versaoSemanaOperativa);

            if (semanaOperativa != null)
            {
                if (versaoPMO != null)
                {
                    var pmo = await _pmoRepository.GetbyExpressionAsync(x => x.IdPmo == semanaOperativa.IdPmo && x.VerControleconcorrencia == versaoPMO);
                    if (pmo != null)
                    {
                        pmo.VerControleconcorrencia = versaoPMO;
                    }
                }

                if (versaoSemanaOperativa != null) semanaOperativa.VerControleconcorrencia = versaoSemanaOperativa;

                if (isPadrao)
                {
                    AssociarGabaritoPadrao(semanaOperativa);
                }
                else
                {
                    AssociarGabaritoEstudoAnterior(idSemanaEstudoGabarito, semanaOperativa);
                }

                //semanaOperativa.SituacaoId = (int)SituacaoSemanaOperativaEnum.Configuracao;
                semanaOperativa.IdTpsituacaosemanaoperNavigation = await _situacaoSemanaOperativaRepository.GetByIdAsync((int)SituacaoSemanaOperativaEnum.GeracaoBlocos);
                semanaOperativa.DinUltimaalteracao = DateTime.Now;

                _historicoService.CriarSalvarHistoricoSemanaOperativa(semanaOperativa);
            }


        }

        private async void AssociarGabaritoEstudoAnterior(int? idSemanaEstudoGabarito, SemanaOperativa semanaOperativa)
        {
            if (idSemanaEstudoGabarito.HasValue)
            {
                SemanaOperativa semanaEstudoGabarito = await ObterSemanaOperativaPorChave(idSemanaEstudoGabarito.Value);
                IEnumerable<Gabarito> gabaritosCopiados = CopiarGabaritos(semanaEstudoGabarito.TbGabaritos.ToList());
                SituacaoColetaInsumo situacao = await _situacaoColetaInsumoRepository.GetByIdAsync((int)SituacaoColetaInsumoEnum.NaoIniciado);
                IEnumerable<ColetaInsumo> coletasCopiadas = semanaEstudoGabarito.TbColetainsumos.ToList().Where(ci => ci.IdInsumopmoNavigation.FlgAtivo).Select(ci =>
                    CriarColetaInsumo(ci.IdAgenteinstituicaoNavigation, ci.IdInsumopmoNavigation, ci.CodPerfilons, semanaOperativa, situacao));

                AssociarGabaritosColetasASemana(semanaOperativa, gabaritosCopiados, coletasCopiadas);
            }
        }

        private void AssociarGabaritosColetasASemana(SemanaOperativa semanaOperativa, IEnumerable<Gabarito> gabaritos,
           IEnumerable<ColetaInsumo> coletasInsumos)
        {
            // É preciso limpar a lista para que o EF limpe os gabaritos e coletas
            // pois esse fluxo é chamado também pelo ResetarGabarito.
            _gabaritoRepository.DeletarPorIdSemanaOperativa(semanaOperativa.IdPmo);
            foreach (var gabarito in gabaritos)
            {
                semanaOperativa.TbGabaritos.Add(gabarito);
            }

            _historicoService.ExcluirHistoricoColetaInsumoViaSemanaOperativa(semanaOperativa.IdPmo);
            _gabaritoRepository.DeletarPorIdSemanaOperativa(semanaOperativa.IdPmo);
            foreach (var coletaInsumo in coletasInsumos)
            {
                semanaOperativa.TbColetainsumos.Add(coletaInsumo);
                _historicoService.CriarSalvarHistoricoColetaInsumo(coletaInsumo);
            }
        }

        private ColetaInsumo CriarColetaInsumo(AgenteInstituicao agente, InsumoPMO insumo, string codigoPerfilONS,
          SemanaOperativa semanaOperativa, SituacaoColetaInsumo situacao)
        {
            return new ColetaInsumo
            {
                IdInsumopmoNavigation = insumo,
                IdAgenteinstituicaoNavigation = agente,
                CodPerfilons = codigoPerfilONS,
                IdTpsituacaocoletainsumoNavigation = situacao,
                IdSemanaoperativaNavigation = semanaOperativa,
                LgnAgenteultimaalteracao = "UserInfo.UserName",
                DinUltimaalteracao = DateTime.Now
            };
        }
        private IEnumerable<Gabarito> CopiarGabaritos(IEnumerable<Gabarito> gabaritos)
        {
            foreach (var gabarito in gabaritos)
            {
                yield return new Gabarito
                {
                    IdAgenteinstituicaoNavigation = gabarito.IdAgenteinstituicaoNavigation,
                    IdInsumopmoNavigation = gabarito.IdInsumopmoNavigation,
                    IdOrigemcoletaNavigation = gabarito.IdOrigemcoletaNavigation,
                    FlgPadrao = false,
                    CodPerfilons = gabarito.CodPerfilons
                };
            }
        }
        private async Task AssociarGabaritoPadrao(SemanaOperativa semanaOperativa)
        {
            var filtro = new GabaritoConfiguracaoFilter { IsPadrao = true };

            var gabaritosPadrao = _gabaritoRepository.ConsultarPorGabaritoFilter(filtro);

            var gabaritosCopiados = CopiarGabaritos(gabaritosPadrao);

            var gabaritosPadraoAgrupados = gabaritosPadrao.GroupBy(g => new { g.IdInsumopmoNavigation, g.IdAgenteinstituicaoNavigation, g.CodPerfilons });
            var situacaoColetaInsumo = await _situacaoColetaInsumoRepository.GetByIdAsync((int)SituacaoColetaInsumoEnum.NaoIniciado);

            var coletasCriadas = gabaritosPadraoAgrupados.Where(g => g.Key.IdInsumopmoNavigation.FlgAtivo)
                .Select(g => CriarColetaInsumo(g.Key.IdAgenteinstituicaoNavigation, g.Key.IdInsumopmoNavigation, g.Key.CodPerfilons,
                    semanaOperativa, situacaoColetaInsumo));

            AssociarGabaritosColetasASemana(semanaOperativa, gabaritosCopiados, coletasCriadas);

        }
    }
}
