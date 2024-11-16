using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class TitulacaoMapping : IEntityTypeConfiguration<Titulacao>
    {
        public void Configure(EntityTypeBuilder<Titulacao> entity)
        {
            entity.HasKey(e => e.IdTitulacao).HasName("pk_tb_titulacao");

            entity.ToTable("tb_titulacao");

            entity.Property(e => e.IdTitulacao).HasColumnName("id_titulacao");
            entity.Property(e => e.CodTitulacao)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("cod_titulacao");
            entity.Property(e => e.NomTitulacao)
                .HasMaxLength(50)
                .HasColumnName("nom_titulacao");
        }
    }
}
