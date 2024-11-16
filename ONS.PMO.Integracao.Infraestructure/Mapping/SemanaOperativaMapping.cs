using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class SemanaOperativaMapping : IEntityTypeConfiguration<SemanaOperativa>
    {
        public void Configure(EntityTypeBuilder<SemanaOperativa> entity)
        {
            entity.HasKey(e => e.IdSemanaoperativa).HasName("pk_tb_semanaoperativa");

            entity.ToTable("tb_semanaoperativa");

            entity.HasIndex(e => e.IdPmo, "in_fk_pmo_semanaoperativa");

            entity.HasIndex(e => e.IdTpsituacaosemanaoper, "in_fk_tpsituacaosemanaoper_semanaoperativa");

            entity.Property(e => e.IdSemanaoperativa).HasColumnName("id_semanaoperativa");
            entity.Property(e => e.DatFimmanutencao)
                .HasColumnType("smalldatetime")
                .HasColumnName("dat_fimmanutencao");
            entity.Property(e => e.DatFimsemana)
                .HasColumnType("smalldatetime")
                .HasColumnName("dat_fimsemana");
            entity.Property(e => e.DatIniciomanutencao)
                .HasColumnType("smalldatetime")
                .HasColumnName("dat_iniciomanutencao");
            entity.Property(e => e.DatIniciosemana)
                .HasColumnType("smalldatetime")
                .HasColumnName("dat_iniciosemana");
            entity.Property(e => e.DatReuniao)
                .HasColumnType("smalldatetime")
                .HasColumnName("dat_reuniao");
            entity.Property(e => e.DinUltimaalteracao)
                .HasColumnType("datetime")
                .HasColumnName("din_ultimaalteracao");
            entity.Property(e => e.IdPmo).HasColumnName("id_pmo");
            entity.Property(e => e.IdTpsituacaosemanaoper).HasColumnName("id_tpsituacaosemanaoper");
            entity.Property(e => e.NomSemanaoperativa)
                .HasMaxLength(150)
                .HasColumnName("nom_semanaoperativa");
            entity.Property(e => e.NumRevisao).HasColumnName("num_revisao");
            entity.Property(e => e.VerControleconcorrencia)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ver_controleconcorrencia");

            entity.HasOne(d => d.IdPmoNavigation).WithMany(p => p.TbSemanaoperativas)
                .HasForeignKey(d => d.IdPmo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pmo_semanaoperativa");

            entity.HasOne(d => d.IdTpsituacaosemanaoperNavigation).WithMany(p => p.TbSemanaoperativas)
                .HasForeignKey(d => d.IdTpsituacaosemanaoper)
                .HasConstraintName("fk_tpsituacaosemanaoper_semanaoperativa");
        }
    }
}
