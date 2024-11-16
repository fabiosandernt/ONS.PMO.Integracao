using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class GrandezaMontadorMapping : IEntityTypeConfiguration<GrandezaMontador>
    {
        public void Configure(EntityTypeBuilder<GrandezaMontador> entity)
        {
            entity.HasKey(e => e.IdGrandezamontador).HasName("pk_tb_grandezamontador");

            entity.ToTable("tb_grandezamontador");

            entity.HasIndex(e => e.IdTpdadograndeza, "in_fk_tpdadograndeza_grandezamontador");

            entity.Property(e => e.IdGrandezamontador).HasColumnName("id_grandezamontador");
            entity.Property(e => e.CodGrandezamontador)
                .HasMaxLength(20)
                .HasColumnName("cod_grandezamontador");
            entity.Property(e => e.DscGrandezamontador)
                .HasMaxLength(150)
                .HasColumnName("dsc_grandezamontador");
            entity.Property(e => e.FlgAceitavalornegativo).HasColumnName("flg_aceitavalornegativo");
            entity.Property(e => e.FlgAtivo)
                .HasDefaultValue(true)
                .HasColumnName("flg_ativo");
            entity.Property(e => e.FlgComentario).HasColumnName("flg_comentario");
            entity.Property(e => e.FlgDecimaisexatos).HasColumnName("flg_decimaisexatos");
            entity.Property(e => e.FlgMotivoalteracao).HasColumnName("flg_motivoalteracao");
            entity.Property(e => e.FlgObrigatorio).HasColumnName("flg_obrigatorio");
            entity.Property(e => e.FlgRecuperaestudos)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("flg_recuperaestudos");
            entity.Property(e => e.IdTpdadograndeza).HasColumnName("id_tpdadograndeza");
            entity.Property(e => e.NomGrandezamontador)
                .HasMaxLength(150)
                .HasColumnName("nom_grandezamontador");
            entity.Property(e => e.QtdDecimais).HasColumnName("qtd_decimais");
            entity.Property(e => e.QtdDigitos).HasColumnName("qtd_digitos");

            entity.HasOne(d => d.IdTpdadograndezaNavigation).WithMany(p => p.TbGrandezamontadors)
                .HasForeignKey(d => d.IdTpdadograndeza)
                .HasConstraintName("fk_tpdadograndeza_grandezamontador");
        }
    }
}