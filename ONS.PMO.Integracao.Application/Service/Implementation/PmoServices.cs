using AutoMapper;
using ONS.PMO.Integracao.Application.Dto.DisponibilidadeCVU;
using ONS.PMO.Integracao.Application.Dto.PMO;
using ONS.PMO.Integracao.Application.Filter;
using ONS.PMO.Integracao.Application.Service.Interfaces;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.SAGER.DisponibilidadeCVU;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.PMO;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.SAGER;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ONS.PMO.Integracao.Application.Service.Implementation
{
    public class PmoServices : IPmoServices
    {

        private readonly IDadosResultadoPmoRepository _dadosResultadoPmoRepository;
        private readonly IMapper _mapper;
        private readonly IPMORepository _PMORepository;
        private readonly IPMORepository _pmoRepository;
        private readonly ISemanaOperativaService _semanaOperativaService;
        private readonly IParametroService _parametroService;
        private readonly IHistoricoService _historicoService;

        public PmoServices(IDadosResultadoPmoRepository dadosResultadoPmoRepository, IMapper mapper, IPMORepository pMORepository, IPMORepository pmoRepository, ISemanaOperativaService semanaOperativaService, IParametroService parametroService, IHistoricoService historicoService)
        {
            _dadosResultadoPmoRepository = dadosResultadoPmoRepository;
            _mapper = mapper;
            _PMORepository = pMORepository;
            _pmoRepository = pmoRepository;
            _semanaOperativaService = semanaOperativaService;
            _parametroService = parametroService;
            _historicoService = historicoService;
        }

        public Task AtualizarMesesAdiantePMOAsync(int idPMO, int? mesesAdiante, byte[] versao)
        {
            throw new NotImplementedException();
        }

        public async Task ExcluirPMOAsync(DadosPMODTO dto)
        {
            var pmo = await _PMORepository.GetbyExpressionAsync(x=>x.IdPmo == dto.IdPMO && x.VerControleconcorrencia == dto.VersaoPMO);
            if (pmo != null)
            {
                await _PMORepository.Delete(pmo);
            }       
        }

        public Task ExcluirUltimaSemanaOperativaAsync(int idPMO, byte[] versaoPMO)
        {
            throw new NotImplementedException();
        }

        public Task<TbPmoDto> GerarPMOAsync(TbPmoDto dto)
        {
            var pmo = new Pmo()
            {
                AnoReferencia = dto.AnoReferencia,
                MesReferencia = dto.MesReferencia,
                SemanasOperativas = semanaOperativaService.GerarSugestaoSemanasOperativas(ano, mes)
            };
            var parametroQtdMeses = parametroService.ObterParametro(ParametroEnum.QuantidadeMesesAFrente);
            if (parametroQtdMeses != null)
            {
                pmo.QuantidadeMesesAdiante = int.Parse(parametroQtdMeses.Valor);
            }
            _PMORepository.Add(pmo);
            return pmo;
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
