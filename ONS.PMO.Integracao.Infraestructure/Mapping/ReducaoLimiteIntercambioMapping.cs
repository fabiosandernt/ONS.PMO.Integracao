using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ReducaoLimiteIntercambioMapping : IEntityTypeConfiguration<ReducaoLimiteIntercambio>
    {
        public void Configure(EntityTypeBuilder<ReducaoLimiteIntercambio> entity)
        {
            entity.HasKey(e => e.IdReducaolimiteintercambio).HasName("pk_tb_reducaolimiteintercambio");

            entity.ToTable("tb_reducaolimiteintercambio");

            entity.HasIndex(e => e.IdLimitesintercambio, "in_fk_limitesintercambio_reducaolimiteintercambio");

            entity.Property(e => e.IdReducaolimiteintercambio).HasColumnName("id_reducaolimiteintercambio");
            entity.Property(e => e.DinFim)
                .HasColumnType("datetime")
                .HasColumnName("din_fim");
            entity.Property(e => e.DinInicio)
                .HasColumnType("datetime")
                .HasColumnName("din_inicio");
            entity.Property(e => e.DscMotivo)
                .HasMaxLength(50)
                .HasColumnName("dsc_motivo");
            entity.Property(e => e.IdLimitesintercambio).HasColumnName("id_limitesintercambio");
            entity.Property(e => e.NumIntervencaosgi).HasColumnName("num_intervencaosgi");
            entity.Property(e => e.TipReducaolimiteintercambio)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tip_reducaolimiteintercambio");
            entity.Property(e => e.ValLimite).HasColumnName("val_limite");

            entity.HasOne(d => d.IdLimitesintercambioNavigation).WithMany(p => p.TbReducaolimiteintercambios)
                .HasForeignKey(d => d.IdLimitesintercambio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_limitesintercambio_reducaolimiteintercambio");
        }
    }
}