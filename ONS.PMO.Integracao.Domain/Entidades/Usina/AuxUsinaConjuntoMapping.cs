using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

public class AuxUsinaConjuntoMapping : IEntityTypeConfiguration<AuxUsinaConjunto>
{
    public void Configure(EntityTypeBuilder<AuxUsinaConjunto> entity)
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
            .HasForeignKey<AuxUsinaConjunto>(d => d.IdOrigemcoletamontador)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_origemcoletamontador_aux_usinaconjunto");

        entity.HasOne(d => d.IdUsinamontadorNavigation).WithMany(p => p.TbAuxUsinaconjuntos)
            .HasForeignKey(d => d.IdUsinamontador)
            .HasConstraintName("fk_aux_usinamontador_aux_usinaconjunto");
    }
}
