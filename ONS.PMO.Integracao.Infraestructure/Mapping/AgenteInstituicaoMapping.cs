using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class AgenteinstituicaoMapping : IEntityTypeConfiguration<Agenteinstituicao>
    {
        public void Configure(EntityTypeBuilder<Agenteinstituicao> builder)
        {
            builder.HasKey(e => e.IdAgenteinstituicao)
                .HasName("pk_tb_agenteinstituicao");

            builder.ToTable("tb_agenteinstituicao");

            builder.Property(e => e.IdAgenteinstituicao)
                .ValueGeneratedNever()
                .HasColumnName("id_agenteinstituicao");

            builder.Property(e => e.DscApelidorazaosocial)
                .HasMaxLength(50)
                .HasColumnName("dsc_apelidorazaosocial");

            builder.Property(e => e.DscRazaosocial)
                .HasMaxLength(100)
                .HasColumnName("dsc_razaosocial");
        }
    }
}
