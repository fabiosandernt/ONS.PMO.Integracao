using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class HisModSemanaOperMapping : IEntityTypeConfiguration<HistoricoSemanaOperativa>
    {
        public void Configure(EntityTypeBuilder<HistoricoSemanaOperativa> entity)
        {
            entity.HasKey(e => e.IdHistmodifsemanaoper).HasName("pk_tb_histmodifsemanaoper");

            entity.ToTable("tb_histmodifsemanaoper");

            entity.HasIndex(e => e.IdSemanaoperativa, "in_fk_semanaoperativa_histmodifsemanaoper");

            entity.HasIndex(e => e.IdTpsituacaosemanaoper, "in_fk_tpsituacaosemanaoper_histmodifsemanaoper");

            entity.Property(e => e.IdHistmodifsemanaoper).HasColumnName("id_histmodifsemanaoper");
            entity.Property(e => e.DinHistmodifsemanaoper)
                .HasColumnType("datetime")
                .HasColumnName("din_histmodifsemanaoper");
            entity.Property(e => e.IdSemanaoperativa).HasColumnName("id_semanaoperativa");
            entity.Property(e => e.IdTpsituacaosemanaoper).HasColumnName("id_tpsituacaosemanaoper");

            entity.HasOne(d => d.IdSemanaoperativaNavigation).WithMany(p => p.TbHistmodifsemanaopers)
                .HasForeignKey(d => d.IdSemanaoperativa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_semanaoperativa_histmodifsemanaoper");

            entity.HasOne(d => d.IdTpsituacaosemanaoperNavigation).WithMany(p => p.TbHistmodifsemanaopers)
                .HasForeignKey(d => d.IdTpsituacaosemanaoper)
                .HasConstraintName("fk_tpsituacaosemanaoper_histmodifsemanaoper");
        }
    }
}