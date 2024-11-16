using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class AuxSubsistemaIntervaloCustoDeficitMapping : IEntityTypeConfiguration<AuxSubsistemaIntervaloCustoDeficit>
    {
        public void Configure(EntityTypeBuilder<AuxSubsistemaIntervaloCustoDeficit> entity)
        {
            entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_subsistemacustodeficit");

            entity.ToTable("tb_aux_subsistemaintervalocustodeficit");

            entity.HasIndex(e => e.IdIntervalocustodeficit, "in_fk_aux_intervalocurvadeficit_aux_subsistemacustodeficit");

            entity.HasIndex(e => e.IdOrigemcoletamontadorsubsistema, "in_fk_aux_subsistemamontador_aux_subsistemacustodeficit");

            entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_oriemcoletamontador_aux_subsistemaintervalocustodeficit");

            entity.Property(e => e.IdOrigemcoletamontador)
                .ValueGeneratedNever()
                .HasColumnName("id_origemcoletamontador");
            entity.Property(e => e.IdIntervalocustodeficit).HasColumnName("id_intervalocustodeficit");
            entity.Property(e => e.IdOrigemcoletamontadorsubsistema).HasColumnName("id_origemcoletamontadorsubsistema");

            entity.HasOne(d => d.IdIntervalocustodeficitNavigation).WithMany(p => p.TbAuxSubsistemaintervalocustodeficits)
                .HasForeignKey(d => d.IdIntervalocustodeficit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_aux_intervalocurvadeficit_aux_subsistemacustodeficit");

            entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxSubsistemaintervalocustodeficit)
                .HasForeignKey<AuxSubsistemaIntervaloCustoDeficit>(d => d.IdOrigemcoletamontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_oriemcoletamontador_aux_subsistemaintervalocustodeficit");

            entity.HasOne(d => d.IdOrigemcoletamontadorsubsistemaNavigation).WithMany(p => p.TbAuxSubsistemaintervalocustodeficits)
                .HasForeignKey(d => d.IdOrigemcoletamontadorsubsistema)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_aux_subsistemamontador_aux_subsistemacustodeficit");
        }
    }
}