using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class EstudoMontadorNaoOficialMapping : IEntityTypeConfiguration<EstudoMontadorNaoOficial>
    {
        public void Configure(EntityTypeBuilder<EstudoMontadorNaoOficial> entity)
        {
            entity.HasKey(e => e.IdEstudomontador).HasName("pk_tb_estudomontadornaooficial");

            entity.ToTable("tb_estudomontadornaooficial");

            entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_estudomontadornaooficial");

            entity.Property(e => e.IdEstudomontador)
                .ValueGeneratedNever()
                .HasColumnName("id_estudomontador");
            entity.Property(e => e.AgeId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("age_id");
            entity.Property(e => e.CodEstudonaooficial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cod_estudonaooficial");
            entity.Property(e => e.DatFimsemana)
                .HasColumnType("datetime")
                .HasColumnName("dat_fimsemana");
            entity.Property(e => e.DatIniciosemana)
                .HasColumnType("datetime")
                .HasColumnName("dat_iniciosemana");
            entity.Property(e => e.LgnUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lgn_usuario");
            entity.Property(e => e.NomEstudonaooficial)
                .HasMaxLength(150)
                .HasColumnName("nom_estudonaooficial");
            entity.Property(e => e.NumRevisao).HasColumnName("num_revisao");

            entity.HasOne(d => d.IdEstudomontadorNavigation).WithOne(p => p.TbEstudomontadornaooficial)
                .HasForeignKey<EstudoMontadorNaoOficial>(d => d.IdEstudomontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_estudomontador_estudomontadornaooficial");
        }
    }
}
