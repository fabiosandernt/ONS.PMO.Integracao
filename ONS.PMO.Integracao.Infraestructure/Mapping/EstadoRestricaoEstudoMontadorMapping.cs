using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class EstadoRestricaoEstudoMontadorMapping : IEntityTypeConfiguration<EstadoRestricaoEstudoMontador>
    {
        public void Configure(EntityTypeBuilder<EstadoRestricaoEstudoMontador> entity)
        {
            entity.HasKey(e => e.IdEstadorestricaoestudomontador).HasName("pk_tb_estadorestricaoestudomontador");

            entity.ToTable("tb_estadorestricaoestudomontador");

            entity.Property(e => e.IdEstadorestricaoestudomontador).HasColumnName("id_estadorestricaoestudomontador");
            entity.Property(e => e.DscEstadorestricaoestudomontador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dsc_estadorestricaoestudomontador");
            entity.Property(e => e.FlgEscritarecuperacaodados).HasColumnName("flg_escritarecuperacaodados");
        }
    }
}
