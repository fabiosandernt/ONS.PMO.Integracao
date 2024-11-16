using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.BDT;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class MneespEstudoMontadorMapping : IEntityTypeConfiguration<MneespEstudoMontador>
    {
        public void Configure(EntityTypeBuilder<MneespEstudoMontador> entity)
        {
            entity.HasKey(e => e.IdMneespestudomontador).HasName("pk_tb_mneespestudomontador");

            entity.ToTable("tb_mneespestudomontador");

            entity.HasIndex(e => e.IdEstadomnemonicoestudomontador, "in_fk_estadomnemonicoestudomontador_mneespestudomontador");

            entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_mneespestudomontador");

            entity.Property(e => e.IdMneespestudomontador).HasColumnName("id_mneespestudomontador");
            entity.Property(e => e.DinUltimaalteracao)
                .HasColumnType("datetime")
                .HasColumnName("din_ultimaalteracao");
            entity.Property(e => e.IdEstadomnemonicoestudomontador).HasColumnName("id_estadomnemonicoestudomontador");
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

            entity.HasOne(d => d.IdEstadomnemonicoestudomontadorNavigation).WithMany(p => p.TbMneespestudomontadors)
                .HasForeignKey(d => d.IdEstadomnemonicoestudomontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_estadomnemonicoestudomontador_mneespestudomontador");

            entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbMneespestudomontadors)
                .HasForeignKey(d => d.IdEstudomontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_estudomontador_mneespestudomontador");
        }
    }
}