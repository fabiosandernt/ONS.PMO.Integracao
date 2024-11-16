using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class AuxSubmercadoMapping : IEntityTypeConfiguration<AuxSubmercado>
    {
        public void Configure(EntityTypeBuilder<AuxSubmercado> entity)
        {
            entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_submercado");

            entity.ToTable("tb_aux_submercado");

            entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_aux_submercado");

            entity.Property(e => e.IdOrigemcoletamontador)
                .ValueGeneratedNever()
                .HasColumnName("id_origemcoletamontador");
            entity.Property(e => e.CodSubmercado)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cod_submercado");

            entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxSubmercado)
                .HasForeignKey<AuxSubmercado>(d => d.IdOrigemcoletamontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_origemcoletamontador_aux_submercado");
        }
    }
}