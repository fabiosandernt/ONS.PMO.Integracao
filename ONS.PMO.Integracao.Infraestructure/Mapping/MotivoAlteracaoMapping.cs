using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class MotivoAlteracaoMapping : IEntityTypeConfiguration<MotivoAlteracao>
    {
        public void Configure(EntityTypeBuilder<MotivoAlteracao> entity)
        {
            entity.HasKey(e => e.IdMotivoalteracao).HasName("pk_tb_motivoalteracao");

            entity.ToTable("tb_motivoalteracao");

            entity.Property(e => e.IdMotivoalteracao).HasColumnName("id_motivoalteracao");
            entity.Property(e => e.DinUltimaalteracao)
                .HasColumnType("datetime")
                .HasColumnName("din_ultimaalteracao");
            entity.Property(e => e.DscMotivo)
                .HasMaxLength(150)
                .HasColumnName("dsc_motivo");
            entity.Property(e => e.FlgAtivo).HasColumnName("flg_ativo");
            entity.Property(e => e.LgnUltimaalteracao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lgn_ultimaalteracao");
            entity.Property(e => e.NomMotivo)
                .HasMaxLength(150)
                .HasColumnName("nom_motivo");
            entity.Property(e => e.VerControleconcorrencia)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ver_controleconcorrencia");
        }
    }
}
