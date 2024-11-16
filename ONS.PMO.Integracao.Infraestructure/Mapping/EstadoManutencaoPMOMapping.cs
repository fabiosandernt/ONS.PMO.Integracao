using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.BDT;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class EstadoManutencaoPMOMapping : IEntityTypeConfiguration<EstadoManutencaoPMO>
    {
        public void Configure(EntityTypeBuilder<EstadoManutencaoPMO> entity)
        {
            entity.HasKey(e => e.IdEstadomanutencaopmo)
        .HasName("pk_tb_estadomanutencaopmo");

            entity.ToTable("tb_estadomanutencaopmo");

            entity.Property(e => e.IdEstadomanutencaopmo).HasColumnName("id_estadomanutencaopmo");
            entity.Property(e => e.DscEstado)
                .HasMaxLength(20)
                .HasColumnName("dsc_estado");
        }
    }
}
