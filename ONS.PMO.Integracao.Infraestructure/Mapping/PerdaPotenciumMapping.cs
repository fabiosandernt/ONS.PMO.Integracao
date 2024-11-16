using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class PerdaPotenciumMapping : IEntityTypeConfiguration<PerdaPotencium>
    {
        public void Configure(EntityTypeBuilder<PerdaPotencium> entity)
        {
            entity.HasKey(e => e.IdPerdapotencia).HasName("pk_tb_perdapotencia");

            entity.ToTable("tb_perdapotencia");

            entity.HasIndex(e => e.IdConfiguracaogestaomanutencao, "in_fk_configuracaogestaomanutencao_perdadepotencia");

            entity.Property(e => e.IdPerdapotencia).HasColumnName("id_perdapotencia");
            entity.Property(e => e.IdConfiguracaogestaomanutencao).HasColumnName("id_configuracaogestaomanutencao");
            entity.Property(e => e.NomCurtosubsistema)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nom_curtosubsistema");
            entity.Property(e => e.ValPerdapotencia).HasColumnName("val_perdapotencia");

            entity.HasOne(d => d.IdConfiguracaogestaomanutencaoNavigation).WithMany(p => p.TbPerdapotencia)
                .HasForeignKey(d => d.IdConfiguracaogestaomanutencao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_configuracaogestaomanutencao_perdadepotencia");
        }
    }
}
