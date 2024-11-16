using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class DadoGrandezaMapping : IEntityTypeConfiguration<DadoGrandeza>
    {
        public void Configure(EntityTypeBuilder<DadoGrandeza> entity)
        {
            entity.HasKey(e => e.IdTpdadograndeza).HasName("pk_tb_tpdadograndeza");

            entity.ToTable("tb_tpdadograndeza");

            entity.Property(e => e.IdTpdadograndeza)
                .ValueGeneratedNever()
                .HasColumnName("id_tpdadograndeza");
            entity.Property(e => e.DscTpdadograndeza)
                .HasMaxLength(20)
                .HasColumnName("dsc_tpdadograndeza");
            entity.Property(e => e.FlgMontador).HasColumnName("flg_montador");
            entity.Property(e => e.FlgPmo).HasColumnName("flg_pmo");
        }
    }
}
