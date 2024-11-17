using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.Auxiliar;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

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
        public virtual DbSet<AgenteInstituicao> AgenteInstituicoes { get; set; }

        public virtual DbSet<Arquivo> Arquivos { get; set; }

        public virtual DbSet<ArquivoExportacao> TbArquivoexportacaos { get; set; }

        public virtual DbSet<ArquivoFonteResultadoPmo> TbArquivofonteresultpmos { get; set; }

        public virtual DbSet<ArquivoSemanaOperativa> ArquivoSemanaOperativas { get; set; }

        public virtual DbSet<TbAuxConjmaqmontador> TbAuxConjmaqmontadors { get; set; }

        public virtual DbSet<TbAuxContrato> TbAuxContratos { get; set; }

        public virtual DbSet<TbAuxDesvioagua> TbAuxDesvioaguas { get; set; }

        public virtual DbSet<TbAuxInterligacao> TbAuxInterligacaos { get; set; }

        public virtual DbSet<TbAuxInterligacaomontador> TbAuxInterligacaomontadors { get; set; }

        public virtual DbSet<TbAuxInterligacaomontadorinterligacao> TbAuxInterligacaomontadorinterligacaos { get; set; }

        public virtual DbSet<TbAuxInterligacaomontadorusina> TbAuxInterligacaomontadorusinas { get; set; }

        public virtual DbSet<TbAuxIntervalocustodeficit> TbAuxIntervalocustodeficits { get; set; }

        public virtual DbSet<TbAuxMnemonicomontador> TbAuxMnemonicomontadors { get; set; }

        public virtual DbSet<TbAuxPequenausina> TbAuxPequenausinas { get; set; }

        public virtual DbSet<TbAuxReemontador> TbAuxReemontadors { get; set; }

        public virtual DbSet<TbAuxReservatorio> TbAuxReservatorios { get; set; }

        public virtual DbSet<TbAuxSubmercado> TbAuxSubmercados { get; set; }

        public virtual DbSet<TbAuxSubsistema> TbAuxSubsistemas { get; set; }

        public virtual DbSet<TbAuxSubsistemacontrato> TbAuxSubsistemacontratos { get; set; }

        public virtual DbSet<TbAuxSubsistemaintervalocustodeficit> TbAuxSubsistemaintervalocustodeficits { get; set; }

        public virtual DbSet<TbAuxSubsistemamontador> TbAuxSubsistemamontadors { get; set; }

        public virtual DbSet<TbAuxUnidadegeradora> TbAuxUnidadegeradoras { get; set; }

        public virtual DbSet<TbAuxUnidadegeradoramontador> TbAuxUnidadegeradoramontadors { get; set; }

        public virtual DbSet<TbAuxUsina> TbAuxUsinas { get; set; }

        public virtual DbSet<TbAuxUsinaconjunto> TbAuxUsinaconjuntos { get; set; }

        public virtual DbSet<TbAuxUsinamnemonico> TbAuxUsinamnemonicos { get; set; }

        public virtual DbSet<TbAuxUsinamontador> TbAuxUsinamontadors { get; set; }

        public virtual DbSet<Bloco> TbBlocos { get; set; }

        public virtual DbSet<BlocoEstudoMontador> TbBlocoestudomontadors { get; set; }

        public virtual DbSet<CampoChave> TbCampochaves { get; set; }

        public virtual DbSet<CampoChaveTipoColeta> TbCampochavetpcoleta { get; set; }

        public virtual DbSet<ChaveBloco> TbChaveblocos { get; set; }

        public virtual DbSet<ChaveBlocoEstudo> TbChaveblocoestudos { get; set; }

        public virtual DbSet<ChaveMnemonico> TbChavemnemonicos { get; set; }

        public virtual DbSet<ChaveMnemonicoEstudo> TbChavemnemonicoestudos { get; set; }

        public virtual DbSet<ColetaInsumo> TbColetainsumos { get; set; }

        public virtual DbSet<ColunaGrandeza> TbColunagrandezas { get; set; }

        public virtual DbSet<ConfiguracaoCenarioPadrao> TbConfiguracaocenariopadraos { get; set; }

        public virtual DbSet<ConfiguracaoGestaoManutencao> TbConfiguracaogestaomanutencaos { get; set; }

        public virtual DbSet<ConjuntoGeracaoMinima> TbConjuntogeracaominimas { get; set; }

        public virtual DbSet<DadoColetaEstruturado> DadoColetaEstruturados { get; set; }

        public virtual DbSet<DadoColetaManutencao> DadoColetaManutencaos { get; set; }

        public virtual DbSet<DadoColetaNaoEstruturado> DadoColetaNaoEstruturados { get; set; }

        public virtual DbSet<DadoColeta> DadoColetas { get; set; }

        public virtual DbSet<DadoResultadoPMO> DadoResultadoPMOs { get; set; }

        public virtual DbSet<DadosConvergencia> DadosConvergencias { get; set; }

        public virtual DbSet<DecisaoComandoGNL> TbDecisaocomandognls { get; set; }

        public virtual DbSet<DemandaIntegral> TbDemandaintegrals { get; set; }

        public virtual DbSet<Desligamento> TbDesligamentos { get; set; }

        public virtual DbSet<DiaSemana> TbDiasemanas { get; set; }

        public virtual DbSet<EstadoBlocoEstudoMontador> TbEstadoblocoestudomontadors { get; set; }

        public virtual DbSet<EstadoManutencaoPmo> TbEstadomanutencaopmos { get; set; }

        public virtual DbSet<EstadoMnemonicoEstudoMontador> TbEstadomnemonicoestudomontadors { get; set; }

        public virtual DbSet<EstadoRestricaoEstudoMontador> TbEstadorestricaoestudomontadors { get; set; }

        public virtual DbSet<EstagioGrandeza> TbEstagiograndezas { get; set; }

        public virtual DbSet<EstagioGrandezaMnemonico> TbEstagiograndezamnemonicos { get; set; }

        public virtual DbSet<EstudoMontador> TbEstudomontadors { get; set; }

        public virtual DbSet<EstudoMontadorNaoOficial> TbEstudomontadornaooficials { get; set; }

        public virtual DbSet<EstudoSelecionado> TbEstudoselecionados { get; set; }

        public virtual DbSet<ExportacaoArquivoTexto> TbExportacaoarquivotextos { get; set; }

        public virtual DbSet<FonteOrigem> TbFonteorigems { get; set; }

        public virtual DbSet<Gabarito> Gabaritos { get; set; }

        public virtual DbSet<GeracaoMinimaPeriodoDia> TbGeracaominimaperiododia { get; set; }

        public virtual DbSet<GeracaoPequenasUsina> TbGeracaopequenasusinas { get; set; }

        public virtual DbSet<GeracaoTermica> TbGeracaotermicas { get; set; }

        public virtual DbSet<Grandeza> Grandezas { get; set; }

        public virtual DbSet<GrandezaBloco> TbGrandezablocos { get; set; }

        public virtual DbSet<GrandezaBlocoAC> TbGrandezablocoacs { get; set; }

        public virtual DbSet<GrandezaBlocoEstudo> TbGrandezablocoestudos { get; set; }

        public virtual DbSet<GrandezaMnemonicoEstudo> TbGrandezamnemonicoestudos { get; set; }

        public virtual DbSet<GrandezaMontador> TbGrandezamontadors { get; set; }

        public virtual DbSet<HistoricoConfiguracaoBloco> TbHisconfigblocos { get; set; }

        public virtual DbSet<HistoricoConfiguracaoGrandeza> TbHisconfiggrandezas { get; set; }

        public virtual DbSet<HistoricoModificacaoColetaInsumo> HistoricoModificacaoColetaInsumos { get; set; }

        public virtual DbSet<HistoricoModificacaoSemanaOperativa> HistoricoModificacaoSemanaOperativas { get; set; }

        public virtual DbSet<ImportacaoPmo> TbImportacaopmos { get; set; }

        public virtual DbSet<InsumoEstruturado> InsumoEstruturados { get; set; }

        public virtual DbSet<InsumoNaoEstruturado> InsumoNaoEstruturados { get; set; }

        public virtual DbSet<InsumoPMO> InsumoPMOs { get; set; }

        public virtual DbSet<IntervencaoSGI> TbIntervencaosgis { get; set; }

        public virtual DbSet<LimitePeriodoDia> TbLimiteperiododia { get; set; }

        public virtual DbSet<LimitesIntercambio> TbLimitesintercambios { get; set; }

        public virtual DbSet<LimitesPatamar> TbLimitespatamars { get; set; }

        public virtual DbSet<ListaResultadoPmo> TbListaresultadopmos { get; set; }

        public virtual DbSet<LogAuditoria> LogAuditorias { get; set; }

        public virtual DbSet<LogDadosInformado> LogDadosInformados { get; set; }

        public virtual DbSet<LogNotificacao> LogNotificacoes { get; set; }

        public virtual DbSet<ManutencaoPmo> TbManutencaopmos { get; set; }

        public virtual DbSet<ManutencaoProgramadaEstudo> TbManutencaoprogramadaestudos { get; set; }

        public virtual DbSet<ManutencaoProgramada> TbManutencaoprogramada { get; set; }

        public virtual DbSet<MneespEstudoMontador> TbMneespestudomontadors { get; set; }

        public virtual DbSet<MnemonicoBlocoAC> TbMnemonicoblocoacs { get; set; }

        public virtual DbSet<MnemonicoEstudoMontador> TbMnemonicoestudomontadors { get; set; }

        public virtual DbSet<MnemonicoPmo> TbMnemonicopmos { get; set; }

        public virtual DbSet<ModificacaoConfiguracaoBlocoEstudo> TbModifconfigblocoestudos { get; set; }

        public virtual DbSet<MotivoAlteracao> TbMotivoalteracaos { get; set; }

        public virtual DbSet<OrdemExportacaoAgente> TbOrdemexportacaoagentes { get; set; }

        public virtual DbSet<OrdenacaoRegistro> TbOrdenacaoregistros { get; set; }

        public virtual DbSet<OrigemColetaMontador> TbOrigemcoletamontadors { get; set; }

        public virtual DbSet<OrigemColetum> TbOrigemcoleta { get; set; }

        public virtual DbSet<OrigemResultadoPmo> TbOrigemresultadopmos { get; set; }

        public virtual DbSet<ParametroPMO> ParametroPMOs { get; set; }

        public virtual DbSet<PerdaPotencia> TbPerdapotencia { get; set; }

        public virtual DbSet<Pmo> Pmos { get; set; }

        public virtual DbSet<RecuperacaoDado> TbRecuperacaodados { get; set; }

        public virtual DbSet<RecuperacaoDadosAgentePmo> TbRecuperacaodadosagentepmos { get; set; }

        public virtual DbSet<RecuperacaoDadosBloco> TbRecuperacaodadosblocos { get; set; }

        public virtual DbSet<ReducaoLimiteIntercambio> TbReducaolimiteintercambios { get; set; }

        public virtual DbSet<Restricao> TbRestricaos { get; set; }

        public virtual DbSet<RestricaoEletrica> TbRestricaoeletricas { get; set; }

        public virtual DbSet<RestricaoEstudo> TbRestricaoestudos { get; set; }

        public virtual DbSet<ResultadoColetaPmo> TbResultadocoletapmos { get; set; }

        public virtual DbSet<SemanaOperativa> SemanaOperativas { get; set; }

        public virtual DbSet<Titulacao> TbTitulacaos { get; set; }

        public virtual DbSet<CategoriaInsumo> CategoriaInsumos { get; set; }

        public virtual DbSet<Coleta> Coletas { get; set; }

        public virtual DbSet<DadoGrandeza> TbTpdadograndezas { get; set; }

        public virtual DbSet<Estagio> TbTpestagios { get; set; }

        public virtual DbSet<TipoImportacaoPmo> TbTpimportacaopmos { get; set; }

        public virtual DbSet<Limite> Limites { get; set; }

        public virtual DbSet<TipoManutencaoProgramada> TbTpmanutencaoprogramada { get; set; }

        public virtual DbSet<TipoMnemonico> TbTpmnemonicos { get; set; }

        public virtual DbSet<Patamar> Patamares { get; set; }

        public virtual DbSet<TipoPeriodoMontador> TbTpperiodomontadors { get; set; }

        public virtual DbSet<TipoRestricao> TbTprestricaos { get; set; }

        public virtual DbSet<SituacaoColetaInsumo> SituacaoColetaIsumos { get; set; }

        public virtual DbSet<SituacaoSemanaOperativa> SituacaoSemanaOperativas { get; set; }  

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();
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

            modelBuilder.Entity<AgenteInstituicao>(entity =>
            {
                entity.HasKey(e => e.IdAgenteInstituicao)
                    .HasName("pk_tb_agenteinstituicao")
                    .IsClustered(false);

                entity.ToTable("tb_agenteinstituicao");

                entity.Property(e => e.IdAgenteInstituicao)
                    .ValueGeneratedNever()
                    .HasColumnName("id_agenteinstituicao");
                entity.Property(e => e.DscApelidorazaosocial)
                    .HasMaxLength(50)
                    .HasColumnName("dsc_apelidorazaosocial");
                entity.Property(e => e.DscRazaosocial)
                    .HasMaxLength(100)
                    .HasColumnName("dsc_razaosocial");
            });

            modelBuilder.Entity<Arquivo>(entity =>
            {
                entity.HasKey(e => e.IdArquivo).HasName("pk_tb_arquivo");

                entity.ToTable("tb_arquivo", tb => tb.HasComment("Tem o propósito geral de armazena dados sobre um arquivo, que poderá ser referenciado por outras dados do sistema."));

                entity.HasIndex(e => e.IdArquivo, "in_pk_tb_arquivo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdArquivo)
                    .ValueGeneratedNever()
                    .HasComment("Identificador dos arquivos que contém insumos para o sistema")
                    .HasColumnName("id_arquivo");
                entity.Property(e => e.ArqConteudo)
                    .HasComment("Conteúdo do arquivo")
                    .HasColumnName("arq_conteudo");
                entity.Property(e => e.CodHashverificacao)
                    .HasMaxLength(100)
                    .HasComment("Código Hash de verificação do arquivo (uso interno) para garantir a consistencia do arquivo")
                    .HasColumnName("cod_hashverificacao");
                entity.Property(e => e.DscMimearquivo)
                    .HasMaxLength(100)
                    .HasComment("Tipo do arquivo (MimeType), segundo a nomenclatura padrão da IANA")
                    .HasColumnName("dsc_mimearquivo");
                entity.Property(e => e.FlgExcluido)
                    .HasDefaultValue(false)
                    .HasComment("Indica se o arquivo foi excluído logicamente")
                    .HasColumnName("flg_excluido");
                entity.Property(e => e.NomArquivo)
                    .HasMaxLength(255)
                    .HasComment("Nome do Arquivo com Extensão")
                    .HasColumnName("nom_arquivo");
                entity.Property(e => e.NumTamanhoarquivo)
                    .HasComment("Tamanho em bytes do arquivo")
                    .HasColumnName("num_tamanhoarquivo");
            });

            modelBuilder.Entity<ArquivoExportacao>(entity =>
            {
                entity.HasKey(e => e.IdArquivoexportacao).HasName("pk_tb_arquivoexportacao");

                entity.ToTable("tb_arquivoexportacao");

                entity.Property(e => e.IdArquivoexportacao)
                    .ValueGeneratedNever()
                    .HasColumnName("id_arquivoexportacao");
                entity.Property(e => e.DscArquivoexportacao)
                    .HasMaxLength(20)
                    .HasColumnName("dsc_arquivoexportacao");
                entity.Property(e => e.NomArquivoexportacao)
                    .HasMaxLength(20)
                    .HasColumnName("nom_arquivoexportacao");
            });

            modelBuilder.Entity<ArquivoFonteResultadoPmo>(entity =>
            {
                entity.HasKey(e => e.IdArquivofonteresultpmo).HasName("pk_tb_arquivofonteresultpmo");

                entity.ToTable("tb_arquivofonteresultpmo");

                entity.Property(e => e.IdArquivofonteresultpmo)
                    .ValueGeneratedNever()
                    .HasColumnName("id_arquivofonteresultpmo");
                entity.Property(e => e.NomArquivofonteresultpmo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nom_arquivofonteresultpmo");
            });

            modelBuilder.Entity<ArquivoSemanaOperativa>(entity =>
            {
                entity.HasKey(e => e.IdArquivosemanaoperativa).HasName("pk_tb_arquivosemanaoperativa");

                entity.ToTable("tb_arquivosemanaoperativa", tb => tb.HasComment("Associação de arquivos encaminhados por semana operativa "));

                entity.HasIndex(e => e.IdArquivo, "in_fk_arquivo_arquivosemanaoperativa").HasFillFactor(90);

                entity.HasIndex(e => e.IdSemanaoperativa, "in_fk_semanaoperativa_arquivosemanaoperativa").HasFillFactor(90);

                entity.HasIndex(e => e.IdTpsituacaosemanaoper, "in_fk_tpsituacaosemanaoper_arquivosemanaoperativa").HasFillFactor(90);

                entity.HasIndex(e => e.IdArquivosemanaoperativa, "in_pk_tb_arquivosemanaoperativa")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdArquivosemanaoperativa)
                    .HasComment("Identificador do arquivo da semana operativa")
                    .HasColumnName("id_arquivosemanaoperativa");
                entity.Property(e => e.FlgPublicado)
                    .HasComment("Indica se o arquivo associado a semana operativa foi publicado")
                    .HasColumnName("flg_publicado");
                entity.Property(e => e.IdArquivo)
                    .HasComment("Identificador dos arquivos que contém insumos para o sistema")
                    .HasColumnName("id_arquivo");
                entity.Property(e => e.IdSemanaoperativa)
                    .HasComment("Identificadorda semana operativa do programa mensal de operação - PMO")
                    .HasColumnName("id_semanaoperativa");
                entity.Property(e => e.IdTpsituacaosemanaoper)
                    .HasComment("Identificador da situação da semana operativado. Possíveis valores: Configuração, Coleta de dados, Geração de blocos, Convergência CCEE e Publicado")
                    .HasColumnName("id_tpsituacaosemanaoper");

                entity.HasOne(d => d.IdArquivoNavigation).WithMany(p => p.TbArquivosemanaoperativas)
                    .HasForeignKey(d => d.IdArquivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_arquivo_arquivosemanaoperativa");

                entity.HasOne(d => d.IdSemanaoperativaNavigation).WithMany(p => p.TbArquivosemanaoperativas)
                    .HasForeignKey(d => d.IdSemanaoperativa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_semanaoperativa_arquivosemanaoperativa");

                entity.HasOne(d => d.IdTpsituacaosemanaoperNavigation).WithMany(p => p.TbArquivosemanaoperativas)
                    .HasForeignKey(d => d.IdTpsituacaosemanaoper)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tpsituacaosemanaoper_arquivosemanaoperativa");
            });

            modelBuilder.Entity<TbAuxConjmaqmontador>(entity =>
            {
                entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_conjmaqmontador");

                entity.ToTable("tb_aux_conjmaqmontador");

                entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_aux_conjmaqmontador");

                entity.Property(e => e.IdOrigemcoletamontador)
                    .ValueGeneratedNever()
                    .HasColumnName("id_origemcoletamontador");
                entity.Property(e => e.CodDppusina).HasColumnName("cod_dppusina");
                entity.Property(e => e.IdGruge).HasColumnName("id_gruge");
                entity.Property(e => e.NomCurtousina)
                    .HasMaxLength(20)
                    .HasColumnName("nom_curtousina");

                entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxConjmaqmontador)
                    .HasForeignKey<TbAuxConjmaqmontador>(d => d.IdOrigemcoletamontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origemcoletamontador_aux_conjmaqmontador");
            });

            modelBuilder.Entity<TbAuxContrato>(entity =>
            {
                entity.HasKey(e => e.IdContrato).HasName("pk_tb_aux_contrato");

                entity.ToTable("tb_aux_contrato");

                entity.Property(e => e.IdContrato).HasColumnName("id_contrato");
                entity.Property(e => e.CodContrato).HasColumnName("cod_contrato");
                entity.Property(e => e.DinIniciovalidade)
                    .HasColumnType("datetime")
                    .HasColumnName("din_iniciovalidade");
                entity.Property(e => e.DinTerminovalidade)
                    .HasColumnType("datetime")
                    .HasColumnName("din_terminovalidade");
                entity.Property(e => e.DinUltimaalteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("din_ultimaalteracao");
                entity.Property(e => e.DscContrato).HasColumnName("dsc_contrato");
                entity.Property(e => e.FlgAtivo).HasColumnName("flg_ativo");
                entity.Property(e => e.LgnUltimaalteracao)
                    .HasMaxLength(50)
                    .HasColumnName("lgn_ultimaalteracao");
                entity.Property(e => e.NomContrato)
                    .HasMaxLength(10)
                    .HasColumnName("nom_contrato");
                entity.Property(e => e.VerControleconcorrencia)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("ver_controleconcorrencia");
            });

            modelBuilder.Entity<TbAuxDesvioagua>(entity =>
            {
                entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_desvioagua");

                entity.ToTable("tb_aux_desvioagua");

                entity.HasIndex(e => e.IdUsinamontadorretirada, "in_fk_aux_usinamontador_aux_desvioaguaretirada");

                entity.HasIndex(e => e.IdUsinamontadorretorno, "in_fk_aux_usinamontador_aux_desvioaguaretorno");

                entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_aux_desvioagua");

                entity.Property(e => e.IdOrigemcoletamontador)
                    .ValueGeneratedNever()
                    .HasColumnName("id_origemcoletamontador");
                entity.Property(e => e.DscDesvioagua).HasColumnName("dsc_desvioagua");
                entity.Property(e => e.IdUsinamontadorretirada).HasColumnName("id_usinamontadorretirada");
                entity.Property(e => e.IdUsinamontadorretorno).HasColumnName("id_usinamontadorretorno");

                entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxDesvioagua)
                    .HasForeignKey<TbAuxDesvioagua>(d => d.IdOrigemcoletamontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origemcoletamontador_aux_desvioagua");

                entity.HasOne(d => d.IdUsinamontadorretiradaNavigation).WithMany(p => p.TbAuxDesvioaguaIdUsinamontadorretiradaNavigations)
                    .HasForeignKey(d => d.IdUsinamontadorretirada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_aux_usinamontador_aux_desvioaguaretirada");

                entity.HasOne(d => d.IdUsinamontadorretornoNavigation).WithMany(p => p.TbAuxDesvioaguaIdUsinamontadorretornoNavigations)
                    .HasForeignKey(d => d.IdUsinamontadorretorno)
                    .HasConstraintName("fk_aux_usinamontador_aux_desvioaguaretorno");
            });

            modelBuilder.Entity<TbAuxInterligacao>(entity =>
            {
                entity.HasKey(e => e.IdInterligacao).HasName("pk_tb_aux_interligacao");

                entity.ToTable("tb_aux_interligacao");

                entity.Property(e => e.IdInterligacao).HasColumnName("id_interligacao");
                entity.Property(e => e.IdIntercambiopdes).HasColumnName("id_intercambiopdes");
                entity.Property(e => e.NomIntercambiopdes)
                    .HasMaxLength(150)
                    .HasColumnName("nom_intercambiopdes");
            });

            modelBuilder.Entity<TbAuxInterligacaomontador>(entity =>
            {
                entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_interligacaomontador");

                entity.ToTable("tb_aux_interligacaomontador");

                entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_aux_interligacaomontador");

                entity.Property(e => e.IdOrigemcoletamontador)
                    .ValueGeneratedNever()
                    .HasColumnName("id_origemcoletamontador");
                entity.Property(e => e.CodSubsistemade)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("cod_subsistemade");
                entity.Property(e => e.CodSubsistemapara)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("cod_subsistemapara");
                entity.Property(e => e.NomCurtosubsistemade)
                    .HasMaxLength(20)
                    .HasColumnName("nom_curtosubsistemade");
                entity.Property(e => e.NomCurtosubsistemapara)
                    .HasMaxLength(20)
                    .HasColumnName("nom_curtosubsistemapara");

                entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxInterligacaomontador)
                    .HasForeignKey<TbAuxInterligacaomontador>(d => d.IdOrigemcoletamontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origemcoletamontador_aux_interligacaomontador");
            });

            modelBuilder.Entity<TbAuxInterligacaomontadorinterligacao>(entity =>
            {
                entity.HasKey(e => new { e.IdInterligacao, e.IdOrigemcoletainterligacao }).HasName("pk_tb_aux_interligacaomontadorinterligacao");

                entity.ToTable("tb_aux_interligacaomontadorinterligacao");

                entity.HasIndex(e => e.IdInterligacao, "in_fk_aux_interligacao_aux_interligacaomontadorinterligacao");

                entity.HasIndex(e => e.IdOrigemcoletainterligacao, "in_fk_origemcoletamontador_aux_interligacaomontadorinterligacao");

                entity.Property(e => e.IdInterligacao).HasColumnName("id_interligacao");
                entity.Property(e => e.IdOrigemcoletainterligacao).HasColumnName("id_origemcoletainterligacao");
                entity.Property(e => e.FlgSoma).HasColumnName("flg_soma");

                entity.HasOne(d => d.IdInterligacaoNavigation).WithMany(p => p.TbAuxInterligacaomontadorinterligacaos)
                    .HasForeignKey(d => d.IdInterligacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_aux_interligacao_aux_interligacaomontadorinterligacao");

                entity.HasOne(d => d.IdOrigemcoletainterligacaoNavigation).WithMany(p => p.TbAuxInterligacaomontadorinterligacaos)
                    .HasForeignKey(d => d.IdOrigemcoletainterligacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origemcoletamontador_aux_interligacaomontadorinterligacao");
            });

            modelBuilder.Entity<TbAuxInterligacaomontadorusina>(entity =>
            {
                entity.HasKey(e => new { e.IdOrigemcoletainterligprinc, e.IdOrigemcoletausina }).HasName("pk_tb_aux_interligacaomontadorusina");

                entity.ToTable("tb_aux_interligacaomontadorusina");

                entity.HasIndex(e => e.IdOrigemcoletainterligprinc, "in_fk_origemcoletamontador_aux_interligacaomontadorusina");

                entity.HasIndex(e => e.IdOrigemcoletausina, "in_fk_origemcoletamontador_aux_interligacaomontadorusina2");

                entity.Property(e => e.IdOrigemcoletainterligprinc).HasColumnName("id_origemcoletainterligprinc");
                entity.Property(e => e.IdOrigemcoletausina).HasColumnName("id_origemcoletausina");
                entity.Property(e => e.FlgSoma).HasColumnName("flg_soma");

                entity.HasOne(d => d.IdOrigemcoletainterligprincNavigation).WithMany(p => p.TbAuxInterligacaomontadorusinaIdOrigemcoletainterligprincNavigations)
                    .HasForeignKey(d => d.IdOrigemcoletainterligprinc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origemcoletamontador_aux_interligacaomontadorusina");

                entity.HasOne(d => d.IdOrigemcoletausinaNavigation).WithMany(p => p.TbAuxInterligacaomontadorusinaIdOrigemcoletausinaNavigations)
                    .HasForeignKey(d => d.IdOrigemcoletausina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origemcoletamontador_aux_interligacaomontadorusina2");
            });

            modelBuilder.Entity<TbAuxIntervalocustodeficit>(entity =>
            {
                entity.HasKey(e => e.IdIntervalocustodeficit).HasName("pk_tb_aux_intervalocustodeficit");

                entity.ToTable("tb_aux_intervalocustodeficit");

                entity.Property(e => e.IdIntervalocustodeficit).HasColumnName("id_intervalocustodeficit");
                entity.Property(e => e.CodIntervalocustodeficit).HasColumnName("cod_intervalocustodeficit");
                entity.Property(e => e.DinIniciovalidade)
                    .HasColumnType("datetime")
                    .HasColumnName("din_iniciovalidade");
                entity.Property(e => e.DinTerminovalidade)
                    .HasColumnType("datetime")
                    .HasColumnName("din_terminovalidade");
                entity.Property(e => e.DinUltimaalteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("din_ultimaalteracao");
                entity.Property(e => e.DscIntervalocustodeficit).HasColumnName("dsc_intervalocustodeficit");
                entity.Property(e => e.FlgAtivo).HasColumnName("flg_ativo");
                entity.Property(e => e.LgnUltimaalteracao)
                    .HasMaxLength(50)
                    .HasColumnName("lgn_ultimaalteracao");
                entity.Property(e => e.NomIntervalocustodeficit)
                    .HasMaxLength(10)
                    .HasColumnName("nom_intervalocustodeficit");
                entity.Property(e => e.VerControleconcorrencia)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("ver_controleconcorrencia");
            });

            modelBuilder.Entity<TbAuxMnemonicomontador>(entity =>
            {
                entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_mnemonicomontador");

                entity.ToTable("tb_aux_mnemonicomontador");

                entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_aux_mnemonicomontador");

                entity.Property(e => e.IdOrigemcoletamontador)
                    .ValueGeneratedNever()
                    .HasColumnName("id_origemcoletamontador");
                entity.Property(e => e.NomMnemonico)
                    .HasMaxLength(50)
                    .HasColumnName("nom_mnemonico");

                entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxMnemonicomontador)
                    .HasForeignKey<TbAuxMnemonicomontador>(d => d.IdOrigemcoletamontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origemcoletamontador_aux_mnemonicomontador");
            });

            modelBuilder.Entity<TbAuxPequenausina>(entity =>
            {
                entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_pequenausina");

                entity.ToTable("tb_aux_pequenausina");

                entity.HasIndex(e => e.IdSubsistemamontador, "in_fk_aux_subsistemamontador_aux_pequenausina");

                entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_aux_pequenausina");

                entity.Property(e => e.IdOrigemcoletamontador)
                    .ValueGeneratedNever()
                    .HasColumnName("id_origemcoletamontador");
                entity.Property(e => e.DscPequenausina).HasColumnName("dsc_pequenausina");
                entity.Property(e => e.IdSubsistemamontador).HasColumnName("id_subsistemamontador");
                entity.Property(e => e.NomPequenausina)
                    .HasMaxLength(10)
                    .HasColumnName("nom_pequenausina");

                entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxPequenausina)
                    .HasForeignKey<TbAuxPequenausina>(d => d.IdOrigemcoletamontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origemcoletamontador_aux_pequenausina");

                entity.HasOne(d => d.IdSubsistemamontadorNavigation).WithMany(p => p.TbAuxPequenausinas)
                    .HasForeignKey(d => d.IdSubsistemamontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_aux_subsistemamontador_aux_pequenausina");
            });

            modelBuilder.Entity<TbAuxReemontador>(entity =>
            {
                entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_reemontador");

                entity.ToTable("tb_aux_reemontador");

                entity.Property(e => e.IdOrigemcoletamontador)
                    .ValueGeneratedNever()
                    .HasColumnName("id_origemcoletamontador");
                entity.Property(e => e.CodRee).HasColumnName("cod_ree");
                entity.Property(e => e.NomCurtoree)
                    .HasMaxLength(50)
                    .HasColumnName("nom_curtoree");
                entity.Property(e => e.NomLongoree)
                    .HasMaxLength(100)
                    .HasColumnName("nom_longoree");

                entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxReemontador)
                    .HasForeignKey<TbAuxReemontador>(d => d.IdOrigemcoletamontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origemcoletamontador_aux_reemontador");
            });

            modelBuilder.Entity<TbAuxReservatorio>(entity =>
            {
                entity.HasKey(e => e.IdOrigemcoleta).HasName("pk_tb_aux_reservatorio");

                entity.ToTable("tb_aux_reservatorio");

                entity.HasIndex(e => e.IdOrigemcoleta, "in_fk_origemcoleta_aux_reservatorio").HasFillFactor(90);

                entity.Property(e => e.IdOrigemcoleta)
                    .HasMaxLength(50)
                    .HasColumnName("id_origemcoleta");
                entity.Property(e => e.CodDpp).HasColumnName("cod_dpp");
                entity.Property(e => e.CodSubsistema)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("cod_subsistema");
                entity.Property(e => e.NomCurto)
                    .HasMaxLength(50)
                    .HasColumnName("nom_curto");
                entity.Property(e => e.NomLongo)
                    .HasMaxLength(100)
                    .HasColumnName("nom_longo");

                entity.HasOne(d => d.IdOrigemcoletaNavigation).WithOne(p => p.TbAuxReservatorio)
                    .HasForeignKey<TbAuxReservatorio>(d => d.IdOrigemcoleta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origemcoleta_aux_reservatorio");
            });

            modelBuilder.Entity<TbAuxSubmercado>(entity =>
            {
                entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_submercado");

                entity.ToTable("tb_aux_submercado");

                entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_aux_submercado");

                entity.Property(e => e.IdOrigemcoletamontador)
                    .ValueGeneratedNever()
                    .HasColumnName("id_origemcoletamontador");
                entity.Property(e => e.CodSubmercado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("cod_submercado");

                entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxSubmercado)
                    .HasForeignKey<TbAuxSubmercado>(d => d.IdOrigemcoletamontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origemcoletamontador_aux_submercado");
            });

            modelBuilder.Entity<TbAuxSubsistema>(entity =>
            {
                entity.HasKey(e => e.IdOrigemcoleta).HasName("pk_tb_aux_subsistema");

                entity.ToTable("tb_aux_subsistema");

                entity.HasIndex(e => e.IdOrigemcoleta, "in_fk_origemcoleta_aux_subsistema").HasFillFactor(90);

                entity.Property(e => e.IdOrigemcoleta)
                    .HasMaxLength(50)
                    .HasColumnName("id_origemcoleta");
                entity.Property(e => e.CodSubsistema)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("cod_subsistema");

                entity.HasOne(d => d.IdOrigemcoletaNavigation).WithOne(p => p.TbAuxSubsistema)
                    .HasForeignKey<TbAuxSubsistema>(d => d.IdOrigemcoleta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origemcoleta_aux_subsistema");
            });

            modelBuilder.Entity<TbAuxSubsistemacontrato>(entity =>
            {
                entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_subsistemacontrato");

                entity.ToTable("tb_aux_subsistemacontrato");

                entity.HasIndex(e => e.IdContrato, "in_fk_aux_contrato_aux_subsistemacontrato");

                entity.HasIndex(e => e.IdOrigemcoletamontadorsubsistema, "in_fk_aux_subsistemamontador_aux_subsistemacontrato");

                entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_aux_subsistemacontrato");

                entity.Property(e => e.IdOrigemcoletamontador)
                    .ValueGeneratedNever()
                    .HasColumnName("id_origemcoletamontador");
                entity.Property(e => e.IdContrato).HasColumnName("id_contrato");
                entity.Property(e => e.IdOrigemcoletamontadorsubsistema).HasColumnName("id_origemcoletamontadorsubsistema");

                entity.HasOne(d => d.IdContratoNavigation).WithMany(p => p.TbAuxSubsistemacontratos)
                    .HasForeignKey(d => d.IdContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_aux_contrato_aux_subsistemacontrato");

                entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxSubsistemacontrato)
                    .HasForeignKey<TbAuxSubsistemacontrato>(d => d.IdOrigemcoletamontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origemcoletamontador_aux_subsistemacontrato");

                entity.HasOne(d => d.IdOrigemcoletamontadorsubsistemaNavigation).WithMany(p => p.TbAuxSubsistemacontratos)
                    .HasForeignKey(d => d.IdOrigemcoletamontadorsubsistema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_aux_subsistemamontador_aux_subsistemacontrato");
            });

            modelBuilder.Entity<TbAuxSubsistemaintervalocustodeficit>(entity =>
            {
                entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_subsistemacustodeficit");

                entity.ToTable("tb_aux_subsistemaintervalocustodeficit");

                entity.HasIndex(e => e.IdIntervalocustodeficit, "in_fk_aux_intervalocurvadeficit_aux_subsistemacustodeficit");

                entity.HasIndex(e => e.IdOrigemcoletamontadorsubsistema, "in_fk_aux_subsistemamontador_aux_subsistemacustodeficit");

                entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_oriemcoletamontador_aux_subsistemaintervalocustodeficit");

                entity.Property(e => e.IdOrigemcoletamontador)
                    .ValueGeneratedNever()
                    .HasColumnName("id_origemcoletamontador");
                entity.Property(e => e.IdIntervalocustodeficit).HasColumnName("id_intervalocustodeficit");
                entity.Property(e => e.IdOrigemcoletamontadorsubsistema).HasColumnName("id_origemcoletamontadorsubsistema");

                entity.HasOne(d => d.IdIntervalocustodeficitNavigation).WithMany(p => p.TbAuxSubsistemaintervalocustodeficits)
                    .HasForeignKey(d => d.IdIntervalocustodeficit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_aux_intervalocurvadeficit_aux_subsistemacustodeficit");

                entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxSubsistemaintervalocustodeficit)
                    .HasForeignKey<TbAuxSubsistemaintervalocustodeficit>(d => d.IdOrigemcoletamontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_oriemcoletamontador_aux_subsistemaintervalocustodeficit");

                entity.HasOne(d => d.IdOrigemcoletamontadorsubsistemaNavigation).WithMany(p => p.TbAuxSubsistemaintervalocustodeficits)
                    .HasForeignKey(d => d.IdOrigemcoletamontadorsubsistema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_aux_subsistemamontador_aux_subsistemacustodeficit");
            });

            modelBuilder.Entity<TbAuxSubsistemamontador>(entity =>
            {
                entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_subsistemamontador");

                entity.ToTable("tb_aux_subsistemamontador");

                entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_aux_subsistemamontador");

                entity.Property(e => e.IdOrigemcoletamontador)
                    .ValueGeneratedNever()
                    .HasColumnName("id_origemcoletamontador");
                entity.Property(e => e.CodSubsistema).HasColumnName("cod_subsistema");
                entity.Property(e => e.NomCurtosubsistema)
                    .HasMaxLength(20)
                    .HasColumnName("nom_curtosubsistema");
                entity.Property(e => e.NumTppatamares).HasColumnName("num_tppatamares");

                entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxSubsistemamontador)
                    .HasForeignKey<TbAuxSubsistemamontador>(d => d.IdOrigemcoletamontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origemcoletamontador_aux_subsistemamontador");
            });

            modelBuilder.Entity<TbAuxUnidadegeradora>(entity =>
            {
                entity.HasKey(e => e.IdOrigemcoleta).HasName("pk_tb_aux_unidadegeradora");

                entity.ToTable("tb_aux_unidadegeradora");

                entity.HasIndex(e => e.IdOrigemcoletausinapai, "in_fk_aux_usina_aux_unidadegeradora").HasFillFactor(90);

                entity.HasIndex(e => e.IdOrigemcoleta, "in_fk_origemcoleta_aux_unidadegeradora").HasFillFactor(90);

                entity.Property(e => e.IdOrigemcoleta)
                    .HasMaxLength(50)
                    .HasColumnName("id_origemcoleta");
                entity.Property(e => e.CodDpp).HasColumnName("cod_dpp");
                entity.Property(e => e.IdOrigemcoletausinapai)
                    .HasMaxLength(50)
                    .HasColumnName("id_origemcoletausinapai");
                entity.Property(e => e.NumConjunto).HasColumnName("num_conjunto");
                entity.Property(e => e.NumMaquina).HasColumnName("num_maquina");
                entity.Property(e => e.ValPotencianominal).HasColumnName("val_potencianominal");

                entity.HasOne(d => d.IdOrigemcoletaNavigation).WithOne(p => p.TbAuxUnidadegeradora)
                    .HasForeignKey<TbAuxUnidadegeradora>(d => d.IdOrigemcoleta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origemcoleta_aux_unidadegeradora");

                entity.HasOne(d => d.IdOrigemcoletausinapaiNavigation).WithMany(p => p.TbAuxUnidadegeradoras)
                    .HasForeignKey(d => d.IdOrigemcoletausinapai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_aux_usina_aux_unidadegeradora");
            });

            modelBuilder.Entity<TbAuxUnidadegeradoramontador>(entity =>
            {
                entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_unidadegeradoramontador");

                entity.ToTable("tb_aux_unidadegeradoramontador");

                entity.HasIndex(e => e.IdOrigemcoletamontadorusina, "in_fk_aux_usinamontador_aux_unidadegeradoramontador");

                entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_aux_unidadegeradoramontador");

                entity.Property(e => e.IdOrigemcoletamontador)
                    .ValueGeneratedNever()
                    .HasColumnName("id_origemcoletamontador");
                entity.Property(e => e.CodSubsistema)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("cod_subsistema");
                entity.Property(e => e.CodUsiplanejamento).HasColumnName("cod_usiplanejamento");
                entity.Property(e => e.IdGruge).HasColumnName("id_gruge");
                entity.Property(e => e.IdOrigemcoletamontadorusina).HasColumnName("id_origemcoletamontadorusina");
                entity.Property(e => e.NomCurtosubsistema)
                    .HasMaxLength(20)
                    .HasColumnName("nom_curtosubsistema");
                entity.Property(e => e.NomCurtouge)
                    .HasMaxLength(80)
                    .HasColumnName("nom_curtouge");
                entity.Property(e => e.NomCurtousina)
                    .HasMaxLength(20)
                    .HasColumnName("nom_curtousina");
                entity.Property(e => e.NumGruge).HasColumnName("num_gruge");
                entity.Property(e => e.NumUge).HasColumnName("num_uge");
                entity.Property(e => e.ValPotencianominal).HasColumnName("val_potencianominal");

                entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxUnidadegeradoramontador)
                    .HasForeignKey<TbAuxUnidadegeradoramontador>(d => d.IdOrigemcoletamontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origemcoletamontador_aux_unidadegeradoramontador");

                entity.HasOne(d => d.IdOrigemcoletamontadorusinaNavigation).WithMany(p => p.TbAuxUnidadegeradoramontadors)
                    .HasForeignKey(d => d.IdOrigemcoletamontadorusina)
                    .HasConstraintName("fk_aux_usinamontador_aux_unidadegeradoramontador");
            });

            modelBuilder.Entity<TbAuxUsina>(entity =>
            {
                entity.HasKey(e => e.IdOrigemcoleta)
                    .HasName("pk_tb_aux_usina")
                    .IsClustered(false);

                entity.ToTable("tb_aux_usina");

                entity.HasIndex(e => e.IdOrigemcoleta, "in_fk_origemcoleta_aux_usina").HasFillFactor(90);

                entity.Property(e => e.IdOrigemcoleta)
                    .HasMaxLength(50)
                    .HasColumnName("id_origemcoleta");
                entity.Property(e => e.CodDpp).HasColumnName("cod_dpp");
                entity.Property(e => e.CodSubmercado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("cod_submercado");
                entity.Property(e => e.CodSubsistema)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("cod_subsistema");
                entity.Property(e => e.CodTpgeracao)
                    .HasMaxLength(15)
                    .HasColumnName("cod_tpgeracao");
                entity.Property(e => e.NomCurto)
                    .HasMaxLength(50)
                    .HasColumnName("nom_curto");
                entity.Property(e => e.NomLongo)
                    .HasMaxLength(100)
                    .HasColumnName("nom_longo");

                entity.HasOne(d => d.IdOrigemcoletaNavigation).WithOne(p => p.TbAuxUsina)
                    .HasForeignKey<TbAuxUsina>(d => d.IdOrigemcoleta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origemcoleta_aux_usina");
            });

            modelBuilder.Entity<TbAuxUsinaconjunto>(entity =>
            {
                entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_usinaconjunto");

                entity.ToTable("tb_aux_usinaconjunto");

                entity.HasIndex(e => e.IdUsinamontador, "in_fk_aux_usinamontador_aux_usinaconjunto");

                entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_aux_usinaconjunto");

                entity.Property(e => e.IdOrigemcoletamontador)
                    .ValueGeneratedNever()
                    .HasColumnName("id_origemcoletamontador");
                entity.Property(e => e.IdUsinamontador).HasColumnName("id_usinamontador");
                entity.Property(e => e.NumGruge).HasColumnName("num_gruge");

                entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxUsinaconjunto)
                    .HasForeignKey<TbAuxUsinaconjunto>(d => d.IdOrigemcoletamontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origemcoletamontador_aux_usinaconjunto");

                entity.HasOne(d => d.IdUsinamontadorNavigation).WithMany(p => p.TbAuxUsinaconjuntos)
                    .HasForeignKey(d => d.IdUsinamontador)
                    .HasConstraintName("fk_aux_usinamontador_aux_usinaconjunto");
            });

            modelBuilder.Entity<TbAuxUsinamnemonico>(entity =>
            {
                entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_usinamnemonico");

                entity.ToTable("tb_aux_usinamnemonico");

                entity.HasIndex(e => e.IdOrigemcoletamnemonico, "in_fk_aux_mnemonicomontador_aux_usinamnemonico");

                entity.HasIndex(e => e.IdOrigemcoletausina, "in_fk_aux_usinamontador_aux_usinamnemonico");

                entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_aux_usinamnemonico");

                entity.Property(e => e.IdOrigemcoletamontador)
                    .ValueGeneratedNever()
                    .HasColumnName("id_origemcoletamontador");
                entity.Property(e => e.IdOrigemcoletamnemonico).HasColumnName("id_origemcoletamnemonico");
                entity.Property(e => e.IdOrigemcoletausina).HasColumnName("id_origemcoletausina");

                entity.HasOne(d => d.IdOrigemcoletamnemonicoNavigation).WithMany(p => p.TbAuxUsinamnemonicos)
                    .HasForeignKey(d => d.IdOrigemcoletamnemonico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_aux_mnemonicomontador_aux_usinamnemonico");

                entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxUsinamnemonico)
                    .HasForeignKey<TbAuxUsinamnemonico>(d => d.IdOrigemcoletamontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origemcoletamontador_aux_usinamnemonico");

                entity.HasOne(d => d.IdOrigemcoletausinaNavigation).WithMany(p => p.TbAuxUsinamnemonicos)
                    .HasForeignKey(d => d.IdOrigemcoletausina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_aux_usinamontador_aux_usinamnemonico");
            });

            modelBuilder.Entity<TbAuxUsinamontador>(entity =>
            {
                entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_usinamontador");

                entity.ToTable("tb_aux_usinamontador");

                entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_aux_usinamontador");

                entity.Property(e => e.IdOrigemcoletamontador)
                    .ValueGeneratedNever()
                    .HasColumnName("id_origemcoletamontador");
                entity.Property(e => e.CodDpp).HasColumnName("cod_dpp");
                entity.Property(e => e.CodRee).HasColumnName("cod_ree");
                entity.Property(e => e.CodSubsistema)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("cod_subsistema");
                entity.Property(e => e.CodTpgeracao)
                    .HasMaxLength(15)
                    .HasColumnName("cod_tpgeracao");
                entity.Property(e => e.IdAge)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("id_age");
                entity.Property(e => e.IdOrigemcoletamontadorree)
                    .HasMaxLength(50)
                    .HasColumnName("id_origemcoletamontadorree");
                entity.Property(e => e.IdResjusante).HasColumnName("id_resjusante");
                entity.Property(e => e.IdTpusina)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("id_tpusina");
                entity.Property(e => e.NomCurto)
                    .HasMaxLength(20)
                    .HasColumnName("nom_curto");
                entity.Property(e => e.NomCurtoree)
                    .HasMaxLength(100)
                    .HasColumnName("nom_curtoree");
                entity.Property(e => e.NomCurtosubsistema)
                    .HasMaxLength(20)
                    .HasColumnName("nom_curtosubsistema");
                entity.Property(e => e.NomLongo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nom_longo");
                entity.Property(e => e.NumRestricao).HasColumnName("num_restricao");

                entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxUsinamontador)
                    .HasForeignKey<TbAuxUsinamontador>(d => d.IdOrigemcoletamontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origemcoletamontador_aux_usinamontador");
            });

            modelBuilder.Entity<Bloco>(entity =>
            {
                entity.HasKey(e => e.IdBloco).HasName("pk_tb_bloco");

                entity.ToTable("tb_bloco");

                entity.HasIndex(e => e.IdArquivoexportacao, "in_fk_arquivoexportacao_bloco");

                entity.HasIndex(e => e.IdTpcoleta, "in_fk_tpcoleta_bloco");

                entity.HasIndex(e => e.IdTpestagio, "in_fk_tpestagio_bloco");

                entity.Property(e => e.IdBloco).HasColumnName("id_bloco");
                entity.Property(e => e.CodBloco)
                    .HasMaxLength(50)
                    .HasColumnName("cod_bloco");
                entity.Property(e => e.DscCabecalho).HasColumnName("dsc_cabecalho");
                entity.Property(e => e.FlgAtivo)
                    .HasDefaultValue(true)
                    .HasColumnName("flg_ativo");
                entity.Property(e => e.FlgEspecifico).HasColumnName("flg_especifico");
                entity.Property(e => e.FlgExpansaousinas).HasColumnName("flg_expansaousinas");
                entity.Property(e => e.FlgExportacaoestagio)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("flg_exportacaoestagio");
                entity.Property(e => e.FlgExportado).HasColumnName("flg_exportado");
                entity.Property(e => e.FlgReservado).HasColumnName("flg_reservado");
                entity.Property(e => e.IdArquivoexportacao).HasColumnName("id_arquivoexportacao");
                entity.Property(e => e.IdTpcoleta).HasColumnName("id_tpcoleta");
                entity.Property(e => e.IdTpestagio).HasColumnName("id_tpestagio");
                entity.Property(e => e.NomBloco)
                    .HasMaxLength(150)
                    .HasColumnName("nom_bloco");
                entity.Property(e => e.NumOrdem).HasColumnName("num_ordem");
                entity.Property(e => e.QtdEstagios).HasColumnName("qtd_estagios");
                entity.Property(e => e.VerControleconcorrencia)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("ver_controleconcorrencia");

                entity.HasOne(d => d.IdArquivoexportacaoNavigation).WithMany(p => p.TbBlocos)
                    .HasForeignKey(d => d.IdArquivoexportacao)
                    .HasConstraintName("fk_arquivoexportacao_bloco");

                entity.HasOne(d => d.IdTpcoletaNavigation).WithMany(p => p.TbBlocos)
                    .HasForeignKey(d => d.IdTpcoleta)
                    .HasConstraintName("fk_tpcoleta_bloco");

                entity.HasOne(d => d.IdTpestagioNavigation).WithMany(p => p.TbBlocos)
                    .HasForeignKey(d => d.IdTpestagio)
                    .HasConstraintName("fk_tpestagio_bloco");

                entity.HasMany(d => d.IdTpcategoriainsumos).WithMany(p => p.IdBlocos)
                    .UsingEntity<Dictionary<string, object>>(
                        "TbBlocotpcategoriainsumo",
                        r => r.HasOne<CategoriaInsumo>().WithMany()
                            .HasForeignKey("IdTpcategoriainsumo")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_tpcategoriainsumo_blocotpcategoriainsumo"),
                        l => l.HasOne<Bloco>().WithMany()
                            .HasForeignKey("IdBloco")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_bloco_blocotpcategoriainsumo"),
                        j =>
                        {
                            j.HasKey("IdBloco", "IdTpcategoriainsumo").HasName("pk_tb_blocotpcategoriainsumo");
                            j.ToTable("tb_blocotpcategoriainsumo");
                            j.HasIndex(new[] { "IdBloco" }, "in_fk_bloco_blocotpcategoriainsumo");
                            j.HasIndex(new[] { "IdTpcategoriainsumo" }, "in_fk_tpcategoriainsumo_blocotpcategoriainsumo");
                            j.IndexerProperty<int>("IdBloco").HasColumnName("id_bloco");
                            j.IndexerProperty<int>("IdTpcategoriainsumo").HasColumnName("id_tpcategoriainsumo");
                        });
            });

            modelBuilder.Entity<BlocoEstudoMontador>(entity =>
            {
                entity.HasKey(e => e.IdBlocoestudomontador).HasName("pk_tb_blocoestudomontador");

                entity.ToTable("tb_blocoestudomontador");

                entity.HasIndex(e => e.IdBloco, "in_fk_bloco_blocoestudomontador");

                entity.HasIndex(e => e.IdEstadoblocoestudomontador, "in_fk_estadoblocoestudomontador_blocoestudomontador");

                entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_blocoestudomontador");

                entity.Property(e => e.IdBlocoestudomontador).HasColumnName("id_blocoestudomontador");
                entity.Property(e => e.DinUltimaalteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("din_ultimaalteracao");
                entity.Property(e => e.IdBloco).HasColumnName("id_bloco");
                entity.Property(e => e.IdEstadoblocoestudomontador).HasColumnName("id_estadoblocoestudomontador");
                entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
                entity.Property(e => e.LgnUltimaalteracao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lgn_ultimaalteracao");
                entity.Property(e => e.LgnUsuariocheckout)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lgn_usuariocheckout");
                entity.Property(e => e.VerControleconcorrencia)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("ver_controleconcorrencia");

                entity.HasOne(d => d.IdBlocoNavigation).WithMany(p => p.TbBlocoestudomontadors)
                    .HasForeignKey(d => d.IdBloco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_bloco_blocoestudomontador");

                entity.HasOne(d => d.IdEstadoblocoestudomontadorNavigation).WithMany(p => p.TbBlocoestudomontadors)
                    .HasForeignKey(d => d.IdEstadoblocoestudomontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estadoblocoestudomontador_blocoestudomontador");

                entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbBlocoestudomontadors)
                    .HasForeignKey(d => d.IdEstudomontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estudomontador_blocoestudomontador");
            });

            modelBuilder.Entity<CampoChave>(entity =>
            {
                entity.HasKey(e => e.IdCampochave).HasName("pk_tb_campochave");

                entity.ToTable("tb_campochave");

                entity.Property(e => e.IdCampochave)
                    .ValueGeneratedNever()
                    .HasColumnName("id_campochave");
                entity.Property(e => e.CodCampochave)
                    .HasMaxLength(20)
                    .HasColumnName("cod_campochave");
                entity.Property(e => e.DscCampochave)
                    .HasMaxLength(50)
                    .HasColumnName("dsc_campochave");
            });

            modelBuilder.Entity<CampoChaveTipoColeta>(entity =>
            {
                entity.HasKey(e => new { e.IdCampochave, e.IdTpcoleta }).HasName("pk_tb_campochavetpcoleta");

                entity.ToTable("tb_campochavetpcoleta");

                entity.HasIndex(e => e.IdCampochave, "in_fk_campochave_campochavetpcoleta");

                entity.HasIndex(e => e.IdTpcoleta, "in_fk_tpcoleta_campochavetpcoleta");

                entity.Property(e => e.IdCampochave).HasColumnName("id_campochave");
                entity.Property(e => e.IdTpcoleta).HasColumnName("id_tpcoleta");
                entity.Property(e => e.FlgPrincipal).HasColumnName("flg_principal");
                entity.Property(e => e.NomColorigemcoleta)
                    .HasMaxLength(50)
                    .HasColumnName("nom_colorigemcoleta");

                entity.HasOne(d => d.IdCampochaveNavigation).WithMany(p => p.TbCampochavetpcoleta)
                    .HasForeignKey(d => d.IdCampochave)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_campochave_campochavetpcoleta");

                entity.HasOne(d => d.IdTpcoletaNavigation).WithMany(p => p.TbCampochavetpcoleta)
                    .HasForeignKey(d => d.IdTpcoleta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tpcoleta_campochavetpcoleta");
            });

            modelBuilder.Entity<ChaveBloco>(entity =>
            {
                entity.HasKey(e => new { e.IdBloco, e.IdCampochave }).HasName("pk_tb_chavebloco");

                entity.ToTable("tb_chavebloco");

                entity.HasIndex(e => e.IdBloco, "in_fk_bloco_chavebloco");

                entity.HasIndex(e => e.IdCampochave, "in_fk_campochave_chavebloco");

                entity.Property(e => e.IdBloco).HasColumnName("id_bloco");
                entity.Property(e => e.IdCampochave).HasColumnName("id_campochave");
                entity.Property(e => e.FlgDispexportacao).HasColumnName("flg_dispexportacao");
                entity.Property(e => e.FlgDispmanutencao).HasColumnName("flg_dispmanutencao");
                entity.Property(e => e.FlgGeralinhacomentario).HasColumnName("flg_geralinhacomentario");
                entity.Property(e => e.ValColfinal).HasColumnName("val_colfinal");
                entity.Property(e => e.ValColinicial).HasColumnName("val_colinicial");

                entity.HasOne(d => d.IdBlocoNavigation).WithMany(p => p.TbChaveblocos)
                    .HasForeignKey(d => d.IdBloco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_bloco_chavebloco");

                entity.HasOne(d => d.IdCampochaveNavigation).WithMany(p => p.TbChaveblocos)
                    .HasForeignKey(d => d.IdCampochave)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_campochave_chavebloco");
            });

            modelBuilder.Entity<ChaveBlocoEstudo>(entity =>
            {
                entity.HasKey(e => e.IdChaveblocoestudo).HasName("pk_tb_chaveblocoestudo");

                entity.ToTable("tb_chaveblocoestudo");

                entity.HasIndex(e => e.IdBloco, "in_fk_bloco_chaveblocoestudo");

                entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_chaveblocoestudo");

                entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_chaveblocoestudo");

                entity.HasIndex(e => e.IdRestricao, "in_fk_restricao_chaveblocoestudo");

                entity.Property(e => e.IdChaveblocoestudo).HasColumnName("id_chaveblocoestudo");
                entity.Property(e => e.IdBloco).HasColumnName("id_bloco");
                entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
                entity.Property(e => e.IdOrigemcoletamontador).HasColumnName("id_origemcoletamontador");
                entity.Property(e => e.IdRestricao).HasColumnName("id_restricao");

                entity.HasOne(d => d.IdBlocoNavigation).WithMany(p => p.TbChaveblocoestudos)
                    .HasForeignKey(d => d.IdBloco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_bloco_chaveblocoestudo");

                entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbChaveblocoestudos)
                    .HasForeignKey(d => d.IdEstudomontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estudomontador_chaveblocoestudo");

                entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithMany(p => p.TbChaveblocoestudos)
                    .HasForeignKey(d => d.IdOrigemcoletamontador)
                    .HasConstraintName("fk_origemcoletamontador_chaveblocoestudo");

                entity.HasOne(d => d.IdRestricaoNavigation).WithMany(p => p.TbChaveblocoestudos)
                    .HasForeignKey(d => d.IdRestricao)
                    .HasConstraintName("fk_restricao_chaveblocoestudo");
            });

            modelBuilder.Entity<ChaveMnemonico>(entity =>
            {
                entity.HasKey(e => new { e.IdCampochave, e.IdMnemonicoblocoac }).HasName("pk_tb_chavemnemonico");

                entity.ToTable("tb_chavemnemonico");

                entity.HasIndex(e => e.IdCampochave, "in_fk_campochave_chavemnemonico");

                entity.HasIndex(e => e.IdMnemonicoblocoac, "in_fk_mnemonicoblocoac_chavemnemonico");

                entity.Property(e => e.IdCampochave).HasColumnName("id_campochave");
                entity.Property(e => e.IdMnemonicoblocoac).HasColumnName("id_mnemonicoblocoac");
                entity.Property(e => e.FlgDispexportacao).HasColumnName("flg_dispexportacao");
                entity.Property(e => e.FlgDispmanutencao).HasColumnName("flg_dispmanutencao");
                entity.Property(e => e.FlgGeralinhacomentario).HasColumnName("flg_geralinhacomentario");

                entity.HasOne(d => d.IdCampochaveNavigation).WithMany(p => p.TbChavemnemonicos)
                    .HasForeignKey(d => d.IdCampochave)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_campochave_chavemnemonico");

                entity.HasOne(d => d.IdMnemonicoblocoacNavigation).WithMany(p => p.TbChavemnemonicos)
                    .HasForeignKey(d => d.IdMnemonicoblocoac)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mnemonicoblocoac_chavemnemonico");
            });

            modelBuilder.Entity<ChaveMnemonicoEstudo>(entity =>
            {
                entity.HasKey(e => e.IdChavemnemonicoestudo).HasName("pk_tb_chavemnemonicoestudo");

                entity.ToTable("tb_chavemnemonicoestudo");

                entity.HasIndex(e => e.IdMnemonicoblocoac, "in_fk_chavemnemonicoestudo_mnemonicoblocoac");

                entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_chavemnemonicoestudo");

                entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_chavemnemonicoestudo");

                entity.Property(e => e.IdChavemnemonicoestudo).HasColumnName("id_chavemnemonicoestudo");
                entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
                entity.Property(e => e.IdMnemonicoblocoac).HasColumnName("id_mnemonicoblocoac");
                entity.Property(e => e.IdOrigemcoletamontador).HasColumnName("id_origemcoletamontador");

                entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbChavemnemonicoestudos)
                    .HasForeignKey(d => d.IdEstudomontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estudomontador_chavemnemonicoestudo");

                entity.HasOne(d => d.IdMnemonicoblocoacNavigation).WithMany(p => p.TbChavemnemonicoestudos)
                    .HasForeignKey(d => d.IdMnemonicoblocoac)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_chavemnemonicoestudo_mnemonicoblocoac");

                entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithMany(p => p.TbChavemnemonicoestudos)
                    .HasForeignKey(d => d.IdOrigemcoletamontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_origemcoletamontador_chavemnemonicoestudo");
            });

            modelBuilder.Entity<ColetaInsumo>(entity =>
            {
                entity.HasKey(e => e.IdColetainsumo).HasName("pk_tb_coletainsumo");

                entity.ToTable("tb_coletainsumo");

                entity.HasIndex(e => e.IdAgenteInstituicao, "in_fk_agenteinstituicao_coletainsumo").HasFillFactor(90);

                entity.HasIndex(e => e.IdInsumopmo, "in_fk_insumopmo_coletainsumo").HasFillFactor(90);

                entity.HasIndex(e => e.IdSemanaoperativa, "in_fk_semanaoperativa_coletainsumo").HasFillFactor(90);

                entity.HasIndex(e => e.IdTpsituacaocoletainsumo, "in_fk_tpsituacaocoletainsumo_coletainsumo").HasFillFactor(90);

                entity.Property(e => e.IdColetainsumo).HasColumnName("id_coletainsumo");
                entity.Property(e => e.CodPerfilons)
                    .HasMaxLength(30)
                    .HasColumnName("cod_perfilons");
                entity.Property(e => e.DinUltimaalteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("din_ultimaalteracao");
                entity.Property(e => e.DscMotivoalteracaoons)
                    .HasMaxLength(1000)
                    .HasColumnName("dsc_motivoalteracaoons");
                entity.Property(e => e.DscMotivorejeicaoons)
                    .HasMaxLength(1000)
                    .HasColumnName("dsc_motivorejeicaoons");
                entity.Property(e => e.IdAgenteInstituicao).HasColumnName("id_agenteinstituicao");
                entity.Property(e => e.IdInsumopmo).HasColumnName("id_insumopmo");
                entity.Property(e => e.IdSemanaoperativa).HasColumnName("id_semanaoperativa");
                entity.Property(e => e.IdTpsituacaocoletainsumo).HasColumnName("id_tpsituacaocoletainsumo");
                entity.Property(e => e.LgnAgenteultimaalteracao)
                    .HasMaxLength(150)
                    .HasColumnName("lgn_agenteultimaalteracao");
                entity.Property(e => e.NomGrandezasnaoestagioalteradas)
                    .HasMaxLength(1000)
                    .HasColumnName("nom_grandezasnaoestagioalteradas");
                entity.Property(e => e.VerControleconcorrencia)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("ver_controleconcorrencia");

                entity.HasOne(d => d.IdAgenteinstituicaoNavigation).WithMany(p => p.TbColetainsumos)
                    .HasForeignKey(d => d.IdAgenteInstituicao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_agenteinstituicao_coletainsumo");

                entity.HasOne(d => d.IdInsumopmoNavigation).WithMany(p => p.TbColetainsumos)
                    .HasForeignKey(d => d.IdInsumopmo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_insumopmo_coletainsumo");

                entity.HasOne(d => d.IdSemanaoperativaNavigation).WithMany(p => p.TbColetainsumos)
                    .HasForeignKey(d => d.IdSemanaoperativa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_semanaoperativa_coletainsumo");

                entity.HasOne(d => d.IdTpsituacaocoletainsumoNavigation).WithMany(p => p.TbColetainsumos)
                    .HasForeignKey(d => d.IdTpsituacaocoletainsumo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tpsituacaocoletainsumo_coletainsumo");
            });

            modelBuilder.Entity<ColunaGrandeza>(entity =>
            {
                entity.HasKey(e => e.IdColunagrandeza).HasName("pk_tb_colunagrandeza");

                entity.ToTable("tb_colunagrandeza");

                entity.HasIndex(e => e.IdGrandezamontador, "in_fk_grandezabloco_colunagrandeza");

                entity.HasIndex(e => e.IdTplimite, "in_fk_tplimite_colunagrandeza");

                entity.HasIndex(e => e.IdTppatamar, "in_fk_tppatamar_colunagrandeza");

                entity.Property(e => e.IdColunagrandeza).HasColumnName("id_colunagrandeza");
                entity.Property(e => e.IdGrandezamontador).HasColumnName("id_grandezamontador");
                entity.Property(e => e.IdTplimite).HasColumnName("id_tplimite");
                entity.Property(e => e.IdTppatamar).HasColumnName("id_tppatamar");
                entity.Property(e => e.ValColfinal).HasColumnName("val_colfinal");
                entity.Property(e => e.ValColinicial).HasColumnName("val_colinicial");

                entity.HasOne(d => d.IdGrandezamontadorNavigation).WithMany(p => p.TbColunagrandezas)
                    .HasForeignKey(d => d.IdGrandezamontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_grandezabloco_colunagrandeza");

                entity.HasOne(d => d.IdTplimiteNavigation).WithMany(p => p.TbColunagrandezas)
                    .HasForeignKey(d => d.IdTplimite)
                    .HasConstraintName("fk_tplimite_colunagrandeza");

                entity.HasOne(d => d.IdTppatamarNavigation).WithMany(p => p.TbColunagrandezas)
                    .HasForeignKey(d => d.IdTppatamar)
                    .HasConstraintName("fk_tppatamar_colunagrandeza");
            });

            modelBuilder.Entity<ConfiguracaoCenarioPadrao>(entity =>
            {
                entity.HasKey(e => e.IdConfiguracaocenariopadrao)
                    .HasName("pk_tb_configuracaocenariopadrao")
                    .IsClustered(false);

                entity.ToTable("tb_configuracaocenariopadrao");

                entity.Property(e => e.IdConfiguracaocenariopadrao)
                    .ValueGeneratedNever()
                    .HasColumnName("id_configuracaocenariopadrao");
                entity.Property(e => e.MesReferencia).HasColumnName("mes_referencia");
                entity.Property(e => e.ValPadrao).HasColumnName("val_padrao");
            });

            modelBuilder.Entity<ConfiguracaoGestaoManutencao>(entity =>
            {
                entity.HasKey(e => e.IdConfiguracaogestaomanutencao).HasName("pk_tb_configuracaogestaomanutencao");

                entity.ToTable("tb_configuracaogestaomanutencao");

                entity.HasIndex(e => e.IdSemanaoperativa, "in_fk_semanaoperativa_configuracaogestaomanutencao");

                entity.Property(e => e.IdConfiguracaogestaomanutencao).HasColumnName("id_configuracaogestaomanutencao");
                entity.Property(e => e.DinColeta)
                    .HasColumnType("datetime")
                    .HasColumnName("din_coleta");
                entity.Property(e => e.HorPonta).HasColumnName("hor_ponta");
                entity.Property(e => e.IdSemanaoperativa).HasColumnName("id_semanaoperativa");
                entity.Property(e => e.LgnColeta)
                    .HasMaxLength(50)
                    .HasColumnName("lgn_coleta");
                entity.Property(e => e.LgnUsuariocheckout)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lgn_usuariocheckout");
                entity.Property(e => e.QtdPeriodoanalise).HasColumnName("qtd_periodoanalise");

                //entity.HasOne(d => d.IdSemanaoperativaNavigation).WithMany(p => p.TbConfiguracaogestaomanutencaos)
                //    .HasForeignKey(d => d.IdSemanaoperativa)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("fk_semanaoperativa_configuracaogestaomanutencao");

                entity.HasMany(d => d.IdAgenteinstituicaos).WithMany(p => p.IdConfiguracaogestaomanutencaos)
                    .UsingEntity<Dictionary<string, object>>(
                        "TbConfiguracaogestaomanutencaoagente",
                        r => r.HasOne<AgenteInstituicao>().WithMany()
                            .HasForeignKey("IdAgenteInstituicao")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_agenteinstituicao_configuracaogestaomanutencaoagente"),
                        l => l.HasOne<ConfiguracaoGestaoManutencao>().WithMany()
                            .HasForeignKey("IdConfiguracaogestaomanutencao")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_configuracaogestaomanutencao_configuracaogestaomanutencaoagente"),
                        j =>
                        {
                            j.HasKey("IdConfiguracaogestaomanutencao", "IdAgenteInstituicao").HasName("pk_tb_configuracaogestaomanutencaoagentes");
                            j.ToTable("tb_configuracaogestaomanutencaoagente");
                            j.HasIndex(new[] { "IdAgenteInstituicao" }, "in_fk_agenteinstituicao_configuracaogestaomanutencaoagente");
                            j.HasIndex(new[] { "IdConfiguracaogestaomanutencao" }, "in_fk_configuracaogestaomanutencao_configuracaogestaomanutencaoagente");
                            j.IndexerProperty<int>("IdConfiguracaogestaomanutencao").HasColumnName("id_configuracaogestaomanutencao");
                            j.IndexerProperty<int>("IdAgenteInstituicao").HasColumnName("id_agenteinstituicao");
                        });
            });

            modelBuilder.Entity<ConjuntoGeracaoMinima>(entity =>
            {
                entity.HasKey(e => e.IdConjuntogeracaominima).HasName("pk_tb_conjuntogeracaominima");

                entity.ToTable("tb_conjuntogeracaominima");

                entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_conjuntogeracaominima");

                entity.Property(e => e.IdConjuntogeracaominima).HasColumnName("id_conjuntogeracaominima");
                entity.Property(e => e.DinUltimaalteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("din_ultimaalteracao");
                entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
                entity.Property(e => e.LgnUltimaalteracao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lgn_ultimaalteracao");
                entity.Property(e => e.NomConjuntogeracaominima)
                    .HasMaxLength(50)
                    .HasColumnName("nom_conjuntogeracaominima");
                entity.Property(e => e.VerControleconcorrencia)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("ver_controleconcorrencia");

                entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbConjuntogeracaominimas)
                    .HasForeignKey(d => d.IdEstudomontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estudomontador_conjuntogeracaominima");

                entity.HasMany(d => d.IdOrigemcoletamontadors).WithMany(p => p.IdConjuntogeracaominimas)
                    .UsingEntity<Dictionary<string, object>>(
                        "TbUsinasconjuntogeracaominima",
                        r => r.HasOne<TbAuxUsinamontador>().WithMany()
                            .HasForeignKey("IdOrigemcoletamontador")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_aux_usinamontador_usinaconjuntogeracaominima"),
                        l => l.HasOne<ConjuntoGeracaoMinima>().WithMany()
                            .HasForeignKey("IdConjuntogeracaominima")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_conjuntogeracaominima_usinasconjuntogeracaominima"),
                        j =>
                        {
                            j.HasKey("IdConjuntogeracaominima", "IdOrigemcoletamontador").HasName("pk_tb_usinasconjuntogeracaominima");
                            j.ToTable("tb_usinasconjuntogeracaominima");
                            j.HasIndex(new[] { "IdOrigemcoletamontador" }, "in_fk_aux_usinamontador_usinaconjuntogeracaominima");
                            j.HasIndex(new[] { "IdConjuntogeracaominima" }, "in_fk_conjuntogeracaominima_usinasconjuntogeracaominima");
                            j.IndexerProperty<int>("IdConjuntogeracaominima").HasColumnName("id_conjuntogeracaominima");
                            j.IndexerProperty<int>("IdOrigemcoletamontador").HasColumnName("id_origemcoletamontador");
                        });
            });

            modelBuilder.Entity<DadoColetaEstruturado>(entity =>
            {
                entity.HasKey(e => e.IdDadocoleta).HasName("pk_tb_dadocoletaestruturado");

                entity.ToTable("tb_dadocoletaestruturado");

                entity.HasIndex(e => e.IdDadocoleta, "in_fk_dadocoleta_dadocoletaestruturado");

                entity.HasIndex(e => e.IdTplimite, "in_fk_tplimite_dadocoletaestruturado").HasFillFactor(90);

                entity.HasIndex(e => e.IdTppatamar, "in_fk_tppatamar_dadocoletaestruturado").HasFillFactor(90);

                entity.Property(e => e.IdDadocoleta)
                    .ValueGeneratedNever()
                    .HasColumnName("id_dadocoleta");
                entity.Property(e => e.DscEstagio)
                    .HasMaxLength(50)
                    .HasColumnName("dsc_estagio");
                entity.Property(e => e.FlgDestacamodificacao).HasColumnName("flg_destacamodificacao");
                entity.Property(e => e.IdTplimite).HasColumnName("id_tplimite");
                entity.Property(e => e.IdTppatamar).HasColumnName("id_tppatamar");
                entity.Property(e => e.ValDado)
                    .HasMaxLength(4000)
                    .HasColumnName("val_dado");

                entity.HasOne(d => d.IdDadocoletaNavigation).WithOne(p => p.TbDadocoletaestruturado)
                    .HasForeignKey<DadoColetaEstruturado>(d => d.IdDadocoleta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_dadocoleta_dadocoletaestruturado");

                entity.HasOne(d => d.IdTplimiteNavigation).WithMany(p => p.TbDadocoletaestruturados)
                    .HasForeignKey(d => d.IdTplimite)
                    .HasConstraintName("fk_tplimite_dadocoletaestruturado");

                entity.HasOne(d => d.IdTppatamarNavigation).WithMany(p => p.TbDadocoletaestruturados)
                    .HasForeignKey(d => d.IdTppatamar)
                    .HasConstraintName("fk_tppatamar_dadocoletaestruturado");
            });

            modelBuilder.Entity<DadoColetaManutencao>(entity =>
            {
                entity.HasKey(e => e.IdDadocoleta).HasName("pk_tb_dadocoletamanutencao");

                entity.ToTable("tb_dadocoletamanutencao");

                entity.HasIndex(e => e.IdOrigemcoletauge, "in_fk_aux_unidadegeradora_dadocoletamanutencao").HasFillFactor(90);

                entity.HasIndex(e => e.IdDadocoleta, "in_fk_dadocoleta_dadocoletamanutencao").HasFillFactor(90);

                entity.Property(e => e.IdDadocoleta)
                    .ValueGeneratedNever()
                    .HasColumnName("id_dadocoleta");
                entity.Property(e => e.DatFim)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dat_fim");
                entity.Property(e => e.DatInicio)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dat_inicio");
                entity.Property(e => e.DscJustificativa)
                    .HasMaxLength(4000)
                    .HasColumnName("dsc_justificativa");
                entity.Property(e => e.IdOrigemcoletauge)
                    .HasMaxLength(50)
                    .HasColumnName("id_origemcoletauge");
                entity.Property(e => e.NomSituacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nom_situacao");
                entity.Property(e => e.NumManutencao)
                    .HasMaxLength(20)
                    .HasColumnName("num_manutencao");
                entity.Property(e => e.PrdTemporetorno)
                    .HasMaxLength(5)
                    .HasColumnName("prd_temporetorno");
                entity.Property(e => e.SglClassificacaotpeqpintervencao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("sgl_classificacaotpeqpintervencao");
                entity.Property(e => e.SglPeriodicidadeintervencao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("sgl_periodicidadeintervencao");

                entity.HasOne(d => d.IdDadocoletaNavigation).WithOne(p => p.TbDadocoletamanutencao)
                    .HasForeignKey<DadoColetaManutencao>(d => d.IdDadocoleta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_dadocoleta_dadocoletamanutencao");

                entity.HasOne(d => d.IdOrigemcoletaugeNavigation).WithMany(p => p.TbDadocoletamanutencaos)
                    .HasForeignKey(d => d.IdOrigemcoletauge)
                    .HasConstraintName("fk_aux_unidadegeradora_dadocoletamanutencao");
            });

            modelBuilder.Entity<DadoColetaNaoEstruturado>(entity =>
            {
                entity.HasKey(e => e.IdDadocoleta).HasName("pk_tb_dadocoletanaoestruturado");

                entity.ToTable("tb_dadocoletanaoestruturado");

                entity.HasIndex(e => e.IdDadocoleta, "in_fk_dadocoleta_dadocoletanaoestruturado");

                entity.Property(e => e.IdDadocoleta)
                    .ValueGeneratedNever()
                    .HasColumnName("id_dadocoleta");
                entity.Property(e => e.ObsDadocoletanaoestruturado)
                    .HasMaxLength(1000)
                    .HasColumnName("obs_dadocoletanaoestruturado");

                entity.HasOne(d => d.IdDadocoletaNavigation).WithOne(p => p.TbDadocoletanaoestruturado)
                    .HasForeignKey<DadoColetaNaoEstruturado>(d => d.IdDadocoleta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_dadocoleta_dadocoletanaoestruturado");

                entity.HasMany(d => d.IdArquivos).WithMany(p => p.IdDadocoleta)
                    .UsingEntity<Dictionary<string, object>>(
                        "TbArqdadocoletanaoestruturado",
                        r => r.HasOne<Arquivo>().WithMany()
                            .HasForeignKey("IdArquivo")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_arquivo_arqdadocoletanaoestruturado"),
                        l => l.HasOne<DadoColetaNaoEstruturado>().WithMany()
                            .HasForeignKey("IdDadocoleta")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_dadocoletanaoestruturado_arqdadocoletanaoestruturado"),
                        j =>
                        {
                            j.HasKey("IdDadocoleta", "IdArquivo").HasName("pk_tb_arqdadocoletanaoestruturado");
                            j.ToTable("tb_arqdadocoletanaoestruturado", tb => tb.HasComment("Associação de arquivos e dados não estruturados"));
                            j.HasIndex(new[] { "IdArquivo" }, "in_fk_arquivo_arqdadocoletanaoestruturado").HasFillFactor(90);
                            j.HasIndex(new[] { "IdDadocoleta" }, "in_fk_dadocoletanaoestruturado_arqdadocoletanaoestruturado").HasFillFactor(90);
                            j.HasIndex(new[] { "IdDadocoleta", "IdArquivo" }, "in_pk_tb_arqdadocoletanaoestruturado")
                                .IsUnique()
                                .HasFillFactor(90);
                            j.IndexerProperty<int>("IdDadocoleta")
                                .HasComment("Identificador do dado coletado não estruturado")
                                .HasColumnName("id_dadocoleta");
                            j.IndexerProperty<Guid>("IdArquivo")
                                .HasComment("Identificador dos arquivos associados ao dado não estruturado")
                                .HasColumnName("id_arquivo");
                        });
            });

            modelBuilder.Entity<DadoColeta>(entity =>
            {
                entity.HasKey(e => e.IdDadocoleta).HasName("pk_tb_dadocoleta");

                entity.ToTable("tb_dadocoleta");

                entity.HasIndex(e => e.IdColetainsumo, "in_fk_coletainsumo_dadocoleta").HasFillFactor(90);

                entity.HasIndex(e => e.IdGabarito, "in_fk_gabarito_dadocoleta").HasFillFactor(90);

                entity.HasIndex(e => e.IdGrandeza, "in_fk_grandeza_dadocoleta").HasFillFactor(90);

                entity.Property(e => e.IdDadocoleta).HasColumnName("id_dadocoleta");
                entity.Property(e => e.IdColetainsumo).HasColumnName("id_coletainsumo");
                entity.Property(e => e.IdGabarito).HasColumnName("id_gabarito");
                entity.Property(e => e.IdGrandeza).HasColumnName("id_grandeza");
                entity.Property(e => e.TipDadocoleta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("tip_dadocoleta");

                entity.HasOne(d => d.IdColetainsumoNavigation).WithMany(p => p.TbDadocoleta)
                    .HasForeignKey(d => d.IdColetainsumo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_coletainsumo_dadocoleta");

                entity.HasOne(d => d.IdGabaritoNavigation).WithMany(p => p.TbDadocoleta)
                    .HasForeignKey(d => d.IdGabarito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_gabarito_dadocoleta");

                entity.HasOne(d => d.IdGrandezaNavigation).WithMany(p => p.TbDadocoleta)
                    .HasForeignKey(d => d.IdGrandeza)
                    .HasConstraintName("fk_grandeza_dadocoleta");
            });

            modelBuilder.Entity<DadoResultadoPMO>(entity =>
            {
                entity.HasKey(e => e.IdDadoresultpmo).HasName("pk_tb_dadoresultpmo");

                entity.ToTable("tb_dadoresultpmo");

                entity.HasIndex(e => e.IdListaresultadopmo, "in_fk_listaresultadopmo_dadoresultpmo");

                entity.HasIndex(e => e.IdMnemonicopmo, "in_fk_mnemonicopmo_dadoresultpmo");

                entity.Property(e => e.IdDadoresultpmo).HasColumnName("id_dadoresultpmo");
                entity.Property(e => e.DscValorcoletadomnemonico)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("dsc_valorcoletadomnemonico");
                entity.Property(e => e.FlgValoroficial).HasColumnName("flg_valoroficial");
                entity.Property(e => e.IdListaresultadopmo).HasColumnName("id_listaresultadopmo");
                entity.Property(e => e.IdMnemonicopmo).HasColumnName("id_mnemonicopmo");
                entity.Property(e => e.IdTppatamar).HasColumnName("id_tppatamar");
                entity.Property(e => e.NumEstagio).HasColumnName("num_estagio");

                entity.HasOne(d => d.IdListaresultadopmoNavigation).WithMany(p => p.TbDadoresultpmos)
                    .HasForeignKey(d => d.IdListaresultadopmo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_listaresultadopmo_dadoresultpmo");

                entity.HasOne(d => d.IdMnemonicopmoNavigation).WithMany(p => p.TbDadoresultpmos)
                    .HasForeignKey(d => d.IdMnemonicopmo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mnemonicopmo_dadoresultpmo");
            });

            modelBuilder.Entity<DadosConvergencia>(entity =>
            {
                entity.HasKey(e => e.IdDadosconvergencia).HasName("pk_tb_dadosconvergencia");

                entity.ToTable("tb_dadosconvergencia");

                entity.HasIndex(e => e.IdSemanaoperativa, "in_fk_semanaoperativa_dadosconvergencia").HasFillFactor(90);

                entity.Property(e => e.IdDadosconvergencia).HasColumnName("id_dadosconvergencia");
                entity.Property(e => e.IdSemanaoperativa).HasColumnName("id_semanaoperativa");
                entity.Property(e => e.LgnRepresentanteccee)
                    .HasMaxLength(30)
                    .HasColumnName("lgn_representanteccee");
                entity.Property(e => e.ObsCcee)
                    .HasMaxLength(1000)
                    .HasColumnName("obs_ccee");

                entity.HasOne(d => d.IdSemanaoperativaNavigation).WithMany(p => p.TbDadosconvergencia)
                    .HasForeignKey(d => d.IdSemanaoperativa)
                    .HasConstraintName("fk_semanaoperativa_dadosconvergencia");
            });

            modelBuilder.Entity<DecisaoComandoGNL>(entity =>
            {
                entity.HasKey(e => e.IdDecisaocomandognl).HasName("pk_tb_decisaocomandognl");

                entity.ToTable("tb_decisaocomandognl");

                entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_aux_usinamontador_decisaocomandognl");

                entity.HasIndex(e => e.IdTitulacao, "in_fk_titulacao_decisaocomandognl");

                entity.HasIndex(e => e.IdTppatamar, "in_fk_tppatamar_decisaocomandognl");

                entity.Property(e => e.IdDecisaocomandognl).HasColumnName("id_decisaocomandognl");
                entity.Property(e => e.DatFinal).HasColumnName("dat_final");
                entity.Property(e => e.DatInicial).HasColumnName("dat_inicial");
                entity.Property(e => e.IdOrigemcoletamontador).HasColumnName("id_origemcoletamontador");
                entity.Property(e => e.IdTitulacao).HasColumnName("id_titulacao");
                entity.Property(e => e.IdTppatamar).HasColumnName("id_tppatamar");
                entity.Property(e => e.ValDespacho).HasColumnName("val_despacho");
                entity.Property(e => e.VerControleconcorrencia)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("ver_controleconcorrencia");

                entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithMany(p => p.TbDecisaocomandognls)
                    .HasForeignKey(d => d.IdOrigemcoletamontador)
                    .HasConstraintName("fk_aux_usinamontador_decisaocomandognl");

                entity.HasOne(d => d.IdTitulacaoNavigation).WithMany(p => p.TbDecisaocomandognls)
                    .HasForeignKey(d => d.IdTitulacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_titulacao_decisaocomandognl");

                entity.HasOne(d => d.IdTppatamarNavigation).WithMany(p => p.TbDecisaocomandognls)
                    .HasForeignKey(d => d.IdTppatamar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tppatamar_decisaocomandognl");
            });

            modelBuilder.Entity<DemandaIntegral>(entity =>
            {
                entity.HasKey(e => e.IdDemandaintegral)
                    .HasName("pk_tb_demandaintegral")
                    .IsClustered(false);

                entity.ToTable("tb_demandaintegral");

                entity.HasIndex(e => e.IdConfiguracaogestaomanutencao, "in_fk_configuracaogestaomanutencao_demandaintegral");

                entity.Property(e => e.IdDemandaintegral).HasColumnName("id_demandaintegral");
                entity.Property(e => e.IdConfiguracaogestaomanutencao).HasColumnName("id_configuracaogestaomanutencao");
                entity.Property(e => e.NomCurtosubsistema)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nom_curtosubsistema");
                entity.Property(e => e.NumEstagio).HasColumnName("num_estagio");
                entity.Property(e => e.ValDemandaintegral).HasColumnName("val_demandaintegral");

                entity.HasOne(d => d.IdConfiguracaogestaomanutencaoNavigation).WithMany(p => p.TbDemandaintegrals)
                    .HasForeignKey(d => d.IdConfiguracaogestaomanutencao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_configuracaogestaomanutencao_demandaintegral");
            });

            modelBuilder.Entity<Desligamento>(entity =>
            {
                entity.HasKey(e => e.IdDesligamento).HasName("pk_tb_desligamentos");

                entity.ToTable("tb_desligamentos");

                entity.HasIndex(e => e.IdConjuntogeracaominima, "in_fk_conjuntogeracaominima_desligamentos");

                entity.Property(e => e.IdDesligamento).HasColumnName("id_desligamento");
                entity.Property(e => e.DinFim)
                    .HasColumnType("datetime")
                    .HasColumnName("din_fim");
                entity.Property(e => e.DinInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("din_inicio");
                entity.Property(e => e.DscMotivo)
                    .HasMaxLength(50)
                    .HasColumnName("dsc_motivo");
                entity.Property(e => e.IdConjuntogeracaominima).HasColumnName("id_conjuntogeracaominima");
                entity.Property(e => e.NumIntervencaosgi).HasColumnName("num_intervencaosgi");
                entity.Property(e => e.TpDesligamento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("tp_desligamento");
                entity.Property(e => e.ValGeracaominima).HasColumnName("val_geracaominima");

                entity.HasOne(d => d.IdConjuntogeracaominimaNavigation).WithMany(p => p.TbDesligamentos)
                    .HasForeignKey(d => d.IdConjuntogeracaominima)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_conjuntogeracaominima_desligamentos");
            });

            modelBuilder.Entity<DiaSemana>(entity =>
            {
                entity.HasKey(e => e.IdDiasemana).HasName("pk_tb_diasemana");

                entity.ToTable("tb_diasemana");

                entity.Property(e => e.IdDiasemana).HasColumnName("id_diasemana");
                entity.Property(e => e.DatDiasemana).HasColumnName("dat_diasemana");
                entity.Property(e => e.FlgFeriado).HasColumnName("flg_feriado");
                entity.Property(e => e.FlgTpdiasemana)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("flg_tpdiasemana");
            });

            modelBuilder.Entity<EstadoBlocoEstudoMontador>(entity =>
            {
                entity.HasKey(e => e.IdEstadoblocoestudomontador).HasName("pk_tb_estadoblocoestudomontador");

                entity.ToTable("tb_estadoblocoestudomontador");

                entity.Property(e => e.IdEstadoblocoestudomontador).HasColumnName("id_estadoblocoestudomontador");
                entity.Property(e => e.DscEstadoblocoestudomontador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsc_estadoblocoestudomontador");
                entity.Property(e => e.FlgEscritarecuperacaodados).HasColumnName("flg_escritarecuperacaodados");
            });

            modelBuilder.Entity<EstadoManutencaoPmo>(entity =>
            {
                entity.HasKey(e => e.IdEstadomanutencaopmo)
                    .HasName("pk_tb_estadomanutencaopmo")
                    .IsClustered(false);

                entity.ToTable("tb_estadomanutencaopmo");

                entity.Property(e => e.IdEstadomanutencaopmo).HasColumnName("id_estadomanutencaopmo");
                entity.Property(e => e.DscEstado)
                    .HasMaxLength(20)
                    .HasColumnName("dsc_estado");
            });

            modelBuilder.Entity<EstadoMnemonicoEstudoMontador>(entity =>
            {
                entity.HasKey(e => e.IdEstadomnemonicoestudomontador).HasName("pk_tb_estadomnemonicoestudomontador");

                entity.ToTable("tb_estadomnemonicoestudomontador");

                entity.Property(e => e.IdEstadomnemonicoestudomontador).HasColumnName("id_estadomnemonicoestudomontador");
                entity.Property(e => e.DscEstadomnemonicoestudomontador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsc_estadomnemonicoestudomontador");
                entity.Property(e => e.FlgEscritarecuperacaodados).HasColumnName("flg_escritarecuperacaodados");
            });

            modelBuilder.Entity<EstadoRestricaoEstudoMontador>(entity =>
            {
                entity.HasKey(e => e.IdEstadorestricaoestudomontador).HasName("pk_tb_estadorestricaoestudomontador");

                entity.ToTable("tb_estadorestricaoestudomontador");

                entity.Property(e => e.IdEstadorestricaoestudomontador).HasColumnName("id_estadorestricaoestudomontador");
                entity.Property(e => e.DscEstadorestricaoestudomontador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsc_estadorestricaoestudomontador");
                entity.Property(e => e.FlgEscritarecuperacaodados).HasColumnName("flg_escritarecuperacaodados");
            });

            modelBuilder.Entity<EstagioGrandeza>(entity =>
            {
                entity.HasKey(e => e.IdEstagiograndeza).HasName("pk_tb_estagiograndeza");

                entity.ToTable("tb_estagiograndeza");

                entity.HasIndex(e => e.IdGrandezablocoestudo, "in_fk_grandezablocoestudo_estagiograndeza");

                entity.Property(e => e.IdEstagiograndeza).HasColumnName("id_estagiograndeza");
                entity.Property(e => e.DatFimsemana).HasColumnName("dat_fimsemana");
                entity.Property(e => e.DatIniciosemana).HasColumnName("dat_iniciosemana");
                entity.Property(e => e.IdGrandezablocoestudo).HasColumnName("id_grandezablocoestudo");

                entity.HasOne(d => d.IdGrandezablocoestudoNavigation).WithMany(p => p.TbEstagiograndezas)
                    .HasForeignKey(d => d.IdGrandezablocoestudo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_grandezablocoestudo_estagiograndeza");
            });

            modelBuilder.Entity<EstagioGrandezaMnemonico>(entity =>
            {
                entity.HasKey(e => e.IdEstagiograndezamnemonico).HasName("pk_tb_estagiograndezamnemonico");

                entity.ToTable("tb_estagiograndezamnemonico");

                entity.HasIndex(e => e.IdGrandezamnemonicoestudo, "in_fk_grandezamnemonicoestudo_estagiograndezamnemonico");

                entity.Property(e => e.IdEstagiograndezamnemonico).HasColumnName("id_estagiograndezamnemonico");
                entity.Property(e => e.DatFimsemana).HasColumnName("dat_fimsemana");
                entity.Property(e => e.DatIniciosemana).HasColumnName("dat_iniciosemana");
                entity.Property(e => e.IdGrandezamnemonicoestudo).HasColumnName("id_grandezamnemonicoestudo");
                entity.Property(e => e.NumIndice).HasColumnName("num_indice");

                entity.HasOne(d => d.IdGrandezamnemonicoestudoNavigation).WithMany(p => p.TbEstagiograndezamnemonicos)
                    .HasForeignKey(d => d.IdGrandezamnemonicoestudo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_grandezamnemonicoestudo_estagiograndezamnemonico");
            });

            modelBuilder.Entity<EstudoMontador>(entity =>
            {
                entity.HasKey(e => e.IdEstudomontador).HasName("pk_tb_estudomontador");

                entity.ToTable("tb_estudomontador");

                entity.HasIndex(e => e.IdSemanaoperativa, "in_fk_semanaoperativa_estudomontador");

                entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
                entity.Property(e => e.IdSemanaoperativa).HasColumnName("id_semanaoperativa");

                //entity.HasOne(d => d.IdSemanaoperativaNavigation).WithMany(p => p.TbEstudomontadors)
                //    .HasForeignKey(d => d.IdSemanaoperativa)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("fk_semanaoperativa_estudomontador");

                entity.HasMany(d => d.IdEstudomontadorrefs).WithMany(p => p.IdEstudomontadors)
                    .UsingEntity<Dictionary<string, object>>(
                        "TbEstudomontadorflexibilizado",
                        r => r.HasOne<EstudoMontador>().WithMany()
                            .HasForeignKey("IdEstudomontadorref")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_estudomontador_estudomontadorflexibilizado_ref"),
                        l => l.HasOne<EstudoMontador>().WithMany()
                            .HasForeignKey("IdEstudomontador")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_estudomontador_estudomontadorflexibilizado"),
                        j =>
                        {
                            j.HasKey("IdEstudomontador", "IdEstudomontadorref").HasName("pk_tb_estudomontadorflexibilizado");
                            j.ToTable("tb_estudomontadorflexibilizado");
                            j.HasIndex(new[] { "IdEstudomontador" }, "in_fk_estudomontador_estudomontadorflexibilizado");
                            j.HasIndex(new[] { "IdEstudomontadorref" }, "in_fk_estudomontador_estudomontadorflexibilizado_ref");
                            j.IndexerProperty<int>("IdEstudomontador").HasColumnName("id_estudomontador");
                            j.IndexerProperty<int>("IdEstudomontadorref").HasColumnName("id_estudomontadorref");
                        });

                entity.HasMany(d => d.IdEstudomontadors).WithMany(p => p.IdEstudomontadorrefs)
                    .UsingEntity<Dictionary<string, object>>(
                        "TbEstudomontadorflexibilizado",
                        r => r.HasOne<EstudoMontador>().WithMany()
                            .HasForeignKey("IdEstudomontador")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_estudomontador_estudomontadorflexibilizado"),
                        l => l.HasOne<EstudoMontador>().WithMany()
                            .HasForeignKey("IdEstudomontadorref")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_estudomontador_estudomontadorflexibilizado_ref"),
                        j =>
                        {
                            j.HasKey("IdEstudomontador", "IdEstudomontadorref").HasName("pk_tb_estudomontadorflexibilizado");
                            j.ToTable("tb_estudomontadorflexibilizado");
                            j.HasIndex(new[] { "IdEstudomontador" }, "in_fk_estudomontador_estudomontadorflexibilizado");
                            j.HasIndex(new[] { "IdEstudomontadorref" }, "in_fk_estudomontador_estudomontadorflexibilizado_ref");
                            j.IndexerProperty<int>("IdEstudomontador").HasColumnName("id_estudomontador");
                            j.IndexerProperty<int>("IdEstudomontadorref").HasColumnName("id_estudomontadorref");
                        });
            });

            modelBuilder.Entity<EstudoMontadorNaoOficial>(entity =>
            {
                entity.HasKey(e => e.IdEstudomontador).HasName("pk_tb_estudomontadornaooficial");

                entity.ToTable("tb_estudomontadornaooficial");

                entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_estudomontadornaooficial");

                entity.Property(e => e.IdEstudomontador)
                    .ValueGeneratedNever()
                    .HasColumnName("id_estudomontador");
                entity.Property(e => e.AgeId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("age_id");
                entity.Property(e => e.CodEstudonaooficial)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cod_estudonaooficial");
                entity.Property(e => e.DatFimsemana)
                    .HasColumnType("datetime")
                    .HasColumnName("dat_fimsemana");
                entity.Property(e => e.DatIniciosemana)
                    .HasColumnType("datetime")
                    .HasColumnName("dat_iniciosemana");
                entity.Property(e => e.LgnUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lgn_usuario");
                entity.Property(e => e.NomEstudonaooficial)
                    .HasMaxLength(150)
                    .HasColumnName("nom_estudonaooficial");
                entity.Property(e => e.NumRevisao).HasColumnName("num_revisao");

                entity.HasOne(d => d.IdEstudomontadorNavigation).WithOne(p => p.TbEstudomontadornaooficial)
                    .HasForeignKey<EstudoMontadorNaoOficial>(d => d.IdEstudomontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estudomontador_estudomontadornaooficial");
            });

            modelBuilder.Entity<EstudoSelecionado>(entity =>
            {
                entity.HasKey(e => e.IdUsuario).HasName("pk_tb_estudoselecionado");

                entity.ToTable("tb_estudoselecionado");

                entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_estudoselecionado");

                entity.Property(e => e.IdUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("id_usuario");
                entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");

                entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbEstudoselecionados)
                    .HasForeignKey(d => d.IdEstudomontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estudomontador_estudoselecionado");
            });

            modelBuilder.Entity<ExportacaoArquivoTexto>(entity =>
            {
                entity.HasKey(e => e.IdExportacaoarquivotexto).HasName("pk_tb_exportacaoarquivotexto");

                entity.ToTable("tb_exportacaoarquivotexto");

                entity.HasIndex(e => e.IdArquivoexportacao, "in_fk_arquivoexportacao_exportacaoarquivotexto");

                entity.HasIndex(e => e.IdSemanaoperativa, "in_fk_semanaoperativa_exportacaoarquivotexto");

                entity.Property(e => e.IdExportacaoarquivotexto).HasColumnName("id_exportacaoarquivotexto");
                entity.Property(e => e.CodHash)
                    .HasMaxLength(200)
                    .HasColumnName("cod_hash");
                entity.Property(e => e.DinExportacao)
                    .HasColumnType("datetime")
                    .HasColumnName("din_exportacao");
                entity.Property(e => e.IdArquivoexportacao).HasColumnName("id_arquivoexportacao");
                entity.Property(e => e.IdSemanaoperativa).HasColumnName("id_semanaoperativa");
                entity.Property(e => e.LgnExportacao)
                    .HasMaxLength(50)
                    .HasColumnName("lgn_exportacao");
                entity.Property(e => e.NomArquivotexto)
                    .HasMaxLength(50)
                    .HasColumnName("nom_arquivotexto");

                entity.HasOne(d => d.IdArquivoexportacaoNavigation).WithMany(p => p.TbExportacaoarquivotextos)
                    .HasForeignKey(d => d.IdArquivoexportacao)
                    .HasConstraintName("fk_arquivoexportacao_exportacaoarquivotexto");

                //entity.HasOne(d => d.IdSemanaoperativaNavigation).WithMany(p => p.TbExportacaoarquivotextos)
                //    .HasForeignKey(d => d.IdSemanaoperativa)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("fk_semanaoperativa_exportacaoarquivotexto");
            });

            modelBuilder.Entity<FonteOrigem>(entity =>
            {
                entity.HasKey(e => e.IdFonteorigem).HasName("pk_tb_fonteorigem");

                entity.ToTable("tb_fonteorigem");

                entity.Property(e => e.IdFonteorigem).HasColumnName("id_fonteorigem");
                entity.Property(e => e.FlgEletrica).HasColumnName("flg_eletrica");
                entity.Property(e => e.FlgHidraulica).HasColumnName("flg_hidraulica");
                entity.Property(e => e.NomFonteorigem)
                    .HasMaxLength(20)
                    .HasColumnName("nom_fonteorigem");
            });

            modelBuilder.Entity<Gabarito>(entity =>
            {
                entity.HasKey(e => e.IdGabarito).HasName("pk_tb_gabarito");

                entity.ToTable("tb_gabarito");

                entity.HasIndex(e => e.IdAgenteInstituicao, "in_fk_agenteinstituicao_gabarito").HasFillFactor(90);

                entity.HasIndex(e => e.IdInsumopmo, "in_fk_insumopmo_gabarito").HasFillFactor(90);

                entity.HasIndex(e => e.IdOrigemcoleta, "in_fk_origemcoleta_gabarito").HasFillFactor(90);

                entity.HasIndex(e => e.IdSemanaoperativa, "in_fk_semanaoperativa_gabarito").HasFillFactor(90);

                entity.Property(e => e.IdGabarito).HasColumnName("id_gabarito");
                entity.Property(e => e.CodPerfilons)
                    .HasMaxLength(30)
                    .HasColumnName("cod_perfilons");
                entity.Property(e => e.FlgPadrao).HasColumnName("flg_padrao");
                entity.Property(e => e.IdAgenteInstituicao).HasColumnName("id_agenteinstituicao");
                entity.Property(e => e.IdInsumopmo).HasColumnName("id_insumopmo");
                entity.Property(e => e.IdOrigemcoleta)
                    .HasMaxLength(50)
                    .HasColumnName("id_origemcoleta");
                entity.Property(e => e.IdSemanaoperativa).HasColumnName("id_semanaoperativa");
                entity.Property(e => e.VerControleconcorrencia)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("ver_controleconcorrencia");

                entity.HasOne(d => d.IdAgenteinstituicaoNavigation).WithMany(p => p.TbGabaritos)
                    .HasForeignKey(d => d.IdAgenteInstituicao)
                    .HasConstraintName("fk_agenteinstituicao_gabarito");

                entity.HasOne(d => d.IdInsumopmoNavigation).WithMany(p => p.TbGabaritos)
                    .HasForeignKey(d => d.IdInsumopmo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_insumopmo_gabarito");

                entity.HasOne(d => d.IdOrigemcoletaNavigation).WithMany(p => p.TbGabaritos)
                    .HasForeignKey(d => d.IdOrigemcoleta)
                    .HasConstraintName("fk_origemcoleta_gabarito");

                entity.HasOne(d => d.IdSemanaoperativaNavigation).WithMany(p => p.TbGabaritos)
                    .HasForeignKey(d => d.IdSemanaoperativa)
                    .HasConstraintName("fk_semanaoperativa_gabarito");
            });

            modelBuilder.Entity<GeracaoMinimaPeriodoDia>(entity =>
            {
                entity.HasKey(e => e.IdGeracaominimaperiododia).HasName("pk_tb_geracaominima");

                entity.ToTable("tb_geracaominimaperiododia");

                entity.HasIndex(e => e.IdConjuntogeracaominima, "in_fk_conjuntogeracaominima_geracaominima");

                entity.HasIndex(e => e.IdDiasemana, "in_fk_diasemana_geracaominima");

                entity.HasIndex(e => e.IdTppatamar, "in_fk_tppatamar_geracaominima");

                entity.Property(e => e.IdGeracaominimaperiododia).HasColumnName("id_geracaominimaperiododia");
                entity.Property(e => e.HorFinal).HasColumnName("hor_final");
                entity.Property(e => e.HorInicial).HasColumnName("hor_inicial");
                entity.Property(e => e.IdConjuntogeracaominima).HasColumnName("id_conjuntogeracaominima");
                entity.Property(e => e.IdDiasemana).HasColumnName("id_diasemana");
                entity.Property(e => e.IdTppatamar).HasColumnName("id_tppatamar");
                entity.Property(e => e.ValGeracaominimaperiododia).HasColumnName("val_geracaominimaperiododia");

                entity.HasOne(d => d.IdConjuntogeracaominimaNavigation).WithMany(p => p.TbGeracaominimaperiododia)
                    .HasForeignKey(d => d.IdConjuntogeracaominima)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_conjuntogeracaominima_geracaominima");

                entity.HasOne(d => d.IdDiasemanaNavigation).WithMany(p => p.TbGeracaominimaperiododia)
                    .HasForeignKey(d => d.IdDiasemana)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_diasemana_geracaominima");

                entity.HasOne(d => d.IdTppatamarNavigation).WithMany(p => p.TbGeracaominimaperiododia)
                    .HasForeignKey(d => d.IdTppatamar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tppatamar_geracaominima");
            });

            modelBuilder.Entity<GeracaoPequenasUsina>(entity =>
            {
                entity.HasKey(e => e.IdGeracaopequenasusinas).HasName("pk_tb_geracaopequenasusinas");

                entity.ToTable("tb_geracaopequenasusinas");

                entity.HasIndex(e => e.IdConfiguracaogestaomanutencao, "in_fk_configuracaogestaomanutencao_geracaopequenasusinas");

                entity.Property(e => e.IdGeracaopequenasusinas).HasColumnName("id_geracaopequenasusinas");
                entity.Property(e => e.IdConfiguracaogestaomanutencao).HasColumnName("id_configuracaogestaomanutencao");
                entity.Property(e => e.NomCurtosubsistema)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nom_curtosubsistema");
                entity.Property(e => e.ValGeracaopequenasusinas).HasColumnName("val_geracaopequenasusinas");

                entity.HasOne(d => d.IdConfiguracaogestaomanutencaoNavigation).WithMany(p => p.TbGeracaopequenasusinas)
                    .HasForeignKey(d => d.IdConfiguracaogestaomanutencao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_configuracaogestaomanutencao_geracaopequenasusinas");
            });

            modelBuilder.Entity<GeracaoTermica>(entity =>
            {
                entity.HasKey(e => e.IdGeracaotermicas).HasName("pk_tb_geracaotermicas");

                entity.ToTable("tb_geracaotermicas");

                entity.HasIndex(e => e.IdConfiguracaogestaomanutencao, "in_fk_configuracaogestaomanutencao_geracaotermicas");

                entity.Property(e => e.IdGeracaotermicas).HasColumnName("id_geracaotermicas");
                entity.Property(e => e.IdConfiguracaogestaomanutencao).HasColumnName("id_configuracaogestaomanutencao");
                entity.Property(e => e.NomCurtosubmercado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nom_curtosubmercado");
                entity.Property(e => e.NomCurtosubsistema)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nom_curtosubsistema");
                entity.Property(e => e.NumEstagio).HasColumnName("num_estagio");
                entity.Property(e => e.ValGeracaotermicas).HasColumnName("val_geracaotermicas");

                entity.HasOne(d => d.IdConfiguracaogestaomanutencaoNavigation).WithMany(p => p.TbGeracaotermicas)
                    .HasForeignKey(d => d.IdConfiguracaogestaomanutencao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_configuracaogestaomanutencao_geracaotermicas");
            });

            modelBuilder.Entity<Grandeza>(entity =>
            {
                entity.HasKey(e => e.IdGrandeza).HasName("pk_tb_grandeza");

                entity.ToTable("tb_grandeza");

                entity.HasIndex(e => e.IdInsumopmo, "in_fk_insumoestruturado_grandeza").HasFillFactor(90);

                entity.HasIndex(e => e.IdTpdadograndeza, "in_fk_tpdadograndeza_grandeza").HasFillFactor(90);

                entity.Property(e => e.IdGrandeza).HasColumnName("id_grandeza");
                entity.Property(e => e.FlgAceitavalornegativo).HasColumnName("flg_aceitavalornegativo");
                entity.Property(e => e.FlgAtivo)
                    .HasDefaultValue(true)
                    .HasColumnName("flg_ativo");
                entity.Property(e => e.FlgColetaporestagio).HasColumnName("flg_coletaporestagio");
                entity.Property(e => e.FlgColetaporlimite).HasColumnName("flg_coletaporlimite");
                entity.Property(e => e.FlgColetaporpatamar).HasColumnName("flg_coletaporpatamar");
                entity.Property(e => e.FlgDestacadiferenca).HasColumnName("flg_destacadiferenca");
                entity.Property(e => e.FlgObrigatoriedade)
                    .HasDefaultValue(false)
                    .HasColumnName("flg_obrigatoriedade");
                entity.Property(e => e.FlgParticipablocomontador)
                    .HasDefaultValue(false)
                    .HasColumnName("flg_participablocomontador");
                entity.Property(e => e.FlgPoderecuperarvalor).HasColumnName("flg_poderecuperarvalor");
                entity.Property(e => e.FlgPreaprovadocomalteracao).HasColumnName("flg_preaprovadocomalteracao");
                entity.Property(e => e.IdInsumopmo).HasColumnName("id_insumopmo");
                entity.Property(e => e.IdTpdadograndeza).HasColumnName("id_tpdadograndeza");
                entity.Property(e => e.NomGrandeza)
                    .HasMaxLength(150)
                    .HasColumnName("nom_grandeza");
                entity.Property(e => e.NumOrdemblocomontador).HasColumnName("num_ordemblocomontador");
                entity.Property(e => e.NumOrdemexibicao).HasColumnName("num_ordemexibicao");
                entity.Property(e => e.QtdDecimais).HasColumnName("qtd_decimais");
                entity.Property(e => e.QtdDigitos).HasColumnName("qtd_digitos");

                entity.HasOne(d => d.IdInsumopmoNavigation).WithMany(p => p.TbGrandezas)
                    .HasForeignKey(d => d.IdInsumopmo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_insumoestruturado_grandeza");

                entity.HasOne(d => d.IdTpdadograndezaNavigation).WithMany(p => p.TbGrandezas)
                    .HasForeignKey(d => d.IdTpdadograndeza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tpdadograndeza_grandeza");
            });

            modelBuilder.Entity<GrandezaBloco>(entity =>
            {
                entity.HasKey(e => e.IdGrandezamontador).HasName("pk_tb_grandezabloco");

                entity.ToTable("tb_grandezabloco");

                entity.HasIndex(e => e.IdBloco, "in_fk_bloco_grandezabloco");

                entity.HasIndex(e => e.IdGrandeza, "in_fk_grandeza_grandezabloco");

                entity.HasIndex(e => e.IdGrandezamontadorref, "in_fk_grandezabloco_grandezabloco");

                entity.HasIndex(e => e.IdGrandezamontador, "in_fk_grandezamontador_grandezabloco");

                entity.Property(e => e.IdGrandezamontador)
                    .ValueGeneratedNever()
                    .HasColumnName("id_grandezamontador");
                entity.Property(e => e.FlgColetapormeses).HasColumnName("flg_coletapormeses");
                entity.Property(e => e.FlgColetaporsemanas).HasColumnName("flg_coletaporsemanas");
                entity.Property(e => e.FlgQuebraestagio).HasColumnName("flg_quebraestagio");
                entity.Property(e => e.IdBloco).HasColumnName("id_bloco");
                entity.Property(e => e.IdGrandeza).HasColumnName("id_grandeza");
                entity.Property(e => e.IdGrandezamontadorref).HasColumnName("id_grandezamontadorref");

                entity.HasOne(d => d.IdBlocoNavigation).WithMany(p => p.TbGrandezablocos)
                    .HasForeignKey(d => d.IdBloco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_bloco_grandezabloco");

                entity.HasOne(d => d.IdGrandezaNavigation).WithMany(p => p.TbGrandezablocos)
                    .HasForeignKey(d => d.IdGrandeza)
                    .HasConstraintName("fk_grandeza_grandezabloco");

                entity.HasOne(d => d.IdGrandezamontadorNavigation).WithOne(p => p.TbGrandezabloco)
                    .HasForeignKey<GrandezaBloco>(d => d.IdGrandezamontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_grandezamontador_grandezabloco");

                entity.HasOne(d => d.IdGrandezamontadorrefNavigation).WithMany(p => p.InverseIdGrandezamontadorrefNavigation)
                    .HasForeignKey(d => d.IdGrandezamontadorref)
                    .HasConstraintName("fk_grandezabloco_grandezabloco");
            });

            modelBuilder.Entity<GrandezaBlocoAC>(entity =>
            {
                entity.HasKey(e => e.IdGrandezamontador).HasName("pk_tb_grandezablocoac");

                entity.ToTable("tb_grandezablocoac");

                entity.HasIndex(e => e.IdGrandezamontador, "in_fk_grandezamontador_grandezablocoac");

                entity.HasIndex(e => e.IdMnemonicoblocoac, "in_fk_mnemonicoblocoac_grandezablocoac");

                entity.Property(e => e.IdGrandezamontador)
                    .ValueGeneratedNever()
                    .HasColumnName("id_grandezamontador");
                entity.Property(e => e.IdMnemonicoblocoac).HasColumnName("id_mnemonicoblocoac");
                entity.Property(e => e.ValColfinal).HasColumnName("val_colfinal");
                entity.Property(e => e.ValColinicial).HasColumnName("val_colinicial");

                entity.HasOne(d => d.IdGrandezamontadorNavigation).WithOne(p => p.TbGrandezablocoac)
                    .HasForeignKey<GrandezaBlocoAC>(d => d.IdGrandezamontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_grandezamontador_grandezablocoac");

                entity.HasOne(d => d.IdMnemonicoblocoacNavigation).WithMany(p => p.TbGrandezablocoacs)
                    .HasForeignKey(d => d.IdMnemonicoblocoac)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mnemonicoblocoac_grandezablocoac");

                entity.HasMany(d => d.IdGrandezamontadordependentes).WithMany(p => p.IdGrandezamontadors)
                    .UsingEntity<Dictionary<string, object>>(
                        "TbGrandezablocoacdependente",
                        r => r.HasOne<GrandezaBlocoAC>().WithMany()
                            .HasForeignKey("IdGrandezamontadordependente")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_grandezablocoac_grandezablocoacdependente_dependente"),
                        l => l.HasOne<GrandezaBlocoAC>().WithMany()
                            .HasForeignKey("IdGrandezamontador")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_grandezablocoac_grandezablocoacdependente_montador"),
                        j =>
                        {
                            j.HasKey("IdGrandezamontador", "IdGrandezamontadordependente").HasName("pk_tb_grandezablocoacdependente");
                            j.ToTable("tb_grandezablocoacdependente");
                            j.HasIndex(new[] { "IdGrandezamontadordependente" }, "in_fk_grandezablocoac_grandezablocoacdependente_dependente");
                            j.HasIndex(new[] { "IdGrandezamontador" }, "in_fk_grandezablocoac_grandezablocoacdependente_montador");
                            j.IndexerProperty<int>("IdGrandezamontador").HasColumnName("id_grandezamontador");
                            j.IndexerProperty<int>("IdGrandezamontadordependente").HasColumnName("id_grandezamontadordependente");
                        });

                entity.HasMany(d => d.IdGrandezamontadors).WithMany(p => p.IdGrandezamontadordependentes)
                    .UsingEntity<Dictionary<string, object>>(
                        "TbGrandezablocoacdependente",
                        r => r.HasOne<GrandezaBlocoAC>().WithMany()
                            .HasForeignKey("IdGrandezamontador")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_grandezablocoac_grandezablocoacdependente_montador"),
                        l => l.HasOne<GrandezaBlocoAC>().WithMany()
                            .HasForeignKey("IdGrandezamontadordependente")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_grandezablocoac_grandezablocoacdependente_dependente"),
                        j =>
                        {
                            j.HasKey("IdGrandezamontador", "IdGrandezamontadordependente").HasName("pk_tb_grandezablocoacdependente");
                            j.ToTable("tb_grandezablocoacdependente");
                            j.HasIndex(new[] { "IdGrandezamontadordependente" }, "in_fk_grandezablocoac_grandezablocoacdependente_dependente");
                            j.HasIndex(new[] { "IdGrandezamontador" }, "in_fk_grandezablocoac_grandezablocoacdependente_montador");
                            j.IndexerProperty<int>("IdGrandezamontador").HasColumnName("id_grandezamontador");
                            j.IndexerProperty<int>("IdGrandezamontadordependente").HasColumnName("id_grandezamontadordependente");
                        });
            });

            modelBuilder.Entity<GrandezaBlocoEstudo>(entity =>
            {
                entity.HasKey(e => e.IdGrandezablocoestudo).HasName("pk_tb_grandezablocoestudo");

                entity.ToTable("tb_grandezablocoestudo");

                entity.HasIndex(e => e.IdColunagrandeza, "in_fk_colunagrandeza_grandezablocoestudo");

                entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_grandezablocoestudo");

                entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_grandezablocoestudo");

                entity.HasIndex(e => e.IdRestricao, "in_fk_restricao_grandezablocoestudo");

                entity.Property(e => e.IdGrandezablocoestudo).HasColumnName("id_grandezablocoestudo");
                entity.Property(e => e.FlgFonte)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("flg_fonte");
                entity.Property(e => e.FlgNormalizado).HasColumnName("flg_normalizado");
                entity.Property(e => e.IdColunagrandeza).HasColumnName("id_colunagrandeza");
                entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
                entity.Property(e => e.IdOrigemcoletamontador).HasColumnName("id_origemcoletamontador");
                entity.Property(e => e.IdRestricao).HasColumnName("id_restricao");
                entity.Property(e => e.ValGrandezablocoestudo)
                    .HasMaxLength(500)
                    .HasColumnName("val_grandezablocoestudo");
                entity.Property(e => e.ValGrandezablocoestudooriginal)
                    .HasMaxLength(500)
                    .HasColumnName("val_grandezablocoestudooriginal");

                entity.HasOne(d => d.IdColunagrandezaNavigation).WithMany(p => p.TbGrandezablocoestudos)
                    .HasForeignKey(d => d.IdColunagrandeza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_colunagrandeza_grandezablocoestudo");

                entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbGrandezablocoestudos)
                    .HasForeignKey(d => d.IdEstudomontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estudomontador_grandezablocoestudo");

                entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithMany(p => p.TbGrandezablocoestudos)
                    .HasForeignKey(d => d.IdOrigemcoletamontador)
                    .HasConstraintName("fk_origemcoletamontador_grandezablocoestudo");

                entity.HasOne(d => d.IdRestricaoNavigation).WithMany(p => p.TbGrandezablocoestudos)
                    .HasForeignKey(d => d.IdRestricao)
                    .HasConstraintName("fk_restricao_grandezablocoestudo");
            });

            modelBuilder.Entity<GrandezaMnemonicoEstudo>(entity =>
            {
                entity.HasKey(e => e.IdGrandezamnemonicoestudo).HasName("pk_tb_grandezamnemonicoestudo");

                entity.ToTable("tb_grandezamnemonicoestudo");

                entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_grandezamnemonicoestudo");

                entity.HasIndex(e => e.IdGrandezamontador, "in_fk_grandezablocoac_grandezamnemonicoestudo");

                entity.HasIndex(e => e.IdMotivoalteracao, "in_fk_motivoalteracao_grandezamnemonicoestudo");

                entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_grandezamnemonicoestudo");

                entity.Property(e => e.IdGrandezamnemonicoestudo).HasColumnName("id_grandezamnemonicoestudo");
                entity.Property(e => e.FlgFonte)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("flg_fonte");
                entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
                entity.Property(e => e.IdGrandezamontador).HasColumnName("id_grandezamontador");
                entity.Property(e => e.IdMotivoalteracao).HasColumnName("id_motivoalteracao");
                entity.Property(e => e.IdOrigemcoletamontador).HasColumnName("id_origemcoletamontador");
                entity.Property(e => e.ValGrandezamnemonicoestudo)
                    .HasMaxLength(300)
                    .HasColumnName("val_grandezamnemonicoestudo");

                entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbGrandezamnemonicoestudos)
                    .HasForeignKey(d => d.IdEstudomontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estudomontador_grandezamnemonicoestudo");

                entity.HasOne(d => d.IdGrandezamontadorNavigation).WithMany(p => p.TbGrandezamnemonicoestudos)
                    .HasForeignKey(d => d.IdGrandezamontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_grandezablocoac_grandezamnemonicoestudo");

                entity.HasOne(d => d.IdMotivoalteracaoNavigation).WithMany(p => p.TbGrandezamnemonicoestudos)
                    .HasForeignKey(d => d.IdMotivoalteracao)
                    .HasConstraintName("fk_motivoalteracao_grandezamnemonicoestudo");

                entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithMany(p => p.TbGrandezamnemonicoestudos)
                    .HasForeignKey(d => d.IdOrigemcoletamontador)
                    .HasConstraintName("fk_origemcoletamontador_grandezamnemonicoestudo");
            });

            modelBuilder.Entity<GrandezaMontador>(entity =>
            {
                entity.HasKey(e => e.IdGrandezamontador).HasName("pk_tb_grandezamontador");

                entity.ToTable("tb_grandezamontador");

                entity.HasIndex(e => e.IdTpdadograndeza, "in_fk_tpdadograndeza_grandezamontador");

                entity.Property(e => e.IdGrandezamontador).HasColumnName("id_grandezamontador");
                entity.Property(e => e.CodGrandezamontador)
                    .HasMaxLength(20)
                    .HasColumnName("cod_grandezamontador");
                entity.Property(e => e.DscGrandezamontador)
                    .HasMaxLength(150)
                    .HasColumnName("dsc_grandezamontador");
                entity.Property(e => e.FlgAceitavalornegativo).HasColumnName("flg_aceitavalornegativo");
                entity.Property(e => e.FlgAtivo)
                    .HasDefaultValue(true)
                    .HasColumnName("flg_ativo");
                entity.Property(e => e.FlgComentario).HasColumnName("flg_comentario");
                entity.Property(e => e.FlgDecimaisexatos).HasColumnName("flg_decimaisexatos");
                entity.Property(e => e.FlgMotivoalteracao).HasColumnName("flg_motivoalteracao");
                entity.Property(e => e.FlgObrigatorio).HasColumnName("flg_obrigatorio");
                entity.Property(e => e.FlgRecuperaestudos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("flg_recuperaestudos");
                entity.Property(e => e.IdTpdadograndeza).HasColumnName("id_tpdadograndeza");
                entity.Property(e => e.NomGrandezamontador)
                    .HasMaxLength(150)
                    .HasColumnName("nom_grandezamontador");
                entity.Property(e => e.QtdDecimais).HasColumnName("qtd_decimais");
                entity.Property(e => e.QtdDigitos).HasColumnName("qtd_digitos");

                entity.HasOne(d => d.IdTpdadograndezaNavigation).WithMany(p => p.TbGrandezamontadors)
                    .HasForeignKey(d => d.IdTpdadograndeza)
                    .HasConstraintName("fk_tpdadograndeza_grandezamontador");
            });

            modelBuilder.Entity<HistoricoConfiguracaoBloco>(entity =>
            {
                entity.HasKey(e => e.IdModifconfigblocoestudo).HasName("pk_tb_hisconfigbloco");

                entity.ToTable("tb_hisconfigbloco");

                entity.HasIndex(e => e.IdModifconfigblocoestudo, "in_fk_modifconfigblocoestudo_hisconfigbloco");

                entity.Property(e => e.IdModifconfigblocoestudo)
                    .ValueGeneratedNever()
                    .HasColumnName("id_modifconfigblocoestudo");
                entity.Property(e => e.DscCabecalho).HasColumnName("dsc_cabecalho");
                entity.Property(e => e.FlgProximoestudo).HasColumnName("flg_proximoestudo");

                entity.HasOne(d => d.IdModifconfigblocoestudoNavigation).WithOne(p => p.TbHisconfigbloco)
                    .HasForeignKey<HistoricoConfiguracaoBloco>(d => d.IdModifconfigblocoestudo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_modifconfigblocoestudo_hisconfigbloco");
            });

            modelBuilder.Entity<HistoricoConfiguracaoGrandeza>(entity =>
            {
                entity.HasKey(e => new { e.IdModifconfigblocoestudo, e.IdGrandezamontador }).HasName("pk_tb_hisconfiggrandeza");

                entity.ToTable("tb_hisconfiggrandeza");

                entity.HasIndex(e => e.IdGrandezamontador, "in_fk_grandezamontador_hisconfiggrandeza");

                entity.HasIndex(e => e.IdModifconfigblocoestudo, "in_fk_modifconfigblocoestudo_hisconfiggrandeza");

                entity.Property(e => e.IdModifconfigblocoestudo).HasColumnName("id_modifconfigblocoestudo");
                entity.Property(e => e.IdGrandezamontador).HasColumnName("id_grandezamontador");
                entity.Property(e => e.FlgProximoestudo).HasColumnName("flg_proximoestudo");

                entity.HasOne(d => d.IdGrandezamontadorNavigation).WithMany(p => p.TbHisconfiggrandezas)
                    .HasForeignKey(d => d.IdGrandezamontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_grandezamontador_hisconfiggrandeza");

                entity.HasOne(d => d.IdModifconfigblocoestudoNavigation).WithMany(p => p.TbHisconfiggrandezas)
                    .HasForeignKey(d => d.IdModifconfigblocoestudo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_modifconfigblocoestudo_hisconfiggrandeza");
            });

            modelBuilder.Entity<HistoricoModificacaoColetaInsumo>(entity =>
            {
                entity.HasKey(e => e.IdHistmodifcoletainsumo).HasName("pk_tb_histmodifcoletainsumo");

                entity.ToTable("tb_histmodifcoletainsumo");

                entity.HasIndex(e => e.IdColetainsumo, "in_fk_coletainsumo_histmodifcoletainsumo").HasFillFactor(90);

                entity.HasIndex(e => e.IdTpsituacaocoletainsumo, "in_fk_tpsituacaocoletainsumo_histmodifcoletainsumo").HasFillFactor(90);

                entity.Property(e => e.IdHistmodifcoletainsumo).HasColumnName("id_histmodifcoletainsumo");
                entity.Property(e => e.DinHistmodifcoletainsumo)
                    .HasColumnType("datetime")
                    .HasColumnName("din_histmodifcoletainsumo");
                entity.Property(e => e.IdColetainsumo).HasColumnName("id_coletainsumo");
                entity.Property(e => e.IdTpsituacaocoletainsumo).HasColumnName("id_tpsituacaocoletainsumo");

                entity.HasOne(d => d.IdColetainsumoNavigation).WithMany(p => p.TbHistmodifcoletainsumos)
                    .HasForeignKey(d => d.IdColetainsumo)
                    .HasConstraintName("fk_coletainsumo_histmodifcoletainsumo");

                entity.HasOne(d => d.IdTpsituacaocoletainsumoNavigation).WithMany(p => p.TbHistmodifcoletainsumos)
                    .HasForeignKey(d => d.IdTpsituacaocoletainsumo)
                    .HasConstraintName("fk_tpsituacaocoletainsumo_histmodifcoletainsumo");
            });

            modelBuilder.Entity<HistoricoModificacaoSemanaOperativa>(entity =>
            {
                entity.HasKey(e => e.IdHistmodifsemanaoper).HasName("pk_tb_histmodifsemanaoper");

                entity.ToTable("tb_histmodifsemanaoper");

                entity.HasIndex(e => e.IdSemanaoperativa, "in_fk_semanaoperativa_histmodifsemanaoper").HasFillFactor(90);

                entity.HasIndex(e => e.IdTpsituacaosemanaoper, "in_fk_tpsituacaosemanaoper_histmodifsemanaoper").HasFillFactor(90);

                entity.Property(e => e.IdHistmodifsemanaoper).HasColumnName("id_histmodifsemanaoper");
                entity.Property(e => e.DinHistmodifsemanaoper)
                    .HasColumnType("datetime")
                    .HasColumnName("din_histmodifsemanaoper");
                entity.Property(e => e.IdSemanaoperativa).HasColumnName("id_semanaoperativa");
                entity.Property(e => e.IdTpsituacaosemanaoper).HasColumnName("id_tpsituacaosemanaoper");

                //entity.HasOne(d => d.IdSemanaoperativaNavigation).WithMany(p => p.TbHistmodifsemanaopers)
                //    .HasForeignKey(d => d.IdSemanaoperativa)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("fk_semanaoperativa_histmodifsemanaoper");

                entity.HasOne(d => d.IdTpsituacaosemanaoperNavigation).WithMany(p => p.TbHistmodifsemanaopers)
                    .HasForeignKey(d => d.IdTpsituacaosemanaoper)
                    .HasConstraintName("fk_tpsituacaosemanaoper_histmodifsemanaoper");
            });

            modelBuilder.Entity<ImportacaoPmo>(entity =>
            {
                entity.HasKey(e => e.IdImportacaopmo).HasName("pk_tb_importacaopmo");

                entity.ToTable("tb_importacaopmo");

                entity.HasIndex(e => e.IdSemanaoperativa, "in_fk_semanaoperativa_importacaopmo");

                entity.HasIndex(e => e.IdTpimportacaopmo, "in_fk_tpimportacaopmo_importacaopmo");

                entity.Property(e => e.IdImportacaopmo).HasColumnName("id_importacaopmo");
                entity.Property(e => e.DinImportacao)
                    .HasColumnType("datetime")
                    .HasColumnName("din_importacao");
                entity.Property(e => e.DinUltimaalteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("din_ultimaalteracao");
                entity.Property(e => e.FlgProcessando).HasColumnName("flg_processando");
                entity.Property(e => e.IdSemanaoperativa).HasColumnName("id_semanaoperativa");
                entity.Property(e => e.IdTpimportacaopmo).HasColumnName("id_tpimportacaopmo");
                entity.Property(e => e.NomUsuarioultimaalteracao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nom_usuarioultimaalteracao");

                //entity.HasOne(d => d.IdSemanaoperativaNavigation).WithMany(p => p.TbImportacaopmos)
                //    .HasForeignKey(d => d.IdSemanaoperativa)
                //    .HasConstraintName("fk_semanaoperativa_importacaopmo");

                entity.HasOne(d => d.IdTpimportacaopmoNavigation).WithMany(p => p.TbImportacaopmos)
                    .HasForeignKey(d => d.IdTpimportacaopmo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tpimportacaopmo_importacaopmo");
            });

            modelBuilder.Entity<InsumoEstruturado>(entity =>
            {
                entity.HasKey(e => e.IdInsumopmo).HasName("pk_tb_insumoestruturado");

                entity.ToTable("tb_insumoestruturado");

                entity.HasIndex(e => e.IdInsumopmo, "in_fk_insumopmo_insumoestruturado").HasFillFactor(90);

                entity.HasIndex(e => e.IdTpcategoriainsumo, "in_fk_tpcategoriainsumo_insumoestruturado").HasFillFactor(90);

                entity.HasIndex(e => e.IdTpcoleta, "in_fk_tpcoleta_insumoestruturado").HasFillFactor(90);

                entity.Property(e => e.IdInsumopmo)
                    .ValueGeneratedNever()
                    .HasColumnName("id_insumopmo");
                entity.Property(e => e.IdTpcategoriainsumo).HasColumnName("id_tpcategoriainsumo");
                entity.Property(e => e.IdTpcoleta).HasColumnName("id_tpcoleta");
                entity.Property(e => e.NumOrdemblocomontador).HasColumnName("num_ordemblocomontador");
                entity.Property(e => e.QtdMesesadiante).HasColumnName("qtd_mesesadiante");
                entity.Property(e => e.TipBlocomontador)
                    .HasMaxLength(6)
                    .HasColumnName("tip_blocomontador");

                entity.HasOne(d => d.IdInsumopmoNavigation).WithOne(p => p.TbInsumoestruturado)
                    .HasForeignKey<InsumoEstruturado>(d => d.IdInsumopmo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_insumopmo_insumoestruturado");

                entity.HasOne(d => d.IdTpcategoriainsumoNavigation).WithMany(p => p.TbInsumoestruturados)
                    .HasForeignKey(d => d.IdTpcategoriainsumo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tpcategoriainsumo_insumoestruturado");

                entity.HasOne(d => d.IdTpcoletaNavigation).WithMany(p => p.TbInsumoestruturados)
                    .HasForeignKey(d => d.IdTpcoleta)
                    .HasConstraintName("fk_tpcoleta_insumoestruturado");
            });

            modelBuilder.Entity<InsumoNaoEstruturado>(entity =>
            {
                entity.HasKey(e => e.IdInsumopmo).HasName("pk_tb_insumonaoestruturado");

                entity.ToTable("tb_insumonaoestruturado");

                entity.HasIndex(e => e.IdInsumopmo, "in_fk_insumopmo_insumonaoestruturado").HasFillFactor(90);

                entity.Property(e => e.IdInsumopmo)
                    .ValueGeneratedNever()
                    .HasColumnName("id_insumopmo");
                entity.Property(e => e.FlgUtilizadoconvergencia).HasColumnName("flg_utilizadoconvergencia");
                entity.Property(e => e.FlgUtilizadodecomp).HasColumnName("flg_utilizadodecomp");
                entity.Property(e => e.FlgUtilizadoprocessamento).HasColumnName("flg_utilizadoprocessamento");
                entity.Property(e => e.FlgUtilizadopublicacao).HasColumnName("flg_utilizadopublicacao");

                entity.HasOne(d => d.IdInsumopmoNavigation).WithOne(p => p.TbInsumonaoestruturado)
                    .HasForeignKey<InsumoNaoEstruturado>(d => d.IdInsumopmo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_insumopmo_insumonaoestruturado");
            });

            modelBuilder.Entity<InsumoPMO>(entity =>
            {
                entity.HasKey(e => e.IdInsumopmo).HasName("pk_tb_insumopmo");

                entity.ToTable("tb_insumopmo");

                entity.Property(e => e.IdInsumopmo).HasColumnName("id_insumopmo");
                entity.Property(e => e.DinUltimaalteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("din_ultimaalteracao");
                entity.Property(e => e.FlgAtivo)
                    .HasDefaultValue(true)
                    .HasColumnName("flg_ativo");
                entity.Property(e => e.FlgExportainsumo).HasColumnName("flg_exportainsumo");
                entity.Property(e => e.FlgPreaprovado).HasColumnName("flg_preaprovado");
                entity.Property(e => e.FlgReservado).HasColumnName("flg_reservado");
                entity.Property(e => e.NomInsumopmo)
                    .HasMaxLength(150)
                    .HasColumnName("nom_insumopmo");
                entity.Property(e => e.NumOrdemexibicao).HasColumnName("num_ordemexibicao");
                entity.Property(e => e.SglInsumo)
                    .HasMaxLength(10)
                    .HasDefaultValue("-")
                    .HasColumnName("sgl_insumo");
                entity.Property(e => e.TipInsumopmo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("tip_insumopmo");
                entity.Property(e => e.VerControleconcorrencia)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("ver_controleconcorrencia");
            });

            modelBuilder.Entity<IntervencaoSGI>(entity =>
            {
                entity.HasKey(e => e.IdIntervencaosgi).HasName("pk_tb_intervencaosgi");

                entity.ToTable("tb_intervencaosgi");

                entity.Property(e => e.IdIntervencaosgi).HasColumnName("id_intervencaosgi");
                entity.Property(e => e.DinFimprogramado)
                    .HasColumnType("datetime")
                    .HasColumnName("din_fimprogramado");
                entity.Property(e => e.DinInicioefetivo)
                    .HasColumnType("datetime")
                    .HasColumnName("din_inicioefetivo");
                entity.Property(e => e.DscIntervencaosgi)
                    .HasMaxLength(150)
                    .HasColumnName("dsc_intervencaosgi");
                entity.Property(e => e.DscRecomendacao)
                    .HasMaxLength(350)
                    .HasColumnName("dsc_recomendacao");
                entity.Property(e => e.IdAgenteInstituicao).HasColumnName("id_agenteinstituicao");
                entity.Property(e => e.IdOrigemcoletauge)
                    .HasMaxLength(50)
                    .HasColumnName("id_origemcoletauge");
                entity.Property(e => e.NomAgente)
                    .HasMaxLength(100)
                    .HasColumnName("nom_agente");
                entity.Property(e => e.NomEquipamentoprincipal)
                    .HasMaxLength(50)
                    .HasColumnName("nom_equipamentoprincipal");
                entity.Property(e => e.NomStatus)
                    .HasMaxLength(50)
                    .HasColumnName("nom_status");
                entity.Property(e => e.NomTpintervencaosgi)
                    .HasMaxLength(50)
                    .HasColumnName("nom_tpintervencaosgi");
                entity.Property(e => e.NumIntervencaosgi).HasColumnName("num_intervencaosgi");
            });

            modelBuilder.Entity<LimitePeriodoDia>(entity =>
            {
                entity.HasKey(e => e.IdLimiteperiododia).HasName("pk_tb_limiteperiododia");

                entity.ToTable("tb_limiteperiododia");

                entity.HasIndex(e => e.IdDiasemana, "in_fk_diasemana_limiteperiododia");

                entity.HasIndex(e => e.IdLimitesintercambio, "in_fk_limitesintercambio_limiteperiododia");

                entity.HasIndex(e => e.IdTppatamar, "in_fk_tppatamar_limiteperiododia");

                entity.Property(e => e.IdLimiteperiododia).HasColumnName("id_limiteperiododia");
                entity.Property(e => e.HorFinal).HasColumnName("hor_final");
                entity.Property(e => e.HorInicial).HasColumnName("hor_inicial");
                entity.Property(e => e.IdDiasemana).HasColumnName("id_diasemana");
                entity.Property(e => e.IdLimitesintercambio).HasColumnName("id_limitesintercambio");
                entity.Property(e => e.IdTppatamar).HasColumnName("id_tppatamar");
                entity.Property(e => e.ValLimite).HasColumnName("val_limite");

                entity.HasOne(d => d.IdDiasemanaNavigation).WithMany(p => p.TbLimiteperiododia)
                    .HasForeignKey(d => d.IdDiasemana)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_diasemana_limiteperiododia");

                entity.HasOne(d => d.IdLimitesintercambioNavigation).WithMany(p => p.TbLimiteperiododia)
                    .HasForeignKey(d => d.IdLimitesintercambio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_limitesintercambio_limiteperiododia");

                entity.HasOne(d => d.IdTppatamarNavigation).WithMany(p => p.TbLimiteperiododia)
                    .HasForeignKey(d => d.IdTppatamar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tppatamar_limiteperiododia");
            });

            modelBuilder.Entity<LimitesIntercambio>(entity =>
            {
                entity.HasKey(e => e.IdLimitesintercambio).HasName("pk_tb_limitesintercambio");

                entity.ToTable("tb_limitesintercambio");

                entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_limitesintercambio");

                entity.Property(e => e.IdLimitesintercambio).HasColumnName("id_limitesintercambio");
                entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
                entity.Property(e => e.IdInterligacao).HasColumnName("id_interligacao");
                entity.Property(e => e.NomDocumentoorigem)
                    .HasMaxLength(50)
                    .HasColumnName("nom_documentoorigem");
                entity.Property(e => e.NomInterligacao)
                    .HasMaxLength(50)
                    .HasColumnName("nom_interligacao");
                entity.Property(e => e.NumOrdem).HasColumnName("num_ordem");
                entity.Property(e => e.VerControleconcorrencia)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("ver_controleconcorrencia");

                entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbLimitesintercambios)
                    .HasForeignKey(d => d.IdEstudomontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estudomontador_limitesintercambio");
            });

            modelBuilder.Entity<LimitesPatamar>(entity =>
            {
                entity.HasKey(e => e.IdLimpatamar).HasName("pk_tb_limitespatamar");

                entity.ToTable("tb_limitespatamar");

                entity.HasIndex(e => e.IdLimitesintercambio, "in_fk_limitesintercambio_limitespatamar");

                entity.HasIndex(e => e.IdTppatamar, "in_fk_tppatamar_limitespatamar");

                entity.Property(e => e.IdLimpatamar).HasColumnName("id_limpatamar");
                entity.Property(e => e.IdLimitesintercambio).HasColumnName("id_limitesintercambio");
                entity.Property(e => e.IdTppatamar).HasColumnName("id_tppatamar");
                entity.Property(e => e.ValLimdeslig).HasColumnName("val_limdeslig");
                entity.Property(e => e.ValLimredecompletames1).HasColumnName("val_limredecompletames1");
                entity.Property(e => e.ValLimredecompletames2).HasColumnName("val_limredecompletames2");
                entity.Property(e => e.ValTotalhoraspatamar).HasColumnName("val_totalhoraspatamar");

                entity.HasOne(d => d.IdLimitesintercambioNavigation).WithMany(p => p.TbLimitespatamars)
                    .HasForeignKey(d => d.IdLimitesintercambio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_limitesintercambio_limitespatamar");

                entity.HasOne(d => d.IdTppatamarNavigation).WithMany(p => p.TbLimitespatamars)
                    .HasForeignKey(d => d.IdTppatamar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tppatamar_limitespatamar");
            });

            modelBuilder.Entity<ListaResultadoPmo>(entity =>
            {
                entity.HasKey(e => e.IdListaresultadopmo).HasName("pk_tb_listaresultadopmo");

                entity.ToTable("tb_listaresultadopmo");

                entity.HasIndex(e => e.IdImportacaopmo, "in_fk_importacaopmo_listaresultadopmo");

                entity.HasIndex(e => e.IdOrigemresultadopmo, "in_fk_origemresultadopmo_listaresultadopmo");

                entity.HasIndex(e => e.IdResultadocoletapmo, "in_fk_resultadocoletapmo_listaresultadopmo");

                entity.Property(e => e.IdListaresultadopmo).HasColumnName("id_listaresultadopmo");
                entity.Property(e => e.IdImportacaopmo).HasColumnName("id_importacaopmo");
                entity.Property(e => e.IdOrigemresultadopmo).HasColumnName("id_origemresultadopmo");
                entity.Property(e => e.IdResultadocoletapmo).HasColumnName("id_resultadocoletapmo");

                entity.HasOne(d => d.IdImportacaopmoNavigation).WithMany(p => p.TbListaresultadopmos)
                    .HasForeignKey(d => d.IdImportacaopmo)
                    .HasConstraintName("fk_importacaopmo_listaresultadopmo");

                entity.HasOne(d => d.IdOrigemresultadopmoNavigation).WithMany(p => p.TbListaresultadopmos)
                    .HasForeignKey(d => d.IdOrigemresultadopmo)
                    .HasConstraintName("fk_origemresultadopmo_listaresultadopmo");

                entity.HasOne(d => d.IdResultadocoletapmoNavigation).WithMany(p => p.TbListaresultadopmos)
                    .HasForeignKey(d => d.IdResultadocoletapmo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_resultadocoletapmo_listaresultadopmo");
            });

            modelBuilder.Entity<LogAuditoria>(entity =>
            {
                entity.HasKey(e => e.IdLogauditoria).HasName("pk_tb_logauditoria");

                entity.ToTable("tb_logauditoria");

                entity.Property(e => e.IdLogauditoria).HasColumnName("id_logauditoria");
                entity.Property(e => e.DinExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("din_execucao");
                entity.Property(e => e.DocOperacaologada)
                    .HasColumnType("xml")
                    .HasColumnName("doc_operacaologada");
                entity.Property(e => e.DscTipoacaoexecutada)
                    .HasMaxLength(100)
                    .HasColumnName("dsc_tipoacaoexecutada");
                entity.Property(e => e.NomExecutor)
                    .HasMaxLength(100)
                    .HasColumnName("nom_executor");
                entity.Property(e => e.NomFuncionalidade)
                    .HasMaxLength(50)
                    .HasColumnName("nom_funcionalidade");
                entity.Property(e => e.NomRegistro)
                    .HasMaxLength(200)
                    .HasColumnName("nom_registro");
            });

            modelBuilder.Entity<LogDadosInformado>(entity =>
            {
                entity.HasKey(e => e.IdLogdadosinformados).HasName("pk_tb_logdadosinformados");

                entity.ToTable("tb_logdadosinformados");

                entity.Property(e => e.IdLogdadosinformados).HasColumnName("id_logdadosinformados");
                entity.Property(e => e.DinAcao)
                    .HasColumnType("datetime")
                    .HasColumnName("din_acao");
                entity.Property(e => e.DscAcao)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dsc_acao");
                entity.Property(e => e.IdAgenteInstituicao).HasColumnName("id_agenteinstituicao");
                entity.Property(e => e.IdSemanaoperativa).HasColumnName("id_semanaoperativa");
                entity.Property(e => e.MailUsuario)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("mail_usuario");
                entity.Property(e => e.NomUsuario)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nom_usuario");
            });

            modelBuilder.Entity<LogNotificacao>(entity =>
            {
                entity.HasKey(e => e.IdLognotificacao).HasName("pk_tb_lognotificacao");

                entity.ToTable("tb_lognotificacao");

                entity.HasIndex(e => e.IdAgenteInstituicao, "in_fk_agenteinstituicao_lognotificacao");

                entity.HasIndex(e => e.IdSemanaoperativa, "in_fk_semanaoperativa_lognotificacao");

                entity.Property(e => e.IdLognotificacao).HasColumnName("id_lognotificacao");
                entity.Property(e => e.DinAcao)
                    .HasColumnType("datetime")
                    .HasColumnName("din_acao");
                entity.Property(e => e.DscAcao)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("dsc_acao");
                entity.Property(e => e.IdAgenteInstituicao).HasColumnName("id_agenteinstituicao");
                entity.Property(e => e.IdSemanaoperativa).HasColumnName("id_semanaoperativa");
                entity.Property(e => e.MailEnviado)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("mail_enviado");
                entity.Property(e => e.MailEnviar)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("mail_enviar");
                entity.Property(e => e.NomUsuario)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nom_usuario");

                entity.HasOne(d => d.IdAgenteinstituicaoNavigation).WithMany(p => p.TbLognotificacaos)
                    .HasForeignKey(d => d.IdAgenteInstituicao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_agenteinstituicao_lognotificacao");

                //entity.HasOne(d => d.IdSemanaoperativaNavigation).WithMany(p => p.TbLognotificacaos)
                //    .HasForeignKey(d => d.IdSemanaoperativa)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("fk_semanaoperativa_lognotificacao");
            });

            modelBuilder.Entity<ManutencaoPmo>(entity =>
            {
                entity.HasKey(e => e.IdManutencaopmo).HasName("pk_tb_manutencaopmo");

                entity.ToTable("tb_manutencaopmo");

                entity.HasIndex(e => e.IdAgenteInstituicao, "in_fk_agenteintituicao_manutencaopmo");

                entity.HasIndex(e => e.IdOrigemcoletauge, "in_fk_aux_unidadegeradora_manutencaopmo");

                entity.HasIndex(e => e.IdConfiguracaogestaomanutencao, "in_fk_configuracaogestaomanutencao_manutencaopmo");

                entity.HasIndex(e => e.IdEstadomanutencaopmo, "in_fk_estadomanutencaopmo_manutencaopmo");

                entity.Property(e => e.IdManutencaopmo).HasColumnName("id_manutencaopmo");
                entity.Property(e => e.DinInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("din_inicio");
                entity.Property(e => e.DinInicioreprogramado)
                    .HasColumnType("datetime")
                    .HasColumnName("din_inicioreprogramado");
                entity.Property(e => e.DinTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("din_termino");
                entity.Property(e => e.DinTerminoreprogramado)
                    .HasColumnType("datetime")
                    .HasColumnName("din_terminoreprogramado");
                entity.Property(e => e.DscJustificativa).HasColumnName("dsc_justificativa");
                entity.Property(e => e.FlgCancelada).HasColumnName("flg_cancelada");
                entity.Property(e => e.FlgImportadosgi).HasColumnName("flg_importadosgi");
                entity.Property(e => e.FlgImportadowebpmo).HasColumnName("flg_importadowebpmo");
                entity.Property(e => e.IdAgenteInstituicao).HasColumnName("id_agenteinstituicao");
                entity.Property(e => e.IdConfiguracaogestaomanutencao).HasColumnName("id_configuracaogestaomanutencao");
                entity.Property(e => e.IdEstadomanutencaopmo).HasColumnName("id_estadomanutencaopmo");
                entity.Property(e => e.IdOrigemcoletauge)
                    .HasMaxLength(50)
                    .HasColumnName("id_origemcoletauge");
                entity.Property(e => e.NumSgi).HasColumnName("num_sgi");

                entity.HasOne(d => d.IdAgenteinstituicaoNavigation).WithMany(p => p.TbManutencaopmos)
                    .HasForeignKey(d => d.IdAgenteInstituicao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_agenteintituicao_manutencaopmo");

                entity.HasOne(d => d.IdConfiguracaogestaomanutencaoNavigation).WithMany(p => p.TbManutencaopmos)
                    .HasForeignKey(d => d.IdConfiguracaogestaomanutencao)
                    .HasConstraintName("fk_configuracaogestaomanutencao_manutencaopmo");

                entity.HasOne(d => d.IdEstadomanutencaopmoNavigation).WithMany(p => p.TbManutencaopmos)
                    .HasForeignKey(d => d.IdEstadomanutencaopmo)
                    .HasConstraintName("fk_estadomanutencaopmo_manutencaopmo");

                entity.HasOne(d => d.IdOrigemcoletaugeNavigation).WithMany(p => p.TbManutencaopmos)
                    .HasForeignKey(d => d.IdOrigemcoletauge)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_aux_unidadegeradora_manutencaopmo");

                entity.HasMany(d => d.IdManutencaopmocondicionada).WithMany(p => p.IdManutencaopmos)
                    .UsingEntity<Dictionary<string, object>>(
                        "TbManutencaopmocondicionadum",
                        r => r.HasOne<ManutencaoPmo>().WithMany()
                            .HasForeignKey("IdManutencaopmocondicionada")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_manutencaopmo_manutencaopmocondicionada_condicionada"),
                        l => l.HasOne<ManutencaoPmo>().WithMany()
                            .HasForeignKey("IdManutencaopmo")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_manutencaopmo_manutencaopmocondicionada"),
                        j =>
                        {
                            j.HasKey("IdManutencaopmo", "IdManutencaopmocondicionada").HasName("pk_tb_manutencaopmocondicionada");
                            j.ToTable("tb_manutencaopmocondicionada");
                            j.HasIndex(new[] { "IdManutencaopmo" }, "in_fk_manutencaopmo_manutencaopmocondicionada");
                            j.HasIndex(new[] { "IdManutencaopmocondicionada" }, "in_fk_manutencaopmo_manutencaopmocondicionada_condicionada");
                            j.IndexerProperty<int>("IdManutencaopmo").HasColumnName("id_manutencaopmo");
                            j.IndexerProperty<int>("IdManutencaopmocondicionada").HasColumnName("id_manutencaopmocondicionada");
                        });

                entity.HasMany(d => d.IdManutencaopmos).WithMany(p => p.IdManutencaopmocondicionada)
                    .UsingEntity<Dictionary<string, object>>(
                        "TbManutencaopmocondicionadum",
                        r => r.HasOne<ManutencaoPmo>().WithMany()
                            .HasForeignKey("IdManutencaopmo")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_manutencaopmo_manutencaopmocondicionada"),
                        l => l.HasOne<ManutencaoPmo>().WithMany()
                            .HasForeignKey("IdManutencaopmocondicionada")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_manutencaopmo_manutencaopmocondicionada_condicionada"),
                        j =>
                        {
                            j.HasKey("IdManutencaopmo", "IdManutencaopmocondicionada").HasName("pk_tb_manutencaopmocondicionada");
                            j.ToTable("tb_manutencaopmocondicionada");
                            j.HasIndex(new[] { "IdManutencaopmo" }, "in_fk_manutencaopmo_manutencaopmocondicionada");
                            j.HasIndex(new[] { "IdManutencaopmocondicionada" }, "in_fk_manutencaopmo_manutencaopmocondicionada_condicionada");
                            j.IndexerProperty<int>("IdManutencaopmo").HasColumnName("id_manutencaopmo");
                            j.IndexerProperty<int>("IdManutencaopmocondicionada").HasColumnName("id_manutencaopmocondicionada");
                        });
            });

            modelBuilder.Entity<ManutencaoProgramadaEstudo>(entity =>
            {
                entity.HasKey(e => e.IdEstudomontador).HasName("pk_tb_manutencaoprogramadaestudo");

                entity.ToTable("tb_manutencaoprogramadaestudo");

                entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_manutencaoprogramadaestudo");

                entity.Property(e => e.IdEstudomontador)
                    .ValueGeneratedNever()
                    .HasColumnName("id_estudomontador");
                entity.Property(e => e.LgnUsuariocheckout)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lgn_usuariocheckout");
                entity.Property(e => e.VerControleconcorrencia)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("ver_controleconcorrencia");

                entity.HasOne(d => d.IdEstudomontadorNavigation).WithOne(p => p.TbManutencaoprogramadaestudo)
                    .HasForeignKey<ManutencaoProgramadaEstudo>(d => d.IdEstudomontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estudomontador_manutencaoprogramadaestudo");
            });

            modelBuilder.Entity<ManutencaoProgramada>(entity =>
            {
                entity.HasKey(e => e.IdManutencaoprogramada).HasName("pk_tb_manutencaoprogramada");

                entity.ToTable("tb_manutencaoprogramada");

                entity.HasIndex(e => e.IdAgenteInstituicao, "in_fk_agenteinstituicao_manutencaoprogramada");

                entity.HasIndex(e => e.IdOrigemuge, "in_fk_aux_unidadegeradoramontador_manutencaoprogramada");

                entity.HasIndex(e => e.IdOrigemusi, "in_fk_aux_usinamontador_manutencaoprogramada");

                entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_manutencaoprogramada");

                entity.HasIndex(e => e.IdTpmanutencaoprogramada, "in_fk_tpmanutencaoprogramada_manutencaoprogramada");

                entity.Property(e => e.IdManutencaoprogramada).HasColumnName("id_manutencaoprogramada");
                entity.Property(e => e.DinInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("din_inicio");
                entity.Property(e => e.DinTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("din_termino");
                entity.Property(e => e.DinUltimaalteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("din_ultimaalteracao");
                entity.Property(e => e.DscJustificativa)
                    .HasMaxLength(1000)
                    .HasColumnName("dsc_justificativa");
                entity.Property(e => e.IdAgenteInstituicao).HasColumnName("id_agenteinstituicao");
                entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
                entity.Property(e => e.IdOrigemuge).HasColumnName("id_origemuge");
                entity.Property(e => e.IdOrigemusi).HasColumnName("id_origemusi");
                entity.Property(e => e.IdTpmanutencaoprogramada).HasColumnName("id_tpmanutencaoprogramada");
                entity.Property(e => e.LgnUltimaalteracao)
                    .HasMaxLength(50)
                    .HasColumnName("lgn_ultimaalteracao");
                entity.Property(e => e.VerControleconcorrencia)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("ver_controleconcorrencia");

                entity.HasOne(d => d.IdAgenteinstituicaoNavigation).WithMany(p => p.TbManutencaoprogramada)
                    .HasForeignKey(d => d.IdAgenteInstituicao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_agenteinstituicao_manutencaoprogramada");

                entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbManutencaoprogramada)
                    .HasForeignKey(d => d.IdEstudomontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estudomontador_manutencaoprogramada");

                entity.HasOne(d => d.IdOrigemugeNavigation).WithMany(p => p.TbManutencaoprogramada)
                    .HasForeignKey(d => d.IdOrigemuge)
                    .HasConstraintName("fk_aux_unidadegeradoramontador_manutencaoprogramada");

                entity.HasOne(d => d.IdOrigemusiNavigation).WithMany(p => p.TbManutencaoprogramada)
                    .HasForeignKey(d => d.IdOrigemusi)
                    .HasConstraintName("fk_aux_usinamontador_manutencaoprogramada");

                entity.HasOne(d => d.IdTpmanutencaoprogramadaNavigation).WithMany(p => p.TbManutencaoprogramada)
                    .HasForeignKey(d => d.IdTpmanutencaoprogramada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tpmanutencaoprogramada_manutencaoprogramada");
            });

            modelBuilder.Entity<MneespEstudoMontador>(entity =>
            {
                entity.HasKey(e => e.IdMneespestudomontador).HasName("pk_tb_mneespestudomontador");

                entity.ToTable("tb_mneespestudomontador");

                entity.HasIndex(e => e.IdEstadomnemonicoestudomontador, "in_fk_estadomnemonicoestudomontador_mneespestudomontador");

                entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_mneespestudomontador");

                entity.Property(e => e.IdMneespestudomontador).HasColumnName("id_mneespestudomontador");
                entity.Property(e => e.DinUltimaalteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("din_ultimaalteracao");
                entity.Property(e => e.IdEstadomnemonicoestudomontador).HasColumnName("id_estadomnemonicoestudomontador");
                entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
                entity.Property(e => e.LgnUltimaalteracao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lgn_ultimaalteracao");
                entity.Property(e => e.LgnUsuariocheckout)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lgn_usuariocheckout");
                entity.Property(e => e.VerControleconcorrencia)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("ver_controleconcorrencia");

                entity.HasOne(d => d.IdEstadomnemonicoestudomontadorNavigation).WithMany(p => p.TbMneespestudomontadors)
                    .HasForeignKey(d => d.IdEstadomnemonicoestudomontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estadomnemonicoestudomontador_mneespestudomontador");

                entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbMneespestudomontadors)
                    .HasForeignKey(d => d.IdEstudomontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estudomontador_mneespestudomontador");
            });

            modelBuilder.Entity<MnemonicoBlocoAC>(entity =>
            {
                entity.HasKey(e => e.IdMnemonicoblocoac).HasName("pk_tb_mnemonicoblocoac");

                entity.ToTable("tb_mnemonicoblocoac");

                entity.HasIndex(e => e.IdTpcoleta, "in_fk_tpcoleta_mnemonicoblocoac");

                entity.Property(e => e.IdMnemonicoblocoac).HasColumnName("id_mnemonicoblocoac");
                entity.Property(e => e.CodMnemonicoblocoac)
                    .HasMaxLength(50)
                    .HasColumnName("cod_mnemonicoblocoac");
                entity.Property(e => e.FlgAtivo).HasColumnName("flg_ativo");
                entity.Property(e => e.FlgReservado).HasColumnName("flg_reservado");
                entity.Property(e => e.IdTpcoleta).HasColumnName("id_tpcoleta");
                entity.Property(e => e.NomMnemonicoblocoac)
                    .HasMaxLength(150)
                    .HasColumnName("nom_mnemonicoblocoac");
                entity.Property(e => e.NumOrdem).HasColumnName("num_ordem");
                entity.Property(e => e.QtdIndices).HasColumnName("qtd_indices");
                entity.Property(e => e.ValColfinalindice).HasColumnName("val_colfinalindice");
                entity.Property(e => e.ValColinicialindice).HasColumnName("val_colinicialindice");
                entity.Property(e => e.VerControleconcorrencia)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("ver_controleconcorrencia");

                entity.HasOne(d => d.IdTpcoletaNavigation).WithMany(p => p.TbMnemonicoblocoacs)
                    .HasForeignKey(d => d.IdTpcoleta)
                    .HasConstraintName("fk_tpcoleta_mnemonicoblocoac");
            });

            modelBuilder.Entity<MnemonicoEstudoMontador>(entity =>
            {
                entity.HasKey(e => e.IdBlocoestudomontador).HasName("pk_tb_mnemonicoestudomontador");

                entity.ToTable("tb_mnemonicoestudomontador");

                entity.HasIndex(e => e.IdEstadomnemonicoestudomontador, "in_fk_estadomnemonicoestudomontador_mnemonicoestudomontador");

                entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_mnemonicoestudomontador");

                entity.HasIndex(e => e.IdMnemonicoblocoac, "in_fk_mnemonicoblocoac_mnemonicoestudomontador");

                entity.Property(e => e.IdBlocoestudomontador).HasColumnName("id_blocoestudomontador");
                entity.Property(e => e.DinUltimaalteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("din_ultimaalteracao");
                entity.Property(e => e.IdEstadomnemonicoestudomontador).HasColumnName("id_estadomnemonicoestudomontador");
                entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
                entity.Property(e => e.IdMnemonicoblocoac).HasColumnName("id_mnemonicoblocoac");
                entity.Property(e => e.LgnUltimaalteracao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lgn_ultimaalteracao");
                entity.Property(e => e.LgnUsuariocheckout)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lgn_usuariocheckout");
                entity.Property(e => e.VerControleconcorrencia)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("ver_controleconcorrencia");

                entity.HasOne(d => d.IdEstadomnemonicoestudomontadorNavigation).WithMany(p => p.TbMnemonicoestudomontadors)
                    .HasForeignKey(d => d.IdEstadomnemonicoestudomontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estadomnemonicoestudomontador_mnemonicoestudomontador");

                entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbMnemonicoestudomontadors)
                    .HasForeignKey(d => d.IdEstudomontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estudomontador_mnemonicoestudomontador");

                entity.HasOne(d => d.IdMnemonicoblocoacNavigation).WithMany(p => p.TbMnemonicoestudomontadors)
                    .HasForeignKey(d => d.IdMnemonicoblocoac)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mnemonicoblocoac_mnemonicoestudomontador");
            });

            modelBuilder.Entity<MnemonicoPmo>(entity =>
            {
                entity.HasKey(e => e.IdMnemonicopmo).HasName("pk_tb_mnemonicopmo");

                entity.ToTable("tb_mnemonicopmo");

                entity.HasIndex(e => e.IdResultadocoletapmo, "in_fk_resultadocoletapmo_mnemonicopmo");

                entity.HasIndex(e => e.IdTpdadograndeza, "in_fk_tpdadograndeza_mnemonicopmo");

                entity.HasIndex(e => e.IdTpperiodomontador, "in_fk_tpperiodomontador_mnemonicopmo");

                entity.Property(e => e.IdMnemonicopmo)
                    .ValueGeneratedNever()
                    .HasColumnName("id_mnemonicopmo");
                entity.Property(e => e.CodMnemonicopmo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("cod_mnemonicopmo");
                entity.Property(e => e.FlgAceitavalornegativo).HasColumnName("flg_aceitavalornegativo");
                entity.Property(e => e.FlgAtivo).HasColumnName("flg_ativo");
                entity.Property(e => e.FlgColetamediapatamares).HasColumnName("flg_coletamediapatamares");
                entity.Property(e => e.FlgColetapatamar).HasColumnName("flg_coletapatamar");
                entity.Property(e => e.FlgColetareservatorio).HasColumnName("flg_coletareservatorio");
                entity.Property(e => e.FlgColetasubsistema).HasColumnName("flg_coletasubsistema");
                entity.Property(e => e.FlgColetausina).HasColumnName("flg_coletausina");
                entity.Property(e => e.IdResultadocoletapmo).HasColumnName("id_resultadocoletapmo");
                entity.Property(e => e.IdTpdadograndeza).HasColumnName("id_tpdadograndeza");
                entity.Property(e => e.IdTpperiodomontador).HasColumnName("id_tpperiodomontador");
                entity.Property(e => e.NomMnemonicopmo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nom_mnemonicopmo");
                entity.Property(e => e.QtdCasasdecimaisvalor).HasColumnName("qtd_casasdecimaisvalor");
                entity.Property(e => e.QtdDigitosvalor).HasColumnName("qtd_digitosvalor");

                entity.HasOne(d => d.IdResultadocoletapmoNavigation).WithMany(p => p.TbMnemonicopmos)
                    .HasForeignKey(d => d.IdResultadocoletapmo)
                    .HasConstraintName("fk_resultadocoletapmo_mnemonicopmo");

                entity.HasOne(d => d.IdTpdadograndezaNavigation).WithMany(p => p.TbMnemonicopmos)
                    .HasForeignKey(d => d.IdTpdadograndeza)
                    .HasConstraintName("fk_tpdadograndeza_mnemonicopmo");

                entity.HasOne(d => d.IdTpperiodomontadorNavigation).WithMany(p => p.TbMnemonicopmos)
                    .HasForeignKey(d => d.IdTpperiodomontador)
                    .HasConstraintName("fk_tpperiodomontador_mnemonicopmo");
            });

            modelBuilder.Entity<ModificacaoConfiguracaoBlocoEstudo>(entity =>
            {
                entity.HasKey(e => e.IdModifconfigblocoestudo).HasName("pk_tb_modifconfigblocoestudo");

                entity.ToTable("tb_modifconfigblocoestudo");

                entity.HasIndex(e => e.IdBloco, "in_fk_bloco_modifconfigblocoestudo");

                entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_modifconfigblocoestudo");

                entity.Property(e => e.IdModifconfigblocoestudo).HasColumnName("id_modifconfigblocoestudo");
                entity.Property(e => e.IdBloco).HasColumnName("id_bloco");
                entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
                entity.Property(e => e.NomCampo)
                    .HasMaxLength(50)
                    .HasColumnName("nom_campo");
                entity.Property(e => e.NumRevisao).HasColumnName("num_revisao");
                entity.Property(e => e.ValCampo)
                    .HasMaxLength(300)
                    .HasColumnName("val_campo");

                entity.HasOne(d => d.IdBlocoNavigation).WithMany(p => p.TbModifconfigblocoestudos)
                    .HasForeignKey(d => d.IdBloco)
                    .HasConstraintName("fk_bloco_modifconfigblocoestudo");

                entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbModifconfigblocoestudos)
                    .HasForeignKey(d => d.IdEstudomontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estudomontador_modifconfigblocoestudo");

                entity.HasMany(d => d.IdCampochaves).WithMany(p => p.IdModifconfigblocoestudos)
                    .UsingEntity<Dictionary<string, object>>(
                        "TbHisconfigchavebloco",
                        r => r.HasOne<CampoChave>().WithMany()
                            .HasForeignKey("IdCampochave")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_campochave_hisconfigchavebloco"),
                        l => l.HasOne<ModificacaoConfiguracaoBlocoEstudo>().WithMany()
                            .HasForeignKey("IdModifconfigblocoestudo")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_modifconfigblocoestudo_hisconfigchavebloco"),
                        j =>
                        {
                            j.HasKey("IdModifconfigblocoestudo", "IdCampochave").HasName("pk_tb_hisconfigchavebloco");
                            j.ToTable("tb_hisconfigchavebloco");
                            j.HasIndex(new[] { "IdCampochave" }, "in_fk_campochave_hisconfigchavebloco");
                            j.HasIndex(new[] { "IdModifconfigblocoestudo" }, "in_fk_modifconfigblocoestudo_hisconfigchavebloco");
                            j.IndexerProperty<int>("IdModifconfigblocoestudo").HasColumnName("id_modifconfigblocoestudo");
                            j.IndexerProperty<int>("IdCampochave").HasColumnName("id_campochave");
                        });

                entity.HasMany(d => d.IdColunagrandezas).WithMany(p => p.IdModifconfigblocoestudos)
                    .UsingEntity<Dictionary<string, object>>(
                        "TbHiscolunagrandeza",
                        r => r.HasOne<ColunaGrandeza>().WithMany()
                            .HasForeignKey("IdColunagrandeza")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_colunagrandeza_hiscolunagrandeza"),
                        l => l.HasOne<ModificacaoConfiguracaoBlocoEstudo>().WithMany()
                            .HasForeignKey("IdModifconfigblocoestudo")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_modifconfigblocoestudo_hiscolunagrandeza"),
                        j =>
                        {
                            j.HasKey("IdModifconfigblocoestudo", "IdColunagrandeza").HasName("pk_tb_hiscolunagrandeza");
                            j.ToTable("tb_hiscolunagrandeza");
                            j.HasIndex(new[] { "IdColunagrandeza" }, "in_fk_colunagrandeza_hiscolunagrandeza");
                            j.HasIndex(new[] { "IdModifconfigblocoestudo" }, "in_fk_modifconfigblocoestudo_hiscolunagrandeza");
                            j.IndexerProperty<int>("IdModifconfigblocoestudo").HasColumnName("id_modifconfigblocoestudo");
                            j.IndexerProperty<int>("IdColunagrandeza").HasColumnName("id_colunagrandeza");
                        });
            });

            modelBuilder.Entity<MotivoAlteracao>(entity =>
            {
                entity.HasKey(e => e.IdMotivoalteracao).HasName("pk_tb_motivoalteracao");

                entity.ToTable("tb_motivoalteracao");

                entity.Property(e => e.IdMotivoalteracao).HasColumnName("id_motivoalteracao");
                entity.Property(e => e.DinUltimaalteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("din_ultimaalteracao");
                entity.Property(e => e.DscMotivo)
                    .HasMaxLength(150)
                    .HasColumnName("dsc_motivo");
                entity.Property(e => e.FlgAtivo).HasColumnName("flg_ativo");
                entity.Property(e => e.LgnUltimaalteracao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lgn_ultimaalteracao");
                entity.Property(e => e.NomMotivo)
                    .HasMaxLength(150)
                    .HasColumnName("nom_motivo");
                entity.Property(e => e.VerControleconcorrencia)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("ver_controleconcorrencia");
            });

            modelBuilder.Entity<OrdemExportacaoAgente>(entity =>
            {
                entity.HasKey(e => e.AgeId).HasName("pk_tb_ordemexportacaoagente");

                entity.ToTable("tb_ordemexportacaoagente");

                entity.Property(e => e.AgeId)
                    .HasMaxLength(3)
                    .HasColumnName("age_id");
                entity.Property(e => e.NumOrdemexportacao).HasColumnName("num_ordemexportacao");
            });

            modelBuilder.Entity<OrdenacaoRegistro>(entity =>
            {
                entity.HasKey(e => e.IdOrdenacaoregistros).HasName("pk_tb_ordenacaoregistros");

                entity.ToTable("tb_ordenacaoregistros");

                entity.HasIndex(e => e.IdBloco, "in_fk_bloco_ordenacaoregistros");

                entity.HasIndex(e => e.IdCampochave, "in_fk_campochave_ordenacaoregistros");

                entity.HasIndex(e => e.IdGrandezamontador, "in_fk_grandezabloco_ordenacaoregistros");

                entity.Property(e => e.IdOrdenacaoregistros).HasColumnName("id_ordenacaoregistros");
                entity.Property(e => e.FlgTpordenacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("flg_tpordenacao");
                entity.Property(e => e.IdBloco).HasColumnName("id_bloco");
                entity.Property(e => e.IdCampochave).HasColumnName("id_campochave");
                entity.Property(e => e.IdGrandezamontador).HasColumnName("id_grandezamontador");
                entity.Property(e => e.NumOrdenacao).HasColumnName("num_ordenacao");
                entity.Property(e => e.NumRevisao).HasColumnName("num_revisao");

                entity.HasOne(d => d.IdBlocoNavigation).WithMany(p => p.TbOrdenacaoregistros)
                    .HasForeignKey(d => d.IdBloco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_bloco_ordenacaoregistros");

                entity.HasOne(d => d.IdCampochaveNavigation).WithMany(p => p.TbOrdenacaoregistros)
                    .HasForeignKey(d => d.IdCampochave)
                    .HasConstraintName("fk_campochave_ordenacaoregistros");

                entity.HasOne(d => d.IdGrandezamontadorNavigation).WithMany(p => p.TbOrdenacaoregistros)
                    .HasForeignKey(d => d.IdGrandezamontador)
                    .HasConstraintName("fk_grandezabloco_ordenacaoregistros");
            });

            modelBuilder.Entity<OrigemColetaMontador>(entity =>
            {
                entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_origemcoletamontador");

                entity.ToTable("tb_origemcoletamontador");

                entity.HasIndex(e => e.IdTpcoleta, "in_fk_tpcoleta_origemcoletamontador");

                entity.Property(e => e.IdOrigemcoletamontador).HasColumnName("id_origemcoletamontador");
                entity.Property(e => e.CodOrigemcoletamontador)
                    .HasMaxLength(50)
                    .HasColumnName("cod_origemcoletamontador");
                entity.Property(e => e.DinIniciovalidade)
                    .HasColumnType("datetime")
                    .HasColumnName("din_iniciovalidade");
                entity.Property(e => e.DinTerminovalidade)
                    .HasColumnType("datetime")
                    .HasColumnName("din_terminovalidade");
                entity.Property(e => e.DinUltimaalteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("din_ultimaalteracao");
                entity.Property(e => e.FlgAtivo).HasColumnName("flg_ativo");
                entity.Property(e => e.IdTpcoleta).HasColumnName("id_tpcoleta");
                entity.Property(e => e.LgnUltimaalteracao)
                    .HasMaxLength(50)
                    .HasColumnName("lgn_ultimaalteracao");
                entity.Property(e => e.NomExibicao)
                    .HasMaxLength(255)
                    .HasColumnName("nom_exibicao");
                entity.Property(e => e.VerControleconcorrencia)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("ver_controleconcorrencia");

                entity.HasOne(d => d.IdTpcoletaNavigation).WithMany(p => p.TbOrigemcoletamontadors)
                    .HasForeignKey(d => d.IdTpcoleta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tpcoleta_origemcoletamontador");
            });

            modelBuilder.Entity<OrigemColetum>(entity =>
            {
                entity.HasKey(e => e.IdOrigemcoleta).HasName("pk_tb_origemcoleta");

                entity.ToTable("tb_origemcoleta");

                entity.Property(e => e.IdOrigemcoleta)
                    .HasMaxLength(50)
                    .HasColumnName("id_origemcoleta");
                entity.Property(e => e.NomExibicao)
                    .HasMaxLength(150)
                    .HasColumnName("nom_exibicao");
                entity.Property(e => e.TipOrigemcoleta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("tip_origemcoleta");
            });

            modelBuilder.Entity<OrigemResultadoPmo>(entity =>
            {
                entity.HasKey(e => e.IdOrigemresultadopmo).HasName("pk_tb_origemresultadopmo");

                entity.ToTable("tb_origemresultadopmo");

                entity.Property(e => e.IdOrigemresultadopmo).HasColumnName("id_origemresultadopmo");
                entity.Property(e => e.CodOrigemresultadopmo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod_origemresultadopmo");
                entity.Property(e => e.CodOrigemresultadopmopai)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod_origemresultadopmopai");
                entity.Property(e => e.NomOrigemresultadopmo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nom_origemresultadopmo");
                entity.Property(e => e.TipOrigemresultadopmo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("tip_origemresultadopmo");
            });

            modelBuilder.Entity<ParametroPMO>(entity =>
            {
                entity.HasKey(e => e.IdParametropmo).HasName("pk_tb_parametropmo");

                entity.ToTable("tb_parametropmo");

                entity.Property(e => e.IdParametropmo).HasColumnName("id_parametropmo");
                entity.Property(e => e.DscParametropmo)
                    .HasMaxLength(255)
                    .HasColumnName("dsc_parametropmo");
                entity.Property(e => e.NomParametropmo)
                    .HasMaxLength(50)
                    .HasColumnName("nom_parametropmo");
                entity.Property(e => e.ValParametropmo)
                    .HasMaxLength(1000)
                    .HasColumnName("val_parametropmo");
            });

            modelBuilder.Entity<PerdaPotencia>(entity =>
            {
                entity.HasKey(e => e.IdPerdapotencia).HasName("pk_tb_perdapotencia");

                entity.ToTable("tb_perdapotencia");

                entity.HasIndex(e => e.IdConfiguracaogestaomanutencao, "in_fk_configuracaogestaomanutencao_perdadepotencia");

                entity.Property(e => e.IdPerdapotencia).HasColumnName("id_perdapotencia");
                entity.Property(e => e.IdConfiguracaogestaomanutencao).HasColumnName("id_configuracaogestaomanutencao");
                entity.Property(e => e.NomCurtosubsistema)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nom_curtosubsistema");
                entity.Property(e => e.ValPerdapotencia).HasColumnName("val_perdapotencia");

                entity.HasOne(d => d.IdConfiguracaogestaomanutencaoNavigation).WithMany(p => p.TbPerdapotencia)
                    .HasForeignKey(d => d.IdConfiguracaogestaomanutencao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_configuracaogestaomanutencao_perdadepotencia");
            });

            modelBuilder.Entity<Pmo>(entity =>
            {
                entity.HasKey(e => e.IdPmo).HasName("pk_tb_pmo");

                entity.ToTable("tb_pmo");

                entity.Property(e => e.IdPmo).HasColumnName("id_pmo");
                entity.Property(e => e.AnoReferencia).HasColumnName("ano_referencia");
                entity.Property(e => e.MesReferencia).HasColumnName("mes_referencia");
                entity.Property(e => e.QtdMesesadiante).HasColumnName("qtd_mesesadiante");
                entity.Property(e => e.VerControleconcorrencia)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("ver_controleconcorrencia");
            });

            modelBuilder.Entity<RecuperacaoDado>(entity =>
            {
                entity.HasKey(e => e.IdRecuperacaodados).HasName("pk_tb_recuperacaodados");

                entity.ToTable("tb_recuperacaodados");

                entity.HasIndex(e => e.IdEstudomontadordestino, "in_fk_estudomontador_recuperacaodados_destino");

                entity.HasIndex(e => e.IdEstudomontadorfonte, "in_fk_estudomontador_recuperacaodados_fonte");

                entity.HasIndex(e => e.IdSemanaoperativafonte, "in_fk_semanaoperativa_recuperacaodados");

                entity.Property(e => e.IdRecuperacaodados).HasColumnName("id_recuperacaodados");
                entity.Property(e => e.DinRecuperacao)
                    .HasColumnType("datetime")
                    .HasColumnName("din_recuperacao");
                entity.Property(e => e.FlgInserirchaves).HasColumnName("flg_inserirchaves");
                entity.Property(e => e.IdEstudomontadordestino).HasColumnName("id_estudomontadordestino");
                entity.Property(e => e.IdEstudomontadorfonte).HasColumnName("id_estudomontadorfonte");
                entity.Property(e => e.IdSemanaoperativafonte).HasColumnName("id_semanaoperativafonte");
                entity.Property(e => e.LgnUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lgn_usuario");
                entity.Property(e => e.NomArquivofonte)
                    .HasMaxLength(200)
                    .HasColumnName("nom_arquivofonte");

                entity.HasOne(d => d.IdEstudomontadordestinoNavigation).WithMany(p => p.TbRecuperacaodadoIdEstudomontadordestinoNavigations)
                    .HasForeignKey(d => d.IdEstudomontadordestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estudomontador_recuperacaodados_destino");

                entity.HasOne(d => d.IdEstudomontadorfonteNavigation).WithMany(p => p.TbRecuperacaodadoIdEstudomontadorfonteNavigations)
                    .HasForeignKey(d => d.IdEstudomontadorfonte)
                    .HasConstraintName("fk_estudomontador_recuperacaodados_fonte");

                //entity.HasOne(d => d.IdSemanaoperativafonteNavigation).WithMany(p => p.TbRecuperacaodados)
                //    .HasForeignKey(d => d.IdSemanaoperativafonte)
                //    .HasConstraintName("fk_semanaoperativa_recuperacaodados_fonte");
            });

            modelBuilder.Entity<RecuperacaoDadosAgentePmo>(entity =>
            {
                entity.HasKey(e => new { e.IdRecuperacaodados, e.AgeId }).HasName("pk_tb_recuperacaodadosagentepmo");

                entity.ToTable("tb_recuperacaodadosagentepmo");

                entity.HasIndex(e => e.IdRecuperacaodados, "in_fk_recuperacaodados_recuperacaodadosagentepmo");

                entity.Property(e => e.IdRecuperacaodados).HasColumnName("id_recuperacaodados");
                entity.Property(e => e.AgeId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("age_id");

                entity.HasOne(d => d.IdRecuperacaodadosNavigation).WithMany(p => p.TbRecuperacaodadosagentepmos)
                    .HasForeignKey(d => d.IdRecuperacaodados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_recuperacaodados_recuperacaodadosagentepmo");
            });

            modelBuilder.Entity<RecuperacaoDadosBloco>(entity =>
            {
                entity.HasKey(e => new { e.IdRecuperacaodados, e.IdBloco }).HasName("pk_tb_recuperacaodadosbloco");

                entity.ToTable("tb_recuperacaodadosbloco");

                entity.HasIndex(e => e.IdRecuperacaodados, "in_fk_recuperacaodados_recuperacaodadosbloco");

                entity.Property(e => e.IdRecuperacaodados).HasColumnName("id_recuperacaodados");
                entity.Property(e => e.IdBloco).HasColumnName("id_bloco");

                entity.HasOne(d => d.IdRecuperacaodadosNavigation).WithMany(p => p.TbRecuperacaodadosblocos)
                    .HasForeignKey(d => d.IdRecuperacaodados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_recuperacaodados_recuperacaodadosbloco");
            });

            modelBuilder.Entity<ReducaoLimiteIntercambio>(entity =>
            {
                entity.HasKey(e => e.IdReducaolimiteintercambio).HasName("pk_tb_reducaolimiteintercambio");

                entity.ToTable("tb_reducaolimiteintercambio");

                entity.HasIndex(e => e.IdLimitesintercambio, "in_fk_limitesintercambio_reducaolimiteintercambio");

                entity.Property(e => e.IdReducaolimiteintercambio).HasColumnName("id_reducaolimiteintercambio");
                entity.Property(e => e.DinFim)
                    .HasColumnType("datetime")
                    .HasColumnName("din_fim");
                entity.Property(e => e.DinInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("din_inicio");
                entity.Property(e => e.DscMotivo)
                    .HasMaxLength(50)
                    .HasColumnName("dsc_motivo");
                entity.Property(e => e.IdLimitesintercambio).HasColumnName("id_limitesintercambio");
                entity.Property(e => e.NumIntervencaosgi).HasColumnName("num_intervencaosgi");
                entity.Property(e => e.TipReducaolimiteintercambio)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("tip_reducaolimiteintercambio");
                entity.Property(e => e.ValLimite).HasColumnName("val_limite");

                entity.HasOne(d => d.IdLimitesintercambioNavigation).WithMany(p => p.TbReducaolimiteintercambios)
                    .HasForeignKey(d => d.IdLimitesintercambio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_limitesintercambio_reducaolimiteintercambio");
            });

            modelBuilder.Entity<Restricao>(entity =>
            {
                entity.HasKey(e => e.IdRestricao).HasName("pk_tb_restricao");

                entity.ToTable("tb_restricao");

                entity.HasIndex(e => e.IdFonteorigem, "in_fk_fonteorigem_restricao");

                entity.HasIndex(e => e.IdRestricaopai, "in_fk_restricao_restricao_pai");

                entity.HasIndex(e => new { e.IdTprestricao, e.IdEstudomontador }, "in_fk_restricaoestudo_restricao");

                entity.Property(e => e.IdRestricao).HasColumnName("id_restricao");
                entity.Property(e => e.CodIdentificador).HasColumnName("cod_identificador");
                entity.Property(e => e.DinEstagiofinal)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("din_estagiofinal");
                entity.Property(e => e.DinEstagioinicial)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("din_estagioinicial");
                entity.Property(e => e.DinUltimaalteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("din_ultimaalteracao");
                entity.Property(e => e.DscComentario).HasColumnName("dsc_comentario");
                entity.Property(e => e.FlgImportado).HasColumnName("flg_importado");
                entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
                entity.Property(e => e.IdFonteorigem).HasColumnName("id_fonteorigem");
                entity.Property(e => e.IdRestricaopai).HasColumnName("id_restricaopai");
                entity.Property(e => e.IdTprestricao).HasColumnName("id_tprestricao");
                entity.Property(e => e.LgnUltimaalteracao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lgn_ultimaalteracao");
                entity.Property(e => e.NumRestricao).HasColumnName("num_restricao");
                entity.Property(e => e.NumRestricaoestudoanterior).HasColumnName("num_restricaoestudoanterior");

                entity.HasOne(d => d.IdFonteorigemNavigation).WithMany(p => p.TbRestricaos)
                    .HasForeignKey(d => d.IdFonteorigem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_fonteorigem_restricao");

                entity.HasOne(d => d.IdRestricaopaiNavigation).WithMany(p => p.InverseIdRestricaopaiNavigation)
                    .HasForeignKey(d => d.IdRestricaopai)
                    .HasConstraintName("fk_restricao_restricao_pai");

                entity.HasOne(d => d.TbRestricaoestudo).WithMany(p => p.TbRestricaos)
                    .HasForeignKey(d => new { d.IdTprestricao, d.IdEstudomontador })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_restricaoestudo_restricao");
            });

            modelBuilder.Entity<RestricaoEletrica>(entity =>
            {
                entity.HasKey(e => e.IdRestricao).HasName("pk_tb_restricaoeletrica");

                entity.ToTable("tb_restricaoeletrica");

                entity.HasIndex(e => e.IdRestricao, "in_fk_restricao_restricaoeletrica");

                entity.Property(e => e.IdRestricao)
                    .ValueGeneratedNever()
                    .HasColumnName("id_restricao");
                entity.Property(e => e.CodEstruturacaores)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("cod_estruturacaores");

                entity.HasOne(d => d.IdRestricaoNavigation).WithOne(p => p.TbRestricaoeletrica)
                    .HasForeignKey<RestricaoEletrica>(d => d.IdRestricao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_restricao_restricaoeletrica");
            });

            modelBuilder.Entity<RestricaoEstudo>(entity =>
            {
                entity.HasKey(e => new { e.IdTprestricao, e.IdEstudomontador }).HasName("pk_tb_restricaoestudo");

                entity.ToTable("tb_restricaoestudo");

                entity.HasIndex(e => e.IdEstadorestricaoestudomontador, "in_fk_estadorestricaoestudomontador_restricaoestudo");

                entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_restricaoestudo");

                entity.HasIndex(e => e.IdTprestricao, "in_fk_tprestricao_restricaoestudo");

                entity.Property(e => e.IdTprestricao).HasColumnName("id_tprestricao");
                entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
                entity.Property(e => e.IdEstadorestricaoestudomontador).HasColumnName("id_estadorestricaoestudomontador");
                entity.Property(e => e.LgnUsuariocheckout)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lgn_usuariocheckout");
                entity.Property(e => e.VerControleconcorrencia)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("ver_controleconcorrencia");

                entity.HasOne(d => d.IdEstadorestricaoestudomontadorNavigation).WithMany(p => p.TbRestricaoestudos)
                    .HasForeignKey(d => d.IdEstadorestricaoestudomontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estadorestricaoestudomontador_restricaoestudo");

                entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbRestricaoestudos)
                    .HasForeignKey(d => d.IdEstudomontador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estudomontador_restricaoestudo");

                entity.HasOne(d => d.IdTprestricaoNavigation).WithMany(p => p.TbRestricaoestudos)
                    .HasForeignKey(d => d.IdTprestricao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tprestricao_restricaoestudo");
            });

            modelBuilder.Entity<ResultadoColetaPmo>(entity =>
            {
                entity.HasKey(e => e.IdResultadocoletapmo).HasName("pk_tb_resultadocoletapmo");

                entity.ToTable("tb_resultadocoletapmo");

                entity.HasIndex(e => e.IdArquivofonteresultpmo, "in_fk_arquivofonteresultpmo_resultadocoletapmo");

                entity.Property(e => e.IdResultadocoletapmo)
                    .ValueGeneratedNever()
                    .HasColumnName("id_resultadocoletapmo");
                entity.Property(e => e.DinUltimaalteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("din_ultimaalteracao");
                entity.Property(e => e.IdArquivofonteresultpmo).HasColumnName("id_arquivofonteresultpmo");
                entity.Property(e => e.NomResultadocoletapmo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("nom_resultadocoletapmo");
                entity.Property(e => e.NomUsuarioultimaalteracao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nom_usuarioultimaalteracao");
                entity.Property(e => e.ObsResultadocoletapmo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("obs_resultadocoletapmo");

                entity.HasOne(d => d.IdArquivofonteresultpmoNavigation).WithMany(p => p.TbResultadocoletapmos)
                    .HasForeignKey(d => d.IdArquivofonteresultpmo)
                    .HasConstraintName("fk_arquivofonteresultpmo_resultadocoletapmo");
            });

            modelBuilder.Entity<SemanaOperativa>(entity =>
            {
                entity.HasKey(e => e.IdSemanaoperativa).HasName("pk_tb_semanaoperativa");

                entity.ToTable("tb_semanaoperativa");

                entity.HasIndex(e => e.IdPmo, "in_fk_pmo_semanaoperativa").HasFillFactor(90);

                entity.HasIndex(e => e.IdTpsituacaosemanaoper, "in_fk_tpsituacaosemanaoper_semanaoperativa").HasFillFactor(90);

                entity.Property(e => e.IdSemanaoperativa).HasColumnName("id_semanaoperativa");
                entity.Property(e => e.DatFimmanutencao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dat_fimmanutencao");
                entity.Property(e => e.DatFimsemana)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dat_fimsemana");
                entity.Property(e => e.DatIniciomanutencao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dat_iniciomanutencao");
                entity.Property(e => e.DatIniciosemana)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dat_iniciosemana");
                entity.Property(e => e.DatReuniao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dat_reuniao");
                entity.Property(e => e.DinUltimaalteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("din_ultimaalteracao");
                entity.Property(e => e.IdPmo).HasColumnName("id_pmo");
                entity.Property(e => e.IdTpsituacaosemanaoper).HasColumnName("id_tpsituacaosemanaoper");
                entity.Property(e => e.NomSemanaoperativa)
                    .HasMaxLength(150)
                    .HasColumnName("nom_semanaoperativa");
                entity.Property(e => e.NumRevisao).HasColumnName("num_revisao");
                entity.Property(e => e.VerControleconcorrencia)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("ver_controleconcorrencia");

                entity.HasOne(d => d.IdPmoNavigation).WithMany(p => p.TbSemanaoperativas)
                    .HasForeignKey(d => d.IdPmo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pmo_semanaoperativa");

                entity.HasOne(d => d.IdTpsituacaosemanaoperNavigation).WithMany(p => p.TbSemanaoperativas)
                    .HasForeignKey(d => d.IdTpsituacaosemanaoper)
                    .HasConstraintName("fk_tpsituacaosemanaoper_semanaoperativa");
            });

            modelBuilder.Entity<Titulacao>(entity =>
            {
                entity.HasKey(e => e.IdTitulacao).HasName("pk_tb_titulacao");

                entity.ToTable("tb_titulacao");

                entity.Property(e => e.IdTitulacao).HasColumnName("id_titulacao");
                entity.Property(e => e.CodTitulacao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cod_titulacao");
                entity.Property(e => e.NomTitulacao)
                    .HasMaxLength(50)
                    .HasColumnName("nom_titulacao");
            });

            modelBuilder.Entity<CategoriaInsumo>(entity =>
            {
                entity.HasKey(e => e.IdTpcategoriainsumo).HasName("pk_tb_tpcategoriainsumo");

                entity.ToTable("tb_tpcategoriainsumo");

                entity.Property(e => e.IdTpcategoriainsumo)
                    .ValueGeneratedNever()
                    .HasColumnName("id_tpcategoriainsumo");
                entity.Property(e => e.DscTpcategoriainsumo)
                    .HasMaxLength(20)
                    .HasColumnName("dsc_tpcategoriainsumo");
                entity.Property(e => e.FlgMontador).HasColumnName("flg_montador");
                entity.Property(e => e.FlgPmo).HasColumnName("flg_pmo");
            });

            modelBuilder.Entity<Coleta>(entity =>
            {
                entity.HasKey(e => e.IdTpcoleta).HasName("pk_tb_tpcoleta");

                entity.ToTable("tb_tpcoleta");

                entity.Property(e => e.IdTpcoleta)
                    .ValueGeneratedNever()
                    .HasColumnName("id_tpcoleta");
                entity.Property(e => e.DscTpcoleta)
                    .HasMaxLength(50)
                    .HasColumnName("dsc_tpcoleta");
                entity.Property(e => e.FlgBlocomontador).HasColumnName("flg_blocomontador");
                entity.Property(e => e.FlgMnemonicomontador).HasColumnName("flg_mnemonicomontador");
                entity.Property(e => e.FlgPmo).HasColumnName("flg_pmo");
            });

            modelBuilder.Entity<DadoGrandeza>(entity =>
            {
                entity.HasKey(e => e.IdTpdadograndeza).HasName("pk_tb_tpdadograndeza");

                entity.ToTable("tb_tpdadograndeza");

                entity.Property(e => e.IdTpdadograndeza)
                    .ValueGeneratedNever()
                    .HasColumnName("id_tpdadograndeza");
                entity.Property(e => e.DscTpdadograndeza)
                    .HasMaxLength(20)
                    .HasColumnName("dsc_tpdadograndeza");
                entity.Property(e => e.FlgMontador).HasColumnName("flg_montador");
                entity.Property(e => e.FlgPmo).HasColumnName("flg_pmo");
            });

            modelBuilder.Entity<Estagio>(entity =>
            {
                entity.HasKey(e => e.IdTpestagio).HasName("pk_tb_tpestagio");

                entity.ToTable("tb_tpestagio");

                entity.Property(e => e.IdTpestagio)
                    .ValueGeneratedNever()
                    .HasColumnName("id_tpestagio");
                entity.Property(e => e.DscTpestagio)
                    .HasMaxLength(50)
                    .HasColumnName("dsc_tpestagio");
            });

            modelBuilder.Entity<TipoImportacaoPmo>(entity =>
            {
                entity.HasKey(e => e.IdTpimportacaopmo).HasName("pk_tb_tpimportacaopmo");

                entity.ToTable("tb_tpimportacaopmo");

                entity.Property(e => e.IdTpimportacaopmo)
                    .ValueGeneratedNever()
                    .HasColumnName("id_tpimportacaopmo");
                entity.Property(e => e.DscTpimportacaopmo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsc_tpimportacaopmo");
            });

            modelBuilder.Entity<Limite>(entity =>
            {
                entity.HasKey(e => e.IdTplimite).HasName("pk_tb_tplimite");

                entity.ToTable("tb_tplimite");

                entity.Property(e => e.IdTplimite)
                    .ValueGeneratedNever()
                    .HasColumnName("id_tplimite");
                entity.Property(e => e.DscTplimite)
                    .HasMaxLength(20)
                    .HasColumnName("dsc_tplimite");
            });

            modelBuilder.Entity<TipoManutencaoProgramada>(entity =>
            {
                entity.HasKey(e => e.IdTpmanutencaoprogramada).HasName("pk_tb_tpmanutencaoprogramada");

                entity.ToTable("tb_tpmanutencaoprogramada");

                entity.Property(e => e.IdTpmanutencaoprogramada).HasColumnName("id_tpmanutencaoprogramada");
                entity.Property(e => e.NomTpmanutencaoprogramada)
                    .HasMaxLength(70)
                    .HasColumnName("nom_tpmanutencaoprogramada");
            });

            modelBuilder.Entity<TipoMnemonico>(entity =>
            {
                entity.HasKey(e => e.IdTpmnemonico).HasName("pk_tb_tpmnemonico");

                entity.ToTable("tb_tpmnemonico");

                entity.Property(e => e.IdTpmnemonico)
                    .ValueGeneratedNever()
                    .HasColumnName("id_tpmnemonico");
                entity.Property(e => e.NomTpmnemonico)
                    .HasMaxLength(50)
                    .HasColumnName("nom_tpmnemonico");
            });

            modelBuilder.Entity<Patamar>(entity =>
            {
                entity.HasKey(e => e.IdTppatamar).HasName("pk_tb_tppatamar");

                entity.ToTable("tb_tppatamar");

                entity.Property(e => e.IdTppatamar)
                    .ValueGeneratedNever()
                    .HasColumnName("id_tppatamar");
                entity.Property(e => e.DscTppatamar)
                    .HasMaxLength(20)
                    .HasColumnName("dsc_tppatamar");
                entity.Property(e => e.ValAzul).HasColumnName("val_azul");
                entity.Property(e => e.ValVerde).HasColumnName("val_verde");
                entity.Property(e => e.ValVermelho).HasColumnName("val_vermelho");
            });

            modelBuilder.Entity<TipoPeriodoMontador>(entity =>
            {
                entity.HasKey(e => e.IdTpperiodomontador).HasName("pk_tb_tpperiodomontador");

                entity.ToTable("tb_tpperiodomontador");

                entity.Property(e => e.IdTpperiodomontador)
                    .ValueGeneratedNever()
                    .HasColumnName("id_tpperiodomontador");
                entity.Property(e => e.NomTpperiodomontador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nom_tpperiodomontador");
            });

            modelBuilder.Entity<TipoRestricao>(entity =>
            {
                entity.HasKey(e => e.IdTprestricao).HasName("pk_tb_tprestricao");

                entity.ToTable("tb_tprestricao");

                entity.Property(e => e.IdTprestricao).HasColumnName("id_tprestricao");
                entity.Property(e => e.CodTprestricao)
                    .HasMaxLength(10)
                    .HasColumnName("cod_tprestricao");
                entity.Property(e => e.DscTprestricao)
                    .HasMaxLength(50)
                    .HasColumnName("dsc_tprestricao");

                entity.HasMany(d => d.IdBlocos).WithMany(p => p.IdTprestricaos)
                    .UsingEntity<Dictionary<string, object>>(
                        "TbTprestricaobloco",
                        r => r.HasOne<Bloco>().WithMany()
                            .HasForeignKey("IdBloco")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_bloco_tprestricaobloco"),
                        l => l.HasOne<TipoRestricao>().WithMany()
                            .HasForeignKey("IdTprestricao")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("fk_tprestricao_tprestricaobloco"),
                        j =>
                        {
                            j.HasKey("IdTprestricao", "IdBloco").HasName("pk_tb_tprestricaobloco");
                            j.ToTable("tb_tprestricaobloco");
                            j.HasIndex(new[] { "IdBloco" }, "in_fk_bloco_tprestricaobloco");
                            j.HasIndex(new[] { "IdTprestricao" }, "in_fk_tprestricao_tprestricaobloco");
                            j.IndexerProperty<int>("IdTprestricao").HasColumnName("id_tprestricao");
                            j.IndexerProperty<int>("IdBloco").HasColumnName("id_bloco");
                        });
            });

            modelBuilder.Entity<SituacaoColetaInsumo>(entity =>
            {
                entity.HasKey(e => e.IdTpsituacaocoletainsumo).HasName("pk_tb_tpsituacaocoletainsumo");

                entity.ToTable("tb_tpsituacaocoletainsumo");

                entity.Property(e => e.IdTpsituacaocoletainsumo)
                    .ValueGeneratedNever()
                    .HasColumnName("id_tpsituacaocoletainsumo");
                entity.Property(e => e.DscTpsituacaocoletainsumo)
                    .HasMaxLength(20)
                    .HasColumnName("dsc_tpsituacaocoletainsumo");
            });

            modelBuilder.Entity<SituacaoSemanaOperativa>(entity =>
            {
                entity.HasKey(e => e.IdTpsituacaosemanaoper).HasName("pk_tb_tpsituacaosemanaoper");

                entity.ToTable("tb_tpsituacaosemanaoper");

                entity.Property(e => e.IdTpsituacaosemanaoper)
                    .ValueGeneratedNever()
                    .HasColumnName("id_tpsituacaosemanaoper");
                entity.Property(e => e.DscSituacaosemanaoper)
                    .HasMaxLength(20)
                    .HasColumnName("dsc_situacaosemanaoper");
            });

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(WebPmoContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
