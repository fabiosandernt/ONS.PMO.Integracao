using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.BDT;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ListaResultadoPMOMapping : IEntityTypeConfiguration<ListaResultadoPMO>
    {
        public void Configure(EntityTypeBuilder<ListaResultadoPMO> entity)
        {
            entity.HasKey(e => e.IdListaresultadopmo).HasName("pk_tb_listaresultadopmo");

            entity.ToTable("tb_listaresultadopmo");

            entity.HasIndex(e => e.IdImportacaopmo, "in_fk_importacaopmo_listaresultadopmo");

            entity.HasIndex(e => e.IdOrigemresultadopmo, "in_fk_origemresultadopmo_listaresultadopmo");

            entity.HasIndex(e => e.IdResultadocoletapmo, "in_fk_resultadocoletapmo_listaresultadopmo");

            entity.Property(e => e.IdListaresultadopmo).HasColumnName("id_listaresultadopmo");
            entity.Property(e => e.IdImportacaopmo).HasColumnName("id_importacaopmo");
            entity.Property(e => e.IdOrigemresultadopmo).HasColumnName("id_origemresultadopmo");
            entity.Property(e => e.IdResultadocoletapmo).HasColumnName("id_resultadocoletapmo");

            entity.HasOne(d => d.IdImportacaopmoNavigation).WithMany(p => p.TbListaresultadopmos)
                .HasForeignKey(d => d.IdImportacaopmo)
                .HasConstraintName("fk_importacaopmo_listaresultadopmo");

            entity.HasOne(d => d.IdOrigemresultadopmoNavigation).WithMany(p => p.TbListaresultadopmos)
                .HasForeignKey(d => d.IdOrigemresultadopmo)
                .HasConstraintName("fk_origemresultadopmo_listaresultadopmo");

            entity.HasOne(d => d.IdResultadocoletapmoNavigation).WithMany(p => p.TbListaresultadopmos)
                .HasForeignKey(d => d.IdResultadocoletapmo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_resultadocoletapmo_listaresultadopmo");
        }
    }
}