using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ManutencaoProgramadaEstudoMapping : IEntityTypeConfiguration<ManutencaoProgramadaEstudo>
    {
        public void Configure(EntityTypeBuilder<ManutencaoProgramadaEstudo> entity)
        {
            entity.HasKey(e => e.IdEstudomontador).HasName("pk_tb_manutencaoprogramadaestudo");

            entity.ToTable("tb_manutencaoprogramadaestudo");

            entity.HasIndex(e => e.IdEstudomontador, "in_fk_estudomontador_manutencaoprogramadaestudo");

            entity.Property(e => e.IdEstudomontador)
                .ValueGeneratedNever()
                .HasColumnName("id_estudomontador");
            entity.Property(e => e.LgnUsuariocheckout)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lgn_usuariocheckout");
            entity.Property(e => e.VerControleconcorrencia)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ver_controleconcorrencia");

            entity.HasOne(d => d.IdEstudomontadorNavigation).WithOne(p => p.TbManutencaoprogramadaestudo)
                .HasForeignKey<ManutencaoProgramadaEstudo>(d => d.IdEstudomontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_estudomontador_manutencaoprogramadaestudo");
        }
    }
}