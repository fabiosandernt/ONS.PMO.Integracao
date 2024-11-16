using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class InsumoEstruturadoMapping : IEntityTypeConfiguration<InsumoEstruturado>
    {
        public void Configure(EntityTypeBuilder<InsumoEstruturado> entity)
        {
            entity.HasKey(e => e.IdInsumopmo).HasName("pk_tb_insumoestruturado");

            entity.ToTable("tb_insumoestruturado");

            entity.HasIndex(e => e.IdInsumopmo, "in_fk_insumopmo_insumoestruturado");

            entity.HasIndex(e => e.IdTpcategoriainsumo, "in_fk_tpcategoriainsumo_insumoestruturado");

            entity.HasIndex(e => e.IdTpcoleta, "in_fk_tpcoleta_insumoestruturado");

            entity.Property(e => e.IdInsumopmo)
                .ValueGeneratedNever()
                .HasColumnName("id_insumopmo");
            entity.Property(e => e.IdTpcategoriainsumo).HasColumnName("id_tpcategoriainsumo");
            entity.Property(e => e.IdTpcoleta).HasColumnName("id_tpcoleta");
            entity.Property(e => e.NumOrdemblocomontador).HasColumnName("num_ordemblocomontador");
            entity.Property(e => e.QtdMesesadiante).HasColumnName("qtd_mesesadiante");
            entity.Property(e => e.TipBlocomontador)
                .HasMaxLength(6)
                .HasColumnName("tip_blocomontador");

            entity.HasOne(d => d.IdInsumopmoNavigation).WithOne(p => p.TbInsumoestruturado)
                .HasForeignKey<InsumoEstruturado>(d => d.IdInsumopmo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_insumopmo_insumoestruturado");

            entity.HasOne(d => d.IdTpcategoriainsumoNavigation).WithMany(p => p.TbInsumoestruturados)
                .HasForeignKey(d => d.IdTpcategoriainsumo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tpcategoriainsumo_insumoestruturado");

            entity.HasOne(d => d.IdTpcoletaNavigation).WithMany(p => p.TbInsumoestruturados)
                .HasForeignKey(d => d.IdTpcoleta)
                .HasConstraintName("fk_tpcoleta_insumoestruturado");
        }
    }
}
