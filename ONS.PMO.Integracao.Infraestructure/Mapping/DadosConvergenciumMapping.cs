using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class DadosConvergenciumMapping : IEntityTypeConfiguration<DadosConvergencia>
    {
        public void Configure(EntityTypeBuilder<DadosConvergencia> entity)
        {
            entity.HasKey(e => e.IdDadosconvergencia).HasName("pk_tb_dadosconvergencia");

            entity.ToTable("tb_dadosconvergencia");

            entity.HasIndex(e => e.IdSemanaoperativa, "in_fk_semanaoperativa_dadosconvergencia");

            entity.Property(e => e.IdDadosconvergencia).HasColumnName("id_dadosconvergencia");
            entity.Property(e => e.IdSemanaoperativa).HasColumnName("id_semanaoperativa");
            entity.Property(e => e.LgnRepresentanteccee)
                .HasMaxLength(30)
                .HasColumnName("lgn_representanteccee");
            entity.Property(e => e.ObsCcee)
                .HasMaxLength(1000)
                .HasColumnName("obs_ccee");

            entity.HasOne(d => d.IdSemanaoperativaNavigation).WithMany(p => p.TbDadosconvergencia)
                .HasForeignKey(d => d.IdSemanaoperativa)
                .HasConstraintName("fk_semanaoperativa_dadosconvergencia");
        }
    }
}
