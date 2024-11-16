using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class BlocoMapping : IEntityTypeConfiguration<Bloco>
    {
        public void Configure(EntityTypeBuilder<Bloco> entity)
        {
            entity.HasKey(e => e.IdBloco).HasName("pk_tb_bloco");

            entity.ToTable("tb_bloco");

            entity.HasIndex(e => e.IdArquivoexportacao, "in_fk_arquivoexportacao_bloco");

            entity.HasIndex(e => e.IdTpcoleta, "in_fk_tpcoleta_bloco");

            entity.HasIndex(e => e.IdTpestagio, "in_fk_tpestagio_bloco");

            entity.Property(e => e.IdBloco).HasColumnName("id_bloco");
            entity.Property(e => e.CodBloco)
                .HasMaxLength(50)
                .HasColumnName("cod_bloco");
            entity.Property(e => e.DscCabecalho).HasColumnName("dsc_cabecalho");
            entity.Property(e => e.FlgAtivo)
                .HasDefaultValue(true)
                .HasColumnName("flg_ativo");
            entity.Property(e => e.FlgEspecifico).HasColumnName("flg_especifico");
            entity.Property(e => e.FlgExpansaousinas).HasColumnName("flg_expansaousinas");
            entity.Property(e => e.FlgExportacaoestagio)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("flg_exportacaoestagio");
            entity.Property(e => e.FlgExportado).HasColumnName("flg_exportado");
            entity.Property(e => e.FlgReservado).HasColumnName("flg_reservado");
            entity.Property(e => e.IdArquivoexportacao).HasColumnName("id_arquivoexportacao");
            entity.Property(e => e.IdTpcoleta).HasColumnName("id_tpcoleta");
            entity.Property(e => e.IdTpestagio).HasColumnName("id_tpestagio");
            entity.Property(e => e.NomBloco)
                .HasMaxLength(150)
                .HasColumnName("nom_bloco");
            entity.Property(e => e.NumOrdem).HasColumnName("num_ordem");
            entity.Property(e => e.QtdEstagios).HasColumnName("qtd_estagios");
            entity.Property(e => e.VerControleconcorrencia)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ver_controleconcorrencia");

            entity.HasOne(d => d.IdArquivoexportacaoNavigation).WithMany(p => p.TbBlocos)
                .HasForeignKey(d => d.IdArquivoexportacao)
                .HasConstraintName("fk_arquivoexportacao_bloco");

            entity.HasOne(d => d.IdTpcoletaNavigation).WithMany(p => p.TbBlocos)
                .HasForeignKey(d => d.IdTpcoleta)
                .HasConstraintName("fk_tpcoleta_bloco");

            entity.HasOne(d => d.IdTpestagioNavigation).WithMany(p => p.TbBlocos)
                .HasForeignKey(d => d.IdTpestagio)
                .HasConstraintName("fk_tpestagio_bloco");

            entity.HasMany(d => d.IdTpcategoriainsumos).WithMany(p => p.IdBlocos)
                .UsingEntity<Dictionary<string, object>>(
                    "TbBlocotpcategoriainsumo",
                    r => r.HasOne<CategoriaInsumo>().WithMany()
                        .HasForeignKey("IdTpcategoriainsumo")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_tpcategoriainsumo_blocotpcategoriainsumo"),
                    l => l.HasOne<Bloco>().WithMany()
                        .HasForeignKey("IdBloco")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_bloco_blocotpcategoriainsumo"),
                    j =>
                    {
                        j.HasKey("IdBloco", "IdTpcategoriainsumo").HasName("pk_tb_blocotpcategoriainsumo");
                        j.ToTable("tb_blocotpcategoriainsumo");
                        j.HasIndex(new[] { "IdBloco" }, "in_fk_bloco_blocotpcategoriainsumo");
                        j.HasIndex(new[] { "IdTpcategoriainsumo" }, "in_fk_tpcategoriainsumo_blocotpcategoriainsumo");
                        j.IndexerProperty<int>("IdBloco").HasColumnName("id_bloco");
                        j.IndexerProperty<int>("IdTpcategoriainsumo").HasColumnName("id_tpcategoriainsumo");
                    });
        }
    }
}
