using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.BDT;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class DadoResultPMOMapping : IEntityTypeConfiguration<DadoResultPMO>
    {
        public void Configure(EntityTypeBuilder<DadoResultPMO> entity)
        {
            entity.HasKey(e => e.IdDadoresultpmo).HasName("pk_tb_dadoresultpmo");

            entity.ToTable("tb_dadoresultpmo");

            entity.HasIndex(e => e.IdListaresultadopmo, "in_fk_listaresultadopmo_dadoresultpmo");

            entity.HasIndex(e => e.IdMnemonicopmo, "in_fk_mnemonicopmo_dadoresultpmo");

            entity.Property(e => e.IdDadoresultpmo).HasColumnName("id_dadoresultpmo");
            entity.Property(e => e.DscValorcoletadomnemonico)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("dsc_valorcoletadomnemonico");
            entity.Property(e => e.FlgValoroficial).HasColumnName("flg_valoroficial");
            entity.Property(e => e.IdListaresultadopmo).HasColumnName("id_listaresultadopmo");
            entity.Property(e => e.IdMnemonicopmo).HasColumnName("id_mnemonicopmo");
            entity.Property(e => e.IdTppatamar).HasColumnName("id_tppatamar");
            entity.Property(e => e.NumEstagio).HasColumnName("num_estagio");

            entity.HasOne(d => d.IdListaresultadopmoNavigation).WithMany(p => p.TbDadoresultpmos)
                .HasForeignKey(d => d.IdListaresultadopmo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_listaresultadopmo_dadoresultpmo");

            entity.HasOne(d => d.IdMnemonicopmoNavigation).WithMany(p => p.TbDadoresultpmos)
                .HasForeignKey(d => d.IdMnemonicopmo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_mnemonicopmo_dadoresultpmo");
        }
    }
}
