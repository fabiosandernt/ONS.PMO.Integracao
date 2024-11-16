using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class HisConfigBlocoMapping : IEntityTypeConfiguration<HistoricoConfiguracaoBloco>
    {
        public void Configure(EntityTypeBuilder<HistoricoConfiguracaoBloco> entity)
        {
            entity.HasKey(e => e.IdModifconfigblocoestudo).HasName("pk_tb_hisconfigbloco");

            entity.ToTable("tb_hisconfigbloco");

            entity.HasIndex(e => e.IdModifconfigblocoestudo, "in_fk_modifconfigblocoestudo_hisconfigbloco");

            entity.Property(e => e.IdModifconfigblocoestudo)
                .ValueGeneratedNever()
                .HasColumnName("id_modifconfigblocoestudo");
            entity.Property(e => e.DscCabecalho).HasColumnName("dsc_cabecalho");
            entity.Property(e => e.FlgProximoestudo).HasColumnName("flg_proximoestudo");

            entity.HasOne(d => d.IdModifconfigblocoestudoNavigation).WithOne(p => p.TbHisconfigbloco)
                .HasForeignKey<HistoricoConfiguracaoBloco>(d => d.IdModifconfigblocoestudo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_modifconfigblocoestudo_hisconfigbloco");
        }
    }
}