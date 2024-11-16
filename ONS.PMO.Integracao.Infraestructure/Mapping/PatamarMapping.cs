using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class PatamarMapping : IEntityTypeConfiguration<Patamar>
    {
        public void Configure(EntityTypeBuilder<Patamar> entity)
        {
            entity.HasKey(e => e.IdTppatamar).HasName("pk_tb_tppatamar");

            entity.ToTable("tb_tppatamar");

            entity.Property(e => e.IdTppatamar)
                .ValueGeneratedNever()
                .HasColumnName("id_tppatamar");
            entity.Property(e => e.DscTppatamar)
                .HasMaxLength(20)
                .HasColumnName("dsc_tppatamar");
            entity.Property(e => e.ValAzul).HasColumnName("val_azul");
            entity.Property(e => e.ValVerde).HasColumnName("val_verde");
            entity.Property(e => e.ValVermelho).HasColumnName("val_vermelho");
        }
    }
}
