using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class CampoChaveMapping : IEntityTypeConfiguration<CampoChave>
    {
        public void Configure(EntityTypeBuilder<CampoChave> builder)
        {
            builder.HasKey(e => e.IdCampochave).HasName("pk_tb_campochave");

            builder.ToTable("tb_campochave");

            builder.Property(e => e.IdCampochave)
                .ValueGeneratedNever()
                .HasColumnName("id_campochave");

            builder.Property(e => e.CodCampochave)
                .HasMaxLength(20)
                .HasColumnName("cod_campochave");

            builder.Property(e => e.DscCampochave)
                .HasMaxLength(50)
                .HasColumnName("dsc_campochave");
        }
    }
}
