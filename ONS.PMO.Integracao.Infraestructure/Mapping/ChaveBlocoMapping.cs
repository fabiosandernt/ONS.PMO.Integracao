using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ChaveBlocoMapping : IEntityTypeConfiguration<ChaveBloco>
    {
        public void Configure(EntityTypeBuilder<ChaveBloco> entity)
        {
            entity.HasKey(e => new { e.IdBloco, e.IdCampochave }).HasName("pk_tb_chavebloco");

            entity.ToTable("tb_chavebloco");

            entity.HasIndex(e => e.IdBloco, "in_fk_bloco_chavebloco");

            entity.HasIndex(e => e.IdCampochave, "in_fk_campochave_chavebloco");

            entity.Property(e => e.IdBloco).HasColumnName("id_bloco");
            entity.Property(e => e.IdCampochave).HasColumnName("id_campochave");
            entity.Property(e => e.FlgDispexportacao).HasColumnName("flg_dispexportacao");
            entity.Property(e => e.FlgDispmanutencao).HasColumnName("flg_dispmanutencao");
            entity.Property(e => e.FlgGeralinhacomentario).HasColumnName("flg_geralinhacomentario");
            entity.Property(e => e.ValColfinal).HasColumnName("val_colfinal");
            entity.Property(e => e.ValColinicial).HasColumnName("val_colinicial");

            entity.HasOne(d => d.IdBlocoNavigation).WithMany(p => p.TbChaveblocos)
                .HasForeignKey(d => d.IdBloco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bloco_chavebloco");

            entity.HasOne(d => d.IdCampochaveNavigation).WithMany(p => p.TbChaveblocos)
                .HasForeignKey(d => d.IdCampochave)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_campochave_chavebloco");
        }
    }
}
