using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ManutencaoProgramadumMapping : IEntityTypeConfiguration<ManutencaoProgramadum>
    {
        public void Configure(EntityTypeBuilder<ManutencaoProgramadum> entity)
        {
            entity.HasKey(e => e.IdTpmanutencaoprogramada).HasName("pk_tb_tpmanutencaoprogramada");

            entity.ToTable("tb_tpmanutencaoprogramada");

            entity.Property(e => e.IdTpmanutencaoprogramada).HasColumnName("id_tpmanutencaoprogramada");
            entity.Property(e => e.NomTpmanutencaoprogramada)
                .HasMaxLength(70)
                .HasColumnName("nom_tpmanutencaoprogramada");
        }
    }
}