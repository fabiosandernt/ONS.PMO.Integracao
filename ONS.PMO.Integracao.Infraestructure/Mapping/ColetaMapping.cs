using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ColetaMapping : IEntityTypeConfiguration<Coleta>
    {
        public void Configure(EntityTypeBuilder<Coleta> entity)
        {
            entity.HasKey(e => e.IdTpcoleta).HasName("pk_tb_tpcoleta");

            entity.ToTable("tb_tpcoleta");

            entity.Property(e => e.IdTpcoleta)
                .ValueGeneratedNever()
                .HasColumnName("id_tpcoleta");
            entity.Property(e => e.DscTpcoleta)
                .HasMaxLength(50)
                .HasColumnName("dsc_tpcoleta");
            entity.Property(e => e.FlgBlocomontador).HasColumnName("flg_blocomontador");
            entity.Property(e => e.FlgMnemonicomontador).HasColumnName("flg_mnemonicomontador");
            entity.Property(e => e.FlgPmo).HasColumnName("flg_pmo");
        }
    }
}
