using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.BDT;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ParametroPMOMapping : IEntityTypeConfiguration<ParametroPMO>
    {
        public void Configure(EntityTypeBuilder<ParametroPMO> entity)
        {
            entity.HasKey(e => e.IdParametropmo).HasName("pk_tb_parametropmo");

            entity.ToTable("tb_parametropmo");

            entity.Property(e => e.IdParametropmo).HasColumnName("id_parametropmo");
            entity.Property(e => e.DscParametropmo)
                .HasMaxLength(255)
                .HasColumnName("dsc_parametropmo");
            entity.Property(e => e.NomParametropmo)
                .HasMaxLength(50)
                .HasColumnName("nom_parametropmo");
            entity.Property(e => e.ValParametropmo)
                .HasMaxLength(1000)
                .HasColumnName("val_parametropmo");
        }
    }
}
