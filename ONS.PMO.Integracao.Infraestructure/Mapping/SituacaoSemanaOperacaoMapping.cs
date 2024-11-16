using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class SituacaoSemanaOperacaoMapping : IEntityTypeConfiguration<SituacaoSemanaOperacao>
    {
        public void Configure(EntityTypeBuilder<SituacaoSemanaOperacao> entity)
        {
            entity.HasKey(e => e.IdTpsituacaosemanaoper).HasName("pk_tb_tpsituacaosemanaoper");

            entity.ToTable("tb_tpsituacaosemanaoper");

            entity.Property(e => e.IdTpsituacaosemanaoper)
                .ValueGeneratedNever()
                .HasColumnName("id_tpsituacaosemanaoper");
            entity.Property(e => e.DscSituacaosemanaoper)
                .HasMaxLength(20)
                .HasColumnName("dsc_situacaosemanaoper");
        }
    }
}
