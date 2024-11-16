using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ArquivoMapping : IEntityTypeConfiguration<Arquivo>
    {
        public void Configure(EntityTypeBuilder<Arquivo> builder)
        {
            builder.HasKey(e => e.IdArquivo).HasName("pk_tb_arquivo");

            builder.ToTable("tb_arquivo", tb => tb.HasComment("Tem o propósito geral de armazena dados sobre um arquivo, que poderá ser referenciado por outras dados do sistema."));

            builder.HasIndex(e => e.IdArquivo, "in_pk_tb_arquivo")
                .IsUnique();

            builder.Property(e => e.IdArquivo)
                .ValueGeneratedNever()
                .HasComment("Identificador dos arquivos que contém insumos para o sistema")
                .HasColumnName("id_arquivo");

            builder.Property(e => e.ArqConteudo)
                .HasComment("Conteúdo do arquivo")
                .HasColumnName("arq_conteudo");

            builder.Property(e => e.CodHashverificacao)
                .HasMaxLength(100)
                .HasComment("Código Hash de verificação do arquivo (uso interno) para garantir a consistencia do arquivo")
                .HasColumnName("cod_hashverificacao");

            builder.Property(e => e.DscMimearquivo)
                .HasMaxLength(100)
                .HasComment("Tipo do arquivo (MimeType), segundo a nomenclatura padrão da IANA")
                .HasColumnName("dsc_mimearquivo");

            builder.Property(e => e.FlgExcluido)
                .HasDefaultValue(false)
                .HasComment("Indica se o arquivo foi excluído logicamente")
                .HasColumnName("flg_excluido");

            builder.Property(e => e.NomArquivo)
                .HasMaxLength(255)
                .HasComment("Nome do Arquivo com Extensão")
                .HasColumnName("nom_arquivo");

            builder.Property(e => e.NumTamanhoarquivo)
                .HasComment("Tamanho em bytes do arquivo")
                .HasColumnName("num_tamanhoarquivo");
        }
    }
}
