using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.BDT;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ManutencaoPMOMapping : IEntityTypeConfiguration<ManutencaoPMO>
    {
        public void Configure(EntityTypeBuilder<ManutencaoPMO> entity)
        {
            entity.HasKey(e => e.IdManutencaopmo).HasName("pk_tb_manutencaopmo");

            entity.ToTable("tb_manutencaopmo");

            entity.HasIndex(e => e.IdAgenteinstituicao, "in_fk_agenteintituicao_manutencaopmo");

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
            entity.Property(e => e.IdAgenteinstituicao).HasColumnName("id_agenteinstituicao");
            entity.Property(e => e.IdConfiguracaogestaomanutencao).HasColumnName("id_configuracaogestaomanutencao");
            entity.Property(e => e.IdEstadomanutencaopmo).HasColumnName("id_estadomanutencaopmo");
            entity.Property(e => e.IdOrigemcoletauge)
                .HasMaxLength(50)
                .HasColumnName("id_origemcoletauge");
            entity.Property(e => e.NumSgi).HasColumnName("num_sgi");

            entity.HasOne(d => d.IdAgenteinstituicaoNavigation).WithMany(p => p.TbManutencaopmos)
                .HasForeignKey(d => d.IdAgenteinstituicao)
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
                    r => r.HasOne<ManutencaoPMO>().WithMany()
                        .HasForeignKey("IdManutencaopmocondicionada")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_manutencaopmo_manutencaopmocondicionada_condicionada"),
                    l => l.HasOne<ManutencaoPMO>().WithMany()
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
                    r => r.HasOne<ManutencaoPMO>().WithMany()
                        .HasForeignKey("IdManutencaopmo")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_manutencaopmo_manutencaopmocondicionada"),
                    l => l.HasOne<ManutencaoPMO>().WithMany()
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
        }
    }
}
