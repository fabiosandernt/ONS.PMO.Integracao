using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class LogDadosInformadoMapping : IEntityTypeConfiguration<LogDadosInformado>
    {
        public void Configure(EntityTypeBuilder<LogDadosInformado> entity)
        {
            entity.HasKey(e => e.IdLogdadosinformados).HasName("pk_tb_logdadosinformados");

            entity.ToTable("tb_logdadosinformados");

            entity.Property(e => e.IdLogdadosinformados).HasColumnName("id_logdadosinformados");
            entity.Property(e => e.DinAcao)
                .HasColumnType("datetime")
                .HasColumnName("din_acao");
            entity.Property(e => e.DscAcao)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dsc_acao");
            entity.Property(e => e.IdAgenteinstituicao).HasColumnName("id_agenteinstituicao");
            entity.Property(e => e.IdSemanaoperativa).HasColumnName("id_semanaoperativa");
            entity.Property(e => e.MailUsuario)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("mail_usuario");
            entity.Property(e => e.NomUsuario)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nom_usuario");
        }
    }
}