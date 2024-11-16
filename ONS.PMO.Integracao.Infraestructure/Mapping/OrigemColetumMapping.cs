using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class OrigemColetumMapping : IEntityTypeConfiguration<OrigemColetum>
    {
        public void Configure(EntityTypeBuilder<OrigemColetum> entity)
        {
            entity.HasKey(e => e.IdOrigemcoleta).HasName("pk_tb_origemcoleta");

            entity.ToTable("tb_origemcoleta");

            entity.Property(e => e.IdOrigemcoleta)
                .HasMaxLength(50)
                .HasColumnName("id_origemcoleta");
            entity.Property(e => e.NomExibicao)
                .HasMaxLength(150)
                .HasColumnName("nom_exibicao");
            entity.Property(e => e.TipOrigemcoleta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tip_origemcoleta");
        }
    }
}
