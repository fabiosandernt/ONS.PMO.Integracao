using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class DadoColetumMapping : IEntityTypeConfiguration<DadoColeta>
    {
        public void Configure(EntityTypeBuilder<DadoColeta> entity)
        {
            entity.HasKey(e => e.IdDadocoleta).HasName("pk_tb_dadocoleta");

            entity.ToTable("tb_dadocoleta");

            entity.HasIndex(e => e.IdColetainsumo, "in_fk_coletainsumo_dadocoleta");

            entity.HasIndex(e => e.IdGabarito, "in_fk_gabarito_dadocoleta");

            entity.HasIndex(e => e.IdGrandeza, "in_fk_grandeza_dadocoleta");

            entity.Property(e => e.IdDadocoleta).HasColumnName("id_dadocoleta");
            entity.Property(e => e.IdColetainsumo).HasColumnName("id_coletainsumo");
            entity.Property(e => e.IdGabarito).HasColumnName("id_gabarito");
            entity.Property(e => e.IdGrandeza).HasColumnName("id_grandeza");
            entity.Property(e => e.TipDadocoleta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tip_dadocoleta");

            entity.HasOne(d => d.IdColetainsumoNavigation).WithMany(p => p.TbDadocoleta)
                .HasForeignKey(d => d.IdColetainsumo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_coletainsumo_dadocoleta");

            entity.HasOne(d => d.IdGabaritoNavigation).WithMany(p => p.TbDadocoleta)
                .HasForeignKey(d => d.IdGabarito)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_gabarito_dadocoleta");

            entity.HasOne(d => d.IdGrandezaNavigation).WithMany(p => p.TbDadocoleta)
                .HasForeignKey(d => d.IdGrandeza)
                .HasConstraintName("fk_grandeza_dadocoleta");
        }
    }
}
