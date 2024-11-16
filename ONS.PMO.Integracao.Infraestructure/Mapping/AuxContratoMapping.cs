using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class AuxContratoMapping : IEntityTypeConfiguration<AuxContrato>
    {
        public void Configure(EntityTypeBuilder<AuxContrato> entity)
        {
            entity.HasKey(e => e.IdContrato).HasName("pk_tb_aux_contrato");
            entity.ToTable("tb_aux_contrato");

            entity.Property(e => e.IdContrato).HasColumnName("id_contrato");
            entity.Property(e => e.CodContrato).HasColumnName("cod_contrato");
            entity.Property(e => e.DinIniciovalidade)
                .HasColumnType("datetime")
                .HasColumnName("din_iniciovalidade");
            entity.Property(e => e.DinTerminovalidade)
                .HasColumnType("datetime")
                .HasColumnName("din_terminovalidade");
            entity.Property(e => e.DinUltimaalteracao)
                .HasColumnType("datetime")
                .HasColumnName("din_ultimaalteracao");
            entity.Property(e => e.DscContrato).HasColumnName("dsc_contrato");
            entity.Property(e => e.FlgAtivo).HasColumnName("flg_ativo");
            entity.Property(e => e.LgnUltimaalteracao)
                .HasMaxLength(50)
                .HasColumnName("lgn_ultimaalteracao");
            entity.Property(e => e.NomContrato)
                .HasMaxLength(10)
                .HasColumnName("nom_contrato");
            entity.Property(e => e.VerControleconcorrencia)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ver_controleconcorrencia");
        }
    }
}