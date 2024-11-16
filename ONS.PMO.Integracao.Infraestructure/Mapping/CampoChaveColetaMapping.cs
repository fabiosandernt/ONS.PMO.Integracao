using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class CampoChaveColetaMapping : IEntityTypeConfiguration<CampoChaveColeta>
    {
        public void Configure(EntityTypeBuilder<CampoChaveColeta> entity)
        {
            entity.HasKey(e => new { e.IdCampochave, e.IdTpcoleta }).HasName("pk_tb_campochavetpcoleta");

            entity.ToTable("tb_campochavetpcoleta");

            entity.HasIndex(e => e.IdCampochave, "in_fk_campochave_campochavetpcoleta");

            entity.HasIndex(e => e.IdTpcoleta, "in_fk_tpcoleta_campochavetpcoleta");

            entity.Property(e => e.IdCampochave).HasColumnName("id_campochave");
            entity.Property(e => e.IdTpcoleta).HasColumnName("id_tpcoleta");
            entity.Property(e => e.FlgPrincipal).HasColumnName("flg_principal");
            entity.Property(e => e.NomColorigemcoleta)
                .HasMaxLength(50)
                .HasColumnName("nom_colorigemcoleta");

            entity.HasOne(d => d.IdCampochaveNavigation).WithMany(p => p.TbCampochavetpcoleta)
                .HasForeignKey(d => d.IdCampochave)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_campochave_campochavetpcoleta");

            entity.HasOne(d => d.IdTpcoletaNavigation).WithMany(p => p.TbCampochavetpcoleta)
                .HasForeignKey(d => d.IdTpcoleta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tpcoleta_campochavetpcoleta");
        }
    }
}