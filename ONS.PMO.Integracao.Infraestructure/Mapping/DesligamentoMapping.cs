using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class DesligamentoMapping : IEntityTypeConfiguration<Desligamento>
    {
        public void Configure(EntityTypeBuilder<Desligamento> entity)
        {
            entity.HasKey(e => e.IdDesligamento).HasName("pk_tb_desligamentos");

            entity.ToTable("tb_desligamentos");

            entity.HasIndex(e => e.IdConjuntogeracaominima, "in_fk_conjuntogeracaominima_desligamentos");

            entity.Property(e => e.IdDesligamento).HasColumnName("id_desligamento");
            entity.Property(e => e.DinFim)
                .HasColumnType("datetime")
                .HasColumnName("din_fim");
            entity.Property(e => e.DinInicio)
                .HasColumnType("datetime")
                .HasColumnName("din_inicio");
            entity.Property(e => e.DscMotivo)
                .HasMaxLength(50)
                .HasColumnName("dsc_motivo");
            entity.Property(e => e.IdConjuntogeracaominima).HasColumnName("id_conjuntogeracaominima");
            entity.Property(e => e.NumIntervencaosgi).HasColumnName("num_intervencaosgi");
            entity.Property(e => e.TpDesligamento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tp_desligamento");
            entity.Property(e => e.ValGeracaominima).HasColumnName("val_geracaominima");

            entity.HasOne(d => d.IdConjuntogeracaominimaNavigation).WithMany(p => p.TbDesligamentos)
                .HasForeignKey(d => d.IdConjuntogeracaominima)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_conjuntogeracaominima_desligamentos");
        }
    }
}
