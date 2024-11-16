using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class AuxInterligacaoMontadorUsinaMapping : IEntityTypeConfiguration<AuxInterligacaoMontadorUsina>
    {
        public void Configure(EntityTypeBuilder<AuxInterligacaoMontadorUsina> entity)
        {
            entity.HasKey(e => new { e.IdOrigemcoletainterligprinc, e.IdOrigemcoletausina }).HasName("pk_tb_aux_interligacaomontadorusina");

            entity.ToTable("tb_aux_interligacaomontadorusina");

            entity.HasIndex(e => e.IdOrigemcoletainterligprinc, "in_fk_origemcoletamontador_aux_interligacaomontadorusina");

            entity.HasIndex(e => e.IdOrigemcoletausina, "in_fk_origemcoletamontador_aux_interligacaomontadorusina2");

            entity.Property(e => e.IdOrigemcoletainterligprinc).HasColumnName("id_origemcoletainterligprinc");
            entity.Property(e => e.IdOrigemcoletausina).HasColumnName("id_origemcoletausina");
            entity.Property(e => e.FlgSoma).HasColumnName("flg_soma");

            entity.HasOne(d => d.IdOrigemcoletainterligprincNavigation).WithMany(p => p.TbAuxInterligacaomontadorusinaIdOrigemcoletainterligprincNavigations)
                .HasForeignKey(d => d.IdOrigemcoletainterligprinc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_origemcoletamontador_aux_interligacaomontadorusina");

            entity.HasOne(d => d.IdOrigemcoletausinaNavigation).WithMany(p => p.TbAuxInterligacaomontadorusinaIdOrigemcoletausinaNavigations)
                .HasForeignKey(d => d.IdOrigemcoletausina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_origemcoletamontador_aux_interligacaomontadorusina2");
        }
    }
}
