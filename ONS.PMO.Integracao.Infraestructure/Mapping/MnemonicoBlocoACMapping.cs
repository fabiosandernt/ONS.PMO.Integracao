using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class MnemonicoBlocoACMapping : IEntityTypeConfiguration<MnemonicoBlocoAC>
    {
        public void Configure(EntityTypeBuilder<MnemonicoBlocoAC> entity)
        {
            entity.HasKey(e => e.IdMnemonicoblocoac).HasName("pk_tb_mnemonicoblocoac");

            entity.ToTable("tb_mnemonicoblocoac");

            entity.HasIndex(e => e.IdTpcoleta, "in_fk_tpcoleta_mnemonicoblocoac");

            entity.Property(e => e.IdMnemonicoblocoac).HasColumnName("id_mnemonicoblocoac");
            entity.Property(e => e.CodMnemonicoblocoac)
                .HasMaxLength(50)
                .HasColumnName("cod_mnemonicoblocoac");
            entity.Property(e => e.FlgAtivo).HasColumnName("flg_ativo");
            entity.Property(e => e.FlgReservado).HasColumnName("flg_reservado");
            entity.Property(e => e.IdTpcoleta).HasColumnName("id_tpcoleta");
            entity.Property(e => e.NomMnemonicoblocoac)
                .HasMaxLength(150)
                .HasColumnName("nom_mnemonicoblocoac");
            entity.Property(e => e.NumOrdem).HasColumnName("num_ordem");
            entity.Property(e => e.QtdIndices).HasColumnName("qtd_indices");
            entity.Property(e => e.ValColfinalindice).HasColumnName("val_colfinalindice");
            entity.Property(e => e.ValColinicialindice).HasColumnName("val_colinicialindice");
            entity.Property(e => e.VerControleconcorrencia)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ver_controleconcorrencia");

            entity.HasOne(d => d.IdTpcoletaNavigation).WithMany(p => p.TbMnemonicoblocoacs)
                .HasForeignKey(d => d.IdTpcoleta)
                .HasConstraintName("fk_tpcoleta_mnemonicoblocoac");
        }
    }
}