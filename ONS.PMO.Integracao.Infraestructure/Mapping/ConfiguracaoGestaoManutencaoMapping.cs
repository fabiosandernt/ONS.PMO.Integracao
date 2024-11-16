using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ConfiguracaoGestaoManutencaoMapping : IEntityTypeConfiguration<ConfiguracaoGestaoManutencao>
    {
        public void Configure(EntityTypeBuilder<ConfiguracaoGestaoManutencao> entity)
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

            entity.HasOne(d => d.IdSemanaoperativaNavigation).WithMany(p => p.TbConfiguracaogestaomanutencaos)
                .HasForeignKey(d => d.IdSemanaoperativa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_semanaoperativa_configuracaogestaomanutencao");

            entity.HasMany(d => d.IdAgenteinstituicaos).WithMany(p => p.IdConfiguracaogestaomanutencaos)
                .UsingEntity<Dictionary<string, object>>(
                    "TbConfiguracaogestaomanutencaoagente",
                    r => r.HasOne<Agenteinstituicao>().WithMany()
                        .HasForeignKey("IdAgenteinstituicao")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_agenteinstituicao_configuracaogestaomanutencaoagente"),
                    l => l.HasOne<ConfiguracaoGestaoManutencao>().WithMany()
                        .HasForeignKey("IdConfiguracaogestaomanutencao")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_configuracaogestaomanutencao_configuracaogestaomanutencaoagente"),
                    j =>
                    {
                        j.HasKey("IdConfiguracaogestaomanutencao", "IdAgenteinstituicao").HasName("pk_tb_configuracaogestaomanutencaoagentes");
                        j.ToTable("tb_configuracaogestaomanutencaoagente");
                        j.HasIndex(new[] { "IdAgenteinstituicao" }, "in_fk_agenteinstituicao_configuracaogestaomanutencaoagente");
                        j.HasIndex(new[] { "IdConfiguracaogestaomanutencao" }, "in_fk_configuracaogestaomanutencao_configuracaogestaomanutencaoagente");
                        j.IndexerProperty<int>("IdConfiguracaogestaomanutencao").HasColumnName("id_configuracaogestaomanutencao");
                        j.IndexerProperty<int>("IdAgenteinstituicao").HasColumnName("id_agenteinstituicao");
                    });
        }
    }
}
