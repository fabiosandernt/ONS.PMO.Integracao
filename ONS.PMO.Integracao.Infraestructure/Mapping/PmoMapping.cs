using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class PmoMapping : IEntityTypeConfiguration<Pmo>
    {
        public void Configure(EntityTypeBuilder<Pmo> entity)
        {
            entity.HasKey(e => e.IdPmo).HasName("pk_tb_pmo");

            entity.ToTable("tb_pmo");

            entity.Property(e => e.IdPmo).HasColumnName("id_pmo");
            entity.Property(e => e.AnoReferencia).HasColumnName("ano_referencia");
            entity.Property(e => e.MesReferencia).HasColumnName("mes_referencia");
            entity.Property(e => e.QtdMesesadiante).HasColumnName("qtd_mesesadiante");
            entity.Property(e => e.VerControleconcorrencia)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ver_controleconcorrencia");
        }
    }
}