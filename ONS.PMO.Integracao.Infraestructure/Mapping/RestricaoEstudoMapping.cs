using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class RestricaoEstudoMapping : IEntityTypeConfiguration<RestricaoEstudo>
    {
        public void Configure(EntityTypeBuilder<RestricaoEstudo> entity)
        {
            entity.HasKey(e => new { e.IdTprestricao, e.IdEstudomontador }).HasName("pk_tb_restricaoestudo");

            entity.ToTable("tb_restricaoestudo");

            entity.HasIndex(e => e.IdEstadorestricaoestudomontador, "in_fk_estadorestricaoestudomontador_restricaoestudo");

            entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_restricaoestudo");

            entity.HasIndex(e => e.IdTprestricao, "in_fk_tprestricao_restricaoestudo");

            entity.Property(e => e.IdTprestricao).HasColumnName("id_tprestricao");
            entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
            entity.Property(e => e.IdEstadorestricaoestudomontador).HasColumnName("id_estadorestricaoestudomontador");
            entity.Property(e => e.LgnUsuariocheckout)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lgn_usuariocheckout");
            entity.Property(e => e.VerControleconcorrencia)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ver_controleconcorrencia");

            entity.HasOne(d => d.IdEstadorestricaoestudomontadorNavigation).WithMany(p => p.TbRestricaoestudos)
                .HasForeignKey(d => d.IdEstadorestricaoestudomontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_estadorestricaoestudomontador_restricaoestudo");

            entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbRestricaoestudos)
                .HasForeignKey(d => d.IdEstudomontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_estudomontador_restricaoestudo");

            entity.HasOne(d => d.IdTprestricaoNavigation).WithMany(p => p.TbRestricaoestudos)
                .HasForeignKey(d => d.IdTprestricao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tprestricao_restricaoestudo");
        }
    }
}