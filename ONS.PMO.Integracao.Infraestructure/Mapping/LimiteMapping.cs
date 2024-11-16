using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class LimiteMapping : IEntityTypeConfiguration<Limite>
    {
        public void Configure(EntityTypeBuilder<Limite> entity)
        {
            entity.HasKey(e => e.IdTplimite).HasName("pk_tb_tplimite");

            entity.ToTable("tb_tplimite");

            entity.Property(e => e.IdTplimite)
                .ValueGeneratedNever()
                .HasColumnName("id_tplimite");
            entity.Property(e => e.DscTplimite)
                .HasMaxLength(20)
                .HasColumnName("dsc_tplimite");
        }
    }
}