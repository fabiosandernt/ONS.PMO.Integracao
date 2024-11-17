using AutoMapper;
using ONS.PMO.Integracao.Application.Dto.DisponibilidadeCVU;
using ONS.PMO.Integracao.Application.Dto.TabelasDto;
using ONS.PMO.Integracao.Application.Filter;
using ONS.PMO.Integracao.Application.Service.Interfaces;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.SAGER.DisponibilidadeCVU;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.PMO;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.SAGER;
using System.Globalization;

namespace ONS.PMO.Integracao.Application.Service
{
    public class PmoServices : IPmoServices
    {
          
        private readonly IDadosResultadoPmoRepository _dadosResultadoPmoRepository;
        private readonly IMapper _mapper;
        private readonly IPMORepository _PMORepository;


        public PmoServices(IMapper mapper, IDadosResultadoPmoRepository dadosResultadoPmoRepository, IPMORepository PMORepository)
        {
            _PMORepository = PMORepository;
            _dadosResultadoPmoRepository = dadosResultadoPmoRepository;           
            _mapper = mapper;
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


        //public async Task<TbPmoDto> GetByIdAsync(int id)
        //{
        //   var tbPmo = await _PMORepository.Get(id);
        //   var tbPmoDto = _mapper.Map<TbPmoDto>(tbPmo);
        //   return tbPmoDto;
        //}

        public ICollection<TbPmoDto> GetByQueryable(PmoFilter filter)
        {
            var query = _PMORepository.GetByQueryable(filter);
            var pmosDto = _mapper.Map<List<TbPmoDto>>(query);
            return pmosDto;
        }

        public async Task<DadoResultadoPmoDto> ObterDadosMontadorDisponibilidadeInflexibilidadeCVU(DisponibilidadeFilter filter)
        {
            var query = await _dadosResultadoPmoRepository.GetDadoResultPmosAsync(filter);
            var resultados = new List<PmoDto>();
            var resultadoFinal = new DadoResultadoPmoDto() { Pmo = resultados,Offset=filter.Offset??0 };
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
                        IdImportacao = dadoResultado.IdListaresultadopmoNavigation.IdImportacaopmo??0,
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
                if (agente == null) {
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
                if (insumo == null) {
                    insumo = new InsumoDto
                    {
                        IdDadoResultado = dadoResultado.IdDadoresultpmo,
                        codSubsistema= dadoResultado.IdListaresultadopmoNavigation.IdOrigemresultadopmoNavigation.CodOrigemresultadopmopai,
                        codTpGeracao= dadoResultado.IdListaresultadopmoNavigation.TbAuxUsinamontador.CodTpgeracao,
                        MnemonicoId = dadoResultado.IdMnemonicopmo,
                        Grandezas = new List<GrandezaDto>(),
                       
                    };
                agente.Insumo.Add(insumo);
                }
                var grandeza = insumo.Grandezas.FirstOrDefault(x => x.NomeGrandeza == dadoResultado.IdMnemonicopmoNavigation.NomMnemonicopmo);
                if (grandeza == null) {
                    grandeza = new GrandezaDto
                    {
                        CodMnemonicoPMO = dadoResultado.IdMnemonicopmoNavigation.CodMnemonicopmo,
                        NomeGrandeza = dadoResultado.IdMnemonicopmoNavigation.NomMnemonicopmo,
                        Patamares = new List<PatamarDto>()
                    };
                    insumo.Grandezas.Add(grandeza);
                
                }
                var patamares = grandeza.Patamares.FirstOrDefault(x => x.IdPatamar == dadoResultado.IdTppatamar);
                if (patamares == null) {
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

        public async Task<TbPmoDto> ObterPMOPorFiltro(PmoFilter filter)
        {
            var tbPmo = _PMORepository.ObterPorFiltro(filter);       
            //var tbPmo =  await _PMORepository
              //.FindOneByCriterio(x=>x.AnoReferencia == filter.AnoReferencia && x.MesReferencia == filter.MesReferencia);

            if (tbPmo == null)
            {                
                return null; 
            }
           
            var tbPmoDto = _mapper.Map<TbPmoDto>(tbPmo);
            return tbPmoDto;

            

        }

        public void AtualizarMesesAdiantePMO(int idPMO, int? mesesAdiante, byte[] versao)
        {
            ValidarQuantidadeMesesAdiante(mesesAdiante);
            PMO pmo = _PMORepository.FindByKeyConcurrencyValidate(idPMO, versao);
            if (pmo != null)
            {
                pmo.Versao = versao;
                pmo.QuantidadeMesesAdiante = mesesAdiante;
            }
        }
        public Pmo ObterPMOPorChaveAsync(int chave)
        {
            return _PMORepository.FindByKey(chave);
        }

        public void ExcluirPMO(DadosPMODTO dto)
        {
            PMO pmo = _PMORepository.FindByKeyConcurrencyValidate(dto.IdPMO, dto.VersaoPMO);
            if (pmo != null)
            {
                ValidarExclusaoPMO(pmo);
                pmo.Versao = dto.VersaoPMO;
                historicoService.ExcluirHistoricosSemanaOperativa(pmo.SemanasOperativas);
                pmoRepository.Delete(pmo);
            }
            else
            {
                throw new ONSBusinessException(SGIPMOMessages.MS014);
            }
        }

        public PMO GerarPMO(int ano, int mes)
        {
            ValidarInclusaoPMO(ano, mes);
            PMO pmo = new PMO
            {
                AnoReferencia = ano,
                MesReferencia = mes,
                SemanasOperativas = semanaOperativaService.GerarSugestaoSemanasOperativas(ano, mes)
            };
            var parametroQtdMeses = parametroService.ObterParametro(ParametroEnum.QuantidadeMesesAFrente);
            if (parametroQtdMeses != null)
            {
                pmo.QuantidadeMesesAdiante = int.Parse(parametroQtdMeses.Valor);
            }
            pmoRepository.Add(pmo);
            return pmo;
        }

        #region Incluir Semana Operativa

        public void IncluirSemanaOperativa(InclusaoSemanaOperativaDTO dto)
        {
            PMO pmo = _PMORepository.FindByKeyConcurrencyValidate(dto.IdPMO, dto.VersaoPMO);
            if (pmo != null)
            {
                pmo.Versao = dto.VersaoPMO; // Necessário para forçar o incremento da versão do PMO

                var semanasOrdenasPorRevisao = pmo.SemanasOperativas.OrderBy(s => s.Revisao);

                var cultura = CultureInfo.CurrentCulture;
                string nomeMes = cultura.TextInfo.ToTitleCase(cultura.DateTimeFormat.GetMonthName(pmo.MesReferencia));

                if (dto.IsInicioPMO)
                {
                    ValidarExisteEstudoPmo(pmo);
                    semanaOperativaService.AtualizarSemanasOperativasInclusao(semanasOrdenasPorRevisao,
                        pmo.AnoReferencia, nomeMes);
                }

                int revisao = ObterNumeroRevisao(pmo.SemanasOperativas.Count, dto.IsInicioPMO);
                DateTime dataInicioSemana = ObterDataInicioSemana(semanasOrdenasPorRevisao, dto.IsInicioPMO);

                ValidarDataInclusaoExclusaoSemanaOperativa(dataInicioSemana);

                DateTime dataFimPMO = ObterDataFimPMO(semanasOrdenasPorRevisao, dto.IsInicioPMO);

                SemanaOperativa semanaOperativa = semanaOperativaService.GerarSemanaOperativa(pmo.AnoReferencia,
                    nomeMes, dataInicioSemana, dataFimPMO, revisao);

                pmo.SemanasOperativas.Add(semanaOperativa);
            }
        }


        private int ObterNumeroRevisao(int ultimaRevisao, bool isInicioPMO)
        {
            int revisao = 0;
            if (!isInicioPMO)
            {
                revisao = ultimaRevisao;
            }
            return revisao;
        }

        private DateTime ObterDataInicioSemana(IEnumerable<SemanaOperativa> semanasOperativas, bool isInicioPMO)
        {
            return isInicioPMO ? semanasOperativas.First().DataInicioSemana.AddDays(-7)
                : semanasOperativas.Last().DataInicioSemana.AddDays(7);
        }

        private DateTime ObterDataFimPMO(IEnumerable<SemanaOperativa> semanasOperativas, bool isInicioPMO)
        {
            return isInicioPMO ? semanasOperativas.Last().DataFimSemana
                : semanasOperativas.Last().DataFimSemana.AddDays(7);
        }

        #endregion
        #region Excluir Semana Operativa
        public void ExcluirUltimaSemanaOperativa(int idPMO, byte[] versaoPMO)
        {
            PMO pmo = _PMORepository.FindByKeyConcurrencyValidate(idPMO, versaoPMO);
            if (pmo != null)
            {
                ValidarExistenciaSemanaOperativa(pmo);

                SemanaOperativa ultimaSemana = pmo.SemanasOperativas.Last();

                DateTime dataInicioUltimaSemana = ultimaSemana.DataInicioSemana;
                ValidarDataInclusaoExclusaoSemanaOperativa(dataInicioUltimaSemana);

                ValidarColetaDados(ultimaSemana);

                semanaOperativaService.ExcluirSemana(ultimaSemana);

                pmo.Versao = versaoPMO;
            }
        }

        #region Validação
        private void ValidarInclusaoPMO(int ano, int mes)
        {
            IList<string> mensagens = new List<string>();

            DateTime dataCorrente = DateTime.Now.Date;
            if (dataCorrente.Year > ano
                || (dataCorrente.Year == ano && dataCorrente.Month > mes))
            {
                mensagens.Add(SGIPMOMessages.MS003);
            }

            PMOFilter filtro = new PMOFilter()
            {
                Ano = ano,
                Mes = mes
            };

            PMO pmo = pmoRepository.ObterPorFiltro(filtro);

            if (pmo != null)
            {
                mensagens.Add(SGIPMOMessages.MS002);
            }
            if (mensagens.Any())
            {
                throw new ONSBusinessException(mensagens);
            }
        }

        private void ValidarExisteEstudoPmo(PMO pmo)
        {
            if (pmo.SemanasOperativas.Any(s => s.Situacao != null
                && s.Situacao.Id != (int)SituacaoSemanaOperativaEnum.Configuracao))
            {
                throw new ONSBusinessException(SGIPMOMessages.MS065);
            }
        }


        #endregion

        private void ValidarExistenciaSemanaOperativa(PMO pmo)
        {
            if (pmo != null)
            {
                if (pmo.SemanasOperativas.Count == 1)
                {
                    throw new ONSBusinessException(SGIPMOMessages.MS007);
                }
            }
        }

        private void ValidarDataInclusaoExclusaoSemanaOperativa(DateTime data)
        {
            if (data.CompareTo(DateTime.Now.Date) < 0)
            {
                throw new ONSBusinessException(SGIPMOMessages.MS010);
            }
        }

        private void ValidarColetaDados(SemanaOperativa semanaOperativa)
        {
            var situacao = semanaOperativa.Situacao;
            if (situacao != null)
            {
                var sitaucaoSemanaOperativa = (SituacaoSemanaOperativaEnum)situacao.Id;
                if (sitaucaoSemanaOperativa >= SituacaoSemanaOperativaEnum.ColetaDados)
                {
                    throw new ONSBusinessException(SGIPMOMessages.MS011);
                }
            }
        }

        private void ValidarExclusaoPMO(PMO pmo)
        {
            IList<string> mensagens = new List<string>();

            bool existeSemanaPosConfiguracao =
                pmo.SemanasOperativas.Any(s => s.Situacao != null &&
                    s.Situacao.Id > (int)SituacaoSemanaOperativaEnum.Configuracao);

            if (existeSemanaPosConfiguracao)
            {
                mensagens.Add(SGIPMOMessages.MS029);
            }

            bool existeSemanaComGabarito =
                pmo.SemanasOperativas.Any(s => s.Gabaritos.Any());

            if (existeSemanaComGabarito)
            {
                mensagens.Add(SGIPMOMessages.MS030);
            }

            if (mensagens.Any())
            {
                throw new ONSBusinessException(mensagens);
            }
        }

        private void ValidarQuantidadeMesesAdiante(int? qtdMeses)
        {
            if (qtdMeses.HasValue && qtdMeses.Value > 11)
            {
                throw new ONSBusinessException(SGIPMOMessages.MS009);
            }
        }

        #endregion



    }

}
