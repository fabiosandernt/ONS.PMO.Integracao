using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class CategoriaInsumoMapping : IEntityTypeConfiguration<CategoriaInsumo>
    {
        public void Configure(EntityTypeBuilder<CategoriaInsumo> entity)
        {
            entity.HasKey(e => e.IdTpcategoriainsumo).HasName("pk_tb_tpcategoriainsumo");

            entity.ToTable("tb_tpcategoriainsumo");

            entity.Property(e => e.IdTpcategoriainsumo)
                .ValueGeneratedNever()
                .HasColumnName("id_tpcategoriainsumo");
            entity.Property(e => e.DscTpcategoriainsumo)
                .HasMaxLength(20)
                .HasColumnName("dsc_tpcategoriainsumo");
            entity.Property(e => e.FlgMontador).HasColumnName("flg_montador");
            entity.Property(e => e.FlgPmo).HasColumnName("flg_pmo");
        }
    }
}
