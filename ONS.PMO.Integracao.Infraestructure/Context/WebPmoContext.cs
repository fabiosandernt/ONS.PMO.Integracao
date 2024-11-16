﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Application.Profile;
using ONS.PMO.Integracao.Domain.Entidades.BDT;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;
using ONS.PMO.Integracao.Infraestructure.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ONS.PMO.Integracao.Infraestructure.Context
{
    public class WebPmoContext : DbContext
    {
        public WebPmoContext()
        {
                
        }
        public WebPmoContext(DbContextOptions<WebPmoContext> options) : base(options)
        {            
        }
        public virtual DbSet<Agenteinstituicao> TbAgenteinstituicaos { get; set; }

        public virtual DbSet<Arquivo> TbArquivos { get; set; }

        public virtual DbSet<ArquivoExportacao> TbArquivoexportacaos { get; set; }

        public virtual DbSet<ArquivoFonteResultPMO> TbArquivofonteresultpmos { get; set; }

        public virtual DbSet<ArquivoSemanaOperativa> TbArquivosemanaoperativas { get; set; }

        public virtual DbSet<AuxConjMaquinaMontador> TbAuxConjmaqmontadors { get; set; }

        public virtual DbSet<AuxContrato> TbAuxContratos { get; set; }

        public virtual DbSet<AuxDesvioAgua> TbAuxDesvioaguas { get; set; }

        public virtual DbSet<AuxInterligacao> TbAuxInterligacaos { get; set; }

        public virtual DbSet<AuxInterligacaoMontador> TbAuxInterligacaomontadors { get; set; }

        public virtual DbSet<AuxInterligacaoMontadorInterligacao> TbAuxInterligacaomontadorinterligacaos { get; set; }

        public virtual DbSet<AuxInterligacaoMontadorUsina> TbAuxInterligacaomontadorusinas { get; set; }

        public virtual DbSet<AuxIntervaloCustoDeficit> TbAuxIntervalocustodeficits { get; set; }

        public virtual DbSet<AuxMnemonicoMontador> TbAuxMnemonicomontadors { get; set; }

        public virtual DbSet<AuxPequenaUsina> TbAuxPequenausinas { get; set; }

        public virtual DbSet<AuxReeMontador> TbAuxReemontadors { get; set; }

        public virtual DbSet<AuxReservatorio> TbAuxReservatorios { get; set; }

        public virtual DbSet<AuxSubmercado> TbAuxSubmercados { get; set; }

        public virtual DbSet<AuxSubsistema> TbAuxSubsistemas { get; set; }

        public virtual DbSet<AuxSubsistemaContrato> TbAuxSubsistemacontratos { get; set; }

        public virtual DbSet<AuxSubsistemaIntervaloCustoDeficit> TbAuxSubsistemaintervalocustodeficits { get; set; }

        public virtual DbSet<AuxSubsistemaMontador> TbAuxSubsistemamontadors { get; set; }

        public virtual DbSet<AuxUnidadeGeradora> TbAuxUnidadegeradoras { get; set; }

        public virtual DbSet<AuxUnidadeGeradoraMontador> TbAuxUnidadegeradoramontadors { get; set; }

        public virtual DbSet<AuxUsina> TbAuxUsinas { get; set; }

        public virtual DbSet<AuxUsinaConjunto> TbAuxUsinaconjuntos { get; set; }

        public virtual DbSet<AuxUsinaMnemonico> TbAuxUsinamnemonicos { get; set; }

        public virtual DbSet<AuxUsinaMontador> TbAuxUsinamontadors { get; set; }

        public virtual DbSet<Bloco> TbBlocos { get; set; }

        public virtual DbSet<BlocoEstudoMontador> TbBlocoestudomontadors { get; set; }

        public virtual DbSet<CampoChave> TbCampochaves { get; set; }

        public virtual DbSet<Coleta> TbCampochavetpcoleta { get; set; }

        public virtual DbSet<ChaveBloco> TbChaveblocos { get; set; }

        public virtual DbSet<ChaveBlocoEstudo> TbChaveblocoestudos { get; set; }

        public virtual DbSet<ChaveMnemonico> TbChavemnemonicos { get; set; }

        public virtual DbSet<ChaveMnemonicoEstudo> TbChavemnemonicoestudos { get; set; }

        public virtual DbSet<ColetaInsumo> TbColetainsumos { get; set; }

        public virtual DbSet<ColunaGrandeza> TbColunagrandezas { get; set; }

        public virtual DbSet<ConfiguracaoCenarioPadrao> TbConfiguracaocenariopadraos { get; set; }

        public virtual DbSet<ConfiguracaoGestaoManutencao> TbConfiguracaogestaomanutencaos { get; set; }

        public virtual DbSet<ConjuntoGeracaoMinima> TbConjuntogeracaominimas { get; set; }

        public virtual DbSet<DadoColetaEstruturado> TbDadocoletaestruturados { get; set; }

        public virtual DbSet<DadoColetaManutencao> TbDadocoletamanutencaos { get; set; }

        public virtual DbSet<DadoColetaNaoEstruturado> TbDadocoletanaoestruturados { get; set; }

        public virtual DbSet<DadoColeta> TbDadocoleta { get; set; }

        public virtual DbSet<DadoResultPMO> TbDadoresultpmos { get; set; }

        public virtual DbSet<DadosConvergencia> TbDadosconvergencia { get; set; }

        public virtual DbSet<DecisaoComandoGNL> TbDecisaocomandognls { get; set; }

        public virtual DbSet<DemandaIntegral> TbDemandaintegrals { get; set; }

        public virtual DbSet<Desligamento> TbDesligamentos { get; set; }

        public virtual DbSet<DiasSemana> TbDiasemanas { get; set; }

        public virtual DbSet<EstadoBlocoEstudoMontador> TbEstadoblocoestudomontadors { get; set; }

        public virtual DbSet<EstadoManutencaoPMO> TbEstadomanutencaopmos { get; set; }

        public virtual DbSet<EstadoMnemonicoEstudoMontador> TbEstadomnemonicoestudomontadors { get; set; }

        public virtual DbSet<EstadoRestricaoEstudoMontador> TbEstadorestricaoestudomontadors { get; set; }

        public virtual DbSet<EstagioGrandeza> TbEstagiograndezas { get; set; }

        public virtual DbSet<EstagioGrandezaMnemonico> TbEstagiograndezamnemonicos { get; set; }

        public virtual DbSet<EstudoMontador> TbEstudomontadors { get; set; }

        public virtual DbSet<EstudoMontadorNaoOficial> TbEstudomontadornaooficials { get; set; }

        public virtual DbSet<EstudoSelecionado> TbEstudoselecionados { get; set; }

        public virtual DbSet<ExportacaoArquivoTexto> TbExportacaoarquivotextos { get; set; }

        public virtual DbSet<FonteOrigem> TbFonteorigems { get; set; }

        public virtual DbSet<Gabarito> TbGabaritos { get; set; }

        public virtual DbSet<GeracaoMinimaPeriodo> TbGeracaominimaperiododia { get; set; }

        public virtual DbSet<GeracaoPequenasUsina> TbGeracaopequenasusinas { get; set; }

        public virtual DbSet<GeracaoTermica> TbGeracaotermicas { get; set; }

        public virtual DbSet<Grandeza> TbGrandezas { get; set; }

        public virtual DbSet<GrandezaBloco> TbGrandezablocos { get; set; }

        public virtual DbSet<GrandezaBlocoAC> TbGrandezablocoacs { get; set; }

        public virtual DbSet<GrandezaBlocoEstudo> TbGrandezablocoestudos { get; set; }

        public virtual DbSet<GrandezaMnemonicoEstudo> TbGrandezamnemonicoestudos { get; set; }

        public virtual DbSet<GrandezaMontador> TbGrandezamontadors { get; set; }

        public virtual DbSet<HistoricoConfiguracaoBloco> TbHisconfigblocos { get; set; }

        public virtual DbSet<HistoricoConfiguracaoGrandeza> TbHisconfiggrandezas { get; set; }

        public virtual DbSet<HistoricoColetaInsumo> TbHistmodifcoletainsumos { get; set; }

        public virtual DbSet<HistoricoSemanaOperativa> TbHistmodifsemanaopers { get; set; }

        public virtual DbSet<ImportacaoPMO> TbImportacaopmos { get; set; }

        public virtual DbSet<InsumoEstruturado> TbInsumoestruturados { get; set; }

        public virtual DbSet<InsumoNaoEstruturado> TbInsumonaoestruturados { get; set; }

        public virtual DbSet<InsumoPMO> TbInsumopmos { get; set; }

        public virtual DbSet<IntervencaoSGI> TbIntervencaosgis { get; set; }

        public virtual DbSet<LimitePeriodo> TbLimiteperiododia { get; set; }

        public virtual DbSet<LimitesIntercambio> TbLimitesintercambios { get; set; }

        public virtual DbSet<LimitesPatamar> TbLimitespatamars { get; set; }

        public virtual DbSet<ListaResultadoPMO> TbListaresultadopmos { get; set; }

        public virtual DbSet<LogAuditoria> TbLogauditoria { get; set; }

        public virtual DbSet<LogDadosInformado> TbLogdadosinformados { get; set; }

        public virtual DbSet<LogNotificacao> TbLognotificacaos { get; set; }

        public virtual DbSet<ManutencaoPMO> TbManutencaopmos { get; set; }

        public virtual DbSet<ManutencaoProgramadaEstudo> TbManutencaoprogramadaestudos { get; set; }

        public virtual DbSet<ManutencaoPrograma> TbManutencaoprogramada { get; set; }

        public virtual DbSet<MneespEstudoMontador> TbMneespestudomontadors { get; set; }

        public virtual DbSet<MnemonicoBlocoAC> TbMnemonicoblocoacs { get; set; }

        public virtual DbSet<MnemonicoEstudoMontador> TbMnemonicoestudomontadors { get; set; }

        public virtual DbSet<MnemonicoPMO> TbMnemonicopmos { get; set; }

        public virtual DbSet<ModConfigBlocoEstudo> TbModifconfigblocoestudos { get; set; }

        public virtual DbSet<MotivoAlteracao> TbMotivoalteracaos { get; set; }

        public virtual DbSet<OrdemExportacaoAgente> TbOrdemexportacaoagentes { get; set; }

        public virtual DbSet<OrdenacaoRegistro> TbOrdenacaoregistros { get; set; }

        public virtual DbSet<OrigemColetaMontador> TbOrigemcoletamontadors { get; set; }

        public virtual DbSet<OrigemColetum> TbOrigemcoleta { get; set; }

        public virtual DbSet<OrigemResultadoPMO> TbOrigemresultadopmos { get; set; }

        public virtual DbSet<ParametroPMO> TbParametropmos { get; set; }

        public virtual DbSet<PerdaPotencium> TbPerdapotencia { get; set; }

        public virtual DbSet<Pmo> TbPmos { get; set; }

        public virtual DbSet<RecuperacaoDado> TbRecuperacaodados { get; set; }

        public virtual DbSet<RecuperacaoDadosAgentePMO> TbRecuperacaodadosagentepmos { get; set; }

        public virtual DbSet<RecuperacaoDadosBloco> TbRecuperacaodadosblocos { get; set; }

        public virtual DbSet<ReducaoLimiteIntercambio> TbReducaolimiteintercambios { get; set; }

        public virtual DbSet<Restricao> TbRestricaos { get; set; }

        public virtual DbSet<RestricaoEletrica> TbRestricaoeletricas { get; set; }

        public virtual DbSet<RestricaoEstudo> TbRestricaoestudos { get; set; }

        public virtual DbSet<ResultadoColetaPMO> TbResultadocoletapmos { get; set; }

        public virtual DbSet<SemanaOperativa> TbSemanaoperativas { get; set; }

        public virtual DbSet<Titulacao> TbTitulacaos { get; set; }

        public virtual DbSet<CategoriaInsumo> TbTpcategoriainsumos { get; set; }

        public virtual DbSet<Coleta> TbTpcoleta { get; set; }

        public virtual DbSet<DadoGrandeza> TbTpdadograndezas { get; set; }

        public virtual DbSet<Estagio> TbTpestagios { get; set; }

        public virtual DbSet<TipoImportacaoPMO> TbTpimportacaopmos { get; set; }

        public virtual DbSet<Limite> TbTplimites { get; set; }

        public virtual DbSet<ManutencaoProgramadum> TbTpmanutencaoprogramada { get; set; }

        public virtual DbSet<Mnemonico> TbTpmnemonicos { get; set; }

        public virtual DbSet<Patamar> TbTppatamars { get; set; }

        public virtual DbSet<PeriodoMontador> TbTpperiodomontadors { get; set; }

        public virtual DbSet<Prestricao> TbTprestricaos { get; set; }

        public virtual DbSet<SituacaoColetaInsumo> TbTpsituacaocoletainsumos { get; set; }

        public virtual DbSet<SituacaoSemanaOperacao> TbTpsituacaosemanaopers { get; set; }  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.HasDefaultSchema("dbo");
        //    modelBuilder.ApplyConfigurationsFromAssembly(typeof(WebPmoContext).Assembly);
        //    base.OnModelCreating(modelBuilder);
        //}
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.UseCollation("Latin1_General_CI_AI");
            modelBuilder.ApplyConfiguration(new AgenteinstituicaoMapping());
            modelBuilder.ApplyConfiguration(new ArquivoMapping());
            modelBuilder.ApplyConfiguration(new ArquivoExportacaoMapping());
            modelBuilder.ApplyConfiguration(new ArquivoFonteResultPMOMapping());
            modelBuilder.ApplyConfiguration(new ArquivoSemanaOperativaMapping());
            modelBuilder.ApplyConfiguration(new AuxConjMaquinaMontadorMapping());
            modelBuilder.ApplyConfiguration(new AuxContratoMapping());
            modelBuilder.ApplyConfiguration(new AuxDesvioAguaMapping());
            modelBuilder.ApplyConfiguration(new AuxInterligacaoMapping());
            modelBuilder.ApplyConfiguration(new AuxInterligacaoMontadorMapping());
            modelBuilder.ApplyConfiguration(new AuxInterligacaoMontadorInterligacaoMapping());
            modelBuilder.ApplyConfiguration(new AuxInterligacaoMontadorUsinaMapping());
            modelBuilder.ApplyConfiguration(new AuxIntervaloCustoDeficitMapping());
            modelBuilder.ApplyConfiguration(new AuxMnemonicoMontadorMapping());
            modelBuilder.ApplyConfiguration(new AuxPequenaUsinaMapping());
            modelBuilder.ApplyConfiguration(new AuxReeMontadorMapping());
            modelBuilder.ApplyConfiguration(new AuxReservatorioMapping());
            modelBuilder.ApplyConfiguration(new AuxSubmercadoMapping());
            modelBuilder.ApplyConfiguration(new AuxSubsistemaContratoMapping());
            modelBuilder.ApplyConfiguration(new AuxSubsistemaIntervaloCustoDeficitMapping());
            modelBuilder.ApplyConfiguration(new AuxSubsistemaMapping());
            modelBuilder.ApplyConfiguration(new AuxSubsistemaMontadorMapping());
            modelBuilder.ApplyConfiguration(new AuxUnidadeGeradoraMapping());
            modelBuilder.ApplyConfiguration(new AuxUnidadeGeradoraMontadorMapping());
            modelBuilder.ApplyConfiguration(new AuxUsinaConjuntoMapping());
            modelBuilder.ApplyConfiguration(new AuxUsinaMapping());
            modelBuilder.ApplyConfiguration(new AuxUsinaMnemonicoMapping());
            modelBuilder.ApplyConfiguration(new AuxUsinaMontadorMapping());
            modelBuilder.ApplyConfiguration(new BlocoEstudoMontadorMapping());
            modelBuilder.ApplyConfiguration(new BlocoMapping());
            modelBuilder.ApplyConfiguration(new CampoChaveColetaMapping());
            modelBuilder.ApplyConfiguration(new CampoChaveMapping());
            modelBuilder.ApplyConfiguration(new CategoriaInsumoMapping());
            modelBuilder.ApplyConfiguration(new ChaveBlocoEstudoMapping());
            modelBuilder.ApplyConfiguration(new ChaveBlocoMapping());
            modelBuilder.ApplyConfiguration(new ChaveMnemonicoEstudoMapping());
            modelBuilder.ApplyConfiguration(new ChaveMnemonicoMapping());
            modelBuilder.ApplyConfiguration(new ColetaInsumoMapping());
            modelBuilder.ApplyConfiguration(new ColetaMapping());
            modelBuilder.ApplyConfiguration(new ColunaGrandezaMapping());
            modelBuilder.ApplyConfiguration(new ConfiguracaoCenarioPadraoMapping());
            modelBuilder.ApplyConfiguration(new ConfiguracaoGestaoManutencaoMapping());
            modelBuilder.ApplyConfiguration(new ConjuntoGeracaoMinimaMapping());
            modelBuilder.ApplyConfiguration(new DadoColetaEstruturadoMapping());
            modelBuilder.ApplyConfiguration(new DadoColetaManutencaoMapping());
            modelBuilder.ApplyConfiguration(new DadoColetaNaoEstruturadoMapping());
            modelBuilder.ApplyConfiguration(new DadoColetumMapping());
            modelBuilder.ApplyConfiguration(new DadoGrandezaMapping());
            modelBuilder.ApplyConfiguration(new DadoResultPMOMapping());
            modelBuilder.ApplyConfiguration(new DadosConvergenciumMapping());
            modelBuilder.ApplyConfiguration(new DecisaoComandoGNLMapping());
            modelBuilder.ApplyConfiguration(new DemandaIntegralMapping());
            modelBuilder.ApplyConfiguration(new DesligamentoMapping());
            modelBuilder.ApplyConfiguration(new DiasSemanaMapping());
            modelBuilder.ApplyConfiguration(new EstadoBlocoEstudoMontadorMapping());
            modelBuilder.ApplyConfiguration(new EstadoManutencaoPMOMapping());
            modelBuilder.ApplyConfiguration(new EstadoMnemonicoEstudoMontadorMapping());
            modelBuilder.ApplyConfiguration(new EstadoRestricaoEstudoMontadorMapping());
            modelBuilder.ApplyConfiguration(new EstagioGrandezaMapping());
            modelBuilder.ApplyConfiguration(new EstagioGrandezaMnemonicoMapping());
            modelBuilder.ApplyConfiguration(new EstagioMapping());
            modelBuilder.ApplyConfiguration(new EstudoMontadorMapping());
            modelBuilder.ApplyConfiguration(new EstudoMontadorNaoOficialMapping());
            modelBuilder.ApplyConfiguration(new EstudoSelecionadoMapping());
            modelBuilder.ApplyConfiguration(new ExportacaoArquivoTextoMapping());
            modelBuilder.ApplyConfiguration(new FonteOrigemMapping());
            modelBuilder.ApplyConfiguration(new GabaritoMapping());
            modelBuilder.ApplyConfiguration(new GeracaoMinimaPeriodoMapping());
            modelBuilder.ApplyConfiguration(new GeracaoPequenasUsinaMapping());
            modelBuilder.ApplyConfiguration(new GeracaoTermicaMapping());
            modelBuilder.ApplyConfiguration(new GrandezaBlocoACMapping());
            modelBuilder.ApplyConfiguration(new GrandezaBlocoEstudoMapping());
            modelBuilder.ApplyConfiguration(new GrandezaBlocoMapping());
            modelBuilder.ApplyConfiguration(new GrandezaMapping());
            modelBuilder.ApplyConfiguration(new GrandezaMnemonicoEstudoMapping());
            modelBuilder.ApplyConfiguration(new GrandezaMontadorMapping());
            modelBuilder.ApplyConfiguration(new HisConfigBlocoMapping());
            modelBuilder.ApplyConfiguration(new HisConfigGrandezaMapping());
            modelBuilder.ApplyConfiguration(new HisModColetaInsumoMapping());
            modelBuilder.ApplyConfiguration(new HisModSemanaOperMapping());
            modelBuilder.ApplyConfiguration(new ImportacaoPMOMapping());
            modelBuilder.ApplyConfiguration(new InsumoEstruturadoMapping());
            modelBuilder.ApplyConfiguration(new InsumoNaoEstruturadoMapping());
            modelBuilder.ApplyConfiguration(new InsumoPMOMapping());
            modelBuilder.ApplyConfiguration(new IntervencaoSGIMapping());
            modelBuilder.ApplyConfiguration(new LimiteMapping());
            modelBuilder.ApplyConfiguration(new LimitePeriodoMapping());
            modelBuilder.ApplyConfiguration(new LimitesIntercambioMapping());
            modelBuilder.ApplyConfiguration(new LimitesPatamarMapping());
            modelBuilder.ApplyConfiguration(new ListaResultadoPMOMapping());
            modelBuilder.ApplyConfiguration(new LogAuditoriaMapping());
            modelBuilder.ApplyConfiguration(new LogDadosInformadoMapping());
            modelBuilder.ApplyConfiguration(new LogNotificacaoMapping());
            modelBuilder.ApplyConfiguration(new ManutencaoPMOMapping());
            modelBuilder.ApplyConfiguration(new ManutencaoProgramadaEstudoMapping());
            modelBuilder.ApplyConfiguration(new ManutencaoProgramadumMapping());
            modelBuilder.ApplyConfiguration(new ManutencaoProgramaMapping());
            modelBuilder.ApplyConfiguration(new MneespEstudoMontadorMapping());
            modelBuilder.ApplyConfiguration(new MnemonicoBlocoACMapping());
            modelBuilder.ApplyConfiguration(new MnemonicoEstudoMontadorMapping());
            modelBuilder.ApplyConfiguration(new MnemonicoMapping());
            modelBuilder.ApplyConfiguration(new MnemonicoPMOMapping());
            modelBuilder.ApplyConfiguration(new ModConfigBlocoEstudoMapping());
            modelBuilder.ApplyConfiguration(new MotivoAlteracaoMapping());
            modelBuilder.ApplyConfiguration(new OrdemExportacaoAgenteMapping());
            modelBuilder.ApplyConfiguration(new OrdenacaoRegistroMapping());
            modelBuilder.ApplyConfiguration(new OrigemColetaMontadorMapping());
            modelBuilder.ApplyConfiguration(new OrigemColetumMapping());
            modelBuilder.ApplyConfiguration(new OrigemResultadoPMOMapping());
            modelBuilder.ApplyConfiguration(new ParametroPMOMapping());
            modelBuilder.ApplyConfiguration(new PatamarMapping());
            modelBuilder.ApplyConfiguration(new PerdaPotenciumMapping());
            modelBuilder.ApplyConfiguration(new PeriodoMontadorMapping());
            modelBuilder.ApplyConfiguration(new PmoMapping());
            modelBuilder.ApplyConfiguration(new PrestricaoMapping());
            modelBuilder.ApplyConfiguration(new RecuperacaoDadoMapping());
            modelBuilder.ApplyConfiguration(new RecuperacaoDadosAgentePMOMapping());
            modelBuilder.ApplyConfiguration(new RecuperacaoDadosBlocoMapping());
            modelBuilder.ApplyConfiguration(new ReducaoLimiteIntercambioMapping());
            modelBuilder.ApplyConfiguration(new RestricaoEletricaMapping());
            modelBuilder.ApplyConfiguration(new RestricaoEstudoMapping());
            modelBuilder.ApplyConfiguration(new RestricaoMapping());
            modelBuilder.ApplyConfiguration(new ResultadoColetaPMOMapping());
            modelBuilder.ApplyConfiguration(new SemanaOperativaMapping());
            modelBuilder.ApplyConfiguration(new SituacaoColetaInsumoMapping());
            modelBuilder.ApplyConfiguration(new SituacaoSemanaOperacaoMapping());
            modelBuilder.ApplyConfiguration(new TitulacaoMapping());
            modelBuilder.ApplyConfiguration(new TipoImportacaoPMOMapping());

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(WebPmoContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

    }
}
