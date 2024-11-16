using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class GeracaoPequenasUsinaMapping : IEntityTypeConfiguration<GeracaoPequenasUsina>
    {
        public void Configure(EntityTypeBuilder<GeracaoPequenasUsina> entity)
        {
            entity.HasKey(e => e.IdGeracaopequenasusinas).HasName("pk_tb_geracaopequenasusinas");

            entity.ToTable("tb_geracaopequenasusinas");

            entity.HasIndex(e => e.IdConfiguracaogestaomanutencao, "in_fk_configuracaogestaomanutencao_geracaopequenasusinas");

            entity.Property(e => e.IdGeracaopequenasusinas).HasColumnName("id_geracaopequenasusinas");
            entity.Property(e => e.IdConfiguracaogestaomanutencao).HasColumnName("id_configuracaogestaomanutencao");
            entity.Property(e => e.NomCurtosubsistema)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nom_curtosubsistema");
            entity.Property(e => e.ValGeracaopequenasusinas).HasColumnName("val_geracaopequenasusinas");

            entity.HasOne(d => d.IdConfiguracaogestaomanutencaoNavigation).WithMany(p => p.TbGeracaopequenasusinas)
                .HasForeignKey(d => d.IdConfiguracaogestaomanutencao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_configuracaogestaomanutencao_geracaopequenasusinas");
        }
    }
}