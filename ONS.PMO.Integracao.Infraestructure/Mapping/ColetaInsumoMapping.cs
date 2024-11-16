using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ColetaInsumoMapping : IEntityTypeConfiguration<ColetaInsumo>
    {
        public void Configure(EntityTypeBuilder<ColetaInsumo> entity)
        {
            entity.HasKey(e => e.IdColetainsumo).HasName("pk_tb_coletainsumo");

            entity.ToTable("tb_coletainsumo");

            entity.HasIndex(e => e.IdAgenteinstituicao, "in_fk_agenteinstituicao_coletainsumo");

            entity.HasIndex(e => e.IdInsumopmo, "in_fk_insumopmo_coletainsumo");

            entity.HasIndex(e => e.IdSemanaoperativa, "in_fk_semanaoperativa_coletainsumo");

            entity.HasIndex(e => e.IdTpsituacaocoletainsumo, "in_fk_tpsituacaocoletainsumo_coletainsumo");

            entity.Property(e => e.IdColetainsumo).HasColumnName("id_coletainsumo");
            entity.Property(e => e.CodPerfilons)
                .HasMaxLength(30)
                .HasColumnName("cod_perfilons");
            entity.Property(e => e.DinUltimaalteracao)
                .HasColumnType("datetime")
                .HasColumnName("din_ultimaalteracao");
            entity.Property(e => e.DscMotivoalteracaoons)
                .HasMaxLength(1000)
                .HasColumnName("dsc_motivoalteracaoons");
            entity.Property(e => e.DscMotivorejeicaoons)
                .HasMaxLength(1000)
                .HasColumnName("dsc_motivorejeicaoons");
            entity.Property(e => e.IdAgenteinstituicao).HasColumnName("id_agenteinstituicao");
            entity.Property(e => e.IdInsumopmo).HasColumnName("id_insumopmo");
            entity.Property(e => e.IdSemanaoperativa).HasColumnName("id_semanaoperativa");
            entity.Property(e => e.IdTpsituacaocoletainsumo).HasColumnName("id_tpsituacaocoletainsumo");
            entity.Property(e => e.LgnAgenteultimaalteracao)
                .HasMaxLength(150)
                .HasColumnName("lgn_agenteultimaalteracao");
            entity.Property(e => e.NomGrandezasnaoestagioalteradas)
                .HasMaxLength(1000)
                .HasColumnName("nom_grandezasnaoestagioalteradas");
            entity.Property(e => e.VerControleconcorrencia)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ver_controleconcorrencia");

            entity.HasOne(d => d.IdAgenteinstituicaoNavigation).WithMany(p => p.TbColetainsumos)
                .HasForeignKey(d => d.IdAgenteinstituicao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_agenteinstituicao_coletainsumo");

            entity.HasOne(d => d.IdInsumopmoNavigation).WithMany(p => p.TbColetainsumos)
                .HasForeignKey(d => d.IdInsumopmo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_insumopmo_coletainsumo");

            entity.HasOne(d => d.IdSemanaoperativaNavigation).WithMany(p => p.TbColetainsumos)
                .HasForeignKey(d => d.IdSemanaoperativa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_semanaoperativa_coletainsumo");

            entity.HasOne(d => d.IdTpsituacaocoletainsumoNavigation).WithMany(p => p.TbColetainsumos)
                .HasForeignKey(d => d.IdTpsituacaocoletainsumo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tpsituacaocoletainsumo_coletainsumo");
        }
    }
}
