using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class GeracaoMinimaPeriodoMapping : IEntityTypeConfiguration<GeracaoMinimaPeriodo>
    {
        public void Configure(EntityTypeBuilder<GeracaoMinimaPeriodo> entity)
        {
            entity.HasKey(e => e.IdGeracaominimaperiododia).HasName("pk_tb_geracaominima");

            entity.ToTable("tb_geracaominimaperiododia");

            entity.HasIndex(e => e.IdConjuntogeracaominima, "in_fk_conjuntogeracaominima_geracaominima");

            entity.HasIndex(e => e.IdDiasemana, "in_fk_diasemana_geracaominima");

            entity.HasIndex(e => e.IdTppatamar, "in_fk_tppatamar_geracaominima");

            entity.Property(e => e.IdGeracaominimaperiododia).HasColumnName("id_geracaominimaperiododia");
            entity.Property(e => e.HorFinal).HasColumnName("hor_final");
            entity.Property(e => e.HorInicial).HasColumnName("hor_inicial");
            entity.Property(e => e.IdConjuntogeracaominima).HasColumnName("id_conjuntogeracaominima");
            entity.Property(e => e.IdDiasemana).HasColumnName("id_diasemana");
            entity.Property(e => e.IdTppatamar).HasColumnName("id_tppatamar");
            entity.Property(e => e.ValGeracaominimaperiododia).HasColumnName("val_geracaominimaperiododia");

            entity.HasOne(d => d.IdConjuntogeracaominimaNavigation).WithMany(p => p.TbGeracaominimaperiododia)
                .HasForeignKey(d => d.IdConjuntogeracaominima)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_conjuntogeracaominima_geracaominima");

            entity.HasOne(d => d.IdDiasemanaNavigation).WithMany(p => p.TbGeracaominimaperiododia)
                .HasForeignKey(d => d.IdDiasemana)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_diasemana_geracaominima");

            entity.HasOne(d => d.IdTppatamarNavigation).WithMany(p => p.TbGeracaominimaperiododia)
                .HasForeignKey(d => d.IdTppatamar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tppatamar_geracaominima");
        }
    }
}
