using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class AuxSubsistemaMontadorMapping : IEntityTypeConfiguration<AuxSubsistemaMontador>
    {
        public void Configure(EntityTypeBuilder<AuxSubsistemaMontador> entity)
        {
            entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_subsistemamontador");

            entity.ToTable("tb_aux_subsistemamontador");

            entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_aux_subsistemamontador");

            entity.Property(e => e.IdOrigemcoletamontador)
                .ValueGeneratedNever()
                .HasColumnName("id_origemcoletamontador");
            entity.Property(e => e.CodSubsistema).HasColumnName("cod_subsistema");
            entity.Property(e => e.NomCurtosubsistema)
                .HasMaxLength(20)
                .HasColumnName("nom_curtosubsistema");
            entity.Property(e => e.NumTppatamares).HasColumnName("num_tppatamares");

            entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxSubsistemamontador)
                .HasForeignKey<AuxSubsistemaMontador>(d => d.IdOrigemcoletamontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_origemcoletamontador_aux_subsistemamontador");
        }
    }
}
