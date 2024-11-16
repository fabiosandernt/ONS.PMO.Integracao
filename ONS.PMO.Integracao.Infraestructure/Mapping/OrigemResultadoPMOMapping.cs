using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.BDT;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class OrigemResultadoPMOMapping : IEntityTypeConfiguration<OrigemResultadoPMO>
    {
        public void Configure(EntityTypeBuilder<OrigemResultadoPMO> entity)
        {
            entity.HasKey(e => e.IdOrigemresultadopmo).HasName("pk_tb_origemresultadopmo");

            entity.ToTable("tb_origemresultadopmo");

            entity.Property(e => e.IdOrigemresultadopmo).HasColumnName("id_origemresultadopmo");
            entity.Property(e => e.CodOrigemresultadopmo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cod_origemresultadopmo");
            entity.Property(e => e.CodOrigemresultadopmopai)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cod_origemresultadopmopai");
            entity.Property(e => e.NomOrigemresultadopmo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nom_origemresultadopmo");
            entity.Property(e => e.TipOrigemresultadopmo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("tip_origemresultadopmo");
        }
    }
}