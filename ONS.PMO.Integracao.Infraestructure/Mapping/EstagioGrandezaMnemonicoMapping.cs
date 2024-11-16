using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class EstagioGrandezaMnemonicoMapping : IEntityTypeConfiguration<EstagioGrandezaMnemonico>
    {
        public void Configure(EntityTypeBuilder<EstagioGrandezaMnemonico> entity)
        {
            entity.HasKey(e => e.IdEstagiograndezamnemonico).HasName("pk_tb_estagiograndezamnemonico");

            entity.ToTable("tb_estagiograndezamnemonico");

            entity.HasIndex(e => e.IdGrandezamnemonicoestudo, "in_fk_grandezamnemonicoestudo_estagiograndezamnemonico");

            entity.Property(e => e.IdEstagiograndezamnemonico).HasColumnName("id_estagiograndezamnemonico");
            entity.Property(e => e.DatFimsemana).HasColumnName("dat_fimsemana");
            entity.Property(e => e.DatIniciosemana).HasColumnName("dat_iniciosemana");
            entity.Property(e => e.IdGrandezamnemonicoestudo).HasColumnName("id_grandezamnemonicoestudo");
            entity.Property(e => e.NumIndice).HasColumnName("num_indice");

            entity.HasOne(d => d.IdGrandezamnemonicoestudoNavigation).WithMany(p => p.TbEstagiograndezamnemonicos)
                .HasForeignKey(d => d.IdGrandezamnemonicoestudo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grandezamnemonicoestudo_estagiograndezamnemonico");
        }
    }
}