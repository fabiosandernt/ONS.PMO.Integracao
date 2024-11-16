using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.BDT;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ImportacaoPMOMapping : IEntityTypeConfiguration<ImportacaoPMO>
    {
        public void Configure(EntityTypeBuilder<ImportacaoPMO> entity)
        {
            entity.HasKey(e => e.IdImportacaopmo).HasName("pk_tb_importacaopmo");

            entity.ToTable("tb_importacaopmo");

            entity.HasIndex(e => e.IdSemanaoperativa, "in_fk_semanaoperativa_importacaopmo");

            entity.HasIndex(e => e.IdTpimportacaopmo, "in_fk_tpimportacaopmo_importacaopmo");

            entity.Property(e => e.IdImportacaopmo).HasColumnName("id_importacaopmo");
            entity.Property(e => e.DinImportacao)
                .HasColumnType("datetime")
                .HasColumnName("din_importacao");
            entity.Property(e => e.DinUltimaalteracao)
                .HasColumnType("datetime")
                .HasColumnName("din_ultimaalteracao");
            entity.Property(e => e.FlgProcessando).HasColumnName("flg_processando");
            entity.Property(e => e.IdSemanaoperativa).HasColumnName("id_semanaoperativa");
            entity.Property(e => e.IdTpimportacaopmo).HasColumnName("id_tpimportacaopmo");
            entity.Property(e => e.NomUsuarioultimaalteracao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_usuarioultimaalteracao");

            entity.HasOne(d => d.IdSemanaoperativaNavigation).WithMany(p => p.TbImportacaopmos)
                .HasForeignKey(d => d.IdSemanaoperativa)
                .HasConstraintName("fk_semanaoperativa_importacaopmo");

            entity.HasOne(d => d.IdTpimportacaopmoNavigation).WithMany(p => p.TbImportacaopmos)
                .HasForeignKey(d => d.IdTpimportacaopmo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tpimportacaopmo_importacaopmo");
        }
    }
}