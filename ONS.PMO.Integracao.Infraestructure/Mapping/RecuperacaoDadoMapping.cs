using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class RecuperacaoDadoMapping : IEntityTypeConfiguration<RecuperacaoDado>
    {
        public void Configure(EntityTypeBuilder<RecuperacaoDado> entity)
        {
            entity.HasKey(e => e.IdRecuperacaodados).HasName("pk_tb_recuperacaodados");

            entity.ToTable("tb_recuperacaodados");

            entity.HasIndex(e => e.IdEstudomontadordestino, "in_fk_estudomontador_recuperacaodados_destino");

            entity.HasIndex(e => e.IdEstudomontadorfonte, "in_fk_estudomontador_recuperacaodados_fonte");

            entity.HasIndex(e => e.IdSemanaoperativafonte, "in_fk_semanaoperativa_recuperacaodados");

            entity.Property(e => e.IdRecuperacaodados).HasColumnName("id_recuperacaodados");
            entity.Property(e => e.DinRecuperacao)
                .HasColumnType("datetime")
                .HasColumnName("din_recuperacao");
            entity.Property(e => e.FlgInserirchaves).HasColumnName("flg_inserirchaves");
            entity.Property(e => e.IdEstudomontadordestino).HasColumnName("id_estudomontadordestino");
            entity.Property(e => e.IdEstudomontadorfonte).HasColumnName("id_estudomontadorfonte");
            entity.Property(e => e.IdSemanaoperativafonte).HasColumnName("id_semanaoperativafonte");
            entity.Property(e => e.LgnUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lgn_usuario");
            entity.Property(e => e.NomArquivofonte)
                .HasMaxLength(200)
                .HasColumnName("nom_arquivofonte");

            entity.HasOne(d => d.IdEstudomontadordestinoNavigation).WithMany(p => p.TbRecuperacaodadoIdEstudomontadordestinoNavigations)
                .HasForeignKey(d => d.IdEstudomontadordestino)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_estudomontador_recuperacaodados_destino");

            entity.HasOne(d => d.IdEstudomontadorfonteNavigation).WithMany(p => p.TbRecuperacaodadoIdEstudomontadorfonteNavigations)
                .HasForeignKey(d => d.IdEstudomontadorfonte)
                .HasConstraintName("fk_estudomontador_recuperacaodados_fonte");

            entity.HasOne(d => d.IdSemanaoperativafonteNavigation).WithMany(p => p.TbRecuperacaodados)
                .HasForeignKey(d => d.IdSemanaoperativafonte)
                .HasConstraintName("fk_semanaoperativa_recuperacaodados_fonte");
        }
    }
}