using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class MnemonicoEstudoMontadorMapping : IEntityTypeConfiguration<MnemonicoEstudoMontador>
    {
        public void Configure(EntityTypeBuilder<MnemonicoEstudoMontador> entity)
        {
            entity.HasKey(e => e.IdBlocoestudomontador).HasName("pk_tb_mnemonicoestudomontador");

            entity.ToTable("tb_mnemonicoestudomontador");

            entity.HasIndex(e => e.IdEstadomnemonicoestudomontador, "in_fk_estadomnemonicoestudomontador_mnemonicoestudomontador");

            entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_mnemonicoestudomontador");

            entity.HasIndex(e => e.IdMnemonicoblocoac, "in_fk_mnemonicoblocoac_mnemonicoestudomontador");

            entity.Property(e => e.IdBlocoestudomontador).HasColumnName("id_blocoestudomontador");
            entity.Property(e => e.DinUltimaalteracao)
                .HasColumnType("datetime")
                .HasColumnName("din_ultimaalteracao");
            entity.Property(e => e.IdEstadomnemonicoestudomontador).HasColumnName("id_estadomnemonicoestudomontador");
            entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
            entity.Property(e => e.IdMnemonicoblocoac).HasColumnName("id_mnemonicoblocoac");
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

            entity.HasOne(d => d.IdEstadomnemonicoestudomontadorNavigation).WithMany(p => p.TbMnemonicoestudomontadors)
                .HasForeignKey(d => d.IdEstadomnemonicoestudomontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_estadomnemonicoestudomontador_mnemonicoestudomontador");

            entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbMnemonicoestudomontadors)
                .HasForeignKey(d => d.IdEstudomontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_estudomontador_mnemonicoestudomontador");

            entity.HasOne(d => d.IdMnemonicoblocoacNavigation).WithMany(p => p.TbMnemonicoestudomontadors)
                .HasForeignKey(d => d.IdMnemonicoblocoac)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_mnemonicoblocoac_mnemonicoestudomontador");
        }
    }
}