using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class EstadoMnemonicoEstudoMontadorMapping : IEntityTypeConfiguration<EstadoMnemonicoEstudoMontador>
    {
        public void Configure(EntityTypeBuilder<EstadoMnemonicoEstudoMontador> entity)
        {
            entity.HasKey(e => e.IdEstadomnemonicoestudomontador).HasName("pk_tb_estadomnemonicoestudomontador");

            entity.ToTable("tb_estadomnemonicoestudomontador");

            entity.Property(e => e.IdEstadomnemonicoestudomontador).HasColumnName("id_estadomnemonicoestudomontador");
            entity.Property(e => e.DscEstadomnemonicoestudomontador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dsc_estadomnemonicoestudomontador");
            entity.Property(e => e.FlgEscritarecuperacaodados).HasColumnName("flg_escritarecuperacaodados");
        }
    }
}