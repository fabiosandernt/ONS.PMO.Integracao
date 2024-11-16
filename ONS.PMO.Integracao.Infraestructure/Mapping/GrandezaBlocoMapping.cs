using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class GrandezaBlocoMapping : IEntityTypeConfiguration<GrandezaBloco>
    {
        public void Configure(EntityTypeBuilder<GrandezaBloco> entity)
        {
            entity.HasKey(e => e.IdGrandezamontador).HasName("pk_tb_grandezabloco");

            entity.ToTable("tb_grandezabloco");

            entity.HasIndex(e => e.IdBloco, "in_fk_bloco_grandezabloco");

            entity.HasIndex(e => e.IdGrandeza, "in_fk_grandeza_grandezabloco");

            entity.HasIndex(e => e.IdGrandezamontadorref, "in_fk_grandezabloco_grandezabloco");

            entity.HasIndex(e => e.IdGrandezamontador, "in_fk_grandezamontador_grandezabloco");

            entity.Property(e => e.IdGrandezamontador)
                .ValueGeneratedNever()
                .HasColumnName("id_grandezamontador");
            entity.Property(e => e.FlgColetapormeses).HasColumnName("flg_coletapormeses");
            entity.Property(e => e.FlgColetaporsemanas).HasColumnName("flg_coletaporsemanas");
            entity.Property(e => e.FlgQuebraestagio).HasColumnName("flg_quebraestagio");
            entity.Property(e => e.IdBloco).HasColumnName("id_bloco");
            entity.Property(e => e.IdGrandeza).HasColumnName("id_grandeza");
            entity.Property(e => e.IdGrandezamontadorref).HasColumnName("id_grandezamontadorref");

            entity.HasOne(d => d.IdBlocoNavigation).WithMany(p => p.TbGrandezablocos)
                .HasForeignKey(d => d.IdBloco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bloco_grandezabloco");

            entity.HasOne(d => d.IdGrandezaNavigation).WithMany(p => p.TbGrandezablocos)
                .HasForeignKey(d => d.IdGrandeza)
                .HasConstraintName("fk_grandeza_grandezabloco");

            entity.HasOne(d => d.IdGrandezamontadorNavigation).WithOne(p => p.TbGrandezabloco)
                .HasForeignKey<GrandezaBloco>(d => d.IdGrandezamontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grandezamontador_grandezabloco");

            entity.HasOne(d => d.IdGrandezamontadorrefNavigation).WithMany(p => p.InverseIdGrandezamontadorrefNavigation)
                .HasForeignKey(d => d.IdGrandezamontadorref)
                .HasConstraintName("fk_grandezabloco_grandezabloco");
        }
    }
}