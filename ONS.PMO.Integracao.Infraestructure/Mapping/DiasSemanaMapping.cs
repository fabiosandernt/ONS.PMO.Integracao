using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class DiasSemanaMapping : IEntityTypeConfiguration<DiasSemana>
    {
        public void Configure(EntityTypeBuilder<DiasSemana> entity)
        {
            entity.HasKey(e => e.IdDiasemana).HasName("pk_tb_diasemana");

            entity.ToTable("tb_diasemana");

            entity.Property(e => e.IdDiasemana).HasColumnName("id_diasemana");
            entity.Property(e => e.DatDiasemana).HasColumnName("dat_diasemana");
            entity.Property(e => e.FlgFeriado).HasColumnName("flg_feriado");
            entity.Property(e => e.FlgTpdiasemana)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("flg_tpdiasemana");
        }
    }
}
