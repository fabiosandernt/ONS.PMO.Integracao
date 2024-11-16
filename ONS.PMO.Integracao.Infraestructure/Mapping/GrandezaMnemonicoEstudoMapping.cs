using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class GrandezaMnemonicoEstudoMapping : IEntityTypeConfiguration<GrandezaMnemonicoEstudo>
    {
        public void Configure(EntityTypeBuilder<GrandezaMnemonicoEstudo> entity)
        {
            entity.HasKey(e => e.IdGrandezamnemonicoestudo).HasName("pk_tb_grandezamnemonicoestudo");

            entity.ToTable("tb_grandezamnemonicoestudo");

            entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_grandezamnemonicoestudo");

            entity.HasIndex(e => e.IdGrandezamontador, "in_fk_grandezablocoac_grandezamnemonicoestudo");

            entity.HasIndex(e => e.IdMotivoalteracao, "in_fk_motivoalteracao_grandezamnemonicoestudo");

            entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_grandezamnemonicoestudo");

            entity.Property(e => e.IdGrandezamnemonicoestudo).HasColumnName("id_grandezamnemonicoestudo");
            entity.Property(e => e.FlgFonte)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("flg_fonte");
            entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
            entity.Property(e => e.IdGrandezamontador).HasColumnName("id_grandezamontador");
            entity.Property(e => e.IdMotivoalteracao).HasColumnName("id_motivoalteracao");
            entity.Property(e => e.IdOrigemcoletamontador).HasColumnName("id_origemcoletamontador");
            entity.Property(e => e.ValGrandezamnemonicoestudo)
                .HasMaxLength(300)
                .HasColumnName("val_grandezamnemonicoestudo");

            entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbGrandezamnemonicoestudos)
                .HasForeignKey(d => d.IdEstudomontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_estudomontador_grandezamnemonicoestudo");

            entity.HasOne(d => d.IdGrandezamontadorNavigation).WithMany(p => p.TbGrandezamnemonicoestudos)
                .HasForeignKey(d => d.IdGrandezamontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grandezablocoac_grandezamnemonicoestudo");

            entity.HasOne(d => d.IdMotivoalteracaoNavigation).WithMany(p => p.TbGrandezamnemonicoestudos)
                .HasForeignKey(d => d.IdMotivoalteracao)
                .HasConstraintName("fk_motivoalteracao_grandezamnemonicoestudo");

            entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithMany(p => p.TbGrandezamnemonicoestudos)
                .HasForeignKey(d => d.IdOrigemcoletamontador)
                .HasConstraintName("fk_origemcoletamontador_grandezamnemonicoestudo");
        }
    }
}
