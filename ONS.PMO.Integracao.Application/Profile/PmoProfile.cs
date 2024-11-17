
using ONS.PMO.Integracao.Application.Dto.DisponibilidadeCVU;
using ONS.PMO.Integracao.Application.Dto.TabelasDto;
using ONS.PMO.Integracao.Domain.Entidades.Auxiliar;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.SAGER.DisponibilidadeCVU;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Application.Profile
{
    public class PmoProfile : AutoMapper.Profile
    {
        public PmoProfile()
        {

            CreateMap<Pmo, TbPmoDto>()
                .ForMember(dest => dest.IdPmo, opt => opt.MapFrom(src => src.IdPmo))
                .ForMember(dest => dest.AnoReferencia, opt => opt.MapFrom(src => src.AnoReferencia))
                .ForMember(dest => dest.MesReferencia, opt => opt.MapFrom(src => src.MesReferencia))
                .ForMember(dest => dest.QtdMesesadiante, opt => opt.MapFrom(src => src.QtdMesesadiante))
                .ForMember(dest => dest.VerControleconcorrencia.Length, opt => opt.MapFrom(src => src.VerControleconcorrencia))
                .ForMember(dest => dest.TbSemanaoperativas, opt => opt.MapFrom(src => src.TbSemanaoperativas));

            CreateMap<Disponibilidade, DisponibilidadeDto>().ReverseMap();
            CreateMap<AgenteInstituicao, TbAgenteinstituicaoDto>().ReverseMap();
            CreateMap<Arquivo, TbArquivoDto>().ReverseMap();
            CreateMap<ArquivoFonteResultadoPmo, TbArquivofonteresultpmoDto>().ReverseMap();
            CreateMap<ArquivoSemanaOperativa, TbArquivosemanaoperativaDto>().ReverseMap();
            CreateMap<TbAuxConjmaqmontador, TbAuxConjmaqmontadorDto>().ReverseMap();
            CreateMap<TbAuxContrato, TbAuxContratoDto>().ReverseMap();
            CreateMap<TbAuxDesvioagua, TbAuxDesvioaguaDto>().ReverseMap();
            CreateMap<TbAuxInterligacao, TbAuxInterligacaoDto>().ReverseMap();
            CreateMap<TbAuxInterligacaomontador, TbAuxInterligacaomontadorDto>().ReverseMap();
            CreateMap<TbAuxInterligacaomontadorinterligacao, TbAuxInterligacaomontadorinterligacaoDto>().ReverseMap();
            CreateMap<TbAuxInterligacaomontadorusina, TbAuxInterligacaomontadorusinaDto>().ReverseMap();
            CreateMap<TbAuxIntervalocustodeficit, TbAuxIntervalocustodeficitDto>().ReverseMap();
            CreateMap<TbAuxMnemonicomontador, TbAuxMnemonicomontadorDto>().ReverseMap();
            CreateMap<TbAuxPequenausina, TbAuxPequenausinaDto>().ReverseMap();
            CreateMap<TbAuxReemontador, TbAuxReemontadorDto>().ReverseMap();
            CreateMap<TbAuxReservatorio, TbAuxReservatorioDto>().ReverseMap();
            CreateMap<TbAuxSubmercado, TbAuxSubmercadoDto>().ReverseMap();
            CreateMap<TbAuxSubsistemacontrato, TbAuxSubsistemacontratoDto>().ReverseMap();
            CreateMap<TbAuxSubsistema, TbAuxSubsistemaDto>().ReverseMap();
            CreateMap<TbAuxSubsistemaintervalocustodeficit, TbAuxSubsistemaintervalocustodeficitDto>().ReverseMap();
            CreateMap<TbAuxSubsistemamontador, TbAuxSubsistemamontadorDto>().ReverseMap();
            CreateMap<TbAuxUnidadegeradora, TbAuxUnidadegeradoraDto>().ReverseMap();
            CreateMap<TbAuxUnidadegeradoramontador, TbAuxUnidadegeradoramontadorDto>().ReverseMap();
            CreateMap<TbAuxUsinaconjunto, TbAuxUsinaconjuntoDto>().ReverseMap();
            CreateMap<TbAuxUsina, TbAuxUsinaDto>().ReverseMap();
            CreateMap<TbAuxUsinamnemonico, TbAuxUsinamnemonicoDto>().ReverseMap();
            CreateMap<TbAuxUsinamontador, TbAuxUsinamontadorDto>().ReverseMap();
            CreateMap<Bloco, TbBlocoDto>().ReverseMap();
            CreateMap<BlocoEstudoMontador, TbBlocoestudomontadorDto>().ReverseMap();
            CreateMap<CampoChave, TbCampochaveDto>().ReverseMap();
            CreateMap<CampoChaveTipoColeta, TbCampochavetpcoletumDto>().ReverseMap();
            CreateMap<ChaveBloco, TbChaveblocoDto>().ReverseMap();
            CreateMap<ChaveBlocoEstudo, TbChaveblocoestudoDto>().ReverseMap();
            CreateMap<ChaveMnemonico, TbChavemnemonicoDto>().ReverseMap();
            CreateMap<ChaveMnemonicoEstudo, TbChavemnemonicoestudoDto>().ReverseMap();
            CreateMap<ColetaInsumo, TbColetainsumoDto>().ReverseMap();
            CreateMap<ColunaGrandeza, TbColunagrandezaDto>().ReverseMap();
            CreateMap<ConfiguracaoCenarioPadrao, TbConfiguracaocenariopadraoDto>().ReverseMap();
            CreateMap<ConfiguracaoGestaoManutencao, TbConfiguracaogestaomanutencaoDto>().ReverseMap();
            CreateMap<ConjuntoGeracaoMinima, TbConjuntogeracaominimaDto>().ReverseMap();
            CreateMap<DadoColetaEstruturado, TbDadocoletaestruturadoDto>().ReverseMap();
            CreateMap<DadoColetaManutencao, TbDadocoletamanutencaoDto>().ReverseMap();
            CreateMap<DadoColetaNaoEstruturado, TbDadocoletanaoestruturadoDto>().ReverseMap();
            CreateMap<DadoColeta, TbDadocoletumDto>().ReverseMap();
            CreateMap<DadoResultadoPMO, TbDadoresultpmoDto>().ReverseMap();
            CreateMap<DadosConvergencia, TbDadosconvergenciumDto>().ReverseMap();
            CreateMap<DecisaoComandoGNL, TbDecisaocomandognlDto>().ReverseMap();
            CreateMap<DemandaIntegral, TbDemandaintegralDto>().ReverseMap();
            CreateMap<Desligamento, TbDesligamentoDto>().ReverseMap();
            CreateMap<DiaSemana, TbDiasemanaDto>().ReverseMap();
            CreateMap<EstadoBlocoEstudoMontador, TbEstadoblocoestudomontadorDto>().ReverseMap();
            CreateMap<EstadoManutencaoPmo, TbEstadomanutencaopmoDto>().ReverseMap();
            CreateMap<EstadoMnemonicoEstudoMontador, TbEstadomnemonicoestudomontadorDto>().ReverseMap();
            CreateMap<EstadoRestricaoEstudoMontador, TbEstadorestricaoestudomontadorDto>().ReverseMap();
            CreateMap<EstagioGrandeza, TbEstagiograndezaDto>().ReverseMap();
            CreateMap<EstagioGrandezaMnemonico, TbEstagiograndezamnemonicoDto>().ReverseMap();
            CreateMap<EstudoMontador, TbEstudomontadorDto>().ReverseMap();
            CreateMap<EstudoMontadorNaoOficial, TbEstudomontadornaooficialDto>().ReverseMap();
            CreateMap<EstudoSelecionado, TbEstudoselecionadoDto>().ReverseMap();
            CreateMap<ExportacaoArquivoTexto, TbExportacaoarquivotextoDto>().ReverseMap();
            CreateMap<FonteOrigem, TbFonteorigemDto>().ReverseMap();
            CreateMap<Gabarito, TbGabaritoDto>().ReverseMap();
            CreateMap<GeracaoMinimaPeriodoDia, TbGeracaominimaperiododiumDto>().ReverseMap();
            CreateMap<GeracaoPequenasUsina, TbGeracaopequenasusinaDto>().ReverseMap();
            CreateMap<GeracaoTermica, TbGeracaotermicaDto>().ReverseMap();
            CreateMap<GrandezaBloco, TbGrandezablocoDto>().ReverseMap();
            CreateMap<GrandezaBlocoAC, TbGrandezablocoacDto>().ReverseMap();
            CreateMap<GrandezaBlocoEstudo, GrandezaBlocoEstudo>().ReverseMap();
            CreateMap<Grandeza, TbGrandezaDto>().ReverseMap();
            CreateMap<GrandezaMnemonicoEstudo, TbGrandezamnemonicoestudoDto>().ReverseMap();
            CreateMap<GrandezaMontador, TbGrandezamontadorDto>().ReverseMap();
            CreateMap<HistoricoConfiguracaoBloco, TbHisconfigblocoDto>().ReverseMap();
            CreateMap<HistoricoConfiguracaoGrandeza, TbHisconfiggrandezaDto>().ReverseMap();
            CreateMap<HistoricoModificacaoColetaInsumo, TbHistmodifcoletainsumoDto>().ReverseMap();
            CreateMap<HistoricoModificacaoSemanaOperativa, TbHistmodifsemanaoperDto>().ReverseMap();
            CreateMap<ImportacaoPmo, TbImportacaopmoDto>().ReverseMap();
            CreateMap<InsumoEstruturado, TbInsumoestruturadoDto>().ReverseMap();
            CreateMap<InsumoNaoEstruturado, TbInsumonaoestruturadoDto>().ReverseMap();
            CreateMap<InsumoPMO, TbInsumopmoDto>().ReverseMap();
            CreateMap<IntervencaoSGI, TbIntervencaosgiDto>().ReverseMap();
            CreateMap<LimitePeriodoDia, TbLimiteperiododiumDto>().ReverseMap();
            CreateMap<LimitesIntercambio, TbLimitesintercambioDto>().ReverseMap();
            CreateMap<LimitesPatamar, TbLimitespatamarDto>().ReverseMap();
            CreateMap<ListaResultadoPmo, TbListaresultadopmoDto>().ReverseMap();
            CreateMap<LogAuditoria, TbLogauditoriumDto>().ReverseMap();
            CreateMap<LogDadosInformado, TbLogdadosinformadoDto>().ReverseMap();
            CreateMap<LogNotificacao, TbLognotificacaoDto>().ReverseMap();
            CreateMap<ManutencaoPmo, TbManutencaopmoDto>().ReverseMap();
            CreateMap<ManutencaoProgramadaEstudo, TbManutencaoprogramadaestudoDto>().ReverseMap();
            CreateMap<ManutencaoProgramada, TbManutencaoprogramadumDto>().ReverseMap();
            CreateMap<MneespEstudoMontador, TbMneespestudomontadorDto>().ReverseMap();
            CreateMap<MnemonicoBlocoAC, TbMnemonicoblocoacDto>().ReverseMap();
            CreateMap<MnemonicoEstudoMontador, TbMnemonicoestudomontadorDto>().ReverseMap();
            CreateMap<MnemonicoPmo, TbMnemonicopmoDto>().ReverseMap();
            CreateMap<ModificacaoConfiguracaoBlocoEstudo, TbModifconfigblocoestudoDto>().ReverseMap();
            CreateMap<MotivoAlteracao, TbMotivoalteracaoDto>().ReverseMap();
            CreateMap<OrdemExportacaoAgente, TbOrdemexportacaoagenteDto>().ReverseMap();
            CreateMap<OrdenacaoRegistro, TbOrdenacaoregistroDto>().ReverseMap();
            CreateMap<OrigemColetaMontador, TbOrigemcoletamontadorDto>().ReverseMap();
            CreateMap<OrigemColetum, TbOrigemcoletumDto>().ReverseMap();
            CreateMap<OrigemResultadoPmo, TbOrigemresultadopmoDto>().ReverseMap();
            CreateMap<ParametroPMO, TbParametropmoDto>().ReverseMap();
            CreateMap<PerdaPotencia, TbPerdapotenciumDto>().ReverseMap();
            //CreateMap<TbPmo, TbPmoDto>().ReverseMap();
            CreateMap<RecuperacaoDado, TbRecuperacaodadoDto>().ReverseMap();
            CreateMap<RecuperacaoDadosAgentePmo, TbRecuperacaodadosagentepmoDto>().ReverseMap();
            CreateMap<RecuperacaoDadosBloco, TbRecuperacaodadosblocoDto>().ReverseMap();
            CreateMap<ReducaoLimiteIntercambio, TbReducaolimiteintercambioDto>().ReverseMap();
            CreateMap<Restricao, TbRestricaoDto>().ReverseMap();
            CreateMap<RestricaoEletrica, TbRestricaoeletricaDto>().ReverseMap();
            CreateMap<RestricaoEstudo, TbRestricaoestudoDto>().ReverseMap();
            CreateMap<ResultadoColetaPmo, TbResultadocoletapmoDto>().ReverseMap();
            CreateMap<SemanaOperativa, TbSemanaoperativaDto>().ReverseMap();
            CreateMap<Titulacao, TbTitulacaoDto>().ReverseMap();
            CreateMap<CategoriaInsumo, TbTpcategoriainsumoDto>().ReverseMap();
            CreateMap<Coleta, TbTpcoletumDto>().ReverseMap();
            CreateMap<DadoGrandeza, TbTpdadograndezaDto>().ReverseMap();
            CreateMap<Estagio, TbTpestagioDto>().ReverseMap();
            CreateMap<TipoImportacaoPmo, TbTpimportacaopmoDto>().ReverseMap();
            CreateMap<Limite, TbTplimiteDto>().ReverseMap();
            CreateMap<TipoManutencaoProgramada, TbTpmanutencaoprogramadumDto>().ReverseMap();
            CreateMap<TipoMnemonico, TbTpmnemonicoDto>().ReverseMap();
            CreateMap<Patamar, TbTppatamarDto>().ReverseMap();
            CreateMap<TipoPeriodoMontador, TbTpperiodomontadorDto>().ReverseMap();
            CreateMap<TipoRestricao, TbTprestricaoDto>().ReverseMap();
            CreateMap<SituacaoColetaIsumo, TbTpsituacaocoletainsumoDto>().ReverseMap();
            CreateMap<SituacaoSemanaOperativa, TbTpsituacaosemanaoperDto>().ReverseMap();

        }
    }
}
