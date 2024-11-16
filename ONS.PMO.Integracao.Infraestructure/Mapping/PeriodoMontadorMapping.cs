using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class PeriodoMontadorMapping : IEntityTypeConfiguration<PeriodoMontador>
    {
        public void Configure(EntityTypeBuilder<PeriodoMontador> entity)
        {
            entity.HasKey(e => e.IdTpperiodomontador).HasName("pk_tb_tpperiodomontador");

            entity.ToTable("tb_tpperiodomontador");

            entity.Property(e => e.IdTpperiodomontador)
                .ValueGeneratedNever()
                .HasColumnName("id_tpperiodomontador");
            entity.Property(e => e.NomTpperiodomontador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_tpperiodomontador");
        }
    }
}