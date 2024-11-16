using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class DecisaoComandoGNLMapping : IEntityTypeConfiguration<DecisaoComandoGNL>
    {
        public void Configure(EntityTypeBuilder<DecisaoComandoGNL> entity)
        {
            entity.HasKey(e => e.IdDecisaocomandognl).HasName("pk_tb_decisaocomandognl");

            entity.ToTable("tb_decisaocomandognl");

            entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_aux_usinamontador_decisaocomandognl");

            entity.HasIndex(e => e.IdTitulacao, "in_fk_titulacao_decisaocomandognl");

            entity.HasIndex(e => e.IdTppatamar, "in_fk_tppatamar_decisaocomandognl");

            entity.Property(e => e.IdDecisaocomandognl).HasColumnName("id_decisaocomandognl");
            entity.Property(e => e.DatFinal).HasColumnName("dat_final");
            entity.Property(e => e.DatInicial).HasColumnName("dat_inicial");
            entity.Property(e => e.IdOrigemcoletamontador).HasColumnName("id_origemcoletamontador");
            entity.Property(e => e.IdTitulacao).HasColumnName("id_titulacao");
            entity.Property(e => e.IdTppatamar).HasColumnName("id_tppatamar");
            entity.Property(e => e.ValDespacho).HasColumnName("val_despacho");
            entity.Property(e => e.VerControleconcorrencia)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ver_controleconcorrencia");

            entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithMany(p => p.TbDecisaocomandognls)
                .HasForeignKey(d => d.IdOrigemcoletamontador)
                .HasConstraintName("fk_aux_usinamontador_decisaocomandognl");

            entity.HasOne(d => d.IdTitulacaoNavigation).WithMany(p => p.TbDecisaocomandognls)
                .HasForeignKey(d => d.IdTitulacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_titulacao_decisaocomandognl");

            entity.HasOne(d => d.IdTppatamarNavigation).WithMany(p => p.TbDecisaocomandognls)
                .HasForeignKey(d => d.IdTppatamar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tppatamar_decisaocomandognl");
        }
    }
}
