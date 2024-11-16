using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ConjuntoGeracaoMinimaMapping : IEntityTypeConfiguration<ConjuntoGeracaoMinima>
    {
        public void Configure(EntityTypeBuilder<ConjuntoGeracaoMinima> entity)
        {
            entity.HasKey(e => e.IdConjuntogeracaominima).HasName("pk_tb_conjuntogeracaominima");

            entity.ToTable("tb_conjuntogeracaominima");

            entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_conjuntogeracaominima");

            entity.Property(e => e.IdConjuntogeracaominima).HasColumnName("id_conjuntogeracaominima");
            entity.Property(e => e.DinUltimaalteracao)
                .HasColumnType("datetime")
                .HasColumnName("din_ultimaalteracao");
            entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
            entity.Property(e => e.LgnUltimaalteracao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lgn_ultimaalteracao");
            entity.Property(e => e.NomConjuntogeracaominima)
                .HasMaxLength(50)
                .HasColumnName("nom_conjuntogeracaominima");
            entity.Property(e => e.VerControleconcorrencia)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ver_controleconcorrencia");

            entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbConjuntogeracaominimas)
                .HasForeignKey(d => d.IdEstudomontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_estudomontador_conjuntogeracaominima");

            entity.HasMany(d => d.IdOrigemcoletamontadors).WithMany(p => p.IdConjuntogeracaominimas)
                .UsingEntity<Dictionary<string, object>>(
                    "TbUsinasconjuntogeracaominima",
                    r => r.HasOne<AuxUsinaMontador>().WithMany()
                        .HasForeignKey("IdOrigemcoletamontador")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_aux_usinamontador_usinaconjuntogeracaominima"),
                    l => l.HasOne<ConjuntoGeracaoMinima>().WithMany()
                        .HasForeignKey("IdConjuntogeracaominima")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_conjuntogeracaominima_usinasconjuntogeracaominima"),
                    j =>
                    {
                        j.HasKey("IdConjuntogeracaominima", "IdOrigemcoletamontador").HasName("pk_tb_usinasconjuntogeracaominima");
                        j.ToTable("tb_usinasconjuntogeracaominima");
                        j.HasIndex(new[] { "IdOrigemcoletamontador" }, "in_fk_aux_usinamontador_usinaconjuntogeracaominima");
                        j.HasIndex(new[] { "IdConjuntogeracaominima" }, "in_fk_conjuntogeracaominima_usinasconjuntogeracaominima");
                        j.IndexerProperty<int>("IdConjuntogeracaominima").HasColumnName("id_conjuntogeracaominima");
                        j.IndexerProperty<int>("IdOrigemcoletamontador").HasColumnName("id_origemcoletamontador");
                    });
        }
    }
}
