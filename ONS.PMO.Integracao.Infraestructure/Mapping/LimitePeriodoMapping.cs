using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class LimitePeriodoMapping : IEntityTypeConfiguration<LimitePeriodo>
    {
        public void Configure(EntityTypeBuilder<LimitePeriodo> entity)
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
        }
    }
}