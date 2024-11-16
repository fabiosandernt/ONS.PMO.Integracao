using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class HisConfigGrandezaMapping : IEntityTypeConfiguration<HistoricoConfiguracaoGrandeza>
    {
        public void Configure(EntityTypeBuilder<HistoricoConfiguracaoGrandeza> entity)
        {
            entity.HasKey(e => new { e.IdModifconfigblocoestudo, e.IdGrandezamontador }).HasName("pk_tb_hisconfiggrandeza");

            entity.ToTable("tb_hisconfiggrandeza");

            entity.HasIndex(e => e.IdGrandezamontador, "in_fk_grandezamontador_hisconfiggrandeza");

            entity.HasIndex(e => e.IdModifconfigblocoestudo, "in_fk_modifconfigblocoestudo_hisconfiggrandeza");

            entity.Property(e => e.IdModifconfigblocoestudo).HasColumnName("id_modifconfigblocoestudo");
            entity.Property(e => e.IdGrandezamontador).HasColumnName("id_grandezamontador");
            entity.Property(e => e.FlgProximoestudo).HasColumnName("flg_proximoestudo");

            entity.HasOne(d => d.IdGrandezamontadorNavigation).WithMany(p => p.TbHisconfiggrandezas)
                .HasForeignKey(d => d.IdGrandezamontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grandezamontador_hisconfiggrandeza");

            entity.HasOne(d => d.IdModifconfigblocoestudoNavigation).WithMany(p => p.TbHisconfiggrandezas)
                .HasForeignKey(d => d.IdModifconfigblocoestudo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_modifconfigblocoestudo_hisconfiggrandeza");
        }
    }
}
