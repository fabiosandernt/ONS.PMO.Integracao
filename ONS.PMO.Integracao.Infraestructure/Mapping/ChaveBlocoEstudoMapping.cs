using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ChaveBlocoEstudoMapping : IEntityTypeConfiguration<ChaveBlocoEstudo>
    {
        public void Configure(EntityTypeBuilder<ChaveBlocoEstudo> entity)
        {
            entity.HasKey(e => e.IdChaveblocoestudo).HasName("pk_tb_chaveblocoestudo");

            entity.ToTable("tb_chaveblocoestudo");

            entity.HasIndex(e => e.IdBloco, "in_fk_bloco_chaveblocoestudo");

            entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_chaveblocoestudo");

            entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_chaveblocoestudo");

            entity.HasIndex(e => e.IdRestricao, "in_fk_restricao_chaveblocoestudo");

            entity.Property(e => e.IdChaveblocoestudo).HasColumnName("id_chaveblocoestudo");
            entity.Property(e => e.IdBloco).HasColumnName("id_bloco");
            entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
            entity.Property(e => e.IdOrigemcoletamontador).HasColumnName("id_origemcoletamontador");
            entity.Property(e => e.IdRestricao).HasColumnName("id_restricao");

            entity.HasOne(d => d.IdBlocoNavigation).WithMany(p => p.TbChaveblocoestudos)
                .HasForeignKey(d => d.IdBloco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bloco_chaveblocoestudo");

            entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbChaveblocoestudos)
                .HasForeignKey(d => d.IdEstudomontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_estudomontador_chaveblocoestudo");

            entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithMany(p => p.TbChaveblocoestudos)
                .HasForeignKey(d => d.IdOrigemcoletamontador)
                .HasConstraintName("fk_origemcoletamontador_chaveblocoestudo");

            entity.HasOne(d => d.IdRestricaoNavigation).WithMany(p => p.TbChaveblocoestudos)
                .HasForeignKey(d => d.IdRestricao)
                .HasConstraintName("fk_restricao_chaveblocoestudo");
        }
    }
}
