using AutoMapper;
using ONS.PMO.Integracao.Application.Dto.DisponibilidadeCVU;
using ONS.PMO.Integracao.Application.Dto.PMO;
using ONS.PMO.Integracao.Application.Filter;
using ONS.PMO.Integracao.Application.Service.Interfaces;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.Resources;
using ONS.PMO.Integracao.Domain.Entidades.SAGER.DisponibilidadeCVU;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;
using ONS.PMO.Integracao.Domain.Enum;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.PMO;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.SAGER;
using System.Globalization;

namespace ONS.PMO.Integracao.Application.Service.Implementation
{
    public class PmoServices : IPmoServices
    {

        private readonly IDadosResultadoPmoRepository _dadosResultadoPmoRepository;
        private readonly IMapper _mapper;
        private readonly IPMORepository _PMORepository;
        private readonly ISemanaOperativaService _semanaOperativaService;
        private readonly IParametroService _parametroService;
        private readonly IHistoricoService _historicoService;

        public PmoServices(IDadosResultadoPmoRepository dadosResultadoPmoRepository, IMapper mapper, IPMORepository pMORepository, ISemanaOperativaService semanaOperativaService, IParametroService parametroService, IHistoricoService historicoService)
        {
            _dadosResultadoPmoRepository = dadosResultadoPmoRepository;
            _mapper = mapper;
            _PMORepository = pMORepository;
            _semanaOperativaService = semanaOperativaService;
            _parametroService = parametroService;
            _historicoService = historicoService;
        }

        public async Task AtualizarMesesAdiantePMOAsync(int idPMO, int? mesesAdiante, byte[] versao)
        {
            ValidarQuantidadeMesesAdiante(mesesAdiante);
            var pmo = await _PMORepository.GetbyExpressionAsync(x => x.IdPmo == idPMO && x.VerControleconcorrencia == versao);
            if (pmo != null)
            {
                pmo.VerControleconcorrencia = versao;
                pmo.QtdMesesadiante = mesesAdiante;
                await _PMORepository.Save(pmo);
            }
        }
        private void ValidarQuantidadeMesesAdiante(int? qtdMeses)
        {
            if (qtdMeses.HasValue && qtdMeses.Value > 11)
            {
                //throw new ONSBusinessException(SGIPMOMessages.MS009);
                throw new ArgumentException("falta implementar");
            }
        }
        public async Task ExcluirPMOAsync(DadosPMODTO dto)
        {
            var pmo = await _PMORepository.GetbyExpressionAsync(x => x.IdPmo == dto.IdPMO && x.VerControleconcorrencia == dto.VersaoPMO);
            if (pmo != null)
            {
                await _PMORepository.Delete(pmo);
            }
        }

        public async Task ExcluirUltimaSemanaOperativaAsync(int idPMO, byte[] versaoPMO)
        {
            var pmo = await _PMORepository.GetbyExpressionAsync(x => x.IdPmo == idPMO && x.VerControleconcorrencia == versaoPMO);
            if (pmo != null)
            {
                ValidarExistenciaSemanaOperativa(pmo);

                SemanaOperativa ultimaSemana = pmo.TbSemanaoperativas.Last();

                DateTime dataInicioUltimaSemana = ultimaSemana.DatIniciosemana;
                ValidarDataInclusaoExclusaoSemanaOperativa(dataInicioUltimaSemana);

                ValidarColetaDados(ultimaSemana);

                _semanaOperativaService.ExcluirSemana(ultimaSemana);

                pmo.VerControleconcorrencia = versaoPMO;
            }
        }

        private void ValidarColetaDados(SemanaOperativa semanaOperativa)
        {
            var situacao = semanaOperativa.IdTpsituacaosemanaoperNavigation;
            if (situacao != null)
            {
                var sitaucaoSemanaOperativa = (SituacaoSemanaOperativaEnum)situacao.IdTpsituacaosemanaoper;
                if (sitaucaoSemanaOperativa >= SituacaoSemanaOperativaEnum.ColetaDados)
                {
                    var message = BusinessMessage.Get("MS011");
                    throw new ArgumentException(message.Value);
                }
            }
        }
        private void ValidarDataInclusaoExclusaoSemanaOperativa(DateTime data)
        {
            if (data.CompareTo(DateTime.Now.Date) < 0)
            {
                var message = BusinessMessage.Get("MS010");
                throw new ArgumentException(message.Value);
            }
        }

        private void ValidarExistenciaSemanaOperativa(Pmo pmo)
        {
            if (pmo != null)
            {
                if (pmo.TbSemanaoperativas.Count == 1)
                {
                    var message = BusinessMessage.Get("MS007");
                    throw new ArgumentException(message.Value);
                }
            }
        }
        public async Task<IncluirPMODto> GerarPMOAsync(IncluirPMODto dto)
        {
            var pmo = new Pmo()
            {
                AnoReferencia = dto.AnoReferencia,
                MesReferencia = dto.MesReferencia,
                TbSemanaoperativas = _semanaOperativaService.GerarSugestaoSemanasOperativas(dto.AnoReferencia, dto.MesReferencia)
            };
            var parametroQtdMeses = _parametroService.ObterParametro(ParametroEnum.QuantidadeMesesAFrente);
            if (parametroQtdMeses != null)
            {
                pmo.QtdMesesadiante = int.Parse(parametroQtdMeses.ValParametropmo);
            }
            _PMORepository.Save(pmo);
            return dto;
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

        public SemanaOperativa GerarSemanaOperativa(int ano, string nomeMes, DateTime dataInicioSemana,
          DateTime dataFimPMO, int revisao)
        {
            SemanaOperativa semanaOperativa = new SemanaOperativa
            {
                DatIniciosemana = dataInicioSemana,
                DatFimsemana = dataInicioSemana.AddDays(6),
                DatReuniao = ObterDataReuniao(dataInicioSemana, revisao),
                NumRevisao = revisao,
                DatIniciomanutencao = dataInicioSemana,
                DatFimmanutencao = dataFimPMO,
                NomSemanaoperativa = ObterNomeSemanaOperativa(ano, nomeMes, revisao)
            };

            return semanaOperativa;
        }

        private string ObterNomeSemanaOperativa(int ano, string nomeMes, int revisao)
        {
            string nomeSemanaOperativa = revisao == 0 ?
                string.Format("PMO {0} {1}", nomeMes, ano) :
                string.Format("PMO {0} {1} - Revisão {2}", nomeMes, ano, revisao);
            return nomeSemanaOperativa;
        }

        private DateTime ObterDataReuniao(DateTime dataInicioSemana, int revisao)
        {
            ParametroPMO parametro;
            int valorDiaReuniao = 0;
            if (revisao == 0)
            {
                parametro = _parametroService.ObterParametro(ParametroEnum.DiaReuniaoPMO);
                if (parametro != null)
                {
                    valorDiaReuniao = int.Parse(parametro.ValParametropmo);
                }
            }
            else
            {
                parametro = _parametroService.ObterParametro(ParametroEnum.DiaReuniaoRevisao);
                if (parametro != null)
                {
                    valorDiaReuniao = int.Parse(parametro.ValParametropmo);
                }
            }
            int valorDeDiasParaRetroceder = valorDiaReuniao == (int)DayOfWeek.Saturday
                ? -7
                : valorDiaReuniao - (int)DayOfWeek.Saturday;
            return dataInicioSemana.AddDays(valorDeDiasParaRetroceder);
        }
        public async Task<TbPmoDto> GetByIdAsync(int id)
        {
            var tbPmo = await _PMORepository.Get(id);

            var tbPmoDto = new TbPmoDto
            {
                IdPmo = tbPmo.IdPmo,
                AnoReferencia = tbPmo.AnoReferencia,
                MesReferencia = tbPmo.MesReferencia,
                QtdMesesadiante = tbPmo.QtdMesesadiante,
                //VerControleconcorrencia = tbPmo.VerControleconcorrencia,
                TbSemanaoperativas = tbPmo.TbSemanaoperativas.Select(semana => new SemanaOperativa
                {
                    IdSemanaoperativa = semana.IdSemanaoperativa,
                    IdPmo = semana.IdPmo,
                    NomSemanaoperativa = semana.NomSemanaoperativa,
                    DatIniciosemana = semana.DatIniciosemana,
                    DatFimsemana = semana.DatFimsemana,
                    DatReuniao = semana.DatReuniao,
                    DatIniciomanutencao = semana.DatIniciomanutencao,
                    DatFimmanutencao = semana.DatFimmanutencao,
                    NumRevisao = semana.NumRevisao,
                    VerControleconcorrencia = semana.VerControleconcorrencia,
                    DinUltimaalteracao = semana.DinUltimaalteracao,
                    TbColetainsumos = semana.TbColetainsumos.Select(coleta => new ColetaInsumo
                    {
                        IdColetainsumo = coleta.IdColetainsumo,
                        IdTpsituacaocoletainsumo = coleta.IdTpsituacaocoletainsumo,
                        IdSemanaoperativa = coleta.IdSemanaoperativa,
                        IdInsumopmo = coleta.IdInsumopmo,
                        IdAgenteInstituicao = coleta.IdAgenteInstituicao,
                        DscMotivoalteracaoons = coleta.DscMotivoalteracaoons,
                        DscMotivorejeicaoons = coleta.DscMotivorejeicaoons,
                        VerControleconcorrencia = coleta.VerControleconcorrencia,
                        DinUltimaalteracao = coleta.DinUltimaalteracao,
                        LgnAgenteultimaalteracao = coleta.LgnAgenteultimaalteracao,
                        CodPerfilons = coleta.CodPerfilons,
                        NomGrandezasnaoestagioalteradas = coleta.NomGrandezasnaoestagioalteradas
                    }).ToList()
                }).ToList()
            };

            return tbPmoDto;
        }


        public ICollection<TbPmoDto> GetByQueryable(PmoFilter filter)
        {
            var query = _PMORepository.GetByQueryable(filter);
            var pmosDto = _mapper.Map<List<TbPmoDto>>(query);
            return pmosDto;
        }

        public Task IncluirSemanaOperativaAsync(InclusaoSemanaOperativaDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task<DadoResultadoPmoDto> ObterDadosMontadorDisponibilidadeInflexibilidadeCVU(DisponibilidadeFilter filter)
        {
            var query = await _dadosResultadoPmoRepository.GetDadoResultPmosAsync(filter);
            var resultados = new List<PmoDto>();
            var resultadoFinal = new DadoResultadoPmoDto() { Pmo = resultados, Offset = filter.Offset ?? 0 };
            foreach (var dadoResultado in query)
            {
                var pmo = resultados.FirstOrDefault(x => x.IdPmo == dadoResultado.IdListaresultadopmoNavigation.IdImportacaopmoNavigation.IdSemanaoperativaNavigation.IdPmo);
                if (pmo == null)
                {
                    pmo = new PmoDto
                    {
                        IdPmo = dadoResultado.IdListaresultadopmoNavigation.IdImportacaopmoNavigation.IdSemanaoperativaNavigation.IdPmo,
                        ListaResultado = new List<ListaResultadoPmoDto>()
                    };
                    resultados.Add(pmo);
                }
                var resultado = pmo.ListaResultado.FirstOrDefault(r => r.ListaResultadoId == dadoResultado.IdListaresultadopmo);
                if (resultado == null)
                {
                    resultado = new ListaResultadoPmoDto
                    {
                        ListaResultadoId = dadoResultado.IdListaresultadopmo,
                        IdImportacao = dadoResultado.IdListaresultadopmoNavigation.IdImportacaopmo ?? 0,
                        SemanaOperativa = new SemanaOperativaDto
                        {
                            IdSemanaOperativa = dadoResultado.IdListaresultadopmoNavigation.IdImportacaopmoNavigation.IdSemanaoperativaNavigation.IdSemanaoperativa,
                            NomSemanaOperativa = dadoResultado.IdListaresultadopmoNavigation.IdImportacaopmoNavigation.IdSemanaoperativaNavigation.NomSemanaoperativa,
                            DataInicioSemana = dadoResultado.IdListaresultadopmoNavigation.IdImportacaopmoNavigation.IdSemanaoperativaNavigation.DatIniciosemana,
                            DataFimSemana = dadoResultado.IdListaresultadopmoNavigation.IdImportacaopmoNavigation.IdSemanaoperativaNavigation.DatFimsemana,
                            DataReuniao = dadoResultado.IdListaresultadopmoNavigation.IdImportacaopmoNavigation.IdSemanaoperativaNavigation.DatReuniao,
                            NumRevisao = dadoResultado.IdListaresultadopmoNavigation.IdImportacaopmoNavigation.IdSemanaoperativaNavigation.NumRevisao ?? 0,
                            dscSituacaoSemanaOperativa = dadoResultado.IdListaresultadopmoNavigation.IdImportacaopmoNavigation.IdSemanaoperativaNavigation.IdTpsituacaosemanaoperNavigation.DscSituacaosemanaoper,

                        },
                        Agentes = new List<AgenteDto>()

                    };
                    pmo.ListaResultado.Add(resultado);
                }
                var agente = resultado.Agentes.FirstOrDefault(a => a.NomeCurto == dadoResultado.IdListaresultadopmoNavigation.TbAuxUsinamontador.NomCurto);
                if (agente == null)
                {
                    agente = new AgenteDto
                    {
                        NomeCurto = dadoResultado.IdListaresultadopmoNavigation.TbAuxUsinamontador.NomCurto,
                        NomeLongo = dadoResultado.IdListaresultadopmoNavigation.TbAuxUsinamontador.NomLongo,
                        CodDpp = dadoResultado.IdListaresultadopmoNavigation.TbAuxUsinamontador.CodDpp,
                        Insumo = new List<InsumoDto>()

                    };
                    resultado.Agentes.Add(agente);
                }
                var insumo = agente.Insumo.FirstOrDefault(x => x.MnemonicoId == dadoResultado.IdMnemonicopmo);
                if (insumo == null)
                {
                    insumo = new InsumoDto
                    {
                        IdDadoResultado = dadoResultado.IdDadoresultpmo,
                        codSubsistema = dadoResultado.IdListaresultadopmoNavigation.IdOrigemresultadopmoNavigation.CodOrigemresultadopmopai,
                        codTpGeracao = dadoResultado.IdListaresultadopmoNavigation.TbAuxUsinamontador.CodTpgeracao,
                        MnemonicoId = dadoResultado.IdMnemonicopmo,
                        Grandezas = new List<GrandezaDto>(),

                    };
                    agente.Insumo.Add(insumo);
                }
                var grandeza = insumo.Grandezas.FirstOrDefault(x => x.NomeGrandeza == dadoResultado.IdMnemonicopmoNavigation.NomMnemonicopmo);
                if (grandeza == null)
                {
                    grandeza = new GrandezaDto
                    {
                        CodMnemonicoPMO = dadoResultado.IdMnemonicopmoNavigation.CodMnemonicopmo,
                        NomeGrandeza = dadoResultado.IdMnemonicopmoNavigation.NomMnemonicopmo,
                        Patamares = new List<PatamarDto>()
                    };
                    insumo.Grandezas.Add(grandeza);

                }
                var patamares = grandeza.Patamares.FirstOrDefault(x => x.IdPatamar == dadoResultado.IdTppatamar);
                if (patamares == null)
                {
                    patamares = new PatamarDto
                    {
                        IdPatamar = dadoResultado.IdTppatamar ?? 0,
                        Patamar = dadoResultado.Tppatamar,
                        Valor = dadoResultado.DscValorcoletadomnemonico
                    };
                    grandeza.Patamares.Add(patamares);
                }
            }
            return resultadoFinal;


        }

        public ValueTask<TbPmoDto> ObterPMOPorChaveAsync(int chave)
        {
            throw new NotImplementedException();
        }

        public async Task<TbPmoDto> ObterPMOPorFiltro(PmoFilter filter)
        {
            var tbPmo = _PMORepository.ObterPorFiltro(filter);
            //var tbPmo =  await _PMORepository
            //  .GetbyExpressionAsync(x=>x.AnoReferencia == filter.AnoReferencia && x.MesReferencia == filter.MesReferencia);

            if (tbPmo == null)
            {
                return null;
            }

            var tbPmoDto = _mapper.Map<TbPmoDto>(tbPmo);
            return tbPmoDto;



        }

        public ValueTask<PmoDto> ObterPMOPorFiltroExternoAsync(PmoFilter filtro)
        {
            throw new NotImplementedException();
        }
    }

}
