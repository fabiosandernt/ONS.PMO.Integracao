using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ColunaGrandezaMapping : IEntityTypeConfiguration<ColunaGrandeza>
    {
        public void Configure(EntityTypeBuilder<ColunaGrandeza> entity)
        {
            entity.HasKey(e => e.IdColunagrandeza).HasName("pk_tb_colunagrandeza");

            entity.ToTable("tb_colunagrandeza");

            entity.HasIndex(e => e.IdGrandezamontador, "in_fk_grandezabloco_colunagrandeza");

            entity.HasIndex(e => e.IdTplimite, "in_fk_tplimite_colunagrandeza");

            entity.HasIndex(e => e.IdTppatamar, "in_fk_tppatamar_colunagrandeza");

            entity.Property(e => e.IdColunagrandeza).HasColumnName("id_colunagrandeza");
            entity.Property(e => e.IdGrandezamontador).HasColumnName("id_grandezamontador");
            entity.Property(e => e.IdTplimite).HasColumnName("id_tplimite");
            entity.Property(e => e.IdTppatamar).HasColumnName("id_tppatamar");
            entity.Property(e => e.ValColfinal).HasColumnName("val_colfinal");
            entity.Property(e => e.ValColinicial).HasColumnName("val_colinicial");

            entity.HasOne(d => d.IdGrandezamontadorNavigation).WithMany(p => p.TbColunagrandezas)
                .HasForeignKey(d => d.IdGrandezamontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grandezabloco_colunagrandeza");

            entity.HasOne(d => d.IdTplimiteNavigation).WithMany(p => p.TbColunagrandezas)
                .HasForeignKey(d => d.IdTplimite)
                .HasConstraintName("fk_tplimite_colunagrandeza");

            entity.HasOne(d => d.IdTppatamarNavigation).WithMany(p => p.TbColunagrandezas)
                .HasForeignKey(d => d.IdTppatamar)
                .HasConstraintName("fk_tppatamar_colunagrandeza");
        }
    }
}
