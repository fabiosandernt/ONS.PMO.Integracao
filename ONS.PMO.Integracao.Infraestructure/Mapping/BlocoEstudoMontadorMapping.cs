using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class BlocoEstudoMontadorMapping : IEntityTypeConfiguration<BlocoEstudoMontador>
    {
        public void Configure(EntityTypeBuilder<BlocoEstudoMontador> entity)
        {
            entity.HasKey(e => e.IdBlocoestudomontador).HasName("pk_tb_blocoestudomontador");

            entity.ToTable("tb_blocoestudomontador");

            entity.HasIndex(e => e.IdBloco, "in_fk_bloco_blocoestudomontador");

            entity.HasIndex(e => e.IdEstadoblocoestudomontador, "in_fk_estadoblocoestudomontador_blocoestudomontador");

            entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_blocoestudomontador");

            entity.Property(e => e.IdBlocoestudomontador).HasColumnName("id_blocoestudomontador");
            entity.Property(e => e.DinUltimaalteracao)
                .HasColumnType("datetime")
                .HasColumnName("din_ultimaalteracao");
            entity.Property(e => e.IdBloco).HasColumnName("id_bloco");
            entity.Property(e => e.IdEstadoblocoestudomontador).HasColumnName("id_estadoblocoestudomontador");
            entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
            entity.Property(e => e.LgnUltimaalteracao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lgn_ultimaalteracao");
            entity.Property(e => e.LgnUsuariocheckout)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lgn_usuariocheckout");
            entity.Property(e => e.VerControleconcorrencia)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ver_controleconcorrencia");

            entity.HasOne(d => d.IdBlocoNavigation).WithMany(p => p.TbBlocoestudomontadors)
                .HasForeignKey(d => d.IdBloco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bloco_blocoestudomontador");

            entity.HasOne(d => d.IdEstadoblocoestudomontadorNavigation).WithMany(p => p.TbBlocoestudomontadors)
                .HasForeignKey(d => d.IdEstadoblocoestudomontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_estadoblocoestudomontador_blocoestudomontador");

            entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbBlocoestudomontadors)
                .HasForeignKey(d => d.IdEstudomontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_estudomontador_blocoestudomontador");
        }
    }
}
