using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class EstadoBlocoEstudoMontadorMapping : IEntityTypeConfiguration<EstadoBlocoEstudoMontador>
    {
        public void Configure(EntityTypeBuilder<EstadoBlocoEstudoMontador> entity)
        {
            entity.HasKey(e => e.IdEstadoblocoestudomontador).HasName("pk_tb_estadoblocoestudomontador");

            entity.ToTable("tb_estadoblocoestudomontador");

            entity.Property(e => e.IdEstadoblocoestudomontador).HasColumnName("id_estadoblocoestudomontador");
            entity.Property(e => e.DscEstadoblocoestudomontador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dsc_estadoblocoestudomontador");
            entity.Property(e => e.FlgEscritarecuperacaodados).HasColumnName("flg_escritarecuperacaodados");
        }
    }
}
