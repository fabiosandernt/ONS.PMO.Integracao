using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ExportacaoArquivoTextoMapping : IEntityTypeConfiguration<ExportacaoArquivoTexto>
    {
        public void Configure(EntityTypeBuilder<ExportacaoArquivoTexto> entity)
        {
            entity.HasKey(e => e.IdExportacaoarquivotexto).HasName("pk_tb_exportacaoarquivotexto");

            entity.ToTable("tb_exportacaoarquivotexto");

            entity.HasIndex(e => e.IdArquivoexportacao, "in_fk_arquivoexportacao_exportacaoarquivotexto");

            entity.HasIndex(e => e.IdSemanaoperativa, "in_fk_semanaoperativa_exportacaoarquivotexto");

            entity.Property(e => e.IdExportacaoarquivotexto).HasColumnName("id_exportacaoarquivotexto");
            entity.Property(e => e.CodHash)
                .HasMaxLength(200)
                .HasColumnName("cod_hash");
            entity.Property(e => e.DinExportacao)
                .HasColumnType("datetime")
                .HasColumnName("din_exportacao");
            entity.Property(e => e.IdArquivoexportacao).HasColumnName("id_arquivoexportacao");
            entity.Property(e => e.IdSemanaoperativa).HasColumnName("id_semanaoperativa");
            entity.Property(e => e.LgnExportacao)
                .HasMaxLength(50)
                .HasColumnName("lgn_exportacao");
            entity.Property(e => e.NomArquivotexto)
                .HasMaxLength(50)
                .HasColumnName("nom_arquivotexto");

            entity.HasOne(d => d.IdArquivoexportacaoNavigation).WithMany(p => p.TbExportacaoarquivotextos)
                .HasForeignKey(d => d.IdArquivoexportacao)
                .HasConstraintName("fk_arquivoexportacao_exportacaoarquivotexto");

            entity.HasOne(d => d.IdSemanaoperativaNavigation).WithMany(p => p.TbExportacaoarquivotextos)
                .HasForeignKey(d => d.IdSemanaoperativa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_semanaoperativa_exportacaoarquivotexto");
        }
    }
}
