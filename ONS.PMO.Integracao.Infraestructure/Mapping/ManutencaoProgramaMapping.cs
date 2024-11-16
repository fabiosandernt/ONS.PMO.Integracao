using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ManutencaoProgramaMapping : IEntityTypeConfiguration<ManutencaoPrograma>
    {
        public void Configure(EntityTypeBuilder<ManutencaoPrograma> entity)
        {
            entity.HasKey(e => e.IdManutencaoprogramada).HasName("pk_tb_manutencaoprogramada");

            entity.ToTable("tb_manutencaoprogramada");

            entity.HasIndex(e => e.IdAgenteinstituicao, "in_fk_agenteinstituicao_manutencaoprogramada");

            entity.HasIndex(e => e.IdOrigemuge, "in_fk_aux_unidadegeradoramontador_manutencaoprogramada");

            entity.HasIndex(e => e.IdOrigemusi, "in_fk_aux_usinamontador_manutencaoprogramada");

            entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_manutencaoprogramada");

            entity.HasIndex(e => e.IdTpmanutencaoprogramada, "in_fk_tpmanutencaoprogramada_manutencaoprogramada");

            entity.Property(e => e.IdManutencaoprogramada).HasColumnName("id_manutencaoprogramada");
            entity.Property(e => e.DinInicio)
                .HasColumnType("datetime")
                .HasColumnName("din_inicio");
            entity.Property(e => e.DinTermino)
                .HasColumnType("datetime")
                .HasColumnName("din_termino");
            entity.Property(e => e.DinUltimaalteracao)
                .HasColumnType("datetime")
                .HasColumnName("din_ultimaalteracao");
            entity.Property(e => e.DscJustificativa)
                .HasMaxLength(1000)
                .HasColumnName("dsc_justificativa");
            entity.Property(e => e.IdAgenteinstituicao).HasColumnName("id_agenteinstituicao");
            entity.Property(e => e.IdEstudomontador).HasColumnName("id_estudomontador");
            entity.Property(e => e.IdOrigemuge).HasColumnName("id_origemuge");
            entity.Property(e => e.IdOrigemusi).HasColumnName("id_origemusi");
            entity.Property(e => e.IdTpmanutencaoprogramada).HasColumnName("id_tpmanutencaoprogramada");
            entity.Property(e => e.LgnUltimaalteracao)
                .HasMaxLength(50)
                .HasColumnName("lgn_ultimaalteracao");
            entity.Property(e => e.VerControleconcorrencia)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ver_controleconcorrencia");

            entity.HasOne(d => d.IdAgenteinstituicaoNavigation).WithMany(p => p.TbManutencaoprogramada)
                .HasForeignKey(d => d.IdAgenteinstituicao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_agenteinstituicao_manutencaoprogramada");

            entity.HasOne(d => d.IdEstudomontadorNavigation).WithMany(p => p.TbManutencaoprogramada)
                .HasForeignKey(d => d.IdEstudomontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_estudomontador_manutencaoprogramada");

            entity.HasOne(d => d.IdOrigemugeNavigation).WithMany(p => p.TbManutencaoprogramada)
                .HasForeignKey(d => d.IdOrigemuge)
                .HasConstraintName("fk_aux_unidadegeradoramontador_manutencaoprogramada");

            entity.HasOne(d => d.IdOrigemusiNavigation).WithMany(p => p.TbManutencaoprogramada)
                .HasForeignKey(d => d.IdOrigemusi)
                .HasConstraintName("fk_aux_usinamontador_manutencaoprogramada");

            entity.HasOne(d => d.IdTpmanutencaoprogramadaNavigation).WithMany(p => p.TbManutencaoprogramada)
                .HasForeignKey(d => d.IdTpmanutencaoprogramada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tpmanutencaoprogramada_manutencaoprogramada");
        }
    }
}