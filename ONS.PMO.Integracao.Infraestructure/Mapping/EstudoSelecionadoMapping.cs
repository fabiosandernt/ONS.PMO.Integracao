using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class EstudoSelecionadoMapping : IEntityTypeConfiguration<EstudoSelecionado>
    {
        public void Configure(EntityTypeBuilder<EstudoSelecionado> entity)
        {
            entity.HasKey(e => e.IdUsuario).HasName("pk_tb_estudoselecionado");

            entity.ToTable("tb_estudoselecionado");

            entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_estudoselecionado");

            entity.Property(e => e.IdUsuario)
                .HasMaxLength(50)
                .HasColumnName("id_usuario");
            entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");

            entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbEstudoselecionados)
                .HasForeignKey(d => d.IdEstudomontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_estudomontador_estudoselecionado");
        }
    }
}
