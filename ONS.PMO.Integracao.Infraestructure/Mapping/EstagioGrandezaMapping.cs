using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class EstagioGrandezaMapping : IEntityTypeConfiguration<EstagioGrandeza>
    {
        public void Configure(EntityTypeBuilder<EstagioGrandeza> entity)
        {
            entity.HasKey(e => e.IdEstagiograndeza).HasName("pk_tb_estagiograndeza");

            entity.ToTable("tb_estagiograndeza");

            entity.HasIndex(e => e.IdGrandezablocoestudo, "in_fk_grandezablocoestudo_estagiograndeza");

            entity.Property(e => e.IdEstagiograndeza).HasColumnName("id_estagiograndeza");
            entity.Property(e => e.DatFimsemana).HasColumnName("dat_fimsemana");
            entity.Property(e => e.DatIniciosemana).HasColumnName("dat_iniciosemana");
            entity.Property(e => e.IdGrandezablocoestudo).HasColumnName("id_grandezablocoestudo");

            entity.HasOne(d => d.IdGrandezablocoestudoNavigation).WithMany(p => p.TbEstagiograndezas)
                .HasForeignKey(d => d.IdGrandezablocoestudo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grandezablocoestudo_estagiograndeza");
        }
    }
}
