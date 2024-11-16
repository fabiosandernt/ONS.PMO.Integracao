using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

public class AuxUsinaMnemonicoMapping : IEntityTypeConfiguration<AuxUsinaMnemonico>
{
    public void Configure(EntityTypeBuilder<AuxUsinaMnemonico> entity)
    {
        entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_usinamnemonico");

        entity.ToTable("tb_aux_usinamnemonico");

        entity.HasIndex(e => e.IdOrigemcoletamnemonico, "in_fk_aux_mnemonicomontador_aux_usinamnemonico");

        entity.HasIndex(e => e.IdOrigemcoletausina, "in_fk_aux_usinamontador_aux_usinamnemonico");

        entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_aux_usinamnemonico");

        entity.Property(e => e.IdOrigemcoletamontador)
            .ValueGeneratedNever()
            .HasColumnName("id_origemcoletamontador");
        entity.Property(e => e.IdOrigemcoletamnemonico).HasColumnName("id_origemcoletamnemonico");
        entity.Property(e => e.IdOrigemcoletausina).HasColumnName("id_origemcoletausina");

        entity.HasOne(d => d.IdOrigemcoletamnemonicoNavigation).WithMany(p => p.TbAuxUsinamnemonicos)
            .HasForeignKey(d => d.IdOrigemcoletamnemonico)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_aux_mnemonicomontador_aux_usinamnemonico");

        entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxUsinamnemonico)
            .HasForeignKey<AuxUsinaMnemonico>(d => d.IdOrigemcoletamontador)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_origemcoletamontador_aux_usinamnemonico");

        entity.HasOne(d => d.IdOrigemcoletausinaNavigation).WithMany(p => p.TbAuxUsinamnemonicos)
            .HasForeignKey(d => d.IdOrigemcoletausina)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_aux_usinamontador_aux_usinamnemonico");
    }
}
