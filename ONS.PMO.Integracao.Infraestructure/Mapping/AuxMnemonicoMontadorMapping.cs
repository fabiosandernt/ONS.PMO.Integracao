using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class AuxMnemonicoMontadorMapping : IEntityTypeConfiguration<AuxMnemonicoMontador>
    {
        public void Configure(EntityTypeBuilder<AuxMnemonicoMontador> entity)
        {
            entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_mnemonicomontador");

            entity.ToTable("tb_aux_mnemonicomontador");

            entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_aux_mnemonicomontador");

            entity.Property(e => e.IdOrigemcoletamontador)
                .ValueGeneratedNever()
                .HasColumnName("id_origemcoletamontador");
            entity.Property(e => e.NomMnemonico)
                .HasMaxLength(50)
                .HasColumnName("nom_mnemonico");

            entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxMnemonicomontador)
                .HasForeignKey<AuxMnemonicoMontador>(d => d.IdOrigemcoletamontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_origemcoletamontador_aux_mnemonicomontador");
        }
    }
}