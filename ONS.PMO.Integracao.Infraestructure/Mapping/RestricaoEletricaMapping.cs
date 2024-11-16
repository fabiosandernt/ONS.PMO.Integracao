using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class RestricaoEletricaMapping : IEntityTypeConfiguration<RestricaoEletrica>
    {
        public void Configure(EntityTypeBuilder<RestricaoEletrica> entity)
        {
            entity.HasKey(e => e.IdRestricao).HasName("pk_tb_restricaoeletrica");

            entity.ToTable("tb_restricaoeletrica");

            entity.HasIndex(e => e.IdRestricao, "in_fk_restricao_restricaoeletrica");

            entity.Property(e => e.IdRestricao)
                .ValueGeneratedNever()
                .HasColumnName("id_restricao");
            entity.Property(e => e.CodEstruturacaores)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cod_estruturacaores");

            entity.HasOne(d => d.IdRestricaoNavigation).WithOne(p => p.TbRestricaoeletrica)
                .HasForeignKey<RestricaoEletrica>(d => d.IdRestricao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_restricao_restricaoeletrica");
        }
    }
}