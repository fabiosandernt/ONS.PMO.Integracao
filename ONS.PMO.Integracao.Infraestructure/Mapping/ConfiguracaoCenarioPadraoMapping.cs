using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ConfiguracaoCenarioPadraoMapping : IEntityTypeConfiguration<ConfiguracaoCenarioPadrao>
    {
        public void Configure(EntityTypeBuilder<ConfiguracaoCenarioPadrao> entity)
        {
            entity.HasKey(e => e.IdConfiguracaocenariopadrao)
          .HasName("pk_tb_configuracaocenariopadrao");

            entity.ToTable("tb_configuracaocenariopadrao");

            entity.Property(e => e.IdConfiguracaocenariopadrao)
                .ValueGeneratedNever()
                .HasColumnName("id_configuracaocenariopadrao");
            entity.Property(e => e.MesReferencia).HasColumnName("mes_referencia");
            entity.Property(e => e.ValPadrao).HasColumnName("val_padrao");
        }
    }
}
