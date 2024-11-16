using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.BDT;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class TipoImportacaoPMOMapping : IEntityTypeConfiguration<TipoImportacaoPMO>
    {
        public void Configure(EntityTypeBuilder<TipoImportacaoPMO> entity)
        {
            entity.HasKey(e => e.IdTpimportacaopmo).HasName("pk_tb_tpimportacaopmo");

            entity.ToTable("tb_tpimportacaopmo");

            entity.Property(e => e.IdTpimportacaopmo)
                .ValueGeneratedNever()
                .HasColumnName("id_tpimportacaopmo");
            entity.Property(e => e.DscTpimportacaopmo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dsc_tpimportacaopmo");
        }
    }
}
