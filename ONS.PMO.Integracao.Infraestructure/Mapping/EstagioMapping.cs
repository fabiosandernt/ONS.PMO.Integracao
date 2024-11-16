using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class EstagioMapping : IEntityTypeConfiguration<Estagio>
    {
        public void Configure(EntityTypeBuilder<Estagio> entity)
        {
            entity.HasKey(e => e.IdTpestagio).HasName("pk_tb_tpestagio");

            entity.ToTable("tb_tpestagio");

            entity.Property(e => e.IdTpestagio)
                .ValueGeneratedNever()
                .HasColumnName("id_tpestagio");
            entity.Property(e => e.DscTpestagio)
                .HasMaxLength(50)
                .HasColumnName("dsc_tpestagio");
        }
    }
}
