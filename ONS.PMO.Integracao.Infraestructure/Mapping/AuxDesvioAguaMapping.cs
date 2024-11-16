using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class AuxDesvioAguaMapping : IEntityTypeConfiguration<AuxDesvioAgua>
    {
        public void Configure(EntityTypeBuilder<AuxDesvioAgua> entity)
        {
            entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_desvioagua");
            entity.ToTable("tb_aux_desvioagua");

            entity.HasIndex(e => e.IdUsinamontadorretirada, "in_fk_aux_usinamontador_aux_desvioaguaretirada");
            entity.HasIndex(e => e.IdUsinamontadorretorno, "in_fk_aux_usinamontador_aux_desvioaguaretorno");
            entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_aux_desvioagua");

            entity.Property(e => e.IdOrigemcoletamontador)
                .ValueGeneratedNever()
                .HasColumnName("id_origemcoletamontador");
            entity.Property(e => e.DscDesvioagua).HasColumnName("dsc_desvioagua");
            entity.Property(e => e.IdUsinamontadorretirada).HasColumnName("id_usinamontadorretirada");
            entity.Property(e => e.IdUsinamontadorretorno).HasColumnName("id_usinamontadorretorno");

            entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxDesvioagua)
                .HasForeignKey<AuxDesvioAgua>(d => d.IdOrigemcoletamontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_origemcoletamontador_aux_desvioagua");

            entity.HasOne(d => d.IdUsinamontadorretiradaNavigation).WithMany(p => p.TbAuxDesvioaguaIdUsinamontadorretiradaNavigations)
                .HasForeignKey(d => d.IdUsinamontadorretirada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_aux_usinamontador_aux_desvioaguaretirada");

            entity.HasOne(d => d.IdUsinamontadorretornoNavigation).WithMany(p => p.TbAuxDesvioaguaIdUsinamontadorretornoNavigations)
                .HasForeignKey(d => d.IdUsinamontadorretorno)
                .HasConstraintName("fk_aux_usinamontador_aux_desvioaguaretorno");
        }
    }
}
