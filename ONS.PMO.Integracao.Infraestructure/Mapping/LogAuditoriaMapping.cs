using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class LogAuditoriaMapping : IEntityTypeConfiguration<LogAuditoria>
    {
        public void Configure(EntityTypeBuilder<LogAuditoria> entity)
        {
            entity.HasKey(e => e.IdLogauditoria).HasName("pk_tb_logauditoria");

            entity.ToTable("tb_logauditoria");

            entity.Property(e => e.IdLogauditoria).HasColumnName("id_logauditoria");
            entity.Property(e => e.DinExecucao)
                .HasColumnType("datetime")
                .HasColumnName("din_execucao");
            entity.Property(e => e.DocOperacaologada)
                .HasColumnType("xml")
                .HasColumnName("doc_operacaologada");
            entity.Property(e => e.DscTipoacaoexecutada)
                .HasMaxLength(100)
                .HasColumnName("dsc_tipoacaoexecutada");
            entity.Property(e => e.NomExecutor)
                .HasMaxLength(100)
                .HasColumnName("nom_executor");
            entity.Property(e => e.NomFuncionalidade)
                .HasMaxLength(50)
                .HasColumnName("nom_funcionalidade");
            entity.Property(e => e.NomRegistro)
                .HasMaxLength(200)
                .HasColumnName("nom_registro");
        }
    }
}