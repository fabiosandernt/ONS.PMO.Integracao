using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class PrestricaoMapping : IEntityTypeConfiguration<Prestricao>
    {
        public void Configure(EntityTypeBuilder<Prestricao> entity)
        {
            entity.HasKey(e => e.IdTprestricao).HasName("pk_tb_tprestricao");

            entity.ToTable("tb_tprestricao");

            entity.Property(e => e.IdTprestricao).HasColumnName("id_tprestricao");
            entity.Property(e => e.CodTprestricao)
                .HasMaxLength(10)
                .HasColumnName("cod_tprestricao");
            entity.Property(e => e.DscTprestricao)
                .HasMaxLength(50)
                .HasColumnName("dsc_tprestricao");

            entity.HasMany(d => d.IdBlocos).WithMany(p => p.IdTprestricaos)
                .UsingEntity<Dictionary<string, object>>(
                    "TbTprestricaobloco",
                    r => r.HasOne<Bloco>().WithMany()
                        .HasForeignKey("IdBloco")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_bloco_tprestricaobloco"),
                    l => l.HasOne<Prestricao>().WithMany()
                        .HasForeignKey("IdTprestricao")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_tprestricao_tprestricaobloco"),
                    j =>
                    {
                        j.HasKey("IdTprestricao", "IdBloco").HasName("pk_tb_tprestricaobloco");
                        j.ToTable("tb_tprestricaobloco");
                        j.HasIndex(new[] { "IdBloco" }, "in_fk_bloco_tprestricaobloco");
                        j.HasIndex(new[] { "IdTprestricao" }, "in_fk_tprestricao_tprestricaobloco");
                        j.IndexerProperty<int>("IdTprestricao").HasColumnName("id_tprestricao");
                        j.IndexerProperty<int>("IdBloco").HasColumnName("id_bloco");
                    });
        }
    }
}