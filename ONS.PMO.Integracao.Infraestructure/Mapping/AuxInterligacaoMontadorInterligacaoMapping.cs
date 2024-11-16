using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class AuxInterligacaoMontadorInterligacaoMapping : IEntityTypeConfiguration<AuxInterligacaoMontadorInterligacao>
    {
        public void Configure(EntityTypeBuilder<AuxInterligacaoMontadorInterligacao> entity)
        {
            entity.HasKey(e => new { e.IdInterligacao, e.IdOrigemcoletainterligacao }).HasName("pk_tb_aux_interligacaomontadorinterligacao");

            entity.ToTable("tb_aux_interligacaomontadorinterligacao");

            entity.HasIndex(e => e.IdInterligacao, "in_fk_aux_interligacao_aux_interligacaomontadorinterligacao");

            entity.HasIndex(e => e.IdOrigemcoletainterligacao, "in_fk_origemcoletamontador_aux_interligacaomontadorinterligacao");

            entity.Property(e => e.IdInterligacao).HasColumnName("id_interligacao");
            entity.Property(e => e.IdOrigemcoletainterligacao).HasColumnName("id_origemcoletainterligacao");
            entity.Property(e => e.FlgSoma).HasColumnName("flg_soma");

            entity.HasOne(d => d.IdInterligacaoNavigation).WithMany(p => p.TbAuxInterligacaomontadorinterligacaos)
                .HasForeignKey(d => d.IdInterligacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_aux_interligacao_aux_interligacaomontadorinterligacao");

            entity.HasOne(d => d.IdOrigemcoletainterligacaoNavigation).WithMany(p => p.TbAuxInterligacaomontadorinterligacaos)
                .HasForeignKey(d => d.IdOrigemcoletainterligacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_origemcoletamontador_aux_interligacaomontadorinterligacao");
        }
    }
}
