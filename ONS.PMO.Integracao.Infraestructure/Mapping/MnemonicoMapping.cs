using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class MnemonicoMapping : IEntityTypeConfiguration<Mnemonico>
    {
        public void Configure(EntityTypeBuilder<Mnemonico> entity)
        {
            entity.HasKey(e => e.IdTpmnemonico).HasName("pk_tb_tpmnemonico");

            entity.ToTable("tb_tpmnemonico");

            entity.Property(e => e.IdTpmnemonico)
                .ValueGeneratedNever()
                .HasColumnName("id_tpmnemonico");
            entity.Property(e => e.NomTpmnemonico)
                .HasMaxLength(50)
                .HasColumnName("nom_tpmnemonico");
        }
    }
}