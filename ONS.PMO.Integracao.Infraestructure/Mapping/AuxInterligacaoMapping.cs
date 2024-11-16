using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class AuxInterligacaoMapping : IEntityTypeConfiguration<AuxInterligacao>
    {
        public void Configure(EntityTypeBuilder<AuxInterligacao> entity)
        {
            entity.HasKey(e => e.IdInterligacao).HasName("pk_tb_aux_interligacao");

            entity.ToTable("tb_aux_interligacao");

            entity.Property(e => e.IdInterligacao).HasColumnName("id_interligacao");
            entity.Property(e => e.IdIntercambiopdes).HasColumnName("id_intercambiopdes");
            entity.Property(e => e.NomIntercambiopdes)
                .HasMaxLength(150)
                .HasColumnName("nom_intercambiopdes");
        }
    }
}
