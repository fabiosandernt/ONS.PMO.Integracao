using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class OrigemColetaMontadorMapping : IEntityTypeConfiguration<OrigemColetaMontador>
    {
        public void Configure(EntityTypeBuilder<OrigemColetaMontador> entity)
        {
            entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_origemcoletamontador");

            entity.ToTable("tb_origemcoletamontador");

            entity.HasIndex(e => e.IdTpcoleta, "in_fk_tpcoleta_origemcoletamontador");

            entity.Property(e => e.IdOrigemcoletamontador).HasColumnName("id_origemcoletamontador");
            entity.Property(e => e.CodOrigemcoletamontador)
                .HasMaxLength(50)
                .HasColumnName("cod_origemcoletamontador");
            entity.Property(e => e.DinIniciovalidade)
                .HasColumnType("datetime")
                .HasColumnName("din_iniciovalidade");
            entity.Property(e => e.DinTerminovalidade)
                .HasColumnType("datetime")
                .HasColumnName("din_terminovalidade");
            entity.Property(e => e.DinUltimaalteracao)
                .HasColumnType("datetime")
                .HasColumnName("din_ultimaalteracao");
            entity.Property(e => e.FlgAtivo).HasColumnName("flg_ativo");
            entity.Property(e => e.IdTpcoleta).HasColumnName("id_tpcoleta");
            entity.Property(e => e.LgnUltimaalteracao)
                .HasMaxLength(50)
                .HasColumnName("lgn_ultimaalteracao");
            entity.Property(e => e.NomExibicao)
                .HasMaxLength(255)
                .HasColumnName("nom_exibicao");
            entity.Property(e => e.VerControleconcorrencia)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ver_controleconcorrencia");

            entity.HasOne(d => d.IdTpcoletaNavigation).WithMany(p => p.TbOrigemcoletamontadors)
                .HasForeignKey(d => d.IdTpcoleta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tpcoleta_origemcoletamontador");
        }
    }
}
