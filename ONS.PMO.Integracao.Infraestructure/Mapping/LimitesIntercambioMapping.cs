using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class LimitesIntercambioMapping : IEntityTypeConfiguration<LimitesIntercambio>
    {
        public void Configure(EntityTypeBuilder<LimitesIntercambio> entity)
        {
            entity.HasKey(e => e.IdLimitesintercambio).HasName("pk_tb_limitesintercambio");

            entity.ToTable("tb_limitesintercambio");

            entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_limitesintercambio");

            entity.Property(e => e.IdLimitesintercambio).HasColumnName("id_limitesintercambio");
            entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
            entity.Property(e => e.IdInterligacao).HasColumnName("id_interligacao");
            entity.Property(e => e.NomDocumentoorigem)
                .HasMaxLength(50)
                .HasColumnName("nom_documentoorigem");
            entity.Property(e => e.NomInterligacao)
                .HasMaxLength(50)
                .HasColumnName("nom_interligacao");
            entity.Property(e => e.NumOrdem).HasColumnName("num_ordem");
            entity.Property(e => e.VerControleconcorrencia)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ver_controleconcorrencia");

            entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbLimitesintercambios)
                .HasForeignKey(d => d.IdEstudomontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_estudomontador_limitesintercambio");
        }
    }
}