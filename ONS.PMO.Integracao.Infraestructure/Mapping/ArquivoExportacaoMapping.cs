using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ArquivoExportacaoMapping : IEntityTypeConfiguration<ArquivoExportacao>
    {
        public void Configure(EntityTypeBuilder<ArquivoExportacao> builder)
        {
            builder.HasKey(e => e.IdArquivoexportacao).HasName("pk_tb_arquivoexportacao");

            builder.ToTable("tb_arquivoexportacao");

            builder.Property(e => e.IdArquivoexportacao)
                .ValueGeneratedNever()
                .HasColumnName("id_arquivoexportacao");

            builder.Property(e => e.DscArquivoexportacao)
                .HasMaxLength(20)
                .HasColumnName("dsc_arquivoexportacao");

            builder.Property(e => e.NomArquivoexportacao)
                .HasMaxLength(20)
                .HasColumnName("nom_arquivoexportacao");
        }
    }
}
