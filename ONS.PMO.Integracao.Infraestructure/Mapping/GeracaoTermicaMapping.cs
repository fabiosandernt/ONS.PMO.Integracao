using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class GeracaoTermicaMapping : IEntityTypeConfiguration<GeracaoTermica>
    {
        public void Configure(EntityTypeBuilder<GeracaoTermica> entity)
        {
            entity.HasKey(e => e.IdGeracaotermicas).HasName("pk_tb_geracaotermicas");

            entity.ToTable("tb_geracaotermicas");

            entity.HasIndex(e => e.IdConfiguracaogestaomanutencao, "in_fk_configuracaogestaomanutencao_geracaotermicas");

            entity.Property(e => e.IdGeracaotermicas).HasColumnName("id_geracaotermicas");
            entity.Property(e => e.IdConfiguracaogestaomanutencao).HasColumnName("id_configuracaogestaomanutencao");
            entity.Property(e => e.NomCurtosubmercado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nom_curtosubmercado");
            entity.Property(e => e.NomCurtosubsistema)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nom_curtosubsistema");
            entity.Property(e => e.NumEstagio).HasColumnName("num_estagio");
            entity.Property(e => e.ValGeracaotermicas).HasColumnName("val_geracaotermicas");

            entity.HasOne(d => d.IdConfiguracaogestaomanutencaoNavigation).WithMany(p => p.TbGeracaotermicas)
                .HasForeignKey(d => d.IdConfiguracaogestaomanutencao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_configuracaogestaomanutencao_geracaotermicas");
        }
    }
}