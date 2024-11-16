using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.BDT;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class ResultadoColetaPMOMapping : IEntityTypeConfiguration<ResultadoColetaPMO>
    {
        public void Configure(EntityTypeBuilder<ResultadoColetaPMO> entity)
        {
            entity.HasKey(e => e.IdResultadocoletapmo).HasName("pk_tb_resultadocoletapmo");

            entity.ToTable("tb_resultadocoletapmo");

            entity.HasIndex(e => e.IdArquivofonteresultpmo, "in_fk_arquivofonteresultpmo_resultadocoletapmo");

            entity.Property(e => e.IdResultadocoletapmo)
                .ValueGeneratedNever()
                .HasColumnName("id_resultadocoletapmo");
            entity.Property(e => e.DinUltimaalteracao)
                .HasColumnType("datetime")
                .HasColumnName("din_ultimaalteracao");
            entity.Property(e => e.IdArquivofonteresultpmo).HasColumnName("id_arquivofonteresultpmo");
            entity.Property(e => e.NomResultadocoletapmo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("nom_resultadocoletapmo");
            entity.Property(e => e.NomUsuarioultimaalteracao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_usuarioultimaalteracao");
            entity.Property(e => e.ObsResultadocoletapmo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("obs_resultadocoletapmo");

            entity.HasOne(d => d.IdArquivofonteresultpmoNavigation).WithMany(p => p.TbResultadocoletapmos)
                .HasForeignKey(d => d.IdArquivofonteresultpmo)
                .HasConstraintName("fk_arquivofonteresultpmo_resultadocoletapmo");
        }
    }
}