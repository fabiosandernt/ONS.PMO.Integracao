using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.BDT;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class InsumoPMOMapping : IEntityTypeConfiguration<InsumoPMO>
    {
        public void Configure(EntityTypeBuilder<InsumoPMO> entity)
        {
            entity.HasKey(e => e.IdInsumopmo).HasName("pk_tb_insumopmo");

            entity.ToTable("tb_insumopmo");

            entity.Property(e => e.IdInsumopmo).HasColumnName("id_insumopmo");
            entity.Property(e => e.DinUltimaalteracao)
                .HasColumnType("datetime")
                .HasColumnName("din_ultimaalteracao");
            entity.Property(e => e.FlgAtivo)
                .HasDefaultValue(true)
                .HasColumnName("flg_ativo");
            entity.Property(e => e.FlgExportainsumo).HasColumnName("flg_exportainsumo");
            entity.Property(e => e.FlgPreaprovado).HasColumnName("flg_preaprovado");
            entity.Property(e => e.FlgReservado).HasColumnName("flg_reservado");
            entity.Property(e => e.NomInsumopmo)
                .HasMaxLength(150)
                .HasColumnName("nom_insumopmo");
            entity.Property(e => e.NumOrdemexibicao).HasColumnName("num_ordemexibicao");
            entity.Property(e => e.SglInsumo)
                .HasMaxLength(10)
                .HasDefaultValue("-")
                .HasColumnName("sgl_insumo");
            entity.Property(e => e.TipInsumopmo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tip_insumopmo");
            entity.Property(e => e.VerControleconcorrencia)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ver_controleconcorrencia");
        }
    }
}