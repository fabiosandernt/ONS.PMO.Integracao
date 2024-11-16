using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class InsumoNaoEstruturadoMapping : IEntityTypeConfiguration<InsumoNaoEstruturado>
    {
        public void Configure(EntityTypeBuilder<InsumoNaoEstruturado> entity)
        {
            entity.HasKey(e => e.IdInsumopmo).HasName("pk_tb_insumonaoestruturado");

            entity.ToTable("tb_insumonaoestruturado");

            entity.HasIndex(e => e.IdInsumopmo, "in_fk_insumopmo_insumonaoestruturado");

            entity.Property(e => e.IdInsumopmo)
                .ValueGeneratedNever()
                .HasColumnName("id_insumopmo");
            entity.Property(e => e.FlgUtilizadoconvergencia).HasColumnName("flg_utilizadoconvergencia");
            entity.Property(e => e.FlgUtilizadodecomp).HasColumnName("flg_utilizadodecomp");
            entity.Property(e => e.FlgUtilizadoprocessamento).HasColumnName("flg_utilizadoprocessamento");
            entity.Property(e => e.FlgUtilizadopublicacao).HasColumnName("flg_utilizadopublicacao");

            entity.HasOne(d => d.IdInsumopmoNavigation).WithOne(p => p.TbInsumonaoestruturado)
                .HasForeignKey<InsumoNaoEstruturado>(d => d.IdInsumopmo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_insumopmo_insumonaoestruturado");
        }
    }
}