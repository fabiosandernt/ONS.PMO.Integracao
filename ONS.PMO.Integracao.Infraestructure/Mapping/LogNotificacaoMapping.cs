using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class LogNotificacaoMapping : IEntityTypeConfiguration<LogNotificacao>
    {
        public void Configure(EntityTypeBuilder<LogNotificacao> entity)
        {
            entity.HasKey(e => e.IdLognotificacao).HasName("pk_tb_lognotificacao");

            entity.ToTable("tb_lognotificacao");

            entity.HasIndex(e => e.IdAgenteinstituicao, "in_fk_agenteinstituicao_lognotificacao");

            entity.HasIndex(e => e.IdSemanaoperativa, "in_fk_semanaoperativa_lognotificacao");

            entity.Property(e => e.IdLognotificacao).HasColumnName("id_lognotificacao");
            entity.Property(e => e.DinAcao)
                .HasColumnType("datetime")
                .HasColumnName("din_acao");
            entity.Property(e => e.DscAcao)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("dsc_acao");
            entity.Property(e => e.IdAgenteinstituicao).HasColumnName("id_agenteinstituicao");
            entity.Property(e => e.IdSemanaoperativa).HasColumnName("id_semanaoperativa");
            entity.Property(e => e.MailEnviado)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("mail_enviado");
            entity.Property(e => e.MailEnviar)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("mail_enviar");
            entity.Property(e => e.NomUsuario)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nom_usuario");

            entity.HasOne(d => d.IdAgenteinstituicaoNavigation).WithMany(p => p.TbLognotificacaos)
                .HasForeignKey(d => d.IdAgenteinstituicao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_agenteinstituicao_lognotificacao");

            entity.HasOne(d => d.IdSemanaoperativaNavigation).WithMany(p => p.TbLognotificacaos)
                .HasForeignKey(d => d.IdSemanaoperativa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_semanaoperativa_lognotificacao");
        }
    }
}
