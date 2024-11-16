using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class DadoColetaEstruturadoMapping : IEntityTypeConfiguration<DadoColetaEstruturado>
    {
        public void Configure(EntityTypeBuilder<DadoColetaEstruturado> entity)
        {
            entity.HasKey(e => e.IdDadocoleta).HasName("pk_tb_dadocoletaestruturado");

            entity.ToTable("tb_dadocoletaestruturado");

            entity.HasIndex(e => e.IdDadocoleta, "in_fk_dadocoleta_dadocoletaestruturado");

            entity.HasIndex(e => e.IdTplimite, "in_fk_tplimite_dadocoletaestruturado");

            entity.HasIndex(e => e.IdTppatamar, "in_fk_tppatamar_dadocoletaestruturado");

            entity.Property(e => e.IdDadocoleta)
                .ValueGeneratedNever()
                .HasColumnName("id_dadocoleta");
            entity.Property(e => e.DscEstagio)
                .HasMaxLength(50)
                .HasColumnName("dsc_estagio");
            entity.Property(e => e.FlgDestacamodificacao).HasColumnName("flg_destacamodificacao");
            entity.Property(e => e.IdTplimite).HasColumnName("id_tplimite");
            entity.Property(e => e.IdTppatamar).HasColumnName("id_tppatamar");
            entity.Property(e => e.ValDado)
                .HasMaxLength(4000)
                .HasColumnName("val_dado");

            entity.HasOne(d => d.IdDadocoletaNavigation).WithOne(p => p.TbDadocoletaestruturado)
                .HasForeignKey<DadoColetaEstruturado>(d => d.IdDadocoleta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dadocoleta_dadocoletaestruturado");

            entity.HasOne(d => d.IdTplimiteNavigation).WithMany(p => p.TbDadocoletaestruturados)
                .HasForeignKey(d => d.IdTplimite)
                .HasConstraintName("fk_tplimite_dadocoletaestruturado");

            entity.HasOne(d => d.IdTppatamarNavigation).WithMany(p => p.TbDadocoletaestruturados)
                .HasForeignKey(d => d.IdTppatamar)
                .HasConstraintName("fk_tppatamar_dadocoletaestruturado");
        }
    }
}
