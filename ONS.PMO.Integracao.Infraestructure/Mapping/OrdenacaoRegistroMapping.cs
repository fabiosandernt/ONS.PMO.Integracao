using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class OrdenacaoRegistroMapping : IEntityTypeConfiguration<OrdenacaoRegistro>
    {
        public void Configure(EntityTypeBuilder<OrdenacaoRegistro> entity)
        {
            entity.HasKey(e => e.IdOrdenacaoregistros).HasName("pk_tb_ordenacaoregistros");

            entity.ToTable("tb_ordenacaoregistros");

            entity.HasIndex(e => e.IdBloco, "in_fk_bloco_ordenacaoregistros");

            entity.HasIndex(e => e.IdCampochave, "in_fk_campochave_ordenacaoregistros");

            entity.HasIndex(e => e.IdGrandezamontador, "in_fk_grandezabloco_ordenacaoregistros");

            entity.Property(e => e.IdOrdenacaoregistros).HasColumnName("id_ordenacaoregistros");
            entity.Property(e => e.FlgTpordenacao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("flg_tpordenacao");
            entity.Property(e => e.IdBloco).HasColumnName("id_bloco");
            entity.Property(e => e.IdCampochave).HasColumnName("id_campochave");
            entity.Property(e => e.IdGrandezamontador).HasColumnName("id_grandezamontador");
            entity.Property(e => e.NumOrdenacao).HasColumnName("num_ordenacao");
            entity.Property(e => e.NumRevisao).HasColumnName("num_revisao");

            entity.HasOne(d => d.IdBlocoNavigation).WithMany(p => p.TbOrdenacaoregistros)
                .HasForeignKey(d => d.IdBloco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bloco_ordenacaoregistros");

            entity.HasOne(d => d.IdCampochaveNavigation).WithMany(p => p.TbOrdenacaoregistros)
                .HasForeignKey(d => d.IdCampochave)
                .HasConstraintName("fk_campochave_ordenacaoregistros");

            entity.HasOne(d => d.IdGrandezamontadorNavigation).WithMany(p => p.TbOrdenacaoregistros)
                .HasForeignKey(d => d.IdGrandezamontador)
                .HasConstraintName("fk_grandezabloco_ordenacaoregistros");
        }
    }
}