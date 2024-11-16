using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class LimitesPatamarMapping : IEntityTypeConfiguration<LimitesPatamar>
    {
        public void Configure(EntityTypeBuilder<LimitesPatamar> entity)
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
        }
    }
}