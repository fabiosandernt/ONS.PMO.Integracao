using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class GrandezaBlocoACMapping : IEntityTypeConfiguration<GrandezaBlocoAC>
    {
        public void Configure(EntityTypeBuilder<GrandezaBlocoAC> entity)
        {
            entity.HasKey(e => e.IdGrandezamontador).HasName("pk_tb_grandezablocoac");

            entity.ToTable("tb_grandezablocoac");

            entity.HasIndex(e => e.IdGrandezamontador, "in_fk_grandezamontador_grandezablocoac");

            entity.HasIndex(e => e.IdMnemonicoblocoac, "in_fk_mnemonicoblocoac_grandezablocoac");

            entity.Property(e => e.IdGrandezamontador)
                .ValueGeneratedNever()
                .HasColumnName("id_grandezamontador");
            entity.Property(e => e.IdMnemonicoblocoac).HasColumnName("id_mnemonicoblocoac");
            entity.Property(e => e.ValColfinal).HasColumnName("val_colfinal");
            entity.Property(e => e.ValColinicial).HasColumnName("val_colinicial");

            entity.HasOne(d => d.IdGrandezamontadorNavigation).WithOne(p => p.TbGrandezablocoac)
                .HasForeignKey<GrandezaBlocoAC>(d => d.IdGrandezamontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grandezamontador_grandezablocoac");

            entity.HasOne(d => d.IdMnemonicoblocoacNavigation).WithMany(p => p.TbGrandezablocoacs)
                .HasForeignKey(d => d.IdMnemonicoblocoac)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_mnemonicoblocoac_grandezablocoac");

            entity.HasMany(d => d.IdGrandezamontadordependentes).WithMany(p => p.IdGrandezamontadors)
                .UsingEntity<Dictionary<string, object>>(
                    "TbGrandezablocoacdependente",
                    r => r.HasOne<GrandezaBlocoAC>().WithMany()
                        .HasForeignKey("IdGrandezamontadordependente")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_grandezablocoac_grandezablocoacdependente_dependente"),
                    l => l.HasOne<GrandezaBlocoAC>().WithMany()
                        .HasForeignKey("IdGrandezamontador")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_grandezablocoac_grandezablocoacdependente_montador"),
                    j =>
                    {
                        j.HasKey("IdGrandezamontador", "IdGrandezamontadordependente").HasName("pk_tb_grandezablocoacdependente");
                        j.ToTable("tb_grandezablocoacdependente");
                        j.HasIndex(new[] { "IdGrandezamontadordependente" }, "in_fk_grandezablocoac_grandezablocoacdependente_dependente");
                        j.HasIndex(new[] { "IdGrandezamontador" }, "in_fk_grandezablocoac_grandezablocoacdependente_montador");
                        j.IndexerProperty<int>("IdGrandezamontador").HasColumnName("id_grandezamontador");
                        j.IndexerProperty<int>("IdGrandezamontadordependente").HasColumnName("id_grandezamontadordependente");
                    });

            entity.HasMany(d => d.IdGrandezamontadors).WithMany(p => p.IdGrandezamontadordependentes)
                .UsingEntity<Dictionary<string, object>>(
                    "TbGrandezablocoacdependente",
                    r => r.HasOne<GrandezaBlocoAC>().WithMany()
                        .HasForeignKey("IdGrandezamontador")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_grandezablocoac_grandezablocoacdependente_montador"),
                    l => l.HasOne<GrandezaBlocoAC>().WithMany()
                        .HasForeignKey("IdGrandezamontadordependente")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_grandezablocoac_grandezablocoacdependente_dependente"),
                    j =>
                    {
                        j.HasKey("IdGrandezamontador", "IdGrandezamontadordependente").HasName("pk_tb_grandezablocoacdependente");
                        j.ToTable("tb_grandezablocoacdependente");
                        j.HasIndex(new[] { "IdGrandezamontadordependente" }, "in_fk_grandezablocoac_grandezablocoacdependente_dependente");
                        j.HasIndex(new[] { "IdGrandezamontador" }, "in_fk_grandezablocoac_grandezablocoacdependente_montador");
                        j.IndexerProperty<int>("IdGrandezamontador").HasColumnName("id_grandezamontador");
                        j.IndexerProperty<int>("IdGrandezamontadordependente").HasColumnName("id_grandezamontadordependente");
                    });
        }
    }
}