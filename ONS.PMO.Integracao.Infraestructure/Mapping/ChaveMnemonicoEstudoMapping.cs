using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ChaveMnemonicoEstudoMapping : IEntityTypeConfiguration<ChaveMnemonicoEstudo>
    {
        public void Configure(EntityTypeBuilder<ChaveMnemonicoEstudo> entity)
        {
            entity.HasKey(e => e.IdChavemnemonicoestudo).HasName("pk_tb_chavemnemonicoestudo");

            entity.ToTable("tb_chavemnemonicoestudo");

            entity.HasIndex(e => e.IdMnemonicoblocoac, "in_fk_chavemnemonicoestudo_mnemonicoblocoac");

            entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_chavemnemonicoestudo");

            entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_chavemnemonicoestudo");

            entity.Property(e => e.IdChavemnemonicoestudo).HasColumnName("id_chavemnemonicoestudo");
            entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
            entity.Property(e => e.IdMnemonicoblocoac).HasColumnName("id_mnemonicoblocoac");
            entity.Property(e => e.IdOrigemcoletamontador).HasColumnName("id_origemcoletamontador");

            entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbChavemnemonicoestudos)
                .HasForeignKey(d => d.IdEstudomontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_estudomontador_chavemnemonicoestudo");

            entity.HasOne(d => d.IdMnemonicoblocoacNavigation).WithMany(p => p.TbChavemnemonicoestudos)
                .HasForeignKey(d => d.IdMnemonicoblocoac)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_chavemnemonicoestudo_mnemonicoblocoac");

            entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithMany(p => p.TbChavemnemonicoestudos)
                .HasForeignKey(d => d.IdOrigemcoletamontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_origemcoletamontador_chavemnemonicoestudo");
        }
    }
}
