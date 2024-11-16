using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class AuxInterligacaoMontadorMapping : IEntityTypeConfiguration<AuxInterligacaoMontador>
    {
        public void Configure(EntityTypeBuilder<AuxInterligacaoMontador> entity)
        {
            entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_interligacaomontador");

            entity.ToTable("tb_aux_interligacaomontador");

            entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_aux_interligacaomontador");

            entity.Property(e => e.IdOrigemcoletamontador)
                .ValueGeneratedNever()
                .HasColumnName("id_origemcoletamontador");
            entity.Property(e => e.CodSubsistemade)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cod_subsistemade");
            entity.Property(e => e.CodSubsistemapara)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cod_subsistemapara");
            entity.Property(e => e.NomCurtosubsistemade)
                .HasMaxLength(20)
                .HasColumnName("nom_curtosubsistemade");
            entity.Property(e => e.NomCurtosubsistemapara)
                .HasMaxLength(20)
                .HasColumnName("nom_curtosubsistemapara");

            entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxInterligacaomontador)
                .HasForeignKey<AuxInterligacaoMontador>(d => d.IdOrigemcoletamontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_origemcoletamontador_aux_interligacaomontador");
        }
    }
}