using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class AuxIntervaloCustoDeficitMapping : IEntityTypeConfiguration<AuxIntervaloCustoDeficit>
    {
        public void Configure(EntityTypeBuilder<AuxIntervaloCustoDeficit> entity)
        {
            entity.HasKey(e => e.IdIntervalocustodeficit).HasName("pk_tb_aux_intervalocustodeficit");

            entity.ToTable("tb_aux_intervalocustodeficit");

            entity.Property(e => e.IdIntervalocustodeficit).HasColumnName("id_intervalocustodeficit");
            entity.Property(e => e.CodIntervalocustodeficit).HasColumnName("cod_intervalocustodeficit");
            entity.Property(e => e.DinIniciovalidade)
                .HasColumnType("datetime")
                .HasColumnName("din_iniciovalidade");
            entity.Property(e => e.DinTerminovalidade)
                .HasColumnType("datetime")
                .HasColumnName("din_terminovalidade");
            entity.Property(e => e.DinUltimaalteracao)
                .HasColumnType("datetime")
                .HasColumnName("din_ultimaalteracao");
            entity.Property(e => e.DscIntervalocustodeficit).HasColumnName("dsc_intervalocustodeficit");
            entity.Property(e => e.FlgAtivo).HasColumnName("flg_ativo");
            entity.Property(e => e.LgnUltimaalteracao)
                .HasMaxLength(50)
                .HasColumnName("lgn_ultimaalteracao");
            entity.Property(e => e.NomIntervalocustodeficit)
                .HasMaxLength(10)
                .HasColumnName("nom_intervalocustodeficit");
            entity.Property(e => e.VerControleconcorrencia)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ver_controleconcorrencia");
        }
    }
}