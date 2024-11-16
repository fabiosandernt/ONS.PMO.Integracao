using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.BDT;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class RecuperacaoDadosAgentePMOMapping : IEntityTypeConfiguration<RecuperacaoDadosAgentePMO>
    {
        public void Configure(EntityTypeBuilder<RecuperacaoDadosAgentePMO> entity)
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
        }
    }
}
