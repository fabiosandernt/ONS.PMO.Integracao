using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class RestricaoMapping : IEntityTypeConfiguration<Restricao>
    {
        public void Configure(EntityTypeBuilder<Restricao> entity)
        {
            entity.HasKey(e => e.IdRestricao).HasName("pk_tb_restricao");

            entity.ToTable("tb_restricao");

            entity.HasIndex(e => e.IdFonteorigem, "in_fk_fonteorigem_restricao");

            entity.HasIndex(e => e.IdRestricaopai, "in_fk_restricao_restricao_pai");

            entity.HasIndex(e => new { e.IdTprestricao, e.IdEstudomontador }, "in_fk_restricaoestudo_restricao");

            entity.Property(e => e.IdRestricao).HasColumnName("id_restricao");
            entity.Property(e => e.CodIdentificador).HasColumnName("cod_identificador");
            entity.Property(e => e.DinEstagiofinal)
                .HasColumnType("smalldatetime")
                .HasColumnName("din_estagiofinal");
            entity.Property(e => e.DinEstagioinicial)
                .HasColumnType("smalldatetime")
                .HasColumnName("din_estagioinicial");
            entity.Property(e => e.DinUltimaalteracao)
                .HasColumnType("datetime")
                .HasColumnName("din_ultimaalteracao");
            entity.Property(e => e.DscComentario).HasColumnName("dsc_comentario");
            entity.Property(e => e.FlgImportado).HasColumnName("flg_importado");
            entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
            entity.Property(e => e.IdFonteorigem).HasColumnName("id_fonteorigem");
            entity.Property(e => e.IdRestricaopai).HasColumnName("id_restricaopai");
            entity.Property(e => e.IdTprestricao).HasColumnName("id_tprestricao");
            entity.Property(e => e.LgnUltimaalteracao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lgn_ultimaalteracao");
            entity.Property(e => e.NumRestricao).HasColumnName("num_restricao");
            entity.Property(e => e.NumRestricaoestudoanterior).HasColumnName("num_restricaoestudoanterior");

            entity.HasOne(d => d.IdFonteorigemNavigation).WithMany(p => p.TbRestricaos)
                .HasForeignKey(d => d.IdFonteorigem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_fonteorigem_restricao");

            entity.HasOne(d => d.IdRestricaopaiNavigation).WithMany(p => p.InverseIdRestricaopaiNavigation)
                .HasForeignKey(d => d.IdRestricaopai)
                .HasConstraintName("fk_restricao_restricao_pai");

            entity.HasOne(d => d.TbRestricaoestudo).WithMany(p => p.TbRestricaos)
                .HasForeignKey(d => new { d.IdTprestricao, d.IdEstudomontador })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_restricaoestudo_restricao");
        }
    }
}