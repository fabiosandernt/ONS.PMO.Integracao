using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class SituacaoColetaInsumoMapping : IEntityTypeConfiguration<SituacaoColetaInsumo>
    {
        public void Configure(EntityTypeBuilder<SituacaoColetaInsumo> entity)
        {
            entity.HasKey(e => e.IdTpsituacaocoletainsumo).HasName("pk_tb_tpsituacaocoletainsumo");

            entity.ToTable("tb_tpsituacaocoletainsumo");

            entity.Property(e => e.IdTpsituacaocoletainsumo)
                .ValueGeneratedNever()
                .HasColumnName("id_tpsituacaocoletainsumo");
            entity.Property(e => e.DscTpsituacaocoletainsumo)
                .HasMaxLength(20)
                .HasColumnName("dsc_tpsituacaocoletainsumo");
        }
    }
}