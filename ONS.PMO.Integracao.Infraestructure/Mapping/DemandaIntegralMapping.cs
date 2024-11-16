using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class DemandaIntegralMapping : IEntityTypeConfiguration<DemandaIntegral>
    {
        public void Configure(EntityTypeBuilder<DemandaIntegral> entity)
        {
            entity.HasKey(e => e.IdDemandaintegral).HasName("pk_tb_demandaintegral");

            entity.ToTable("tb_demandaintegral");

            entity.HasIndex(e => e.IdConfiguracaogestaomanutencao, "in_fk_configuracaogestaomanutencao_demandaintegral");

            entity.Property(e => e.IdDemandaintegral).HasColumnName("id_demandaintegral");
            entity.Property(e => e.IdConfiguracaogestaomanutencao).HasColumnName("id_configuracaogestaomanutencao");
            entity.Property(e => e.NomCurtosubsistema)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nom_curtosubsistema");
            entity.Property(e => e.NumEstagio).HasColumnName("num_estagio");
            entity.Property(e => e.ValDemandaintegral).HasColumnName("val_demandaintegral");

            entity.HasOne(d => d.IdConfiguracaogestaomanutencaoNavigation).WithMany(p => p.TbDemandaintegrals)
                .HasForeignKey(d => d.IdConfiguracaogestaomanutencao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_configuracaogestaomanutencao_demandaintegral");
        }
    }
}
