using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class EstudoMontadorMapping : IEntityTypeConfiguration<EstudoMontador>
    {
        public void Configure(EntityTypeBuilder<EstudoMontador> entity)
        {
            entity.HasKey(e => e.IdEstudomontador).HasName("pk_tb_estudomontador");

            entity.ToTable("tb_estudomontador");

            entity.HasIndex(e => e.IdSemanaoperativa, "in_fk_semanaoperativa_estudomontador");

            entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
            entity.Property(e => e.IdSemanaoperativa).HasColumnName("id_semanaoperativa");

            entity.HasOne(d => d.IdSemanaoperativaNavigation).WithMany(p => p.TbEstudomontadors)
                .HasForeignKey(d => d.IdSemanaoperativa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_semanaoperativa_estudomontador");

            entity.HasMany(d => d.IdEstudomontadorrefs).WithMany(p => p.IdEstudomontadors)
                .UsingEntity<Dictionary<string, object>>(
                    "TbEstudomontadorflexibilizado",
                    r => r.HasOne<EstudoMontador>().WithMany()
                        .HasForeignKey("IdEstudomontadorref")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_estudomontador_estudomontadorflexibilizado_ref"),
                    l => l.HasOne<EstudoMontador>().WithMany()
                        .HasForeignKey("IdEstudomontador")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_estudomontador_estudomontadorflexibilizado"),
                    j =>
                    {
                        j.HasKey("IdEstudomontador", "IdEstudomontadorref").HasName("pk_tb_estudomontadorflexibilizado");
                        j.ToTable("tb_estudomontadorflexibilizado");
                        j.HasIndex(new[] { "IdEstudomontador" }, "in_fk_estudomontador_estudomontadorflexibilizado");
                        j.HasIndex(new[] { "IdEstudomontadorref" }, "in_fk_estudomontador_estudomontadorflexibilizado_ref");
                        j.IndexerProperty<int>("IdEstudomontador").HasColumnName("id_estudomontador");
                        j.IndexerProperty<int>("IdEstudomontadorref").HasColumnName("id_estudomontadorref");
                    });

            entity.HasMany(d => d.IdEstudomontadors).WithMany(p => p.IdEstudomontadorrefs)
                .UsingEntity<Dictionary<string, object>>(
                    "TbEstudomontadorflexibilizado",
                    r => r.HasOne<EstudoMontador>().WithMany()
                        .HasForeignKey("IdEstudomontador")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_estudomontador_estudomontadorflexibilizado"),
                    l => l.HasOne<EstudoMontador>().WithMany()
                        .HasForeignKey("IdEstudomontadorref")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_estudomontador_estudomontadorflexibilizado_ref"),
                    j =>
                    {
                        j.HasKey("IdEstudomontador", "IdEstudomontadorref").HasName("pk_tb_estudomontadorflexibilizado");
                        j.ToTable("tb_estudomontadorflexibilizado");
                        j.HasIndex(new[] { "IdEstudomontador" }, "in_fk_estudomontador_estudomontadorflexibilizado");
                        j.HasIndex(new[] { "IdEstudomontadorref" }, "in_fk_estudomontador_estudomontadorflexibilizado_ref");
                        j.IndexerProperty<int>("IdEstudomontador").HasColumnName("id_estudomontador");
                        j.IndexerProperty<int>("IdEstudomontadorref").HasColumnName("id_estudomontadorref");
                    });
        }
    }
}
