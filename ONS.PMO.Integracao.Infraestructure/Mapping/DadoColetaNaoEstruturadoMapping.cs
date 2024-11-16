using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class DadoColetaNaoEstruturadoMapping : IEntityTypeConfiguration<DadoColetaNaoEstruturado>
    {
        public void Configure(EntityTypeBuilder<DadoColetaNaoEstruturado> entity)
        {
            entity.HasKey(e => e.IdDadocoleta).HasName("pk_tb_dadocoletanaoestruturado");

            entity.ToTable("tb_dadocoletanaoestruturado");

            entity.HasIndex(e => e.IdDadocoleta, "in_fk_dadocoleta_dadocoletanaoestruturado");

            entity.Property(e => e.IdDadocoleta)
                .ValueGeneratedNever()
                .HasColumnName("id_dadocoleta");
            entity.Property(e => e.ObsDadocoletanaoestruturado)
                .HasMaxLength(1000)
                .HasColumnName("obs_dadocoletanaoestruturado");

            entity.HasOne(d => d.IdDadocoletaNavigation).WithOne(p => p.TbDadocoletanaoestruturado)
                .HasForeignKey<DadoColetaNaoEstruturado>(d => d.IdDadocoleta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dadocoleta_dadocoletanaoestruturado");

            entity.HasMany(d => d.IdArquivos).WithMany(p => p.IdDadocoleta)
                .UsingEntity<Dictionary<string, object>>(
                    "TbArqdadocoletanaoestruturado",
                    r => r.HasOne<Arquivo>().WithMany()
                        .HasForeignKey("IdArquivo")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_arquivo_arqdadocoletanaoestruturado"),
                    l => l.HasOne<DadoColetaNaoEstruturado>().WithMany()
                        .HasForeignKey("IdDadocoleta")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_dadocoletanaoestruturado_arqdadocoletanaoestruturado"),
                    j =>
                    {
                        j.HasKey("IdDadocoleta", "IdArquivo").HasName("pk_tb_arqdadocoletanaoestruturado");
                        j.ToTable("tb_arqdadocoletanaoestruturado", tb => tb.HasComment("Associação de arquivos e dados não estruturados"));
                        j.HasIndex(new[] { "IdArquivo" }, "in_fk_arquivo_arqdadocoletanaoestruturado");
                        j.HasIndex(new[] { "IdDadocoleta" }, "in_fk_dadocoletanaoestruturado_arqdadocoletanaoestruturado");
                        j.HasIndex(new[] { "IdDadocoleta", "IdArquivo" }, "in_pk_tb_arqdadocoletanaoestruturado")
                            .IsUnique();
                        j.IndexerProperty<int>("IdDadocoleta")
                            .HasComment("Identificador do dado coletado não estruturado")
                            .HasColumnName("id_dadocoleta");
                        j.IndexerProperty<Guid>("IdArquivo")
                            .HasComment("Identificador dos arquivos associados ao dado não estruturado")
                            .HasColumnName("id_arquivo");
                    });
        }
    }
}
