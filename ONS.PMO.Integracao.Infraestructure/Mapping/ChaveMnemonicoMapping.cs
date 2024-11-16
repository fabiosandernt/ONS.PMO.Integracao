using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ChaveMnemonicoMapping : IEntityTypeConfiguration<ChaveMnemonico>
    {
        public void Configure(EntityTypeBuilder<ChaveMnemonico> entity)
        {
            entity.HasKey(e => new { e.IdCampochave, e.IdMnemonicoblocoac }).HasName("pk_tb_chavemnemonico");

            entity.ToTable("tb_chavemnemonico");

            entity.HasIndex(e => e.IdCampochave, "in_fk_campochave_chavemnemonico");

            entity.HasIndex(e => e.IdMnemonicoblocoac, "in_fk_mnemonicoblocoac_chavemnemonico");

            entity.Property(e => e.IdCampochave).HasColumnName("id_campochave");
            entity.Property(e => e.IdMnemonicoblocoac).HasColumnName("id_mnemonicoblocoac");
            entity.Property(e => e.FlgDispexportacao).HasColumnName("flg_dispexportacao");
            entity.Property(e => e.FlgDispmanutencao).HasColumnName("flg_dispmanutencao");
            entity.Property(e => e.FlgGeralinhacomentario).HasColumnName("flg_geralinhacomentario");

            entity.HasOne(d => d.IdCampochaveNavigation).WithMany(p => p.TbChavemnemonicos)
                .HasForeignKey(d => d.IdCampochave)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_campochave_chavemnemonico");

            entity.HasOne(d => d.IdMnemonicoblocoacNavigation).WithMany(p => p.TbChavemnemonicos)
                .HasForeignKey(d => d.IdMnemonicoblocoac)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_mnemonicoblocoac_chavemnemonico");
        }
    }
}