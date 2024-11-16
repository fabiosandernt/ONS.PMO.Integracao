using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class GabaritoMapping : IEntityTypeConfiguration<Gabarito>
    {
        public void Configure(EntityTypeBuilder<Gabarito> entity)
        {
            entity.HasKey(e => e.IdGabarito).HasName("pk_tb_gabarito");

            entity.ToTable("tb_gabarito");

            entity.HasIndex(e => e.IdAgenteinstituicao, "in_fk_agenteinstituicao_gabarito");

            entity.HasIndex(e => e.IdInsumopmo, "in_fk_insumopmo_gabarito");

            entity.HasIndex(e => e.IdOrigemcoleta, "in_fk_origemcoleta_gabarito");

            entity.HasIndex(e => e.IdSemanaoperativa, "in_fk_semanaoperativa_gabarito");

            entity.Property(e => e.IdGabarito).HasColumnName("id_gabarito");
            entity.Property(e => e.CodPerfilons)
                .HasMaxLength(30)
                .HasColumnName("cod_perfilons");
            entity.Property(e => e.FlgPadrao).HasColumnName("flg_padrao");
            entity.Property(e => e.IdAgenteinstituicao).HasColumnName("id_agenteinstituicao");
            entity.Property(e => e.IdInsumopmo).HasColumnName("id_insumopmo");
            entity.Property(e => e.IdOrigemcoleta)
                .HasMaxLength(50)
                .HasColumnName("id_origemcoleta");
            entity.Property(e => e.IdSemanaoperativa).HasColumnName("id_semanaoperativa");
            entity.Property(e => e.VerControleconcorrencia)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ver_controleconcorrencia");

            entity.HasOne(d => d.IdAgenteinstituicaoNavigation).WithMany(p => p.TbGabaritos)
                .HasForeignKey(d => d.IdAgenteinstituicao)
                .HasConstraintName("fk_agenteinstituicao_gabarito");

            entity.HasOne(d => d.IdInsumopmoNavigation).WithMany(p => p.TbGabaritos)
                .HasForeignKey(d => d.IdInsumopmo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_insumopmo_gabarito");

            entity.HasOne(d => d.IdOrigemcoletaNavigation).WithMany(p => p.TbGabaritos)
                .HasForeignKey(d => d.IdOrigemcoleta)
                .HasConstraintName("fk_origemcoleta_gabarito");

            entity.HasOne(d => d.IdSemanaoperativaNavigation).WithMany(p => p.TbGabaritos)
                .HasForeignKey(d => d.IdSemanaoperativa)
                .HasConstraintName("fk_semanaoperativa_gabarito");
        }
    }
}
