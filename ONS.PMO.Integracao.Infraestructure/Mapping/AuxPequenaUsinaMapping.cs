using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class AuxPequenaUsinaMapping : IEntityTypeConfiguration<AuxPequenaUsina>
    {
        public void Configure(EntityTypeBuilder<AuxPequenaUsina> entity)
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
                .HasForeignKey<AuxPequenaUsina>(d => d.IdOrigemcoletamontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_origemcoletamontador_aux_pequenausina");

            entity.HasOne(d => d.IdSubsistemamontadorNavigation).WithMany(p => p.TbAuxPequenausinas)
                .HasForeignKey(d => d.IdSubsistemamontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_aux_subsistemamontador_aux_pequenausina");
        }
    }
}
