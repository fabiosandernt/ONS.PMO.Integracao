using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class HisModColetaInsumoMapping : IEntityTypeConfiguration<HistoricoColetaInsumo>
    {
        public void Configure(EntityTypeBuilder<HistoricoColetaInsumo> entity)
        {
            entity.HasKey(e => e.IdHistmodifcoletainsumo).HasName("pk_tb_histmodifcoletainsumo");

            entity.ToTable("tb_histmodifcoletainsumo");

            entity.HasIndex(e => e.IdColetainsumo, "in_fk_coletainsumo_histmodifcoletainsumo");

            entity.HasIndex(e => e.IdTpsituacaocoletainsumo, "in_fk_tpsituacaocoletainsumo_histmodifcoletainsumo");

            entity.Property(e => e.IdHistmodifcoletainsumo).HasColumnName("id_histmodifcoletainsumo");
            entity.Property(e => e.DinHistmodifcoletainsumo)
                .HasColumnType("datetime")
                .HasColumnName("din_histmodifcoletainsumo");
            entity.Property(e => e.IdColetainsumo).HasColumnName("id_coletainsumo");
            entity.Property(e => e.IdTpsituacaocoletainsumo).HasColumnName("id_tpsituacaocoletainsumo");

            entity.HasOne(d => d.IdColetainsumoNavigation).WithMany(p => p.TbHistmodifcoletainsumos)
                .HasForeignKey(d => d.IdColetainsumo)
                .HasConstraintName("fk_coletainsumo_histmodifcoletainsumo");

            entity.HasOne(d => d.IdTpsituacaocoletainsumoNavigation).WithMany(p => p.TbHistmodifcoletainsumos)
                .HasForeignKey(d => d.IdTpsituacaocoletainsumo)
                .HasConstraintName("fk_tpsituacaocoletainsumo_histmodifcoletainsumo");
        }
    }
}