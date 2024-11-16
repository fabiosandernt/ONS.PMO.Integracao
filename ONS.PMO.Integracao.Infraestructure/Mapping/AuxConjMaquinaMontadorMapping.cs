using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class AuxConjMaquinaMontadorMapping : IEntityTypeConfiguration<AuxConjMaquinaMontador>
    {
        public void Configure(EntityTypeBuilder<AuxConjMaquinaMontador> entity)
        {
            entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_conjmaqmontador");
            entity.ToTable("tb_aux_conjmaqmontador");

            entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_aux_conjmaqmontador");

            entity.Property(e => e.IdOrigemcoletamontador)
                .ValueGeneratedNever()
                .HasColumnName("id_origemcoletamontador");
            entity.Property(e => e.CodDppusina).HasColumnName("cod_dppusina");
            entity.Property(e => e.IdGruge).HasColumnName("id_gruge");
            entity.Property(e => e.NomCurtousina)
                .HasMaxLength(20)
                .HasColumnName("nom_curtousina");

            entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxConjmaqmontador)
                .HasForeignKey<AuxConjMaquinaMontador>(d => d.IdOrigemcoletamontador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_origemcoletamontador_aux_conjmaqmontador");
        }
    }
}
