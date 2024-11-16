using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class DadoColetaManutencaoMapping : IEntityTypeConfiguration<DadoColetaManutencao>
    {
        public void Configure(EntityTypeBuilder<DadoColetaManutencao> entity)
        {
            entity.HasKey(e => e.IdDadocoleta).HasName("pk_tb_dadocoletamanutencao");

            entity.ToTable("tb_dadocoletamanutencao");

            entity.HasIndex(e => e.IdOrigemcoletauge, "in_fk_aux_unidadegeradora_dadocoletamanutencao");

            entity.HasIndex(e => e.IdDadocoleta, "in_fk_dadocoleta_dadocoletamanutencao");

            entity.Property(e => e.IdDadocoleta)
                .ValueGeneratedNever()
                .HasColumnName("id_dadocoleta");
            entity.Property(e => e.DatFim)
                .HasColumnType("smalldatetime")
                .HasColumnName("dat_fim");
            entity.Property(e => e.DatInicio)
                .HasColumnType("smalldatetime")
                .HasColumnName("dat_inicio");
            entity.Property(e => e.DscJustificativa)
                .HasMaxLength(4000)
                .HasColumnName("dsc_justificativa");
            entity.Property(e => e.IdOrigemcoletauge)
                .HasMaxLength(50)
                .HasColumnName("id_origemcoletauge");
            entity.Property(e => e.NomSituacao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_situacao");
            entity.Property(e => e.NumManutencao)
                .HasMaxLength(20)
                .HasColumnName("num_manutencao");
            entity.Property(e => e.PrdTemporetorno)
                .HasMaxLength(5)
                .HasColumnName("prd_temporetorno");
            entity.Property(e => e.SglClassificacaotpeqpintervencao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sgl_classificacaotpeqpintervencao");
            entity.Property(e => e.SglPeriodicidadeintervencao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sgl_periodicidadeintervencao");

            entity.HasOne(d => d.IdDadocoletaNavigation).WithOne(p => p.TbDadocoletamanutencao)
                .HasForeignKey<DadoColetaManutencao>(d => d.IdDadocoleta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dadocoleta_dadocoletamanutencao");

            entity.HasOne(d => d.IdOrigemcoletaugeNavigation).WithMany(p => p.TbDadocoletamanutencaos)
                .HasForeignKey(d => d.IdOrigemcoletauge)
                .HasConstraintName("fk_aux_unidadegeradora_dadocoletamanutencao");
        }
    }
}