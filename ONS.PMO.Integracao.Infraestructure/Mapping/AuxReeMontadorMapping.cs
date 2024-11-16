using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.BDT;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class AuxReeMontadorMapping : IEntityTypeConfiguration<AuxReeMontador>
    {
        public void Configure(EntityTypeBuilder<AuxReeMontador> entity)
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
                .HasForeignKey<AuxReeMontador>(d => d.IdOrigemcoletamontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_origemcoletamontador_aux_reemontador");
        }
    }
}
