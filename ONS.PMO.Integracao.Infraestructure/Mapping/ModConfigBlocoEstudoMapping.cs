using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ModConfigBlocoEstudoMapping : IEntityTypeConfiguration<ModConfigBlocoEstudo>
    {
        public void Configure(EntityTypeBuilder<ModConfigBlocoEstudo> entity)
        {
            entity.HasKey(e => e.IdModifconfigblocoestudo).HasName("pk_tb_modifconfigblocoestudo");

            entity.ToTable("tb_modifconfigblocoestudo");

            entity.HasIndex(e => e.IdBloco, "in_fk_bloco_modifconfigblocoestudo");

            entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_modifconfigblocoestudo");

            entity.Property(e => e.IdModifconfigblocoestudo).HasColumnName("id_modifconfigblocoestudo");
            entity.Property(e => e.IdBloco).HasColumnName("id_bloco");
            entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
            entity.Property(e => e.NomCampo)
                .HasMaxLength(50)
                .HasColumnName("nom_campo");
            entity.Property(e => e.NumRevisao).HasColumnName("num_revisao");
            entity.Property(e => e.ValCampo)
                .HasMaxLength(300)
                .HasColumnName("val_campo");

            entity.HasOne(d => d.IdBlocoNavigation).WithMany(p => p.TbModifconfigblocoestudos)
                .HasForeignKey(d => d.IdBloco)
                .HasConstraintName("fk_bloco_modifconfigblocoestudo");

            entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbModifconfigblocoestudos)
                .HasForeignKey(d => d.IdEstudomontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_estudomontador_modifconfigblocoestudo");

            entity.HasMany(d => d.IdCampochaves).WithMany(p => p.IdModifconfigblocoestudos)
                .UsingEntity<Dictionary<string, object>>(
                    "TbHisconfigchavebloco",
                    r => r.HasOne<CampoChave>().WithMany()
                        .HasForeignKey("IdCampochave")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_campochave_hisconfigchavebloco"),
                    l => l.HasOne<ModConfigBlocoEstudo>().WithMany()
                        .HasForeignKey("IdModifconfigblocoestudo")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_modifconfigblocoestudo_hisconfigchavebloco"),
                    j =>
                    {
                        j.HasKey("IdModifconfigblocoestudo", "IdCampochave").HasName("pk_tb_hisconfigchavebloco");
                        j.ToTable("tb_hisconfigchavebloco");
                        j.HasIndex(new[] { "IdCampochave" }, "in_fk_campochave_hisconfigchavebloco");
                        j.HasIndex(new[] { "IdModifconfigblocoestudo" }, "in_fk_modifconfigblocoestudo_hisconfigchavebloco");
                        j.IndexerProperty<int>("IdModifconfigblocoestudo").HasColumnName("id_modifconfigblocoestudo");
                        j.IndexerProperty<int>("IdCampochave").HasColumnName("id_campochave");
                    });

            entity.HasMany(d => d.IdColunagrandezas).WithMany(p => p.IdModifconfigblocoestudos)
                .UsingEntity<Dictionary<string, object>>(
                    "TbHiscolunagrandeza",
                    r => r.HasOne<ColunaGrandeza>().WithMany()
                        .HasForeignKey("IdColunagrandeza")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_colunagrandeza_hiscolunagrandeza"),
                    l => l.HasOne<ModConfigBlocoEstudo>().WithMany()
                        .HasForeignKey("IdModifconfigblocoestudo")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_modifconfigblocoestudo_hiscolunagrandeza"),
                    j =>
                    {
                        j.HasKey("IdModifconfigblocoestudo", "IdColunagrandeza").HasName("pk_tb_hiscolunagrandeza");
                        j.ToTable("tb_hiscolunagrandeza");
                        j.HasIndex(new[] { "IdColunagrandeza" }, "in_fk_colunagrandeza_hiscolunagrandeza");
                        j.HasIndex(new[] { "IdModifconfigblocoestudo" }, "in_fk_modifconfigblocoestudo_hiscolunagrandeza");
                        j.IndexerProperty<int>("IdModifconfigblocoestudo").HasColumnName("id_modifconfigblocoestudo");
                        j.IndexerProperty<int>("IdColunagrandeza").HasColumnName("id_colunagrandeza");
                    });
        }
    }
}