using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class RecuperacaoDadosBlocoMapping : IEntityTypeConfiguration<RecuperacaoDadosBloco>
    {
        public void Configure(EntityTypeBuilder<RecuperacaoDadosBloco> entity)
        {
            entity.HasKey(e => new { e.IdRecuperacaodados, e.IdBloco }).HasName("pk_tb_recuperacaodadosbloco");

            entity.ToTable("tb_recuperacaodadosbloco");

            entity.HasIndex(e => e.IdRecuperacaodados, "in_fk_recuperacaodados_recuperacaodadosbloco");

            entity.Property(e => e.IdRecuperacaodados).HasColumnName("id_recuperacaodados");
            entity.Property(e => e.IdBloco).HasColumnName("id_bloco");

            entity.HasOne(d => d.IdRecuperacaodadosNavigation).WithMany(p => p.TbRecuperacaodadosblocos)
                .HasForeignKey(d => d.IdRecuperacaodados)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_recuperacaodados_recuperacaodadosbloco");
        }
    }
}
