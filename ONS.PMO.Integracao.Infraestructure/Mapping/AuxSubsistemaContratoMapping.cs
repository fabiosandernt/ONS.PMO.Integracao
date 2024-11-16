using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class AuxSubsistemaContratoMapping : IEntityTypeConfiguration<AuxSubsistemaContrato>
{
        public void Configure(EntityTypeBuilder<AuxSubsistemaContrato> entity)
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
                .HasForeignKey<AuxSubsistemaContrato>(d => d.IdOrigemcoletamontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_origemcoletamontador_aux_subsistemacontrato");

            entity.HasOne(d => d.IdOrigemcoletamontadorsubsistemaNavigation).WithMany(p => p.TbAuxSubsistemacontratos)
                .HasForeignKey(d => d.IdOrigemcoletamontadorsubsistema)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_aux_subsistemamontador_aux_subsistemacontrato");
        } 
    }
}
