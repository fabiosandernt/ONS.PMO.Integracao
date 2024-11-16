using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class AuxUnidadeGeradoraMapping : IEntityTypeConfiguration<AuxUnidadeGeradora>
    {
        public void Configure(EntityTypeBuilder<AuxUnidadeGeradora> entity)
        {
            entity.HasKey(e => e.IdOrigemcoleta).HasName("pk_tb_aux_unidadegeradora");

            entity.ToTable("tb_aux_unidadegeradora");

            entity.HasIndex(e => e.IdOrigemcoletausinapai, "in_fk_aux_usina_aux_unidadegeradora");

            entity.HasIndex(e => e.IdOrigemcoleta, "in_fk_origemcoleta_aux_unidadegeradora");

            entity.Property(e => e.IdOrigemcoleta)
                .HasMaxLength(50)
                .HasColumnName("id_origemcoleta");
            entity.Property(e => e.CodDpp).HasColumnName("cod_dpp");
            entity.Property(e => e.IdOrigemcoletausinapai)
                .HasMaxLength(50)
                .HasColumnName("id_origemcoletausinapai");
            entity.Property(e => e.NumConjunto).HasColumnName("num_conjunto");
            entity.Property(e => e.NumMaquina).HasColumnName("num_maquina");
            entity.Property(e => e.ValPotencianominal).HasColumnName("val_potencianominal");

            entity.HasOne(d => d.IdOrigemcoletaNavigation).WithOne(p => p.TbAuxUnidadegeradora)
                .HasForeignKey<AuxUnidadeGeradora>(d => d.IdOrigemcoleta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_origemcoleta_aux_unidadegeradora");

            entity.HasOne(d => d.IdOrigemcoletausinapaiNavigation).WithMany(p => p.TbAuxUnidadegeradoras)
                .HasForeignKey(d => d.IdOrigemcoletausinapai)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_aux_usina_aux_unidadegeradora");
        }
    }
}