using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.BDT;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class MnemonicoPMOMapping : IEntityTypeConfiguration<MnemonicoPMO>
    {
        public void Configure(EntityTypeBuilder<MnemonicoPMO> entity)
        {
            entity.HasKey(e => e.IdMnemonicopmo).HasName("pk_tb_mnemonicopmo");

            entity.ToTable("tb_mnemonicopmo");

            entity.HasIndex(e => e.IdResultadocoletapmo, "in_fk_resultadocoletapmo_mnemonicopmo");

            entity.HasIndex(e => e.IdTpdadograndeza, "in_fk_tpdadograndeza_mnemonicopmo");

            entity.HasIndex(e => e.IdTpperiodomontador, "in_fk_tpperiodomontador_mnemonicopmo");

            entity.Property(e => e.IdMnemonicopmo)
                .ValueGeneratedNever()
                .HasColumnName("id_mnemonicopmo");
            entity.Property(e => e.CodMnemonicopmo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("cod_mnemonicopmo");
            entity.Property(e => e.FlgAceitavalornegativo).HasColumnName("flg_aceitavalornegativo");
            entity.Property(e => e.FlgAtivo).HasColumnName("flg_ativo");
            entity.Property(e => e.FlgColetamediapatamares).HasColumnName("flg_coletamediapatamares");
            entity.Property(e => e.FlgColetapatamar).HasColumnName("flg_coletapatamar");
            entity.Property(e => e.FlgColetareservatorio).HasColumnName("flg_coletareservatorio");
            entity.Property(e => e.FlgColetasubsistema).HasColumnName("flg_coletasubsistema");
            entity.Property(e => e.FlgColetausina).HasColumnName("flg_coletausina");
            entity.Property(e => e.IdResultadocoletapmo).HasColumnName("id_resultadocoletapmo");
            entity.Property(e => e.IdTpdadograndeza).HasColumnName("id_tpdadograndeza");
            entity.Property(e => e.IdTpperiodomontador).HasColumnName("id_tpperiodomontador");
            entity.Property(e => e.NomMnemonicopmo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nom_mnemonicopmo");
            entity.Property(e => e.QtdCasasdecimaisvalor).HasColumnName("qtd_casasdecimaisvalor");
            entity.Property(e => e.QtdDigitosvalor).HasColumnName("qtd_digitosvalor");

            entity.HasOne(d => d.IdResultadocoletapmoNavigation).WithMany(p => p.TbMnemonicopmos)
                .HasForeignKey(d => d.IdResultadocoletapmo)
                .HasConstraintName("fk_resultadocoletapmo_mnemonicopmo");

            entity.HasOne(d => d.IdTpdadograndezaNavigation).WithMany(p => p.TbMnemonicopmos)
                .HasForeignKey(d => d.IdTpdadograndeza)
                .HasConstraintName("fk_tpdadograndeza_mnemonicopmo");

            entity.HasOne(d => d.IdTpperiodomontadorNavigation).WithMany(p => p.TbMnemonicopmos)
                .HasForeignKey(d => d.IdTpperiodomontador)
                .HasConstraintName("fk_tpperiodomontador_mnemonicopmo");
        }
    }
}