using ONS.PMO.Integracao.Application.Dto.DisponibilidadeCVU;
using ONS.PMO.Integracao.Application.Dto.TabelasDto;
using ONS.PMO.Integracao.Domain.Entidades.BDT;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.SAGER.DisponibilidadeCVU;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

namespace ONS.PMO.Integracao.Application.Profile
{
    public class PmoProfile : AutoMapper.Profile
    {
        public PmoProfile()
        {
            CreateMap<ImportacaoPMO, ImportacaoPmoDto>().ReverseMap();
            CreateMap<ListaResultadoPMO, ListaResultadoPmoDto>().ReverseMap();     
            CreateMap<OrigemResultadoPMO, OrigemResultadoPmoDto>().ReverseMap();
            CreateMap<ParametroPMO, ParametroPmoDto>().ReverseMap();
            
            CreateMap<Pmo, PmoDto>()
                .ForMember(dest => dest.IdPmo, opt => opt.MapFrom(src => src.IdPmo))
                .ForMember(dest => dest.AnoReferencia, opt => opt.MapFrom(src => src.AnoReferencia))
                .ForMember(dest => dest.MesReferencia, opt => opt.MapFrom(src => src.MesReferencia))
                .ForMember(dest => dest.QtdMesesadiante, opt => opt.MapFrom(src => src.QtdMesesadiante))
                .ForMember(dest => dest.VerControleconcorrencia.Length, opt => opt.MapFrom(src => src.VerControleconcorrencia))
                .ForMember(dest => dest.TbSemanaoperativas, opt => opt.MapFrom(src => src.TbSemanaoperativas));


            CreateMap<ResultadoColetaPMO, ResultadoColetaPmoDto>().ReverseMap();
            CreateMap<TipoImportacaoPMO, ImportacaoDto>().ReverseMap();

            //Aux
            CreateMap<AuxConjMaquinaMontador, AuxConjMaquinaMontadorDto>().ReverseMap();
            CreateMap<AuxContrato, AuxContratoDto>().ReverseMap();
            CreateMap<AuxDesvioAgua, AuxDesvioAguaDto>().ReverseMap();
            CreateMap<AuxIntervaloCustoDeficit, AuxIntervaloCustoDeficitDto>().ReverseMap();
            CreateMap<AuxMnemonicoMontador, AuxMnemonicoMontadorDto>().ReverseMap();
            CreateMap<AuxReeMontador, AuxReeMontadorDto>().ReverseMap();
            CreateMap<AuxReservatorio, AuxReservatorioDto>().ReverseMap();
            CreateMap<AuxSubmercado, AuxSubmercadoDto>().ReverseMap();
            CreateMap<AuxUnidadeGeradora, AuxUnidadeGeradoraDto>().ReverseMap();
            CreateMap<AuxUnidadeGeradoraMontador, AuxUnidadeGeradoraMontadorDto>().ReverseMap();

            //Arquivos
            CreateMap<Arquivo, ArquivoDto>().ReverseMap();
            CreateMap<ArquivoFonteResultPMO, ArquivoFonteResultPMODto>().ReverseMap();
            CreateMap<ArquivoSemanaOperativa, ArquivoSemanaOperativaDto>().ReverseMap();
            CreateMap<ExportacaoArquivoTexto, ExportacaoArquivoTextoDto>().ReverseMap();

            //Blocos
            CreateMap<Bloco, BlocoDto>().ReverseMap();
            CreateMap<EstadoBlocoEstudoMontador, EstadoBlocoEstudoMontadorDto>().ReverseMap();
            CreateMap<GrandezaBloco, GrandezaBlocoDto>().ReverseMap();
            CreateMap<GrandezaBlocoAC, GrandezaBlocoAcDto>().ReverseMap();
            CreateMap<GrandezaBlocoEstudo, GrandezaBlocoEstudo>().ReverseMap();
            CreateMap<BlocoEstudoMontador, BlocoEstudoMontadorDto>().ReverseMap();

            //Chaves
            CreateMap<ChaveBloco, ChaveBlocoDto>().ReverseMap();
            CreateMap<ChaveBlocoEstudo, ChaveBlocoEstudoDto>().ReverseMap();
            CreateMap<ChaveMnemonico, ChaveMnemonicoDto>().ReverseMap();
            CreateMap<ChaveMnemonicoEstudo, ChaveMnemonicoEstudoDto>().ReverseMap();
            CreateMap<CampoChave, CampoChaveDto>().ReverseMap();
            CreateMap<CampoChaveColeta, CampoChaveColetumDto>().ReverseMap();

            //Dados
            CreateMap<DadoColetaEstruturado, DadoColetaEstruturadoDto>().ReverseMap();
            CreateMap<DadoColetaManutencao, DadoColetaManutencaoDto>().ReverseMap();
            CreateMap<DadoColetaNaoEstruturado, DadoColetanaoEstruturadoDto>().ReverseMap();
            CreateMap<DadoColeta, DadoColetumDto>().ReverseMap();
            CreateMap<DadoResultPMO, DadoResultPMODto>().ReverseMap();
            CreateMap<DadosConvergencia, DadosConvergenciumDto>().ReverseMap();
            CreateMap<RecuperacaoDado, RecuperacaoDadoDto>().ReverseMap();
            CreateMap<RecuperacaoDadosAgentePMO, RecuperacaoDadosAgentePmoDto>().ReverseMap();
            CreateMap<RecuperacaoDadosBloco, RecuperacaoDadosBlocoDto>().ReverseMap();
            CreateMap<DadoGrandeza, DadoGrandezaDto>().ReverseMap();

            //Dias semana
            CreateMap<DiasSemana, DiaSemanaDto>().ReverseMap();
            CreateMap<ONS.PMO.Integracao.Domain.Entidades.PMO.SemanaOperativa, Dto.TabelasDto.SemanaOperativaDto>().ReverseMap();
            CreateMap<SituacaoSemanaOperacao, SituacaoSemanaOperativaDto>().ReverseMap();

            //Estudo e Estado
            CreateMap<EstadoManutencaoPMO, EstadoManutencaoPMODto>().ReverseMap();
            CreateMap<EstadoMnemonicoEstudoMontador, EstadoMnemonicoEstudoMontadorDto>().ReverseMap();
            CreateMap<EstadoRestricaoEstudoMontador, EstadoRestricaoEstudoMontadorDto>().ReverseMap();
            CreateMap<EstudoMontador, EstudoMontadorDto>().ReverseMap();
            CreateMap<EstudoMontadorNaoOficial, EstudoMontadorNaoOficialDto>().ReverseMap();
            CreateMap<EstudoSelecionado, EstudoSelecionadoDto>().ReverseMap();

            //Geração
            CreateMap<ConjuntoGeracaoMinima, ConjuntoGeracaoMinimaDto>().ReverseMap();
            CreateMap<GeracaoMinimaPeriodo, GeracaoMinimaPeriodoDto>().ReverseMap();
            CreateMap<GeracaoPequenasUsina, GeracaoPequenasUsinaDto>().ReverseMap();
            CreateMap<GeracaoTermica, GeracaoTermicaDto>().ReverseMap();

            //Histórico
            CreateMap<ColunaGrandeza, ColunaGrandezaDto>().ReverseMap();
            CreateMap<EstagioGrandeza, EstagioGrandezaDto>().ReverseMap();
            CreateMap<EstagioGrandezaMnemonico, EstagioGrandezaMnemonicoDto>().ReverseMap();
            CreateMap<Grandeza, GrandezaDto>().ReverseMap();
            CreateMap<GrandezaMnemonicoEstudo, GrandezaMnemonicoEstudoDto>().ReverseMap();
            CreateMap<GrandezaMontador, GrandezaMontadorDto>().ReverseMap();
            CreateMap<HistoricoConfiguracaoBloco, HisConfigBlocoDto>().ReverseMap();
            CreateMap<HistoricoConfiguracaoGrandeza, HisConfigGrandezaDto>().ReverseMap();
            CreateMap<HistoricoColetaInsumo, HistmoDifColetaInsumoDto>().ReverseMap();
            CreateMap<HistoricoSemanaOperativa, HistModifSemanaOperDto>().ReverseMap();

            //Insumo
            CreateMap<SituacaoColetaInsumo, SituacaoColetaInsumoDto>().ReverseMap();
            CreateMap<InsumoEstruturado, InsumoEstruturadoDto>().ReverseMap();
            CreateMap<InsumoNaoEstruturado, InsumoNaoEstruturadoDto>().ReverseMap();
            CreateMap<InsumoPMO, InsumoPmoDto>().ReverseMap();
            CreateMap<ColetaInsumo, ColetaInsumoDto>().ReverseMap();
            CreateMap<CategoriaInsumo, CategoriaInsumoDto>().ReverseMap();

            //Interligacao
            CreateMap<AuxInterligacao, AuxInterligacaoDto>().ReverseMap();
            CreateMap<AuxInterligacaoMontador, AuxInterligacaoMontadorDto>().ReverseMap();
            CreateMap<AuxInterligacaoMontadorInterligacao, AuxInterligacaoMontadorInterligacaoDto>().ReverseMap();
            CreateMap<AuxInterligacaoMontadorUsina, AuxInterligacaoMontadorUsinaDto>().ReverseMap();

            //Limite
            CreateMap<LimitePeriodo, LimitePeriodoDto>().ReverseMap();
            CreateMap<LimitesIntercambio, LimitesIntercambioDto>().ReverseMap();
            CreateMap<LimitesPatamar, LimitesPatamarDto>().ReverseMap();
            CreateMap<ReducaoLimiteIntercambio, ReducaoLimiteIntercambioDto>().ReverseMap();
            CreateMap<Limite, LimiteDto>().ReverseMap();

            //Log 
            CreateMap<LogAuditoria, LogAuditoriaDto>().ReverseMap();
            CreateMap<LogDadosInformado, LogDadosInformadoDto>().ReverseMap();
            CreateMap<LogNotificacao, LogNotificacaoDto>().ReverseMap();

            //Manutenção
            CreateMap<ManutencaoProgramadum, ManutencaoProgramadumDto>().ReverseMap();
            CreateMap<ManutencaoPMO, ManutencaoPmoDto>().ReverseMap();
            CreateMap<ManutencaoProgramadaEstudo, ManutencaoProgramadaEstudoDto>().ReverseMap();
            CreateMap<ManutencaoPrograma, ManutencaoProgramadaDto>().ReverseMap();

            //Mnemonico
            CreateMap<MnemonicoBlocoAC, MnemonicoBlocoAcDto>().ReverseMap();
            CreateMap<MnemonicoEstudoMontador, MnemonicoEstudoMontadorDto>().ReverseMap();
            CreateMap<MnemonicoPMO, MnemonicoPmoDto>().ReverseMap();
            CreateMap<Arquivo, ArquivoDto>().ReverseMap();
            CreateMap<Mnemonico, MnemonicoDto>().ReverseMap();

            //Montador
            CreateMap<MneespEstudoMontador, MneespEstudoMontadorDto>().ReverseMap();
            CreateMap<OrigemColetaMontador, OrigemColetaMontadorDto>().ReverseMap();
            CreateMap<PeriodoMontador, PeriodoMontadorDto>().ReverseMap();

            //Restricao
            CreateMap<Restricao, RestricaoDto>().ReverseMap();
            CreateMap<RestricaoEletrica, RestricaoEletricaDto>().ReverseMap();
            CreateMap<RestricaoEstudo, RestricaoEstudoDto>().ReverseMap();
            CreateMap<Prestricao, PrestricaoDto>().ReverseMap();

            //Subsistema
            CreateMap<AuxSubsistemaContrato, AuxSubsistemaContratoDto>().ReverseMap();
            CreateMap<AuxSubsistema, AuxSubsistemaDto>().ReverseMap();
            CreateMap<AuxSubsistemaIntervaloCustoDeficit, AuxSubsistemaIntervaloCustoDeficitDto>().ReverseMap();
            CreateMap<AuxSubsistemaMontador, AuxSubsistemaMontadorDto>().ReverseMap();

            //Usina
            CreateMap<AuxPequenaUsina, AuxPequenaUsinaDto>().ReverseMap();
            CreateMap<AuxUsinaConjunto, AuxUsinaConjuntoDto>().ReverseMap();
            CreateMap<AuxUsina, AuxUsinaDto>().ReverseMap();
            CreateMap<AuxUsinaMnemonico, AuxUsinaMnemonicoDto>().ReverseMap();
            CreateMap<AuxUsinaMontador, AuxUsinaMontadorDto>().ReverseMap();

            //Outros
            CreateMap<Disponibilidade, DisponibilidadeDto>().ReverseMap();
            CreateMap<Agenteinstituicao, AgenteinstituicaoDto>().ReverseMap();
            CreateMap<ConfiguracaoCenarioPadrao, ConfiguracaoCenarioPadraoDto>().ReverseMap();
            CreateMap<ConfiguracaoGestaoManutencao, ConfiguracaoGestaoManutencaoDto>().ReverseMap();
            CreateMap<DecisaoComandoGNL, DecisaoComandoGNLDto>().ReverseMap();
            CreateMap<DemandaIntegral, DemandaIntegralDto>().ReverseMap();
            CreateMap<Desligamento, DesligamentoDto>().ReverseMap();
            CreateMap<FonteOrigem, FonteOrigemDto>().ReverseMap();
            CreateMap<Gabarito, GabaritoDto>().ReverseMap();
            CreateMap<IntervencaoSGI, IntervencaoSgiDto>().ReverseMap();
            CreateMap<ModConfigBlocoEstudo, ModifConfigBlocoEstudoDto>().ReverseMap();
            CreateMap<MotivoAlteracao, MotivoAlteracaoDto>().ReverseMap();
            CreateMap<OrdemExportacaoAgente, OrdemExportacaoAgenteDto>().ReverseMap();
            CreateMap<OrdenacaoRegistro, OrdenacaoRegistroDto>().ReverseMap();
            CreateMap<OrigemColetum, OrigemColetumDto>().ReverseMap();
            CreateMap<PerdaPotencium, PerdaPotenciumDto>().ReverseMap();
            CreateMap<Titulacao, TitulacaoDto>().ReverseMap();
            CreateMap<Coleta, ColetumDto>().ReverseMap();
            CreateMap<Estagio, EstagioDto>().ReverseMap();
            CreateMap<Patamar, Dto.TabelasDto.PatamarDto>().ReverseMap();

        }
    }
}
