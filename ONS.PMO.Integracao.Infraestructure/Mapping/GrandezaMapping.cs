using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class GrandezaMapping : IEntityTypeConfiguration<Grandeza>
    {
        public void Configure(EntityTypeBuilder<Grandeza> entity)
        {
            entity.HasKey(e => e.IdGrandeza).HasName("pk_tb_grandeza");

            entity.ToTable("tb_grandeza");

            entity.HasIndex(e => e.IdInsumopmo, "in_fk_insumoestruturado_grandeza");

            entity.HasIndex(e => e.IdTpdadograndeza, "in_fk_tpdadograndeza_grandeza");

            entity.Property(e => e.IdGrandeza).HasColumnName("id_grandeza");
            entity.Property(e => e.FlgAceitavalornegativo).HasColumnName("flg_aceitavalornegativo");
            entity.Property(e => e.FlgAtivo)
                .HasDefaultValue(true)
                .HasColumnName("flg_ativo");
            entity.Property(e => e.FlgColetaporestagio).HasColumnName("flg_coletaporestagio");
            entity.Property(e => e.FlgColetaporlimite).HasColumnName("flg_coletaporlimite");
            entity.Property(e => e.FlgColetaporpatamar).HasColumnName("flg_coletaporpatamar");
            entity.Property(e => e.FlgDestacadiferenca).HasColumnName("flg_destacadiferenca");
            entity.Property(e => e.FlgObrigatoriedade)
                .HasDefaultValue(false)
                .HasColumnName("flg_obrigatoriedade");
            entity.Property(e => e.FlgParticipablocomontador)
                .HasDefaultValue(false)
                .HasColumnName("flg_participablocomontador");
            entity.Property(e => e.FlgPoderecuperarvalor).HasColumnName("flg_poderecuperarvalor");
            entity.Property(e => e.FlgPreaprovadocomalteracao).HasColumnName("flg_preaprovadocomalteracao");
            entity.Property(e => e.IdInsumopmo).HasColumnName("id_insumopmo");
            entity.Property(e => e.IdTpdadograndeza).HasColumnName("id_tpdadograndeza");
            entity.Property(e => e.NomGrandeza)
                .HasMaxLength(150)
                .HasColumnName("nom_grandeza");
            entity.Property(e => e.NumOrdemblocomontador).HasColumnName("num_ordemblocomontador");
            entity.Property(e => e.NumOrdemexibicao).HasColumnName("num_ordemexibicao");
            entity.Property(e => e.QtdDecimais).HasColumnName("qtd_decimais");
            entity.Property(e => e.QtdDigitos).HasColumnName("qtd_digitos");

            entity.HasOne(d => d.IdInsumopmoNavigation).WithMany(p => p.TbGrandezas)
                .HasForeignKey(d => d.IdInsumopmo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_insumoestruturado_grandeza");

            entity.HasOne(d => d.IdTpdadograndezaNavigation).WithMany(p => p.TbGrandezas)
                .HasForeignKey(d => d.IdTpdadograndeza)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tpdadograndeza_grandeza");
        }
    }
}
