using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ArquivoSemanaOperativaMapping : IEntityTypeConfiguration<ArquivoSemanaOperativa>
    {
        public void Configure(EntityTypeBuilder<ArquivoSemanaOperativa> builder)
        {
            builder.HasKey(e => e.IdArquivosemanaoperativa).HasName("pk_tb_arquivosemanaoperativa");

            builder.ToTable("tb_arquivosemanaoperativa", tb => tb.HasComment("Associação de arquivos encaminhados por semana operativa "));

            builder.HasIndex(e => e.IdArquivo, "in_fk_arquivo_arquivosemanaoperativa");
            builder.HasIndex(e => e.IdSemanaoperativa, "in_fk_semanaoperativa_arquivosemanaoperativa");
            builder.HasIndex(e => e.IdTpsituacaosemanaoper, "in_fk_tpsituacaosemanaoper_arquivosemanaoperativa");
            builder.HasIndex(e => e.IdArquivosemanaoperativa, "in_pk_tb_arquivosemanaoperativa")
                .IsUnique();

            builder.Property(e => e.IdArquivosemanaoperativa)
                .HasComment("Identificador do arquivo da semana operativa")
                .HasColumnName("id_arquivosemanaoperativa");

            builder.Property(e => e.FlgPublicado)
                .HasComment("Indica se o arquivo associado a semana operativa foi publicado")
                .HasColumnName("flg_publicado");

            builder.Property(e => e.IdArquivo)
                .HasComment("Identificador dos arquivos que contém insumos para o sistema")
                .HasColumnName("id_arquivo");

            builder.Property(e => e.IdSemanaoperativa)
                .HasComment("Identificadorda semana operativa do programa mensal de operação - PMO")
                .HasColumnName("id_semanaoperativa");

            builder.Property(e => e.IdTpsituacaosemanaoper)
                .HasComment("Identificador da situação da semana operativado. Possíveis valores: Configuração, Coleta de dados, Geração de blocos, Convergência CCEE e Publicado")
                .HasColumnName("id_tpsituacaosemanaoper");

            builder.HasOne(d => d.IdArquivoNavigation).WithMany(p => p.TbArquivosemanaoperativas)
                .HasForeignKey(d => d.IdArquivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_arquivo_arquivosemanaoperativa");

            builder.HasOne(d => d.IdSemanaoperativaNavigation).WithMany(p => p.TbArquivosemanaoperativas)
                .HasForeignKey(d => d.IdSemanaoperativa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_semanaoperativa_arquivosemanaoperativa");

            builder.HasOne(d => d.IdTpsituacaosemanaoperNavigation).WithMany(p => p.TbArquivosemanaoperativas)
                .HasForeignKey(d => d.IdTpsituacaosemanaoper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tpsituacaosemanaoper_arquivosemanaoperativa");
        }
    }
}