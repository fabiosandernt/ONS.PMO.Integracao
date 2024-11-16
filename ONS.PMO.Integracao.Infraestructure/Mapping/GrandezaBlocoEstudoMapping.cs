using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class GrandezaBlocoEstudoMapping : IEntityTypeConfiguration<GrandezaBlocoEstudo>
    {
        public void Configure(EntityTypeBuilder<GrandezaBlocoEstudo> entity)
        {
            entity.HasKey(e => e.IdGrandezablocoestudo).HasName("pk_tb_grandezablocoestudo");

            entity.ToTable("tb_grandezablocoestudo");

            entity.HasIndex(e => e.IdColunagrandeza, "in_fk_colunagrandeza_grandezablocoestudo");

            entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_grandezablocoestudo");

            entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_grandezablocoestudo");

            entity.HasIndex(e => e.IdRestricao, "in_fk_restricao_grandezablocoestudo");

            entity.Property(e => e.IdGrandezablocoestudo).HasColumnName("id_grandezablocoestudo");
            entity.Property(e => e.FlgFonte)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("flg_fonte");
            entity.Property(e => e.FlgNormalizado).HasColumnName("flg_normalizado");
            entity.Property(e => e.IdColunagrandeza).HasColumnName("id_colunagrandeza");
            entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
            entity.Property(e => e.IdOrigemcoletamontador).HasColumnName("id_origemcoletamontador");
            entity.Property(e => e.IdRestricao).HasColumnName("id_restricao");
            entity.Property(e => e.ValGrandezablocoestudo)
                .HasMaxLength(500)
                .HasColumnName("val_grandezablocoestudo");
            entity.Property(e => e.ValGrandezablocoestudooriginal)
                .HasMaxLength(500)
                .HasColumnName("val_grandezablocoestudooriginal");

            entity.HasOne(d => d.IdColunagrandezaNavigation).WithMany(p => p.TbGrandezablocoestudos)
                .HasForeignKey(d => d.IdColunagrandeza)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_colunagrandeza_grandezablocoestudo");

            entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbGrandezablocoestudos)
                .HasForeignKey(d => d.IdEstudomontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_estudomontador_grandezablocoestudo");

            entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithMany(p => p.TbGrandezablocoestudos)
                .HasForeignKey(d => d.IdOrigemcoletamontador)
                .HasConstraintName("fk_origemcoletamontador_grandezablocoestudo");

            entity.HasOne(d => d.IdRestricaoNavigation).WithMany(p => p.TbGrandezablocoestudos)
                .HasForeignKey(d => d.IdRestricao)
                .HasConstraintName("fk_restricao_grandezablocoestudo");
        }
    }
}
