using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class OrdemExportacaoAgenteMapping : IEntityTypeConfiguration<OrdemExportacaoAgente>
    {
        public void Configure(EntityTypeBuilder<OrdemExportacaoAgente> entity)
        {
            entity.HasKey(e => e.AgeId).HasName("pk_tb_ordemexportacaoagente");

            entity.ToTable("tb_ordemexportacaoagente");

            entity.Property(e => e.AgeId)
                .HasMaxLength(3)
                .HasColumnName("age_id");
            entity.Property(e => e.NumOrdemexportacao).HasColumnName("num_ordemexportacao");
        }
    }
}