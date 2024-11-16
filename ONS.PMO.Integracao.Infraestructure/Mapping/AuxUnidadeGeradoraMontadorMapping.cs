using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class AuxUnidadeGeradoraMontadorMapping : IEntityTypeConfiguration<AuxUnidadeGeradoraMontador>
    {
        public void Configure(EntityTypeBuilder<AuxUnidadeGeradoraMontador> entity)
        {
            entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_unidadegeradoramontador");

            entity.ToTable("tb_aux_unidadegeradoramontador");

            entity.HasIndex(e => e.IdOrigemcoletamontadorusina, "in_fk_aux_usinamontador_aux_unidadegeradoramontador");

            entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_aux_unidadegeradoramontador");

            entity.Property(e => e.IdOrigemcoletamontador)
                .ValueGeneratedNever()
                .HasColumnName("id_origemcoletamontador");
            entity.Property(e => e.CodSubsistema)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cod_subsistema");
            entity.Property(e => e.CodUsiplanejamento).HasColumnName("cod_usiplanejamento");
            entity.Property(e => e.IdGruge).HasColumnName("id_gruge");
            entity.Property(e => e.IdOrigemcoletamontadorusina).HasColumnName("id_origemcoletamontadorusina");
            entity.Property(e => e.NomCurtosubsistema)
                .HasMaxLength(20)
                .HasColumnName("nom_curtosubsistema");
            entity.Property(e => e.NomCurtouge)
                .HasMaxLength(80)
                .HasColumnName("nom_curtouge");
            entity.Property(e => e.NomCurtousina)
                .HasMaxLength(20)
                .HasColumnName("nom_curtousina");
            entity.Property(e => e.NumGruge).HasColumnName("num_gruge");
            entity.Property(e => e.NumUge).HasColumnName("num_uge");
            entity.Property(e => e.ValPotencianominal).HasColumnName("val_potencianominal");

            entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxUnidadegeradoramontador)
                .HasForeignKey<AuxUnidadeGeradoraMontador>(d => d.IdOrigemcoletamontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_origemcoletamontador_aux_unidadegeradoramontador");

            entity.HasOne(d => d.IdOrigemcoletamontadorusinaNavigation).WithMany(p => p.TbAuxUnidadegeradoramontadors)
                .HasForeignKey(d => d.IdOrigemcoletamontadorusina)
                .HasConstraintName("fk_aux_usinamontador_aux_unidadegeradoramontador");
        }
    }
}