using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.BDT;
namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ArquivoFonteResultPMOMapping : IEntityTypeConfiguration<ArquivoFonteResultPMO>
    {
        public void Configure(EntityTypeBuilder<ArquivoFonteResultPMO> builder)
        {
            builder.HasKey(e => e.IdArquivofonteresultpmo).HasName("pk_tb_arquivofonteresultpmo");

            builder.ToTable("tb_arquivofonteresultpmo");

            builder.Property(e => e.IdArquivofonteresultpmo)
                .ValueGeneratedNever()
                .HasColumnName("id_arquivofonteresultpmo");

            builder.Property(e => e.NomArquivofonteresultpmo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nom_arquivofonteresultpmo");
        }
    }
}
