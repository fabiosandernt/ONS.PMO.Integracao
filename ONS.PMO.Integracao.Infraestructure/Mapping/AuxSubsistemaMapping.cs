using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class AuxSubsistemaMapping : IEntityTypeConfiguration<AuxSubsistema>
    {
        public void Configure(EntityTypeBuilder<AuxSubsistema> entity)
        {
            entity.HasKey(e => e.IdOrigemcoleta).HasName("pk_tb_aux_subsistema");

            entity.ToTable("tb_aux_subsistema");

            entity.HasIndex(e => e.IdOrigemcoleta, "in_fk_origemcoleta_aux_subsistema");

            entity.Property(e => e.IdOrigemcoleta)
                .HasMaxLength(50)
                .HasColumnName("id_origemcoleta");
            entity.Property(e => e.CodSubsistema)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cod_subsistema");

            entity.HasOne(d => d.IdOrigemcoletaNavigation).WithOne(p => p.TbAuxSubsistema)
                .HasForeignKey<AuxSubsistema>(d => d.IdOrigemcoleta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_origemcoleta_aux_subsistema");
        }
    }
}